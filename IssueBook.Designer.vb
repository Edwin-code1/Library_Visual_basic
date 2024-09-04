<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueBook))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbBookName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbBookId = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbStudentId = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDatedIssued = New RJCodeAdvance.RJControls.RJDatePicker()
        Me.lblIssuedBookName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIssuedBookID = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.btnIssuedBookReset = New RJCodeAdvance.RJControls.RJButton()
        Me.btnIssuedBooknEdit = New RJCodeAdvance.RJControls.RJButton()
        Me.btnIssuedBookDelete = New RJCodeAdvance.RJControls.RJButton()
        Me.btnIssuedBookSave = New RJCodeAdvance.RJControls.RJButton()
        Me.grdIssuedBooks = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGobackIssued = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnLogout = New RJCodeAdvance.RJControls.RJButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.grdIssuedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(986, 41)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Lend Books"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(102, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Issue Books"
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
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(953, 3)
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
        Me.Guna2Panel2.Controls.Add(Me.cmbBookName)
        Me.Guna2Panel2.Controls.Add(Me.cmbBookId)
        Me.Guna2Panel2.Controls.Add(Me.cmbStudentId)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.txtDatedIssued)
        Me.Guna2Panel2.Controls.Add(Me.lblIssuedBookName)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.lblIssuedBookID)
        Me.Guna2Panel2.Controls.Add(Me.lblStudentId)
        Me.Guna2Panel2.Location = New System.Drawing.Point(140, 47)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(846, 102)
        Me.Guna2Panel2.TabIndex = 4
        '
        'cmbBookName
        '
        Me.cmbBookName.BackColor = System.Drawing.Color.Transparent
        Me.cmbBookName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBookName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBookName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBookName.ItemHeight = 30
        Me.cmbBookName.Location = New System.Drawing.Point(367, 49)
        Me.cmbBookName.Name = "cmbBookName"
        Me.cmbBookName.Size = New System.Drawing.Size(140, 36)
        Me.cmbBookName.TabIndex = 80
        '
        'cmbBookId
        '
        Me.cmbBookId.BackColor = System.Drawing.Color.Transparent
        Me.cmbBookId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBookId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookId.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBookId.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBookId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBookId.ItemHeight = 30
        Me.cmbBookId.Location = New System.Drawing.Point(207, 53)
        Me.cmbBookId.Name = "cmbBookId"
        Me.cmbBookId.Size = New System.Drawing.Size(140, 36)
        Me.cmbBookId.TabIndex = 78
        '
        'cmbStudentId
        '
        Me.cmbStudentId.BackColor = System.Drawing.Color.Transparent
        Me.cmbStudentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudentId.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudentId.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudentId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbStudentId.ItemHeight = 30
        Me.cmbStudentId.Location = New System.Drawing.Point(61, 53)
        Me.cmbStudentId.Name = "cmbStudentId"
        Me.cmbStudentId.Size = New System.Drawing.Size(140, 36)
        Me.cmbStudentId.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Book Name"
        '
        'txtDatedIssued
        '
        Me.txtDatedIssued.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.txtDatedIssued.BorderSize = 0
        Me.txtDatedIssued.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.txtDatedIssued.Location = New System.Drawing.Point(514, 50)
        Me.txtDatedIssued.MinimumSize = New System.Drawing.Size(4, 35)
        Me.txtDatedIssued.Name = "txtDatedIssued"
        Me.txtDatedIssued.Size = New System.Drawing.Size(227, 35)
        Me.txtDatedIssued.SkinColor = System.Drawing.Color.Navy
        Me.txtDatedIssued.TabIndex = 73
        Me.txtDatedIssued.TextColor = System.Drawing.Color.White
        '
        'lblIssuedBookName
        '
        Me.lblIssuedBookName.AutoSize = True
        Me.lblIssuedBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuedBookName.Location = New System.Drawing.Point(685, 148)
        Me.lblIssuedBookName.Name = "lblIssuedBookName"
        Me.lblIssuedBookName.Size = New System.Drawing.Size(0, 18)
        Me.lblIssuedBookName.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(584, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Issued Date"
        '
        'lblIssuedBookID
        '
        Me.lblIssuedBookID.AutoSize = True
        Me.lblIssuedBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuedBookID.Location = New System.Drawing.Point(238, 32)
        Me.lblIssuedBookID.Name = "lblIssuedBookID"
        Me.lblIssuedBookID.Size = New System.Drawing.Size(69, 18)
        Me.lblIssuedBookID.TabIndex = 66
        Me.lblIssuedBookID.Text = "Book ID"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.Location = New System.Drawing.Point(58, 32)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(86, 18)
        Me.lblStudentId.TabIndex = 64
        Me.lblStudentId.Text = "Student ID"
        '
        'btnIssuedBookReset
        '
        Me.btnIssuedBookReset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookReset.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookReset.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnIssuedBookReset.BorderRadius = 10
        Me.btnIssuedBookReset.BorderSize = 0
        Me.btnIssuedBookReset.FlatAppearance.BorderSize = 0
        Me.btnIssuedBookReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedBookReset.ForeColor = System.Drawing.Color.White
        Me.btnIssuedBookReset.Location = New System.Drawing.Point(24, 206)
        Me.btnIssuedBookReset.Name = "btnIssuedBookReset"
        Me.btnIssuedBookReset.Size = New System.Drawing.Size(87, 40)
        Me.btnIssuedBookReset.TabIndex = 63
        Me.btnIssuedBookReset.Text = "Reset"
        Me.btnIssuedBookReset.TextColor = System.Drawing.Color.White
        Me.btnIssuedBookReset.UseVisualStyleBackColor = False
        '
        'btnIssuedBooknEdit
        '
        Me.btnIssuedBooknEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBooknEdit.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBooknEdit.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnIssuedBooknEdit.BorderRadius = 10
        Me.btnIssuedBooknEdit.BorderSize = 0
        Me.btnIssuedBooknEdit.FlatAppearance.BorderSize = 0
        Me.btnIssuedBooknEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedBooknEdit.ForeColor = System.Drawing.Color.White
        Me.btnIssuedBooknEdit.Location = New System.Drawing.Point(24, 160)
        Me.btnIssuedBooknEdit.Name = "btnIssuedBooknEdit"
        Me.btnIssuedBooknEdit.Size = New System.Drawing.Size(87, 40)
        Me.btnIssuedBooknEdit.TabIndex = 62
        Me.btnIssuedBooknEdit.Text = "Edit"
        Me.btnIssuedBooknEdit.TextColor = System.Drawing.Color.White
        Me.btnIssuedBooknEdit.UseVisualStyleBackColor = False
        '
        'btnIssuedBookDelete
        '
        Me.btnIssuedBookDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookDelete.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookDelete.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnIssuedBookDelete.BorderRadius = 10
        Me.btnIssuedBookDelete.BorderSize = 0
        Me.btnIssuedBookDelete.FlatAppearance.BorderSize = 0
        Me.btnIssuedBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedBookDelete.ForeColor = System.Drawing.Color.White
        Me.btnIssuedBookDelete.Location = New System.Drawing.Point(24, 114)
        Me.btnIssuedBookDelete.Name = "btnIssuedBookDelete"
        Me.btnIssuedBookDelete.Size = New System.Drawing.Size(87, 40)
        Me.btnIssuedBookDelete.TabIndex = 61
        Me.btnIssuedBookDelete.Text = "Delete"
        Me.btnIssuedBookDelete.TextColor = System.Drawing.Color.White
        Me.btnIssuedBookDelete.UseVisualStyleBackColor = False
        '
        'btnIssuedBookSave
        '
        Me.btnIssuedBookSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookSave.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnIssuedBookSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnIssuedBookSave.BorderRadius = 10
        Me.btnIssuedBookSave.BorderSize = 0
        Me.btnIssuedBookSave.FlatAppearance.BorderSize = 0
        Me.btnIssuedBookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedBookSave.ForeColor = System.Drawing.Color.White
        Me.btnIssuedBookSave.Location = New System.Drawing.Point(24, 68)
        Me.btnIssuedBookSave.Name = "btnIssuedBookSave"
        Me.btnIssuedBookSave.Size = New System.Drawing.Size(87, 40)
        Me.btnIssuedBookSave.TabIndex = 60
        Me.btnIssuedBookSave.Text = "Save"
        Me.btnIssuedBookSave.TextColor = System.Drawing.Color.White
        Me.btnIssuedBookSave.UseVisualStyleBackColor = False
        '
        'grdIssuedBooks
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.grdIssuedBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.grdIssuedBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIssuedBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdIssuedBooks.ColumnHeadersHeight = 4
        Me.grdIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdIssuedBooks.DefaultCellStyle = DataGridViewCellStyle12
        Me.grdIssuedBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdIssuedBooks.Location = New System.Drawing.Point(140, 173)
        Me.grdIssuedBooks.Name = "grdIssuedBooks"
        Me.grdIssuedBooks.RowHeadersVisible = False
        Me.grdIssuedBooks.Size = New System.Drawing.Size(846, 372)
        Me.grdIssuedBooks.TabIndex = 31
        Me.grdIssuedBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdIssuedBooks.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdIssuedBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdIssuedBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdIssuedBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdIssuedBooks.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdIssuedBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdIssuedBooks.ThemeStyle.HeaderStyle.Height = 4
        Me.grdIssuedBooks.ThemeStyle.ReadOnly = False
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.Height = 22
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdIssuedBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Lent Books List"
        '
        'btnGobackIssued
        '
        Me.btnGobackIssued.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGobackIssued.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnGobackIssued.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnGobackIssued.BorderRadius = 10
        Me.btnGobackIssued.BorderSize = 0
        Me.btnGobackIssued.FlatAppearance.BorderSize = 0
        Me.btnGobackIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGobackIssued.ForeColor = System.Drawing.Color.White
        Me.btnGobackIssued.Location = New System.Drawing.Point(24, 252)
        Me.btnGobackIssued.Name = "btnGobackIssued"
        Me.btnGobackIssued.Size = New System.Drawing.Size(87, 35)
        Me.btnGobackIssued.TabIndex = 64
        Me.btnGobackIssued.Text = "Go Back"
        Me.btnGobackIssued.TextColor = System.Drawing.Color.White
        Me.btnGobackIssued.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Controls.Add(Me.BtnLogout)
        Me.Guna2Panel3.Controls.Add(Me.btnGobackIssued)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.btnIssuedBookSave)
        Me.Guna2Panel3.Controls.Add(Me.btnIssuedBookDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnIssuedBooknEdit)
        Me.Guna2Panel3.Controls.Add(Me.btnIssuedBookReset)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(134, 499)
        Me.Guna2Panel3.TabIndex = 74
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
        Me.BtnLogout.Location = New System.Drawing.Point(18, 447)
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
        Me.Label8.Location = New System.Drawing.Point(35, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Menu"
        '
        'IssueBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 540)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdIssuedBooks)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IssueBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IssueBook"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.grdIssuedBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIssuedBookID As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents btnIssuedBookReset As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnIssuedBooknEdit As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnIssuedBookDelete As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnIssuedBookSave As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents txtDatedIssued As RJCodeAdvance.RJControls.RJDatePicker
    Friend WithEvents grdIssuedBooks As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGobackIssued As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents lblIssuedBookName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBookName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbBookId As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbStudentId As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLogout As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label8 As Label
End Class
