<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterCreate
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SemesterCreate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtCareer = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDepartment = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtSemester = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYear = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New RJCodeAdvance.RJControls.RJButton()
        Me.btnEditSemester = New RJCodeAdvance.RJControls.RJButton()
        Me.btnDeleteSemester = New RJCodeAdvance.RJControls.RJButton()
        Me.btnSaveSemester = New RJCodeAdvance.RJControls.RJButton()
        Me.grdSemester = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnStudentGoBack = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnLogout = New RJCodeAdvance.RJControls.RJButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.grdSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.blbusername)
        Me.Guna2Panel1.Controls.Add(Me.pictureboxCloseIcon)
        Me.Guna2Panel1.Controls.Add(Me.RjCircularPictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(958, 41)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Semester Details"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(80, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Semester"
        '
        'pictureboxCloseIcon
        '
        Me.pictureboxCloseIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.pictureboxCloseIcon.BorderColor = System.Drawing.Color.RoyalBlue
        Me.pictureboxCloseIcon.BorderColor2 = System.Drawing.Color.HotPink
        Me.pictureboxCloseIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.pictureboxCloseIcon.BorderSize = 2
        Me.pictureboxCloseIcon.GradientAngle = 50.0!
        Me.pictureboxCloseIcon.Image = CType(resources.GetObject("pictureboxCloseIcon.Image"), System.Drawing.Image)
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(922, 3)
        Me.pictureboxCloseIcon.Name = "pictureboxCloseIcon"
        Me.pictureboxCloseIcon.Size = New System.Drawing.Size(33, 33)
        Me.pictureboxCloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxCloseIcon.TabIndex = 1
        Me.pictureboxCloseIcon.TabStop = False
        '
        'RjCircularPictureBox1
        '
        Me.RjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircularPictureBox1.BorderSize = 2
        Me.RjCircularPictureBox1.GradientAngle = 50.0!
        Me.RjCircularPictureBox1.Image = CType(resources.GetObject("RjCircularPictureBox1.Image"), System.Drawing.Image)
        Me.RjCircularPictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.RjCircularPictureBox1.Name = "RjCircularPictureBox1"
        Me.RjCircularPictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.RjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircularPictureBox1.TabIndex = 0
        Me.RjCircularPictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.txtCareer)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.txtDepartment)
        Me.Guna2Panel2.Controls.Add(Me.txtSemester)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.txtYear)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Location = New System.Drawing.Point(140, 47)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(818, 111)
        Me.Guna2Panel2.TabIndex = 87
        '
        'txtCareer
        '
        Me.txtCareer.BackColor = System.Drawing.SystemColors.Window
        Me.txtCareer.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtCareer.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtCareer.BorderRadius = 0
        Me.txtCareer.BorderSize = 2
        Me.txtCareer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCareer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCareer.Location = New System.Drawing.Point(594, 57)
        Me.txtCareer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCareer.Multiline = False
        Me.txtCareer.Name = "txtCareer"
        Me.txtCareer.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtCareer.PasswordChar = False
        Me.txtCareer.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtCareer.PlaceholderText = ""
        Me.txtCareer.Size = New System.Drawing.Size(162, 31)
        Me.txtCareer.TabIndex = 73
        Me.txtCareer.Texts = ""
        Me.txtCareer.UnderlinedStyle = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(621, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Career"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Name"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.SystemColors.Window
        Me.txtDepartment.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtDepartment.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtDepartment.BorderRadius = 0
        Me.txtDepartment.BorderSize = 2
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDepartment.Location = New System.Drawing.Point(404, 58)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepartment.Multiline = False
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtDepartment.PasswordChar = False
        Me.txtDepartment.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtDepartment.PlaceholderText = ""
        Me.txtDepartment.Size = New System.Drawing.Size(182, 31)
        Me.txtDepartment.TabIndex = 67
        Me.txtDepartment.Texts = ""
        Me.txtDepartment.UnderlinedStyle = False
        '
        'txtSemester
        '
        Me.txtSemester.BackColor = System.Drawing.SystemColors.Window
        Me.txtSemester.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSemester.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtSemester.BorderRadius = 0
        Me.txtSemester.BorderSize = 2
        Me.txtSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSemester.Location = New System.Drawing.Point(94, 58)
        Me.txtSemester.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSemester.Multiline = False
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSemester.PasswordChar = False
        Me.txtSemester.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSemester.PlaceholderText = ""
        Me.txtSemester.Size = New System.Drawing.Size(148, 31)
        Me.txtSemester.TabIndex = 58
        Me.txtSemester.Texts = ""
        Me.txtSemester.UnderlinedStyle = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Department"
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtYear.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtYear.BorderRadius = 0
        Me.txtYear.BorderSize = 2
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtYear.Location = New System.Drawing.Point(250, 58)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.Multiline = False
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtYear.PasswordChar = False
        Me.txtYear.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtYear.PlaceholderText = ""
        Me.txtYear.Size = New System.Drawing.Size(146, 31)
        Me.txtYear.TabIndex = 59
        Me.txtYear.Texts = ""
        Me.txtYear.UnderlinedStyle = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Year"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReset.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnReset.BorderRadius = 10
        Me.btnReset.BorderSize = 0
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(19, 212)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 40)
        Me.btnReset.TabIndex = 71
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextColor = System.Drawing.Color.White
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEditSemester
        '
        Me.btnEditSemester.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditSemester.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnEditSemester.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnEditSemester.BorderRadius = 10
        Me.btnEditSemester.BorderSize = 0
        Me.btnEditSemester.FlatAppearance.BorderSize = 0
        Me.btnEditSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSemester.ForeColor = System.Drawing.Color.White
        Me.btnEditSemester.Location = New System.Drawing.Point(19, 166)
        Me.btnEditSemester.Name = "btnEditSemester"
        Me.btnEditSemester.Size = New System.Drawing.Size(100, 40)
        Me.btnEditSemester.TabIndex = 70
        Me.btnEditSemester.Text = "Edit"
        Me.btnEditSemester.TextColor = System.Drawing.Color.White
        Me.btnEditSemester.UseVisualStyleBackColor = False
        '
        'btnDeleteSemester
        '
        Me.btnDeleteSemester.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDeleteSemester.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnDeleteSemester.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteSemester.BorderRadius = 10
        Me.btnDeleteSemester.BorderSize = 0
        Me.btnDeleteSemester.FlatAppearance.BorderSize = 0
        Me.btnDeleteSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSemester.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSemester.Location = New System.Drawing.Point(19, 120)
        Me.btnDeleteSemester.Name = "btnDeleteSemester"
        Me.btnDeleteSemester.Size = New System.Drawing.Size(97, 40)
        Me.btnDeleteSemester.TabIndex = 69
        Me.btnDeleteSemester.Text = "Delete"
        Me.btnDeleteSemester.TextColor = System.Drawing.Color.White
        Me.btnDeleteSemester.UseVisualStyleBackColor = False
        '
        'btnSaveSemester
        '
        Me.btnSaveSemester.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveSemester.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveSemester.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSaveSemester.BorderRadius = 10
        Me.btnSaveSemester.BorderSize = 0
        Me.btnSaveSemester.FlatAppearance.BorderSize = 0
        Me.btnSaveSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSemester.ForeColor = System.Drawing.Color.White
        Me.btnSaveSemester.Location = New System.Drawing.Point(19, 64)
        Me.btnSaveSemester.Name = "btnSaveSemester"
        Me.btnSaveSemester.Size = New System.Drawing.Size(97, 40)
        Me.btnSaveSemester.TabIndex = 68
        Me.btnSaveSemester.Text = "Save"
        Me.btnSaveSemester.TextColor = System.Drawing.Color.White
        Me.btnSaveSemester.UseVisualStyleBackColor = False
        '
        'grdSemester
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdSemester.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSemester.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSemester.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdSemester.ColumnHeadersHeight = 4
        Me.grdSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSemester.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdSemester.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSemester.Location = New System.Drawing.Point(140, 182)
        Me.grdSemester.Name = "grdSemester"
        Me.grdSemester.RowHeadersVisible = False
        Me.grdSemester.Size = New System.Drawing.Size(818, 346)
        Me.grdSemester.TabIndex = 89
        Me.grdSemester.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdSemester.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdSemester.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSemester.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdSemester.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdSemester.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdSemester.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSemester.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSemester.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdSemester.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSemester.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdSemester.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdSemester.ThemeStyle.HeaderStyle.Height = 4
        Me.grdSemester.ThemeStyle.ReadOnly = False
        Me.grdSemester.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdSemester.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdSemester.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSemester.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdSemester.ThemeStyle.RowsStyle.Height = 22
        Me.grdSemester.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSemester.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(479, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Semester List"
        '
        'btnStudentGoBack
        '
        Me.btnStudentGoBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentGoBack.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentGoBack.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnStudentGoBack.BorderRadius = 10
        Me.btnStudentGoBack.BorderSize = 0
        Me.btnStudentGoBack.FlatAppearance.BorderSize = 0
        Me.btnStudentGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentGoBack.ForeColor = System.Drawing.Color.White
        Me.btnStudentGoBack.Location = New System.Drawing.Point(19, 258)
        Me.btnStudentGoBack.Name = "btnStudentGoBack"
        Me.btnStudentGoBack.Size = New System.Drawing.Size(100, 37)
        Me.btnStudentGoBack.TabIndex = 90
        Me.btnStudentGoBack.Text = "Go Back"
        Me.btnStudentGoBack.TextColor = System.Drawing.Color.White
        Me.btnStudentGoBack.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Controls.Add(Me.BtnLogout)
        Me.Guna2Panel3.Controls.Add(Me.btnStudentGoBack)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.btnReset)
        Me.Guna2Panel3.Controls.Add(Me.btnSaveSemester)
        Me.Guna2Panel3.Controls.Add(Me.btnEditSemester)
        Me.Guna2Panel3.Controls.Add(Me.btnDeleteSemester)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(134, 489)
        Me.Guna2Panel3.TabIndex = 91
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnLogout.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.BtnLogout.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnLogout.BorderRadius = 10
        Me.BtnLogout.BorderSize = 0
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(23, 447)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(93, 40)
        Me.BtnLogout.TabIndex = 62
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextColor = System.Drawing.Color.White
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(41, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Menu"
        '
        'SemesterCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 530)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.grdSemester)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SemesterCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SemesterCreate"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.grdSemester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents blbusername As Label
    Friend WithEvents pictureboxCloseIcon As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCircularPictureBox1 As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnReset As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnEditSemester As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnDeleteSemester As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnSaveSemester As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDepartment As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtSemester As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYear As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grdSemester As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCareer As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudentGoBack As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLogout As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label8 As Label
End Class
