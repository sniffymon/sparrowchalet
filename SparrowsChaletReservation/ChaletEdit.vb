﻿Imports System.Data.SqlClient

'DECLARATION OF NEEDED VARIABLES
'
Public Class ChaletEdit
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim namememory As String

    'LOADING GUESTNAMES INTO COMBOBOX
    '
    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCheckIn.CustomFormat = " "
        dtpCheckOut.CustomFormat = " "
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        sql = "SELECT Guest_Name FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr2 As SqlDataReader = cmd.ExecuteReader
        Dim guestcombotb As New DataTable

        If dr2.HasRows Then
            While (dr2.Read())
                CboGuestName.Items.Add(dr2(0))
            End While
        Else
            CboGuestName.Items.Add("No Existing Guests")
        End If
        dr2.Close()

        'DISPLAY DATA FROM DATABASE
        '
        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH AND (@date >= CheckIn_Date AND @date < CheckOut_Date) AND Reservation_Status = 'True'"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@date", AdminChaletInfo.dtpDateSpec.Value.ToString("yyyy-MM-dd"))
        dr = cmd.ExecuteReader
        lblChalet.Text = AdminChaletInfo.clickedchalet

        If dr.Read() Then
            dtpCheckIn.CustomFormat = "yyyy-MM-dd"
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            CboGuestName.Text = dr(0)
            dtpCheckIn.Value = dr(3)
            dtpCheckOut.Value = dr(4)
            CboEB.Text = dr(5)
            namememory = CboGuestName.Text
        End If

        conn.Close()
    End Sub

    'UPDATE DISPLAYED DATA 
    '
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim EditCheck As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        sql = "UPDATE Reservation
               SET GuestNo_FK = GuestDetail.GuestNo, CheckIn_Date = @checkindate, CheckOut_Date =@checkoutdate, ExtraBed = @eb
			   FROM GuestDetail 
			   INNER JOIN
			   Reservation
               ON Reservation.GuestNo_FK = GuestDetail.GuestNo
               WHERE GuestDetail.Guest_Name = @memguestname AND ChaletNumber_FK = @clickedchaletCH;"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@memguestname", namememory)
        cmd.Parameters.AddWithValue("@guestname", CboGuestName.SelectedText)
        cmd.Parameters.AddWithValue("@checkindate", dtpCheckIn.Text)
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Text)
        cmd.Parameters.AddWithValue("@eb", CboEB.Text)

        EditCheck = cmd.ExecuteNonQuery()

        If EditCheck = 0 Then
            MsgBox("No Similar Data Found")
        ElseIf EditCheck = 1 Then
            MsgBox("Data Successfully Edited")
        End If

    End Sub

    'LIMIT CHECKOUT DATE TO BE 1 DAY AFTER CHECKIN DATE
    '
    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1)
    End Sub

    'DELETE SELECTED DATA FROM DATABASE
    '
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Recorddeleted As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()

        sql = " DELETE FROM Reservation WHERE ChaletNumber_FK = @clickedchaletCH"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)

        Recorddeleted = cmd.ExecuteNonQuery()
        If Recorddeleted = 0 Then
            MessageBox.Show("Error occured when deleting data. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Recorddeleted = 1 Then
            MessageBox.Show("Record successfully deleted.", "Success")
        End If

        conn.Close()
    End Sub
End Class