﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtendBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtendBooking))
        Me.lblExtendBooking = New System.Windows.Forms.Label()
        Me.pnlChaletAvailability = New System.Windows.Forms.Panel()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.lblOccupied = New System.Windows.Forms.Label()
        Me.pnlOccupied = New System.Windows.Forms.Panel()
        Me.GboBookedChalets = New System.Windows.Forms.GroupBox()
        Me.lblChaletSpec = New System.Windows.Forms.Label()
        Me.tlpChaletButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCH020 = New System.Windows.Forms.Button()
        Me.btnCH001 = New System.Windows.Forms.Button()
        Me.btnCH019 = New System.Windows.Forms.Button()
        Me.btnCH018 = New System.Windows.Forms.Button()
        Me.btnCH017 = New System.Windows.Forms.Button()
        Me.btnCH002 = New System.Windows.Forms.Button()
        Me.btnCH011 = New System.Windows.Forms.Button()
        Me.btnCH012 = New System.Windows.Forms.Button()
        Me.btnCH016 = New System.Windows.Forms.Button()
        Me.btnCH003 = New System.Windows.Forms.Button()
        Me.btnCH015 = New System.Windows.Forms.Button()
        Me.btnCH004 = New System.Windows.Forms.Button()
        Me.btnCH014 = New System.Windows.Forms.Button()
        Me.btnCH005 = New System.Windows.Forms.Button()
        Me.btnCH013 = New System.Windows.Forms.Button()
        Me.btnCH006 = New System.Windows.Forms.Button()
        Me.btnCH007 = New System.Windows.Forms.Button()
        Me.btnCH008 = New System.Windows.Forms.Button()
        Me.btnCH009 = New System.Windows.Forms.Button()
        Me.btnCH010 = New System.Windows.Forms.Button()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.GboInfoSearch = New System.Windows.Forms.GroupBox()
        Me.CboGuestID = New System.Windows.Forms.ComboBox()
        Me.txtGuestEmail = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.Label()
        Me.txtGuestMobile = New System.Windows.Forms.Label()
        Me.lblGuestEmail = New System.Windows.Forms.Label()
        Me.lblGuestMobile = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.pnlChalet = New System.Windows.Forms.Panel()
        Me.btnStandard = New System.Windows.Forms.Button()
        Me.lblStandard = New System.Windows.Forms.Label()
        Me.lblSupreme = New System.Windows.Forms.Label()
        Me.btnSupreme = New System.Windows.Forms.Button()
        Me.pnlChaletAvailability.SuspendLayout()
        Me.GboBookedChalets.SuspendLayout()
        Me.tlpChaletButtons.SuspendLayout()
        Me.GboInfoSearch.SuspendLayout()
        Me.pnlChalet.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExtendBooking
        '
        Me.lblExtendBooking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExtendBooking.AutoSize = True
        Me.lblExtendBooking.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtendBooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblExtendBooking.Location = New System.Drawing.Point(242, 22)
        Me.lblExtendBooking.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExtendBooking.Name = "lblExtendBooking"
        Me.lblExtendBooking.Size = New System.Drawing.Size(473, 47)
        Me.lblExtendBooking.TabIndex = 62
        Me.lblExtendBooking.Text = "EXTEND CHALET BOOKING"
        Me.lblExtendBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlChaletAvailability
        '
        Me.pnlChaletAvailability.Controls.Add(Me.lblAvailable)
        Me.pnlChaletAvailability.Controls.Add(Me.pnlAvailable)
        Me.pnlChaletAvailability.Controls.Add(Me.lblOccupied)
        Me.pnlChaletAvailability.Controls.Add(Me.pnlOccupied)
        Me.pnlChaletAvailability.Location = New System.Drawing.Point(825, 212)
        Me.pnlChaletAvailability.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlChaletAvailability.Name = "pnlChaletAvailability"
        Me.pnlChaletAvailability.Size = New System.Drawing.Size(77, 61)
        Me.pnlChaletAvailability.TabIndex = 61
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblAvailable.Location = New System.Drawing.Point(19, 3)
        Me.lblAvailable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(54, 13)
        Me.lblAvailable.TabIndex = 9
        Me.lblAvailable.Text = "Available"
        '
        'pnlAvailable
        '
        Me.pnlAvailable.BackColor = System.Drawing.Color.White
        Me.pnlAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAvailable.Location = New System.Drawing.Point(4, 2)
        Me.pnlAvailable.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(12, 13)
        Me.pnlAvailable.TabIndex = 13
        '
        'lblOccupied
        '
        Me.lblOccupied.AutoSize = True
        Me.lblOccupied.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblOccupied.Location = New System.Drawing.Point(19, 23)
        Me.lblOccupied.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOccupied.Name = "lblOccupied"
        Me.lblOccupied.Size = New System.Drawing.Size(54, 13)
        Me.lblOccupied.TabIndex = 14
        Me.lblOccupied.Text = "Occupied"
        '
        'pnlOccupied
        '
        Me.pnlOccupied.BackColor = System.Drawing.Color.Red
        Me.pnlOccupied.Location = New System.Drawing.Point(4, 24)
        Me.pnlOccupied.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlOccupied.Name = "pnlOccupied"
        Me.pnlOccupied.Size = New System.Drawing.Size(12, 12)
        Me.pnlOccupied.TabIndex = 15
        '
        'GboBookedChalets
        '
        Me.GboBookedChalets.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GboBookedChalets.Controls.Add(Me.lblChaletSpec)
        Me.GboBookedChalets.Controls.Add(Me.tlpChaletButtons)
        Me.GboBookedChalets.Controls.Add(Me.lblTest)
        Me.GboBookedChalets.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboBookedChalets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GboBookedChalets.Location = New System.Drawing.Point(30, 285)
        Me.GboBookedChalets.Margin = New System.Windows.Forms.Padding(2)
        Me.GboBookedChalets.Name = "GboBookedChalets"
        Me.GboBookedChalets.Padding = New System.Windows.Forms.Padding(2)
        Me.GboBookedChalets.Size = New System.Drawing.Size(845, 145)
        Me.GboBookedChalets.TabIndex = 59
        Me.GboBookedChalets.TabStop = False
        Me.GboBookedChalets.Text = "Guest Booked Chalets"
        '
        'lblChaletSpec
        '
        Me.lblChaletSpec.AutoSize = True
        Me.lblChaletSpec.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaletSpec.Location = New System.Drawing.Point(257, 60)
        Me.lblChaletSpec.Name = "lblChaletSpec"
        Me.lblChaletSpec.Size = New System.Drawing.Size(267, 25)
        Me.lblChaletSpec.TabIndex = 61
        Me.lblChaletSpec.Text = "There are no specified chalets."
        Me.lblChaletSpec.Visible = False
        '
        'tlpChaletButtons
        '
        Me.tlpChaletButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpChaletButtons.ColumnCount = 10
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpChaletButtons.Controls.Add(Me.btnCH020, 9, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH001, 0, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH019, 8, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH018, 7, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH017, 6, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH002, 1, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH011, 0, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH012, 1, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH016, 5, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH003, 2, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH015, 4, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH004, 3, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH014, 3, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH005, 4, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH013, 2, 1)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH006, 5, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH007, 6, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH008, 7, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH009, 8, 0)
        Me.tlpChaletButtons.Controls.Add(Me.btnCH010, 9, 0)
        Me.tlpChaletButtons.Location = New System.Drawing.Point(35, 27)
        Me.tlpChaletButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpChaletButtons.Name = "tlpChaletButtons"
        Me.tlpChaletButtons.RowCount = 2
        Me.tlpChaletButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.0!))
        Me.tlpChaletButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.0!))
        Me.tlpChaletButtons.Size = New System.Drawing.Size(763, 101)
        Me.tlpChaletButtons.TabIndex = 56
        '
        'btnCH020
        '
        Me.btnCH020.BackColor = System.Drawing.Color.White
        Me.btnCH020.BackgroundImage = CType(resources.GetObject("btnCH020.BackgroundImage"), System.Drawing.Image)
        Me.btnCH020.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH020.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH020.FlatAppearance.BorderSize = 3
        Me.btnCH020.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH020.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH020.Location = New System.Drawing.Point(686, 55)
        Me.btnCH020.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH020.Name = "btnCH020"
        Me.btnCH020.Size = New System.Drawing.Size(43, 41)
        Me.btnCH020.TabIndex = 53
        Me.btnCH020.Text = "20"
        Me.btnCH020.UseVisualStyleBackColor = False
        '
        'btnCH001
        '
        Me.btnCH001.BackColor = System.Drawing.Color.White
        Me.btnCH001.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH001.FlatAppearance.BorderSize = 3
        Me.btnCH001.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH001.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH001.Location = New System.Drawing.Point(2, 2)
        Me.btnCH001.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH001.Name = "btnCH001"
        Me.btnCH001.Size = New System.Drawing.Size(43, 41)
        Me.btnCH001.TabIndex = 41
        Me.btnCH001.Text = "01"
        Me.btnCH001.UseVisualStyleBackColor = False
        '
        'btnCH019
        '
        Me.btnCH019.BackColor = System.Drawing.Color.White
        Me.btnCH019.BackgroundImage = CType(resources.GetObject("btnCH019.BackgroundImage"), System.Drawing.Image)
        Me.btnCH019.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH019.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH019.FlatAppearance.BorderSize = 3
        Me.btnCH019.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH019.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH019.Location = New System.Drawing.Point(610, 55)
        Me.btnCH019.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH019.Name = "btnCH019"
        Me.btnCH019.Size = New System.Drawing.Size(43, 41)
        Me.btnCH019.TabIndex = 48
        Me.btnCH019.Text = "19"
        Me.btnCH019.UseVisualStyleBackColor = False
        '
        'btnCH018
        '
        Me.btnCH018.BackColor = System.Drawing.Color.White
        Me.btnCH018.BackgroundImage = CType(resources.GetObject("btnCH018.BackgroundImage"), System.Drawing.Image)
        Me.btnCH018.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH018.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH018.FlatAppearance.BorderSize = 3
        Me.btnCH018.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH018.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH018.Location = New System.Drawing.Point(534, 55)
        Me.btnCH018.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH018.Name = "btnCH018"
        Me.btnCH018.Size = New System.Drawing.Size(43, 41)
        Me.btnCH018.TabIndex = 50
        Me.btnCH018.Text = "18"
        Me.btnCH018.UseVisualStyleBackColor = False
        '
        'btnCH017
        '
        Me.btnCH017.BackColor = System.Drawing.Color.White
        Me.btnCH017.BackgroundImage = CType(resources.GetObject("btnCH017.BackgroundImage"), System.Drawing.Image)
        Me.btnCH017.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH017.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH017.FlatAppearance.BorderSize = 3
        Me.btnCH017.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH017.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH017.Location = New System.Drawing.Point(458, 55)
        Me.btnCH017.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH017.Name = "btnCH017"
        Me.btnCH017.Size = New System.Drawing.Size(43, 41)
        Me.btnCH017.TabIndex = 52
        Me.btnCH017.Text = "17"
        Me.btnCH017.UseVisualStyleBackColor = False
        '
        'btnCH002
        '
        Me.btnCH002.BackColor = System.Drawing.Color.White
        Me.btnCH002.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH002.FlatAppearance.BorderSize = 3
        Me.btnCH002.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH002.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH002.Location = New System.Drawing.Point(78, 2)
        Me.btnCH002.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH002.Name = "btnCH002"
        Me.btnCH002.Size = New System.Drawing.Size(43, 41)
        Me.btnCH002.TabIndex = 39
        Me.btnCH002.Text = "02"
        Me.btnCH002.UseVisualStyleBackColor = False
        '
        'btnCH011
        '
        Me.btnCH011.BackColor = System.Drawing.Color.White
        Me.btnCH011.BackgroundImage = CType(resources.GetObject("btnCH011.BackgroundImage"), System.Drawing.Image)
        Me.btnCH011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH011.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH011.FlatAppearance.BorderSize = 3
        Me.btnCH011.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH011.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH011.Location = New System.Drawing.Point(2, 55)
        Me.btnCH011.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH011.Name = "btnCH011"
        Me.btnCH011.Size = New System.Drawing.Size(43, 41)
        Me.btnCH011.TabIndex = 51
        Me.btnCH011.Text = "11"
        Me.btnCH011.UseVisualStyleBackColor = False
        '
        'btnCH012
        '
        Me.btnCH012.BackColor = System.Drawing.Color.White
        Me.btnCH012.BackgroundImage = CType(resources.GetObject("btnCH012.BackgroundImage"), System.Drawing.Image)
        Me.btnCH012.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH012.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH012.FlatAppearance.BorderSize = 3
        Me.btnCH012.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH012.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH012.Location = New System.Drawing.Point(78, 55)
        Me.btnCH012.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH012.Name = "btnCH012"
        Me.btnCH012.Size = New System.Drawing.Size(43, 41)
        Me.btnCH012.TabIndex = 49
        Me.btnCH012.Text = "12"
        Me.btnCH012.UseVisualStyleBackColor = False
        '
        'btnCH016
        '
        Me.btnCH016.BackColor = System.Drawing.Color.White
        Me.btnCH016.BackgroundImage = CType(resources.GetObject("btnCH016.BackgroundImage"), System.Drawing.Image)
        Me.btnCH016.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH016.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH016.FlatAppearance.BorderSize = 3
        Me.btnCH016.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH016.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH016.Location = New System.Drawing.Point(382, 55)
        Me.btnCH016.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH016.Name = "btnCH016"
        Me.btnCH016.Size = New System.Drawing.Size(43, 41)
        Me.btnCH016.TabIndex = 47
        Me.btnCH016.Text = "16"
        Me.btnCH016.UseVisualStyleBackColor = False
        '
        'btnCH003
        '
        Me.btnCH003.BackColor = System.Drawing.Color.White
        Me.btnCH003.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH003.FlatAppearance.BorderSize = 3
        Me.btnCH003.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH003.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH003.Location = New System.Drawing.Point(154, 2)
        Me.btnCH003.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH003.Name = "btnCH003"
        Me.btnCH003.Size = New System.Drawing.Size(43, 41)
        Me.btnCH003.TabIndex = 34
        Me.btnCH003.Text = "03"
        Me.btnCH003.UseVisualStyleBackColor = False
        '
        'btnCH015
        '
        Me.btnCH015.BackColor = System.Drawing.Color.White
        Me.btnCH015.BackgroundImage = CType(resources.GetObject("btnCH015.BackgroundImage"), System.Drawing.Image)
        Me.btnCH015.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH015.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH015.FlatAppearance.BorderSize = 3
        Me.btnCH015.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH015.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH015.Location = New System.Drawing.Point(306, 55)
        Me.btnCH015.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH015.Name = "btnCH015"
        Me.btnCH015.Size = New System.Drawing.Size(43, 41)
        Me.btnCH015.TabIndex = 46
        Me.btnCH015.Text = "15"
        Me.btnCH015.UseVisualStyleBackColor = False
        '
        'btnCH004
        '
        Me.btnCH004.BackColor = System.Drawing.Color.White
        Me.btnCH004.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH004.FlatAppearance.BorderSize = 3
        Me.btnCH004.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH004.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH004.Location = New System.Drawing.Point(230, 2)
        Me.btnCH004.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH004.Name = "btnCH004"
        Me.btnCH004.Size = New System.Drawing.Size(43, 41)
        Me.btnCH004.TabIndex = 35
        Me.btnCH004.Text = "04"
        Me.btnCH004.UseVisualStyleBackColor = False
        '
        'btnCH014
        '
        Me.btnCH014.BackColor = System.Drawing.Color.White
        Me.btnCH014.BackgroundImage = CType(resources.GetObject("btnCH014.BackgroundImage"), System.Drawing.Image)
        Me.btnCH014.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH014.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH014.FlatAppearance.BorderSize = 3
        Me.btnCH014.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH014.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH014.Location = New System.Drawing.Point(230, 55)
        Me.btnCH014.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH014.Name = "btnCH014"
        Me.btnCH014.Size = New System.Drawing.Size(43, 41)
        Me.btnCH014.TabIndex = 45
        Me.btnCH014.Text = "14"
        Me.btnCH014.UseVisualStyleBackColor = False
        '
        'btnCH005
        '
        Me.btnCH005.BackColor = System.Drawing.Color.White
        Me.btnCH005.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH005.FlatAppearance.BorderSize = 3
        Me.btnCH005.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH005.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH005.Location = New System.Drawing.Point(306, 2)
        Me.btnCH005.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH005.Name = "btnCH005"
        Me.btnCH005.Size = New System.Drawing.Size(43, 41)
        Me.btnCH005.TabIndex = 36
        Me.btnCH005.Text = "05"
        Me.btnCH005.UseVisualStyleBackColor = False
        '
        'btnCH013
        '
        Me.btnCH013.BackColor = System.Drawing.Color.White
        Me.btnCH013.BackgroundImage = CType(resources.GetObject("btnCH013.BackgroundImage"), System.Drawing.Image)
        Me.btnCH013.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCH013.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH013.FlatAppearance.BorderSize = 3
        Me.btnCH013.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH013.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH013.Location = New System.Drawing.Point(154, 55)
        Me.btnCH013.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH013.Name = "btnCH013"
        Me.btnCH013.Size = New System.Drawing.Size(43, 41)
        Me.btnCH013.TabIndex = 44
        Me.btnCH013.Text = "13"
        Me.btnCH013.UseVisualStyleBackColor = False
        '
        'btnCH006
        '
        Me.btnCH006.BackColor = System.Drawing.Color.White
        Me.btnCH006.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH006.FlatAppearance.BorderSize = 3
        Me.btnCH006.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH006.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH006.Location = New System.Drawing.Point(382, 2)
        Me.btnCH006.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH006.Name = "btnCH006"
        Me.btnCH006.Size = New System.Drawing.Size(43, 41)
        Me.btnCH006.TabIndex = 37
        Me.btnCH006.Text = "06"
        Me.btnCH006.UseVisualStyleBackColor = False
        '
        'btnCH007
        '
        Me.btnCH007.BackColor = System.Drawing.Color.White
        Me.btnCH007.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH007.FlatAppearance.BorderSize = 3
        Me.btnCH007.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH007.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH007.Location = New System.Drawing.Point(458, 2)
        Me.btnCH007.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH007.Name = "btnCH007"
        Me.btnCH007.Size = New System.Drawing.Size(43, 41)
        Me.btnCH007.TabIndex = 42
        Me.btnCH007.Text = "07"
        Me.btnCH007.UseVisualStyleBackColor = False
        '
        'btnCH008
        '
        Me.btnCH008.BackColor = System.Drawing.Color.White
        Me.btnCH008.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH008.FlatAppearance.BorderSize = 3
        Me.btnCH008.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH008.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH008.Location = New System.Drawing.Point(534, 2)
        Me.btnCH008.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH008.Name = "btnCH008"
        Me.btnCH008.Size = New System.Drawing.Size(43, 41)
        Me.btnCH008.TabIndex = 40
        Me.btnCH008.Text = "08"
        Me.btnCH008.UseVisualStyleBackColor = False
        '
        'btnCH009
        '
        Me.btnCH009.BackColor = System.Drawing.Color.White
        Me.btnCH009.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH009.FlatAppearance.BorderSize = 3
        Me.btnCH009.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH009.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH009.Location = New System.Drawing.Point(610, 2)
        Me.btnCH009.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH009.Name = "btnCH009"
        Me.btnCH009.Size = New System.Drawing.Size(43, 41)
        Me.btnCH009.TabIndex = 38
        Me.btnCH009.Text = "09"
        Me.btnCH009.UseVisualStyleBackColor = False
        '
        'btnCH010
        '
        Me.btnCH010.BackColor = System.Drawing.Color.White
        Me.btnCH010.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCH010.FlatAppearance.BorderSize = 3
        Me.btnCH010.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCH010.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCH010.Location = New System.Drawing.Point(686, 2)
        Me.btnCH010.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCH010.Name = "btnCH010"
        Me.btnCH010.Size = New System.Drawing.Size(43, 41)
        Me.btnCH010.TabIndex = 43
        Me.btnCH010.Text = "10"
        Me.btnCH010.UseVisualStyleBackColor = False
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(308, 27)
        Me.lblTest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(0, 13)
        Me.lblTest.TabIndex = 33
        '
        'GboInfoSearch
        '
        Me.GboInfoSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GboInfoSearch.Controls.Add(Me.CboGuestID)
        Me.GboInfoSearch.Controls.Add(Me.txtGuestEmail)
        Me.GboInfoSearch.Controls.Add(Me.txtGuestName)
        Me.GboInfoSearch.Controls.Add(Me.txtGuestMobile)
        Me.GboInfoSearch.Controls.Add(Me.lblGuestEmail)
        Me.GboInfoSearch.Controls.Add(Me.lblGuestMobile)
        Me.GboInfoSearch.Controls.Add(Me.lblGuestName)
        Me.GboInfoSearch.Controls.Add(Me.lblGuestID)
        Me.GboInfoSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboInfoSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GboInfoSearch.Location = New System.Drawing.Point(140, 116)
        Me.GboInfoSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.GboInfoSearch.Name = "GboInfoSearch"
        Me.GboInfoSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.GboInfoSearch.Size = New System.Drawing.Size(674, 157)
        Me.GboInfoSearch.TabIndex = 58
        Me.GboInfoSearch.TabStop = False
        Me.GboInfoSearch.Text = "Guest Information Search"
        '
        'CboGuestID
        '
        Me.CboGuestID.FormattingEnabled = True
        Me.CboGuestID.Location = New System.Drawing.Point(274, 31)
        Me.CboGuestID.Margin = New System.Windows.Forms.Padding(2)
        Me.CboGuestID.Name = "CboGuestID"
        Me.CboGuestID.Size = New System.Drawing.Size(173, 20)
        Me.CboGuestID.TabIndex = 11
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestEmail.Location = New System.Drawing.Point(274, 118)
        Me.txtGuestEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(171, 17)
        Me.txtGuestEmail.TabIndex = 10
        '
        'txtGuestName
        '
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestName.Location = New System.Drawing.Point(274, 62)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(171, 17)
        Me.txtGuestName.TabIndex = 9
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestMobile.Location = New System.Drawing.Point(274, 90)
        Me.txtGuestMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(171, 17)
        Me.txtGuestMobile.TabIndex = 8
        '
        'lblGuestEmail
        '
        Me.lblGuestEmail.AutoSize = True
        Me.lblGuestEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblGuestEmail.Location = New System.Drawing.Point(154, 120)
        Me.lblGuestEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestEmail.Name = "lblGuestEmail"
        Me.lblGuestEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblGuestEmail.TabIndex = 7
        Me.lblGuestEmail.Text = "Email Address"
        '
        'lblGuestMobile
        '
        Me.lblGuestMobile.AutoSize = True
        Me.lblGuestMobile.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestMobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblGuestMobile.Location = New System.Drawing.Point(154, 92)
        Me.lblGuestMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestMobile.Name = "lblGuestMobile"
        Me.lblGuestMobile.Size = New System.Drawing.Size(87, 13)
        Me.lblGuestMobile.TabIndex = 5
        Me.lblGuestMobile.Text = "Mobile Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblGuestName.Location = New System.Drawing.Point(154, 65)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(37, 13)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Name"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblGuestID.Location = New System.Drawing.Point(154, 36)
        Me.lblGuestID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(110, 13)
        Me.lblGuestID.TabIndex = 1
        Me.lblGuestID.Text = "Passport/IC Number"
        '
        'pnlChalet
        '
        Me.pnlChalet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlChalet.Controls.Add(Me.btnStandard)
        Me.pnlChalet.Controls.Add(Me.lblStandard)
        Me.pnlChalet.Controls.Add(Me.lblSupreme)
        Me.pnlChalet.Controls.Add(Me.btnSupreme)
        Me.pnlChalet.Location = New System.Drawing.Point(11, 203)
        Me.pnlChalet.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlChalet.Name = "pnlChalet"
        Me.pnlChalet.Size = New System.Drawing.Size(110, 70)
        Me.pnlChalet.TabIndex = 60
        '
        'btnStandard
        '
        Me.btnStandard.BackColor = System.Drawing.Color.White
        Me.btnStandard.Enabled = False
        Me.btnStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnStandard.FlatAppearance.BorderSize = 3
        Me.btnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStandard.Location = New System.Drawing.Point(19, 2)
        Me.btnStandard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStandard.Name = "btnStandard"
        Me.btnStandard.Size = New System.Drawing.Size(28, 29)
        Me.btnStandard.TabIndex = 54
        Me.btnStandard.Text = " "
        Me.btnStandard.UseVisualStyleBackColor = False
        '
        'lblStandard
        '
        Me.lblStandard.AutoSize = True
        Me.lblStandard.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStandard.Location = New System.Drawing.Point(55, 10)
        Me.lblStandard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(53, 13)
        Me.lblStandard.TabIndex = 9
        Me.lblStandard.Text = "Standard"
        '
        'lblSupreme
        '
        Me.lblSupreme.AutoSize = True
        Me.lblSupreme.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupreme.Location = New System.Drawing.Point(55, 48)
        Me.lblSupreme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSupreme.Name = "lblSupreme"
        Me.lblSupreme.Size = New System.Drawing.Size(52, 13)
        Me.lblSupreme.TabIndex = 9
        Me.lblSupreme.Text = "Supreme"
        '
        'btnSupreme
        '
        Me.btnSupreme.BackColor = System.Drawing.Color.White
        Me.btnSupreme.BackgroundImage = CType(resources.GetObject("btnSupreme.BackgroundImage"), System.Drawing.Image)
        Me.btnSupreme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSupreme.Enabled = False
        Me.btnSupreme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnSupreme.FlatAppearance.BorderSize = 3
        Me.btnSupreme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupreme.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupreme.Location = New System.Drawing.Point(19, 40)
        Me.btnSupreme.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSupreme.Name = "btnSupreme"
        Me.btnSupreme.Size = New System.Drawing.Size(28, 29)
        Me.btnSupreme.TabIndex = 55
        Me.btnSupreme.Text = " "
        Me.btnSupreme.UseVisualStyleBackColor = False
        '
        'ExtendBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 476)
        Me.Controls.Add(Me.lblExtendBooking)
        Me.Controls.Add(Me.pnlChaletAvailability)
        Me.Controls.Add(Me.GboBookedChalets)
        Me.Controls.Add(Me.GboInfoSearch)
        Me.Controls.Add(Me.pnlChalet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExtendBooking"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlChaletAvailability.ResumeLayout(False)
        Me.pnlChaletAvailability.PerformLayout()
        Me.GboBookedChalets.ResumeLayout(False)
        Me.GboBookedChalets.PerformLayout()
        Me.tlpChaletButtons.ResumeLayout(False)
        Me.GboInfoSearch.ResumeLayout(False)
        Me.GboInfoSearch.PerformLayout()
        Me.pnlChalet.ResumeLayout(False)
        Me.pnlChalet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExtendBooking As Label
    Friend WithEvents pnlChaletAvailability As Panel
    Friend WithEvents lblAvailable As Label
    Friend WithEvents pnlAvailable As Panel
    Friend WithEvents lblOccupied As Label
    Friend WithEvents pnlOccupied As Panel
    Friend WithEvents GboBookedChalets As GroupBox
    Friend WithEvents tlpChaletButtons As TableLayoutPanel
    Friend WithEvents btnCH020 As Button
    Friend WithEvents btnCH001 As Button
    Friend WithEvents btnCH019 As Button
    Friend WithEvents btnCH018 As Button
    Friend WithEvents btnCH017 As Button
    Friend WithEvents btnCH002 As Button
    Friend WithEvents btnCH011 As Button
    Friend WithEvents btnCH012 As Button
    Friend WithEvents btnCH016 As Button
    Friend WithEvents btnCH003 As Button
    Friend WithEvents btnCH015 As Button
    Friend WithEvents btnCH004 As Button
    Friend WithEvents btnCH014 As Button
    Friend WithEvents btnCH005 As Button
    Friend WithEvents btnCH013 As Button
    Friend WithEvents btnCH006 As Button
    Friend WithEvents btnCH007 As Button
    Friend WithEvents btnCH008 As Button
    Friend WithEvents btnCH009 As Button
    Friend WithEvents btnCH010 As Button
    Friend WithEvents lblTest As Label
    Friend WithEvents GboInfoSearch As GroupBox
    Friend WithEvents CboGuestID As ComboBox
    Friend WithEvents txtGuestEmail As Label
    Friend WithEvents txtGuestName As Label
    Friend WithEvents txtGuestMobile As Label
    Friend WithEvents lblGuestEmail As Label
    Friend WithEvents lblGuestMobile As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents pnlChalet As Panel
    Friend WithEvents btnStandard As Button
    Friend WithEvents lblStandard As Label
    Friend WithEvents lblSupreme As Label
    Friend WithEvents btnSupreme As Button
    Friend WithEvents lblChaletSpec As Label
End Class
