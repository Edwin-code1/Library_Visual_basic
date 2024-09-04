<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReturns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReturns))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbStudentName = New System.Windows.Forms.ComboBox()
        Me.txtBookName = New RJCodeAdvance.RJControls.RJTextBox()
        Me.booklentDate = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookFine = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookReturnedDate = New RJCodeAdvance.RJControls.RJDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStudentbookIssuedName = New System.Windows.Forms.Label()
        Me.btnReturnedBookReset = New RJCodeAdvance.RJControls.RJButton()
        Me.btnReturnedBookDelete = New RJCodeAdvance.RJControls.RJButton()
        Me.btnReturnBookSave = New RJCodeAdvance.RJControls.RJButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdBooksIssuedTracked = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnGobackReturned = New RJCodeAdvance.RJControls.RJButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDtaProcess = New RJCodeAdvance.RJControls.RJButton()
        Me.btnFinesReport = New RJCodeAdvance.RJControls.RJButton()
        Me.btnLoanReturns = New RJCodeAdvance.RJControls.RJButton()
        Me.btnLoanReport = New RJCodeAdvance.RJControls.RJButton()
        Me.BtnReverseProces = New RJCodeAdvance.RJControls.RJButton()
        Me.BtnLogout = New RJCodeAdvance.RJControls.RJButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdBooksReturned = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.grdBooksIssuedTracked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.grdBooksReturned, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(986, 41)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(360, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Book Returns Details"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(106, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Book returns"
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
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(928, 3)
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
        Me.Guna2Panel2.Controls.Add(Me.cmbStudentName)
        Me.Guna2Panel2.Controls.Add(Me.txtBookName)
        Me.Guna2Panel2.Controls.Add(Me.booklentDate)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.txtBookFine)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.txtBookReturnedDate)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.lblStudentbookIssuedName)
        Me.Guna2Panel2.Location = New System.Drawing.Point(179, 47)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(807, 179)
        Me.Guna2Panel2.TabIndex = 5
        '
        'cmbStudentName
        '
        Me.cmbStudentName.FormattingEnabled = True
        Me.cmbStudentName.Location = New System.Drawing.Point(29, 51)
        Me.cmbStudentName.Name = "cmbStudentName"
        Me.cmbStudentName.Size = New System.Drawing.Size(154, 21)
        Me.cmbStudentName.TabIndex = 92
        '
        'txtBookName
        '
        Me.txtBookName.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookName.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookName.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookName.BorderRadius = 0
        Me.txtBookName.BorderSize = 2
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookName.Location = New System.Drawing.Point(258, 41)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookName.Multiline = False
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookName.PasswordChar = False
        Me.txtBookName.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookName.PlaceholderText = ""
        Me.txtBookName.Size = New System.Drawing.Size(113, 31)
        Me.txtBookName.TabIndex = 91
        Me.txtBookName.Texts = ""
        Me.txtBookName.UnderlinedStyle = False
        '
        'booklentDate
        '
        Me.booklentDate.BackColor = System.Drawing.SystemColors.Window
        Me.booklentDate.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.booklentDate.BorderFocusColor = System.Drawing.Color.HotPink
        Me.booklentDate.BorderRadius = 0
        Me.booklentDate.BorderSize = 2
        Me.booklentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booklentDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.booklentDate.Location = New System.Drawing.Point(528, 41)
        Me.booklentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.booklentDate.Multiline = False
        Me.booklentDate.Name = "booklentDate"
        Me.booklentDate.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.booklentDate.PasswordChar = False
        Me.booklentDate.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.booklentDate.PlaceholderText = ""
        Me.booklentDate.Size = New System.Drawing.Size(157, 31)
        Me.booklentDate.TabIndex = 89
        Me.booklentDate.Texts = ""
        Me.booklentDate.UnderlinedStyle = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Book Name"
        '
        'txtBookFine
        '
        Me.txtBookFine.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookFine.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookFine.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookFine.BorderRadius = 0
        Me.txtBookFine.BorderSize = 2
        Me.txtBookFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookFine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookFine.Location = New System.Drawing.Point(390, 41)
        Me.txtBookFine.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookFine.Multiline = False
        Me.txtBookFine.Name = "txtBookFine"
        Me.txtBookFine.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookFine.PasswordChar = False
        Me.txtBookFine.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookFine.PlaceholderText = ""
        Me.txtBookFine.Size = New System.Drawing.Size(113, 31)
        Me.txtBookFine.TabIndex = 85
        Me.txtBookFine.Texts = ""
        Me.txtBookFine.UnderlinedStyle = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fine"
        '
        'txtBookReturnedDate
        '
        Me.txtBookReturnedDate.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.txtBookReturnedDate.BorderSize = 0
        Me.txtBookReturnedDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtBookReturnedDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.txtBookReturnedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookReturnedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBookReturnedDate.Location = New System.Drawing.Point(29, 128)
        Me.txtBookReturnedDate.MinimumSize = New System.Drawing.Size(4, 35)
        Me.txtBookReturnedDate.Name = "txtBookReturnedDate"
        Me.txtBookReturnedDate.Size = New System.Drawing.Size(111, 35)
        Me.txtBookReturnedDate.SkinColor = System.Drawing.Color.AliceBlue
        Me.txtBookReturnedDate.TabIndex = 83
        Me.txtBookReturnedDate.TextColor = System.Drawing.Color.Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Return Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(527, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Issued Date"
        '
        'lblStudentbookIssuedName
        '
        Me.lblStudentbookIssuedName.AutoSize = True
        Me.lblStudentbookIssuedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentbookIssuedName.Location = New System.Drawing.Point(26, 21)
        Me.lblStudentbookIssuedName.Name = "lblStudentbookIssuedName"
        Me.lblStudentbookIssuedName.Size = New System.Drawing.Size(114, 18)
        Me.lblStudentbookIssuedName.TabIndex = 75
        Me.lblStudentbookIssuedName.Text = "Student Name"
        '
        'btnReturnedBookReset
        '
        Me.btnReturnedBookReset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnedBookReset.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnedBookReset.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnReturnedBookReset.BorderRadius = 10
        Me.btnReturnedBookReset.BorderSize = 0
        Me.btnReturnedBookReset.FlatAppearance.BorderSize = 0
        Me.btnReturnedBookReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnedBookReset.ForeColor = System.Drawing.Color.White
        Me.btnReturnedBookReset.Location = New System.Drawing.Point(46, 156)
        Me.btnReturnedBookReset.Name = "btnReturnedBookReset"
        Me.btnReturnedBookReset.Size = New System.Drawing.Size(100, 24)
        Me.btnReturnedBookReset.TabIndex = 89
        Me.btnReturnedBookReset.Text = "Reset"
        Me.btnReturnedBookReset.TextColor = System.Drawing.Color.White
        Me.btnReturnedBookReset.UseVisualStyleBackColor = False
        '
        'btnReturnedBookDelete
        '
        Me.btnReturnedBookDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnedBookDelete.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnedBookDelete.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnReturnedBookDelete.BorderRadius = 10
        Me.btnReturnedBookDelete.BorderSize = 0
        Me.btnReturnedBookDelete.FlatAppearance.BorderSize = 0
        Me.btnReturnedBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnedBookDelete.ForeColor = System.Drawing.Color.White
        Me.btnReturnedBookDelete.Location = New System.Drawing.Point(46, 113)
        Me.btnReturnedBookDelete.Name = "btnReturnedBookDelete"
        Me.btnReturnedBookDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnReturnedBookDelete.TabIndex = 87
        Me.btnReturnedBookDelete.Text = "Delete"
        Me.btnReturnedBookDelete.TextColor = System.Drawing.Color.White
        Me.btnReturnedBookDelete.UseVisualStyleBackColor = False
        '
        'btnReturnBookSave
        '
        Me.btnReturnBookSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnBookSave.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnBookSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnReturnBookSave.BorderRadius = 10
        Me.btnReturnBookSave.BorderSize = 0
        Me.btnReturnBookSave.FlatAppearance.BorderSize = 0
        Me.btnReturnBookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBookSave.ForeColor = System.Drawing.Color.White
        Me.btnReturnBookSave.Location = New System.Drawing.Point(48, 68)
        Me.btnReturnBookSave.Name = "btnReturnBookSave"
        Me.btnReturnBookSave.Size = New System.Drawing.Size(99, 39)
        Me.btnReturnBookSave.TabIndex = 86
        Me.btnReturnBookSave.Text = "Save"
        Me.btnReturnBookSave.TextColor = System.Drawing.Color.White
        Me.btnReturnBookSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(738, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Books Returned"
        '
        'grdBooksIssuedTracked
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdBooksIssuedTracked.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBooksIssuedTracked.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBooksIssuedTracked.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdBooksIssuedTracked.ColumnHeadersHeight = 4
        Me.grdBooksIssuedTracked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdBooksIssuedTracked.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdBooksIssuedTracked.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksIssuedTracked.Location = New System.Drawing.Point(179, 248)
        Me.grdBooksIssuedTracked.Name = "grdBooksIssuedTracked"
        Me.grdBooksIssuedTracked.RowHeadersVisible = False
        Me.grdBooksIssuedTracked.Size = New System.Drawing.Size(399, 253)
        Me.grdBooksIssuedTracked.TabIndex = 32
        Me.grdBooksIssuedTracked.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBooksIssuedTracked.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdBooksIssuedTracked.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBooksIssuedTracked.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdBooksIssuedTracked.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdBooksIssuedTracked.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdBooksIssuedTracked.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdBooksIssuedTracked.ThemeStyle.HeaderStyle.Height = 4
        Me.grdBooksIssuedTracked.ThemeStyle.ReadOnly = False
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.Height = 22
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksIssuedTracked.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnGobackReturned
        '
        Me.btnGobackReturned.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGobackReturned.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnGobackReturned.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnGobackReturned.BorderRadius = 10
        Me.btnGobackReturned.BorderSize = 0
        Me.btnGobackReturned.FlatAppearance.BorderSize = 0
        Me.btnGobackReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGobackReturned.ForeColor = System.Drawing.Color.White
        Me.btnGobackReturned.Location = New System.Drawing.Point(44, 330)
        Me.btnGobackReturned.Name = "btnGobackReturned"
        Me.btnGobackReturned.Size = New System.Drawing.Size(102, 32)
        Me.btnGobackReturned.TabIndex = 87
        Me.btnGobackReturned.Text = "Go Back"
        Me.btnGobackReturned.TextColor = System.Drawing.Color.White
        Me.btnGobackReturned.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Books Issued"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Controls.Add(Me.btnDtaProcess)
        Me.Guna2Panel3.Controls.Add(Me.btnFinesReport)
        Me.Guna2Panel3.Controls.Add(Me.btnLoanReturns)
        Me.Guna2Panel3.Controls.Add(Me.btnLoanReport)
        Me.Guna2Panel3.Controls.Add(Me.BtnReverseProces)
        Me.Guna2Panel3.Controls.Add(Me.btnReturnedBookReset)
        Me.Guna2Panel3.Controls.Add(Me.BtnLogout)
        Me.Guna2Panel3.Controls.Add(Me.btnGobackReturned)
        Me.Guna2Panel3.Controls.Add(Me.btnReturnedBookDelete)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.btnReturnBookSave)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(182, 496)
        Me.Guna2Panel3.TabIndex = 93
        '
        'btnDtaProcess
        '
        Me.btnDtaProcess.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDtaProcess.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnDtaProcess.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDtaProcess.BorderRadius = 10
        Me.btnDtaProcess.BorderSize = 0
        Me.btnDtaProcess.FlatAppearance.BorderSize = 0
        Me.btnDtaProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDtaProcess.ForeColor = System.Drawing.Color.White
        Me.btnDtaProcess.Location = New System.Drawing.Point(49, 29)
        Me.btnDtaProcess.Name = "btnDtaProcess"
        Me.btnDtaProcess.Size = New System.Drawing.Size(99, 33)
        Me.btnDtaProcess.TabIndex = 94
        Me.btnDtaProcess.Text = "DTA Process"
        Me.btnDtaProcess.TextColor = System.Drawing.Color.White
        Me.btnDtaProcess.UseVisualStyleBackColor = False
        '
        'btnFinesReport
        '
        Me.btnFinesReport.BackColor = System.Drawing.Color.ForestGreen
        Me.btnFinesReport.BackgroundColor = System.Drawing.Color.ForestGreen
        Me.btnFinesReport.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnFinesReport.BorderRadius = 10
        Me.btnFinesReport.BorderSize = 0
        Me.btnFinesReport.FlatAppearance.BorderSize = 0
        Me.btnFinesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinesReport.ForeColor = System.Drawing.Color.Black
        Me.btnFinesReport.Location = New System.Drawing.Point(44, 294)
        Me.btnFinesReport.Name = "btnFinesReport"
        Me.btnFinesReport.Size = New System.Drawing.Size(99, 30)
        Me.btnFinesReport.TabIndex = 93
        Me.btnFinesReport.Text = "Fines Report"
        Me.btnFinesReport.TextColor = System.Drawing.Color.Black
        Me.btnFinesReport.UseVisualStyleBackColor = False
        '
        'btnLoanReturns
        '
        Me.btnLoanReturns.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLoanReturns.BackgroundColor = System.Drawing.Color.DarkGreen
        Me.btnLoanReturns.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnLoanReturns.BorderRadius = 10
        Me.btnLoanReturns.BorderSize = 0
        Me.btnLoanReturns.FlatAppearance.BorderSize = 0
        Me.btnLoanReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoanReturns.ForeColor = System.Drawing.Color.Black
        Me.btnLoanReturns.Location = New System.Drawing.Point(46, 258)
        Me.btnLoanReturns.Name = "btnLoanReturns"
        Me.btnLoanReturns.Size = New System.Drawing.Size(99, 30)
        Me.btnLoanReturns.TabIndex = 92
        Me.btnLoanReturns.Text = "Returns Repo"
        Me.btnLoanReturns.TextColor = System.Drawing.Color.Black
        Me.btnLoanReturns.UseVisualStyleBackColor = False
        '
        'btnLoanReport
        '
        Me.btnLoanReport.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLoanReport.BackgroundColor = System.Drawing.Color.DarkGreen
        Me.btnLoanReport.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnLoanReport.BorderRadius = 10
        Me.btnLoanReport.BorderSize = 0
        Me.btnLoanReport.FlatAppearance.BorderSize = 0
        Me.btnLoanReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoanReport.ForeColor = System.Drawing.Color.Black
        Me.btnLoanReport.Location = New System.Drawing.Point(46, 222)
        Me.btnLoanReport.Name = "btnLoanReport"
        Me.btnLoanReport.Size = New System.Drawing.Size(99, 30)
        Me.btnLoanReport.TabIndex = 91
        Me.btnLoanReport.Text = "Loan Report"
        Me.btnLoanReport.TextColor = System.Drawing.Color.Black
        Me.btnLoanReport.UseVisualStyleBackColor = False
        '
        'BtnReverseProces
        '
        Me.BtnReverseProces.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnReverseProces.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.BtnReverseProces.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnReverseProces.BorderRadius = 10
        Me.BtnReverseProces.BorderSize = 0
        Me.BtnReverseProces.FlatAppearance.BorderSize = 0
        Me.BtnReverseProces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReverseProces.ForeColor = System.Drawing.Color.White
        Me.BtnReverseProces.Location = New System.Drawing.Point(46, 186)
        Me.BtnReverseProces.Name = "BtnReverseProces"
        Me.BtnReverseProces.Size = New System.Drawing.Size(99, 30)
        Me.BtnReverseProces.TabIndex = 90
        Me.BtnReverseProces.Text = "Reversar Orden"
        Me.BtnReverseProces.TextColor = System.Drawing.Color.White
        Me.BtnReverseProces.UseVisualStyleBackColor = False
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
        Me.BtnLogout.Location = New System.Drawing.Point(39, 444)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(100, 40)
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
        Me.Label8.Location = New System.Drawing.Point(72, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Menu"
        '
        'grdBooksReturned
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.grdBooksReturned.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdBooksReturned.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBooksReturned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdBooksReturned.ColumnHeadersHeight = 4
        Me.grdBooksReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdBooksReturned.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdBooksReturned.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksReturned.Location = New System.Drawing.Point(595, 248)
        Me.grdBooksReturned.Name = "grdBooksReturned"
        Me.grdBooksReturned.RowHeadersVisible = False
        Me.grdBooksReturned.Size = New System.Drawing.Size(391, 253)
        Me.grdBooksReturned.TabIndex = 88
        Me.grdBooksReturned.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBooksReturned.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdBooksReturned.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBooksReturned.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdBooksReturned.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdBooksReturned.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdBooksReturned.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdBooksReturned.ThemeStyle.HeaderStyle.Height = 4
        Me.grdBooksReturned.ThemeStyle.ReadOnly = False
        Me.grdBooksReturned.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBooksReturned.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdBooksReturned.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBooksReturned.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdBooksReturned.ThemeStyle.RowsStyle.Height = 22
        Me.grdBooksReturned.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBooksReturned.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BookReturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 537)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grdBooksReturned)
        Me.Controls.Add(Me.grdBooksIssuedTracked)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookReturns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookReturns"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.grdBooksIssuedTracked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.grdBooksReturned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents blbusername As Label
    Friend WithEvents pictureboxCloseIcon As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCircularPictureBox1 As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtBookFine As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookReturnedDate As RJCodeAdvance.RJControls.RJDatePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentbookIssuedName As Label
    Friend WithEvents btnReturnedBookReset As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnReturnedBookDelete As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnReturnBookSave As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label4 As Label
    Friend WithEvents grdBooksIssuedTracked As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnGobackReturned As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLogout As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents booklentDate As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtBookName As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents cmbStudentName As ComboBox
    Friend WithEvents grdBooksReturned As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnReverseProces As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnFinesReport As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnLoanReturns As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnLoanReport As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnDtaProcess As RJCodeAdvance.RJControls.RJButton
End Class
