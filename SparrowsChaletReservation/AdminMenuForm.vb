﻿Public Class AdminMenuForm
    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        SelectChaletForm.Close()
        GuestInfoEntry.Close()
    End Sub
    Private Sub btnRegisterGuest_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click, btnAdminInfoPanel.Click, btnEditGuestRecords.Click
        ' "TURN OFF" OTHER TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnAddStaff.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        ' Tabs Switches
        '
        Select Case DirectCast(sender, Button).Name
            ' REGISTER GUEST
            '
            Case btnAddStaff.Name
                GuestInfoEntry.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoEntry)
                GuestInfoEntry.Show()
                GuestInfoEntry.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 91)
                ' EDIT GUEST RECORDS
                '
            Case btnEditGuestRecords.Name
                GuestInfoEdit.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoEdit)
                GuestInfoEdit.Show()
                GuestInfoEdit.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 217)
                ' ADMIN INFO PANEL
                '
            Case btnAdminInfoPanel.Name
                AdminChaletInfo.TopLevel = False
                pnlMainView.Controls.Add(AdminChaletInfo)
                AdminChaletInfo.Show()
                AdminChaletInfo.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 343)
        End Select
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' "TURN OFF" ALL TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnAddStaff.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        indSelectedTab.Visible = False
        SelectChaletForm.Hide()
        GuestInfoEdit.Hide()
        GuestInfoEntry.Hide()
        AdminChaletInfo.Hide()
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click
        If pnlMenu.Location = New Point(-155, 2) Then
            Do Until pnlMenu.Location.X = 0
                pnlMenu.Location = New Point(pnlMenu.Location.X + 1, 2)
            Loop
        ElseIf pnlMenu.Location = New Point(0, 2) Then
            Do Until pnlMenu.Location.X = -155
                pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
            Loop
        End If
    End Sub
    Private Sub pnlMenu_MouseLeave(sender As Object, e As EventArgs) Handles pnlMenu.MouseLeave
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub AdminMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim regDate As Date = Date.Now()
        lblDay.Text = regDate.ToString("dd")
        lblMonth.Text = regDate.ToString("MMM").ToUpper
        lblYear.Text = regDate.ToString("yyyy")
    End Sub
End Class