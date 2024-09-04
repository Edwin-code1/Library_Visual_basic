<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Books))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtBookPublisher = New RJCodeAdvance.RJControls.RJTextBox()
        Me.lblBookQuantity = New System.Windows.Forms.Label()
        Me.txtBookQuantity = New RJCodeAdvance.RJControls.RJTextBox()
        Me.lblbookPrice = New System.Windows.Forms.Label()
        Me.lblbookPublisher = New System.Windows.Forms.Label()
        Me.lblbookAuthor = New System.Windows.Forms.Label()
        Me.lblbookName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookPrice = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtBookAuthor = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtBookName = New RJCodeAdvance.RJControls.RJTextBox()
        Me.btnBookReset = New RJCodeAdvance.RJControls.RJButton()
        Me.btnBookEdit = New RJCodeAdvance.RJControls.RJButton()
        Me.btnBookDelete = New RJCodeAdvance.RJControls.RJButton()
        Me.btnBookSave = New RJCodeAdvance.RJControls.RJButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdBookList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnBookBack = New RJCodeAdvance.RJControls.RJButton()
        Me.btnBookExport = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnLogout = New RJCodeAdvance.RJControls.RJButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.grdBookList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(953, 41)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(468, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Book Details"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(57, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Books"
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
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(920, 3)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(493, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Book List"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.txtBookPublisher)
        Me.Guna2Panel2.Controls.Add(Me.lblBookQuantity)
        Me.Guna2Panel2.Controls.Add(Me.txtBookQuantity)
        Me.Guna2Panel2.Controls.Add(Me.lblbookPrice)
        Me.Guna2Panel2.Controls.Add(Me.lblbookPublisher)
        Me.Guna2Panel2.Controls.Add(Me.lblbookAuthor)
        Me.Guna2Panel2.Controls.Add(Me.lblbookName)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.txtBookPrice)
        Me.Guna2Panel2.Controls.Add(Me.txtBookAuthor)
        Me.Guna2Panel2.Controls.Add(Me.txtBookName)
        Me.Guna2Panel2.Location = New System.Drawing.Point(140, 47)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(813, 245)
        Me.Guna2Panel2.TabIndex = 29
        '
        'txtBookPublisher
        '
        Me.txtBookPublisher.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookPublisher.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookPublisher.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookPublisher.BorderRadius = 0
        Me.txtBookPublisher.BorderSize = 2
        Me.txtBookPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookPublisher.Location = New System.Drawing.Point(333, 75)
        Me.txtBookPublisher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookPublisher.Multiline = False
        Me.txtBookPublisher.Name = "txtBookPublisher"
        Me.txtBookPublisher.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookPublisher.PasswordChar = False
        Me.txtBookPublisher.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookPublisher.PlaceholderText = ""
        Me.txtBookPublisher.Size = New System.Drawing.Size(136, 31)
        Me.txtBookPublisher.TabIndex = 43
        Me.txtBookPublisher.Texts = ""
        Me.txtBookPublisher.UnderlinedStyle = False
        '
        'lblBookQuantity
        '
        Me.lblBookQuantity.AutoSize = True
        Me.lblBookQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookQuantity.Location = New System.Drawing.Point(627, 38)
        Me.lblBookQuantity.Name = "lblBookQuantity"
        Me.lblBookQuantity.Size = New System.Drawing.Size(70, 18)
        Me.lblBookQuantity.TabIndex = 42
        Me.lblBookQuantity.Text = "Quantity"
        '
        'txtBookQuantity
        '
        Me.txtBookQuantity.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookQuantity.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookQuantity.BorderRadius = 0
        Me.txtBookQuantity.BorderSize = 2
        Me.txtBookQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookQuantity.Location = New System.Drawing.Point(630, 73)
        Me.txtBookQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookQuantity.Multiline = False
        Me.txtBookQuantity.Name = "txtBookQuantity"
        Me.txtBookQuantity.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookQuantity.PasswordChar = False
        Me.txtBookQuantity.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookQuantity.PlaceholderText = ""
        Me.txtBookQuantity.Size = New System.Drawing.Size(92, 31)
        Me.txtBookQuantity.TabIndex = 41
        Me.txtBookQuantity.Texts = ""
        Me.txtBookQuantity.UnderlinedStyle = False
        '
        'lblbookPrice
        '
        Me.lblbookPrice.AutoSize = True
        Me.lblbookPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookPrice.Location = New System.Drawing.Point(506, 39)
        Me.lblbookPrice.Name = "lblbookPrice"
        Me.lblbookPrice.Size = New System.Drawing.Size(47, 18)
        Me.lblbookPrice.TabIndex = 40
        Me.lblbookPrice.Text = "Price"
        '
        'lblbookPublisher
        '
        Me.lblbookPublisher.AutoSize = True
        Me.lblbookPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookPublisher.Location = New System.Drawing.Point(330, 40)
        Me.lblbookPublisher.Name = "lblbookPublisher"
        Me.lblbookPublisher.Size = New System.Drawing.Size(78, 18)
        Me.lblbookPublisher.TabIndex = 39
        Me.lblbookPublisher.Text = "Publisher"
        '
        'lblbookAuthor
        '
        Me.lblbookAuthor.AutoSize = True
        Me.lblbookAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookAuthor.Location = New System.Drawing.Point(171, 40)
        Me.lblbookAuthor.Name = "lblbookAuthor"
        Me.lblbookAuthor.Size = New System.Drawing.Size(57, 18)
        Me.lblbookAuthor.TabIndex = 38
        Me.lblbookAuthor.Text = "Author"
        '
        'lblbookName
        '
        Me.lblbookName.AutoSize = True
        Me.lblbookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookName.Location = New System.Drawing.Point(80, 40)
        Me.lblbookName.Name = "lblbookName"
        Me.lblbookName.Size = New System.Drawing.Size(52, 18)
        Me.lblbookName.TabIndex = 37
        Me.lblbookName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, -22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(406, -22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, -22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, -22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Name"
        '
        'txtBookPrice
        '
        Me.txtBookPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookPrice.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookPrice.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookPrice.BorderRadius = 0
        Me.txtBookPrice.BorderSize = 2
        Me.txtBookPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookPrice.Location = New System.Drawing.Point(509, 74)
        Me.txtBookPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookPrice.Multiline = False
        Me.txtBookPrice.Name = "txtBookPrice"
        Me.txtBookPrice.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookPrice.PasswordChar = False
        Me.txtBookPrice.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookPrice.PlaceholderText = ""
        Me.txtBookPrice.Size = New System.Drawing.Size(92, 31)
        Me.txtBookPrice.TabIndex = 28
        Me.txtBookPrice.Texts = ""
        Me.txtBookPrice.UnderlinedStyle = False
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.BackColor = System.Drawing.SystemColors.Window
        Me.txtBookAuthor.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtBookAuthor.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtBookAuthor.BorderRadius = 0
        Me.txtBookAuthor.BorderSize = 2
        Me.txtBookAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookAuthor.Location = New System.Drawing.Point(174, 75)
        Me.txtBookAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookAuthor.Multiline = False
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookAuthor.PasswordChar = False
        Me.txtBookAuthor.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookAuthor.PlaceholderText = ""
        Me.txtBookAuthor.Size = New System.Drawing.Size(127, 31)
        Me.txtBookAuthor.TabIndex = 26
        Me.txtBookAuthor.Texts = ""
        Me.txtBookAuthor.UnderlinedStyle = False
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
        Me.txtBookName.Location = New System.Drawing.Point(66, 75)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookName.Multiline = False
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBookName.PasswordChar = False
        Me.txtBookName.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBookName.PlaceholderText = ""
        Me.txtBookName.Size = New System.Drawing.Size(85, 31)
        Me.txtBookName.TabIndex = 25
        Me.txtBookName.Texts = ""
        Me.txtBookName.UnderlinedStyle = False
        '
        'btnBookReset
        '
        Me.btnBookReset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookReset.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnBookReset.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookReset.BorderRadius = 10
        Me.btnBookReset.BorderSize = 0
        Me.btnBookReset.FlatAppearance.BorderSize = 0
        Me.btnBookReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookReset.ForeColor = System.Drawing.Color.White
        Me.btnBookReset.Location = New System.Drawing.Point(21, 200)
        Me.btnBookReset.Name = "btnBookReset"
        Me.btnBookReset.Size = New System.Drawing.Size(93, 37)
        Me.btnBookReset.TabIndex = 36
        Me.btnBookReset.Text = "Reset"
        Me.btnBookReset.TextColor = System.Drawing.Color.White
        Me.btnBookReset.UseVisualStyleBackColor = False
        '
        'btnBookEdit
        '
        Me.btnBookEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookEdit.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnBookEdit.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookEdit.BorderRadius = 10
        Me.btnBookEdit.BorderSize = 0
        Me.btnBookEdit.FlatAppearance.BorderSize = 0
        Me.btnBookEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookEdit.ForeColor = System.Drawing.Color.White
        Me.btnBookEdit.Location = New System.Drawing.Point(21, 154)
        Me.btnBookEdit.Name = "btnBookEdit"
        Me.btnBookEdit.Size = New System.Drawing.Size(93, 40)
        Me.btnBookEdit.TabIndex = 35
        Me.btnBookEdit.Text = "Edit"
        Me.btnBookEdit.TextColor = System.Drawing.Color.White
        Me.btnBookEdit.UseVisualStyleBackColor = False
        '
        'btnBookDelete
        '
        Me.btnBookDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookDelete.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnBookDelete.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookDelete.BorderRadius = 10
        Me.btnBookDelete.BorderSize = 0
        Me.btnBookDelete.FlatAppearance.BorderSize = 0
        Me.btnBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookDelete.ForeColor = System.Drawing.Color.White
        Me.btnBookDelete.Location = New System.Drawing.Point(21, 108)
        Me.btnBookDelete.Name = "btnBookDelete"
        Me.btnBookDelete.Size = New System.Drawing.Size(93, 40)
        Me.btnBookDelete.TabIndex = 34
        Me.btnBookDelete.Text = "Delete"
        Me.btnBookDelete.TextColor = System.Drawing.Color.White
        Me.btnBookDelete.UseVisualStyleBackColor = False
        '
        'btnBookSave
        '
        Me.btnBookSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookSave.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnBookSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookSave.BorderRadius = 10
        Me.btnBookSave.BorderSize = 0
        Me.btnBookSave.FlatAppearance.BorderSize = 0
        Me.btnBookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookSave.ForeColor = System.Drawing.Color.White
        Me.btnBookSave.Location = New System.Drawing.Point(21, 62)
        Me.btnBookSave.Name = "btnBookSave"
        Me.btnBookSave.Size = New System.Drawing.Size(93, 40)
        Me.btnBookSave.TabIndex = 33
        Me.btnBookSave.Text = "Save"
        Me.btnBookSave.TextColor = System.Drawing.Color.White
        Me.btnBookSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Student Details"
        '
        'grdBookList
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.grdBookList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdBookList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdBookList.ColumnHeadersHeight = 4
        Me.grdBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdBookList.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdBookList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBookList.Location = New System.Drawing.Point(140, 316)
        Me.grdBookList.Name = "grdBookList"
        Me.grdBookList.RowHeadersVisible = False
        Me.grdBookList.Size = New System.Drawing.Size(813, 203)
        Me.grdBookList.TabIndex = 31
        Me.grdBookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBookList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdBookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdBookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdBookList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdBookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdBookList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdBookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdBookList.ThemeStyle.HeaderStyle.Height = 4
        Me.grdBookList.ThemeStyle.ReadOnly = False
        Me.grdBookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdBookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdBookList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdBookList.ThemeStyle.RowsStyle.Height = 22
        Me.grdBookList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdBookList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnBookBack
        '
        Me.btnBookBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookBack.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnBookBack.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookBack.BorderRadius = 10
        Me.btnBookBack.BorderSize = 0
        Me.btnBookBack.FlatAppearance.BorderSize = 0
        Me.btnBookBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookBack.ForeColor = System.Drawing.Color.White
        Me.btnBookBack.Location = New System.Drawing.Point(21, 243)
        Me.btnBookBack.Name = "btnBookBack"
        Me.btnBookBack.Size = New System.Drawing.Size(93, 40)
        Me.btnBookBack.TabIndex = 45
        Me.btnBookBack.Text = "Back"
        Me.btnBookBack.TextColor = System.Drawing.Color.White
        Me.btnBookBack.UseVisualStyleBackColor = False
        '
        'btnBookExport
        '
        Me.btnBookExport.BackColor = System.Drawing.Color.Blue
        Me.btnBookExport.BackgroundColor = System.Drawing.Color.Blue
        Me.btnBookExport.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBookExport.BorderRadius = 10
        Me.btnBookExport.BorderSize = 0
        Me.btnBookExport.FlatAppearance.BorderSize = 0
        Me.btnBookExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookExport.ForeColor = System.Drawing.Color.White
        Me.btnBookExport.Location = New System.Drawing.Point(21, 289)
        Me.btnBookExport.Name = "btnBookExport"
        Me.btnBookExport.Size = New System.Drawing.Size(93, 43)
        Me.btnBookExport.TabIndex = 46
        Me.btnBookExport.Text = "Exportar Libros"
        Me.btnBookExport.TextColor = System.Drawing.Color.White
        Me.btnBookExport.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Controls.Add(Me.BtnLogout)
        Me.Guna2Panel3.Controls.Add(Me.btnBookExport)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.btnBookBack)
        Me.Guna2Panel3.Controls.Add(Me.btnBookSave)
        Me.Guna2Panel3.Controls.Add(Me.btnBookDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnBookEdit)
        Me.Guna2Panel3.Controls.Add(Me.btnBookReset)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(134, 490)
        Me.Guna2Panel3.TabIndex = 73
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
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 531)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.grdBookList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookCreate"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.grdBookList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtBookPublisher As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents lblBookQuantity As Label
    Friend WithEvents txtBookQuantity As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents lblbookPrice As Label
    Friend WithEvents lblbookPublisher As Label
    Friend WithEvents lblbookAuthor As Label
    Friend WithEvents lblbookName As Label
    Friend WithEvents btnBookReset As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnBookEdit As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnBookDelete As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnBookSave As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBookPrice As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtBookAuthor As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtBookName As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grdBookList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnBookBack As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnBookExport As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnLogout As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label8 As Label
End Class
