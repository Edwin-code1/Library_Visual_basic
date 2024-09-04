<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersTable))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.pictureboxCloseIcon = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgrdUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnUserDelete = New RJCodeAdvance.RJControls.RJButton()
        Me.btnmakeAdmin = New RJCodeAdvance.RJControls.RJButton()
        Me.btnGoBack = New RJCodeAdvance.RJControls.RJButton()
        Me.btnRemoveAdmin = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgrdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(360, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "User Details"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.ForeColor = System.Drawing.SystemColors.Highlight
        Me.blbusername.Location = New System.Drawing.Point(42, 9)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(53, 18)
        Me.blbusername.TabIndex = 1
        Me.blbusername.Text = "Users"
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
        Me.pictureboxCloseIcon.Location = New System.Drawing.Point(764, 3)
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
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.dgrdUsers)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(797, 469)
        Me.Guna2Panel2.TabIndex = 58
        '
        'dgrdUsers
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgrdUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgrdUsers.ColumnHeadersHeight = 4
        Me.dgrdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdUsers.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgrdUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdUsers.Location = New System.Drawing.Point(109, 3)
        Me.dgrdUsers.Name = "dgrdUsers"
        Me.dgrdUsers.RowHeadersVisible = False
        Me.dgrdUsers.Size = New System.Drawing.Size(691, 461)
        Me.dgrdUsers.TabIndex = 0
        Me.dgrdUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgrdUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgrdUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgrdUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgrdUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgrdUsers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgrdUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrdUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgrdUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgrdUsers.ThemeStyle.HeaderStyle.Height = 4
        Me.dgrdUsers.ThemeStyle.ReadOnly = False
        Me.dgrdUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgrdUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrdUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgrdUsers.ThemeStyle.RowsStyle.Height = 22
        Me.dgrdUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnUserDelete
        '
        Me.btnUserDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUserDelete.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnUserDelete.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnUserDelete.BorderRadius = 10
        Me.btnUserDelete.BorderSize = 0
        Me.btnUserDelete.FlatAppearance.BorderSize = 0
        Me.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserDelete.ForeColor = System.Drawing.Color.White
        Me.btnUserDelete.Location = New System.Drawing.Point(9, 100)
        Me.btnUserDelete.Name = "btnUserDelete"
        Me.btnUserDelete.Size = New System.Drawing.Size(92, 40)
        Me.btnUserDelete.TabIndex = 48
        Me.btnUserDelete.Text = "Delete"
        Me.btnUserDelete.TextColor = System.Drawing.Color.White
        Me.btnUserDelete.UseVisualStyleBackColor = False
        '
        'btnmakeAdmin
        '
        Me.btnmakeAdmin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnmakeAdmin.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnmakeAdmin.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnmakeAdmin.BorderRadius = 10
        Me.btnmakeAdmin.BorderSize = 0
        Me.btnmakeAdmin.FlatAppearance.BorderSize = 0
        Me.btnmakeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmakeAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmakeAdmin.ForeColor = System.Drawing.Color.White
        Me.btnmakeAdmin.Location = New System.Drawing.Point(11, 155)
        Me.btnmakeAdmin.Name = "btnmakeAdmin"
        Me.btnmakeAdmin.Size = New System.Drawing.Size(90, 40)
        Me.btnmakeAdmin.TabIndex = 59
        Me.btnmakeAdmin.Text = "Make Admin"
        Me.btnmakeAdmin.TextColor = System.Drawing.Color.White
        Me.btnmakeAdmin.UseVisualStyleBackColor = False
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGoBack.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnGoBack.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnGoBack.BorderRadius = 10
        Me.btnGoBack.BorderSize = 0
        Me.btnGoBack.FlatAppearance.BorderSize = 0
        Me.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.White
        Me.btnGoBack.Location = New System.Drawing.Point(8, 208)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(92, 40)
        Me.btnGoBack.TabIndex = 60
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.TextColor = System.Drawing.Color.White
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'btnRemoveAdmin
        '
        Me.btnRemoveAdmin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRemoveAdmin.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnRemoveAdmin.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnRemoveAdmin.BorderRadius = 10
        Me.btnRemoveAdmin.BorderSize = 0
        Me.btnRemoveAdmin.FlatAppearance.BorderSize = 0
        Me.btnRemoveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAdmin.ForeColor = System.Drawing.Color.White
        Me.btnRemoveAdmin.Location = New System.Drawing.Point(8, 46)
        Me.btnRemoveAdmin.Name = "btnRemoveAdmin"
        Me.btnRemoveAdmin.Size = New System.Drawing.Size(93, 40)
        Me.btnRemoveAdmin.TabIndex = 61
        Me.btnRemoveAdmin.Text = "Remove Admin"
        Me.btnRemoveAdmin.TextColor = System.Drawing.Color.White
        Me.btnRemoveAdmin.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.btnGoBack)
        Me.Guna2Panel3.Controls.Add(Me.btnmakeAdmin)
        Me.Guna2Panel3.Controls.Add(Me.btnUserDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnRemoveAdmin)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(112, 469)
        Me.Guna2Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Menu"
        '
        'UsersTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 523)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsersTable"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pictureboxCloseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.dgrdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents blbusername As Label
    Friend WithEvents pictureboxCloseIcon As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCircularPictureBox1 As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgrdUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnUserDelete As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnmakeAdmin As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnGoBack As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents btnRemoveAdmin As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
End Class
