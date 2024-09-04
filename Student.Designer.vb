<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.txtStudentDepartment = New RJCodeAdvance.RJControls.RJTextBox()
        Me.lbllibrarianPassword = New System.Windows.Forms.Label()
        Me.lblLibrarianphone = New System.Windows.Forms.Label()
        Me.lblLibrarianName = New System.Windows.Forms.Label()
        Me.txtStudentPhone = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtStudentName = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSemester = New RJCodeAdvance.RJControls.RJComboBox()
        Me.btnStudentReset = New RJCodeAdvance.RJControls.RJButton()
        Me.btnEditStudent = New RJCodeAdvance.RJControls.RJButton()
        Me.btnDeleteStudent = New RJCodeAdvance.RJControls.RJButton()
        Me.btnSaveStudent = New RJCodeAdvance.RJControls.RJButton()
        Me.grdstudent = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudentGoBack = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnLogout = New RJCodeAdvance.RJControls.RJButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.grdstudent, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(954, 41)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(459, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Student  Details"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(65, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Student"
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
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(918, 0)
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
        'txtStudentDepartment
        '
        Me.txtStudentDepartment.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudentDepartment.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtStudentDepartment.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtStudentDepartment.BorderRadius = 0
        Me.txtStudentDepartment.BorderSize = 2
        Me.txtStudentDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStudentDepartment.Location = New System.Drawing.Point(498, 62)
        Me.txtStudentDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentDepartment.Multiline = False
        Me.txtStudentDepartment.Name = "txtStudentDepartment"
        Me.txtStudentDepartment.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtStudentDepartment.PasswordChar = False
        Me.txtStudentDepartment.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtStudentDepartment.PlaceholderText = ""
        Me.txtStudentDepartment.Size = New System.Drawing.Size(107, 31)
        Me.txtStudentDepartment.TabIndex = 67
        Me.txtStudentDepartment.Texts = ""
        Me.txtStudentDepartment.UnderlinedStyle = False
        '
        'lbllibrarianPassword
        '
        Me.lbllibrarianPassword.AutoSize = True
        Me.lbllibrarianPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibrarianPassword.Location = New System.Drawing.Point(482, 27)
        Me.lbllibrarianPassword.Name = "lbllibrarianPassword"
        Me.lbllibrarianPassword.Size = New System.Drawing.Size(95, 18)
        Me.lbllibrarianPassword.TabIndex = 66
        Me.lbllibrarianPassword.Text = "Department"
        '
        'lblLibrarianphone
        '
        Me.lblLibrarianphone.AutoSize = True
        Me.lblLibrarianphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibrarianphone.Location = New System.Drawing.Point(390, 27)
        Me.lblLibrarianphone.Name = "lblLibrarianphone"
        Me.lblLibrarianphone.Size = New System.Drawing.Size(56, 18)
        Me.lblLibrarianphone.TabIndex = 65
        Me.lblLibrarianphone.Text = "Phone"
        '
        'lblLibrarianName
        '
        Me.lblLibrarianName.AutoSize = True
        Me.lblLibrarianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibrarianName.Location = New System.Drawing.Point(294, 27)
        Me.lblLibrarianName.Name = "lblLibrarianName"
        Me.lblLibrarianName.Size = New System.Drawing.Size(52, 18)
        Me.lblLibrarianName.TabIndex = 64
        Me.lblLibrarianName.Text = "Name"
        '
        'txtStudentPhone
        '
        Me.txtStudentPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudentPhone.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtStudentPhone.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtStudentPhone.BorderRadius = 0
        Me.txtStudentPhone.BorderSize = 2
        Me.txtStudentPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStudentPhone.Location = New System.Drawing.Point(390, 62)
        Me.txtStudentPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentPhone.Multiline = False
        Me.txtStudentPhone.Name = "txtStudentPhone"
        Me.txtStudentPhone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtStudentPhone.PasswordChar = False
        Me.txtStudentPhone.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtStudentPhone.PlaceholderText = ""
        Me.txtStudentPhone.Size = New System.Drawing.Size(100, 31)
        Me.txtStudentPhone.TabIndex = 59
        Me.txtStudentPhone.Texts = ""
        Me.txtStudentPhone.UnderlinedStyle = False
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudentName.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtStudentName.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtStudentName.BorderRadius = 0
        Me.txtStudentName.BorderSize = 2
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStudentName.Location = New System.Drawing.Point(294, 62)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentName.Multiline = False
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtStudentName.PasswordChar = False
        Me.txtStudentName.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtStudentName.PlaceholderText = ""
        Me.txtStudentName.Size = New System.Drawing.Size(85, 31)
        Me.txtStudentName.TabIndex = 58
        Me.txtStudentName.Texts = ""
        Me.txtStudentName.UnderlinedStyle = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.cmbSemester)
        Me.Guna2Panel2.Controls.Add(Me.lblLibrarianName)
        Me.Guna2Panel2.Controls.Add(Me.txtStudentDepartment)
        Me.Guna2Panel2.Controls.Add(Me.txtStudentName)
        Me.Guna2Panel2.Controls.Add(Me.lbllibrarianPassword)
        Me.Guna2Panel2.Controls.Add(Me.txtStudentPhone)
        Me.Guna2Panel2.Controls.Add(Me.lblLibrarianphone)
        Me.Guna2Panel2.Location = New System.Drawing.Point(140, 41)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(814, 114)
        Me.Guna2Panel2.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Semester"
        '
        'cmbSemester
        '
        Me.cmbSemester.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSemester.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.cmbSemester.BorderSize = 1
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbSemester.ForeColor = System.Drawing.Color.DimGray
        Me.cmbSemester.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbSemester.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cmbSemester.ListTextColor = System.Drawing.Color.DimGray
        Me.cmbSemester.Location = New System.Drawing.Point(87, 62)
        Me.cmbSemester.MinimumSize = New System.Drawing.Size(200, 30)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Padding = New System.Windows.Forms.Padding(1)
        Me.cmbSemester.Size = New System.Drawing.Size(200, 30)
        Me.cmbSemester.TabIndex = 73
        Me.cmbSemester.Texts = ""
        '
        'btnStudentReset
        '
        Me.btnStudentReset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentReset.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentReset.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnStudentReset.BorderRadius = 10
        Me.btnStudentReset.BorderSize = 0
        Me.btnStudentReset.FlatAppearance.BorderSize = 0
        Me.btnStudentReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentReset.ForeColor = System.Drawing.Color.White
        Me.btnStudentReset.Location = New System.Drawing.Point(13, 201)
        Me.btnStudentReset.Name = "btnStudentReset"
        Me.btnStudentReset.Size = New System.Drawing.Size(107, 40)
        Me.btnStudentReset.TabIndex = 71
        Me.btnStudentReset.Text = "Reset"
        Me.btnStudentReset.TextColor = System.Drawing.Color.White
        Me.btnStudentReset.UseVisualStyleBackColor = False
        '
        'btnEditStudent
        '
        Me.btnEditStudent.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditStudent.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnEditStudent.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnEditStudent.BorderRadius = 10
        Me.btnEditStudent.BorderSize = 0
        Me.btnEditStudent.FlatAppearance.BorderSize = 0
        Me.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditStudent.ForeColor = System.Drawing.Color.White
        Me.btnEditStudent.Location = New System.Drawing.Point(12, 157)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(108, 38)
        Me.btnEditStudent.TabIndex = 70
        Me.btnEditStudent.Text = "Edit"
        Me.btnEditStudent.TextColor = System.Drawing.Color.White
        Me.btnEditStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDeleteStudent.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnDeleteStudent.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteStudent.BorderRadius = 10
        Me.btnDeleteStudent.BorderSize = 0
        Me.btnDeleteStudent.FlatAppearance.BorderSize = 0
        Me.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStudent.ForeColor = System.Drawing.Color.White
        Me.btnDeleteStudent.Location = New System.Drawing.Point(12, 112)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(108, 39)
        Me.btnDeleteStudent.TabIndex = 69
        Me.btnDeleteStudent.Text = "Delete"
        Me.btnDeleteStudent.TextColor = System.Drawing.Color.White
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveStudent.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveStudent.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSaveStudent.BorderRadius = 10
        Me.btnSaveStudent.BorderSize = 0
        Me.btnSaveStudent.FlatAppearance.BorderSize = 0
        Me.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveStudent.ForeColor = System.Drawing.Color.White
        Me.btnSaveStudent.Location = New System.Drawing.Point(12, 68)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(108, 38)
        Me.btnSaveStudent.TabIndex = 68
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.TextColor = System.Drawing.Color.White
        Me.btnSaveStudent.UseVisualStyleBackColor = False
        '
        'grdstudent
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdstudent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdstudent.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdstudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdstudent.ColumnHeadersHeight = 4
        Me.grdstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdstudent.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdstudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdstudent.Location = New System.Drawing.Point(140, 183)
        Me.grdstudent.Name = "grdstudent"
        Me.grdstudent.RowHeadersVisible = False
        Me.grdstudent.Size = New System.Drawing.Size(811, 345)
        Me.grdstudent.TabIndex = 70
        Me.grdstudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdstudent.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdstudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdstudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdstudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdstudent.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdstudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdstudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdstudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdstudent.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdstudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdstudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdstudent.ThemeStyle.HeaderStyle.Height = 4
        Me.grdstudent.ThemeStyle.ReadOnly = False
        Me.grdstudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdstudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdstudent.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdstudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdstudent.ThemeStyle.RowsStyle.Height = 22
        Me.grdstudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdstudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Student List"
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
        Me.btnStudentGoBack.Location = New System.Drawing.Point(12, 247)
        Me.btnStudentGoBack.Name = "btnStudentGoBack"
        Me.btnStudentGoBack.Size = New System.Drawing.Size(107, 36)
        Me.btnStudentGoBack.TabIndex = 71
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
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Controls.Add(Me.btnStudentReset)
        Me.Guna2Panel3.Controls.Add(Me.btnSaveStudent)
        Me.Guna2Panel3.Controls.Add(Me.btnEditStudent)
        Me.Guna2Panel3.Controls.Add(Me.btnDeleteStudent)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(134, 487)
        Me.Guna2Panel3.TabIndex = 72
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
        Me.BtnLogout.Location = New System.Drawing.Point(12, 444)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(93, 40)
        Me.BtnLogout.TabIndex = 62
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextColor = System.Drawing.Color.White
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Menu"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 528)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.grdstudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.grdstudent, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtStudentDepartment As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents lbllibrarianPassword As Label
    Friend WithEvents lblLibrarianphone As Label
    Friend WithEvents lblLibrarianName As Label
    Friend WithEvents txtStudentPhone As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtStudentName As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnStudentReset As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnEditStudent As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnDeleteStudent As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnSaveStudent As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents grdstudent As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSemester As RJCodeAdvance.RJControls.RJComboBox
    Friend WithEvents btnStudentGoBack As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLogout As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label3 As Label
End Class
