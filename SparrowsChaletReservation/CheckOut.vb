﻿Imports System.Data.SqlClient

Public Class CheckOut
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123; MultipleActiveResultSets=True")
    Dim cmd As SqlCommand
    Public sql, guestnostorage, contraname, contraname2 As String
    Public checkedchalet As New List(Of String)
    Public standardchalets, supremechalets As Integer
    Dim dr As SqlDataReader
    Dim cmdUpdate As SqlCommand
    Public ChaletTotal, dayduration, OverstayCharged, standardprice, supremeprice, overstandard, oversupreme,
        totalstandard, totalsupreme, overalltotal As Double


    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Booking Contradiction CHECK
        '
        If StaffMenuForm.contracheck > 0 Then
            If conn.State = ConnectionState.Closed Then
                Try
                    conn.Open()
                Catch sqlEx As SqlException
                    Select Case sqlEx.Number
                    Case -1, 2, 53, 40
                        MessageBox.Show("Please check if the connection is available!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case Else
                        MessageBox.Show("An unexpected error occured! Please contact your system administrator!", "Undefined Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                End Try
            End If
            sql = "SELECT Guest_ID_PassNum FROM GuestDetail WHERE GuestNo =" & StaffMenuForm.contraguestno
                cmd = New SqlCommand(sql, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                CboGuestID.SelectedText = dr(0)
                CboGuestID_SelectedIndexChanged(e, e)
                dr.Close()
                conn.Close()
            End If
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch sqlEx As SqlException
                Select Case sqlEx.Number
                    Case -1, 2, 53, 40
                        MessageBox.Show("Please check if the connection is available!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case Else
                        MessageBox.Show("An unexpected error occured! Please contact your system administrator!", "Undefined Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            End Try
        End If
        ' LOAD GUEST NUMBER
        '
        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)

        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While (dr.Read())
                CboGuestID.Items.Add(dr(0))
            End While

        Else
            CboGuestID.Items.Add("No Existing Guests")
        End If
        dr.Close()
        conn.Close()

    End Sub
    Private Sub CboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGuestID.SelectedIndexChanged
        ''INPUT VALIDATION & OCCUPANCY SPACE CHECK
        If CboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'clear the textbox before selectign guest
        txtCheckIn.Text = ""
        txtCheckOut.Text = ""
        txtActualCheckOut.Text = ""
        txtOverdue.Text = ""
        txtDuration.Text = ""

        'GUEST DETAIL SECTION START
        sql = "SELECT GuestNo,GuestDetail.Guest_Name,GuestDetail.Guest_Contact_No,GuestDetail.Guest_Email  
               FROM GuestDetail  Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
                WHERE [Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", CboGuestID.Text)
        dr = cmd.ExecuteReader

        If dr.Read() Then
            guestnostorage = dr(0)
            txtGuestName.Text = dr(1)
            txtGuestMobile.Text = dr(2)
            txtGuestEmail.Text = dr(3)
        End If

        dr.Close()
        conn.Close()

        'DETECT CHALETS THAT ARE BOOKED
        sql = "SELECT ChaletNumber_FK , CONVERT(Varchar, CheckIn_Date) ,CONVERT(Varchar, CheckOut_Date)
            FROM Reservation WHERE GuestNo_FK=@guestno AND @currentdate >= Checkout_Date AND Reservation_Status='True'"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        Try
            conn.Open()
        Catch sqlEx As SqlException
            Select Case sqlEx.Number
                Case -1, 2, 53, 40
                    MessageBox.Show("Please check if the connection is available!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("An unexpected error occured! Please contact your system administrator!", "Undefined Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
        cmd.Parameters.AddWithValue("@guestno", guestnostorage)
        cmd.Parameters.AddWithValue("@currentdate", Date.Today)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "SpecifiedCH")

        'show checkin and checkout date if condition match
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read() Then
            txtCheckIn.Text = dr1(1).ToString
            txtCheckOut.Text = dr1(2).ToString
        End If

        dr1.Close()
        conn.Close()

        Dim exdata As DataTable = chaletds.Tables("SpecifiedCH")
        Dim row As DataRow

        For Each ctrl As Control In Me.GboChalet.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next
        '
        Dim removedCH As String
        If exdata.Rows.Count = 0 Then
            MsgBox("There are no checkout details for this guest today!")
            Exit Sub
        ElseIf exdata.Rows.Count > 0 Then
            For Each row In exdata.Rows
                removedCH = row(0).ToString.Remove(0, 2)
                If removedCH > 10 Then
                    supremechalets += 1
                ElseIf removedCH < 11 Then
                    standardchalets += 1
                End If
                checkedchalet.Add("btn" & row(0))

                DirectCast(GboChalet.Controls("btn" & row(0)), Button).Visible = True
            Next

            ' Display the date in the default (general) format.
            txtActualCheckOut.Text = DateTime.Today.ToString("yyyy-MM-dd")

            'get the overdue days
            Dim date1 As Date = Date.Now
            Dim date2 As Date = txtCheckOut.Text
            Dim days As Integer = (date1 - date2).Days

            If (days <= 0) Then
                txtOverdue.Text = 0
            ElseIf (days >= 1) Then
                txtOverdue.Text = days
            End If

            'duration of stay
            Dim StartTime, EndTime, StartTime1, EndTime1 As DateTime
            Dim TimeSpan As TimeSpan
            StartTime = txtCheckIn.Text
            EndTime = txtActualCheckOut.Text
            TimeSpan = EndTime.Subtract(StartTime)
            txtDuration.Text = TimeSpan.Days

            '
            Dim TimeSpan1 As TimeSpan
            StartTime1 = txtCheckIn.Text
            EndTime1 = txtCheckOut.Text
            TimeSpan1 = EndTime.Subtract(StartTime)
            dayduration = TimeSpan.Days

            Dim overstaydays As Double
            overstaydays = txtOverdue.Text

            'price calculation
            OverstayCharged = (standardchalets * overstaydays * 250) + (supremechalets * overstaydays * 350)

            overstandard = (standardchalets * overstaydays * 250)
            oversupreme = (supremechalets * overstaydays * 350)
            standardprice = (standardchalets * dayduration * 150)
            supremeprice = (supremechalets * dayduration * 250)
            totalstandard = (overstandard + standardprice)
            totalsupreme = (oversupreme + supremeprice)
            overalltotal = (totalstandard + totalsupreme)
        End If
        conn.Close()

    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        'Info box for overdue charge
        If txtOverdue.Text = 0 Then
            CheckOutCart.ShowDialog()
        ElseIf txtOverdue.Text >= 1 Then
            MessageBox.Show("Reminder that client will be charged RM 250 for Standard Room and RM350 for Supreme Room each day due to overstay", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckOutCart.ShowDialog()
        End If
    End Sub
    Private Sub CboGuestID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboGuestID.KeyPress
        'only allow numbers and control key in combo box
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class