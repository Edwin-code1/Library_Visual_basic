<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnRegisterForm = New RJCodeAdvance.RJControls.RJButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New RJCodeAdvance.RJControls.RJButton()
        Me.txtuserpasswordL = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtusernameL = New RJCodeAdvance.RJControls.RJTextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.blbusername = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientPanel1.Controls.Add(Me.btnRegisterForm)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnLogin)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtuserpasswordL)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtusernameL)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblpassword)
        Me.Guna2GradientPanel1.Controls.Add(Me.blbusername)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(119, 23)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(460, 345)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'btnRegisterForm
        '
        Me.btnRegisterForm.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegisterForm.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnRegisterForm.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnRegisterForm.BorderRadius = 0
        Me.btnRegisterForm.BorderSize = 0
        Me.btnRegisterForm.FlatAppearance.BorderSize = 0
        Me.btnRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterForm.ForeColor = System.Drawing.Color.White
        Me.btnRegisterForm.Location = New System.Drawing.Point(235, 277)
        Me.btnRegisterForm.Name = "btnRegisterForm"
        Me.btnRegisterForm.Size = New System.Drawing.Size(111, 34)
        Me.btnRegisterForm.TabIndex = 7
        Me.btnRegisterForm.Text = "Register"
        Me.btnRegisterForm.TextColor = System.Drawing.Color.White
        Me.btnRegisterForm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Library Management System"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnLogin.BorderRadius = 0
        Me.btnLogin.BorderSize = 0
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(128, 277)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(81, 34)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextColor = System.Drawing.Color.White
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtuserpasswordL
        '
        Me.txtuserpasswordL.BackColor = System.Drawing.SystemColors.Window
        Me.txtuserpasswordL.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtuserpasswordL.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtuserpasswordL.BorderRadius = 0
        Me.txtuserpasswordL.BorderSize = 2
        Me.txtuserpasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserpasswordL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtuserpasswordL.Location = New System.Drawing.Point(96, 203)
        Me.txtuserpasswordL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuserpasswordL.Multiline = False
        Me.txtuserpasswordL.Name = "txtuserpasswordL"
        Me.txtuserpasswordL.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtuserpasswordL.PasswordChar = True
        Me.txtuserpasswordL.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtuserpasswordL.PlaceholderText = ""
        Me.txtuserpasswordL.Size = New System.Drawing.Size(250, 31)
        Me.txtuserpasswordL.TabIndex = 3
        Me.txtuserpasswordL.Texts = ""
        Me.txtuserpasswordL.UnderlinedStyle = False
        '
        'txtusernameL
        '
        Me.txtusernameL.BackColor = System.Drawing.SystemColors.Window
        Me.txtusernameL.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtusernameL.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtusernameL.BorderRadius = 0
        Me.txtusernameL.BorderSize = 2
        Me.txtusernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusernameL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusernameL.Location = New System.Drawing.Point(96, 131)
        Me.txtusernameL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusernameL.Multiline = False
        Me.txtusernameL.Name = "txtusernameL"
        Me.txtusernameL.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtusernameL.PasswordChar = False
        Me.txtusernameL.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtusernameL.PlaceholderText = ""
        Me.txtusernameL.Size = New System.Drawing.Size(250, 31)
        Me.txtusernameL.TabIndex = 2
        Me.txtusernameL.Texts = ""
        Me.txtusernameL.UnderlinedStyle = False
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(188, 177)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(83, 18)
        Me.lblpassword.TabIndex = 1
        Me.lblpassword.Text = "Password"
        '
        'blbusername
        '
        Me.blbusername.AutoSize = True
        Me.blbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blbusername.Location = New System.Drawing.Point(188, 104)
        Me.blbusername.Name = "blbusername"
        Me.blbusername.Size = New System.Drawing.Size(67, 18)
        Me.blbusername.TabIndex = 0
        Me.blbusername.Text = "Usuario"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 410)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnLogin As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents txtuserpasswordL As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtusernameL As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents blbusername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegisterForm As RJCodeAdvance.RJControls.RJButton
End Class
