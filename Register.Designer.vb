<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.checkAdmin = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegister = New RJCodeAdvance.RJControls.RJButton()
        Me.txtRegisterPassword = New RJCodeAdvance.RJControls.RJTextBox()
        Me.txtRegisterUsername = New RJCodeAdvance.RJControls.RJTextBox()
        Me.lblRegisterpassword = New System.Windows.Forms.Label()
        Me.lblusernameRegister = New System.Windows.Forms.Label()
        Me.RjButton1 = New RJCodeAdvance.RJControls.RJButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientPanel1.Controls.Add(Me.RjButton1)
        Me.Guna2GradientPanel1.Controls.Add(Me.checkAdmin)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnRegister)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtRegisterPassword)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtRegisterUsername)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblRegisterpassword)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblusernameRegister)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(170, 53)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(460, 345)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'checkAdmin
        '
        Me.checkAdmin.Animated = True
        Me.checkAdmin.AutoSize = True
        Me.checkAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAdmin.CheckedState.BorderRadius = 0
        Me.checkAdmin.CheckedState.BorderThickness = 0
        Me.checkAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAdmin.Location = New System.Drawing.Point(273, 274)
        Me.checkAdmin.Name = "checkAdmin"
        Me.checkAdmin.Size = New System.Drawing.Size(63, 17)
        Me.checkAdmin.TabIndex = 10
        Me.checkAdmin.Text = "IsAdmin"
        Me.checkAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkAdmin.UncheckedState.BorderRadius = 0
        Me.checkAdmin.UncheckedState.BorderThickness = 0
        Me.checkAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registro de Usuarios"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegister.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.btnRegister.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnRegister.BorderRadius = 0
        Me.btnRegister.BorderSize = 0
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(95, 262)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(150, 29)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextColor = System.Drawing.Color.White
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterPassword.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtRegisterPassword.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtRegisterPassword.BorderRadius = 0
        Me.txtRegisterPassword.BorderSize = 2
        Me.txtRegisterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRegisterPassword.Location = New System.Drawing.Point(86, 174)
        Me.txtRegisterPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegisterPassword.Multiline = False
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtRegisterPassword.PasswordChar = True
        Me.txtRegisterPassword.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtRegisterPassword.PlaceholderText = ""
        Me.txtRegisterPassword.Size = New System.Drawing.Size(250, 31)
        Me.txtRegisterPassword.TabIndex = 3
        Me.txtRegisterPassword.Texts = ""
        Me.txtRegisterPassword.UnderlinedStyle = False
        '
        'txtRegisterUsername
        '
        Me.txtRegisterUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterUsername.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtRegisterUsername.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtRegisterUsername.BorderRadius = 0
        Me.txtRegisterUsername.BorderSize = 2
        Me.txtRegisterUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRegisterUsername.Location = New System.Drawing.Point(86, 102)
        Me.txtRegisterUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegisterUsername.Multiline = False
        Me.txtRegisterUsername.Name = "txtRegisterUsername"
        Me.txtRegisterUsername.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtRegisterUsername.PasswordChar = False
        Me.txtRegisterUsername.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtRegisterUsername.PlaceholderText = ""
        Me.txtRegisterUsername.Size = New System.Drawing.Size(250, 31)
        Me.txtRegisterUsername.TabIndex = 2
        Me.txtRegisterUsername.Texts = ""
        Me.txtRegisterUsername.UnderlinedStyle = False
        '
        'lblRegisterpassword
        '
        Me.lblRegisterpassword.AutoSize = True
        Me.lblRegisterpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterpassword.Location = New System.Drawing.Point(178, 148)
        Me.lblRegisterpassword.Name = "lblRegisterpassword"
        Me.lblRegisterpassword.Size = New System.Drawing.Size(83, 18)
        Me.lblRegisterpassword.TabIndex = 1
        Me.lblRegisterpassword.Text = "Password"
        '
        'lblusernameRegister
        '
        Me.lblusernameRegister.AutoSize = True
        Me.lblusernameRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusernameRegister.Location = New System.Drawing.Point(178, 75)
        Me.lblusernameRegister.Name = "lblusernameRegister"
        Me.lblusernameRegister.Size = New System.Drawing.Size(67, 18)
        Me.lblusernameRegister.TabIndex = 0
        Me.lblusernameRegister.Text = "Usuario"
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 0
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(95, 297)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(150, 29)
        Me.RjButton1.TabIndex = 11
        Me.RjButton1.Text = "Login"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnRegister As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents txtRegisterPassword As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents txtRegisterUsername As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents lblRegisterpassword As Label
    Friend WithEvents lblusernameRegister As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents checkAdmin As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents RjButton1 As RJCodeAdvance.RJControls.RJButton
End Class
