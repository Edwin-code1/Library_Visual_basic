
Imports System.Security.Cryptography
Imports System.Text
Imports Lib_Soft.Entity

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isAdmin As Boolean = False ' Cambia según el estado real del usuario

        checkAdmin.Checked = isAdmin

    End Sub

    Private Sub checkAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles checkAdmin.CheckedChanged
        If checkAdmin.Checked Then
            ' Código para cuando el usuario es admin
            checkAdmin.BackColor = Color.Green
            checkAdmin.ForeColor = Color.White
            checkAdmin.Text = "Admin"
        Else
            ' Código para cuando el usuario no es admin
            checkAdmin.BackColor = Color.Red
            checkAdmin.ForeColor = Color.White
            checkAdmin.Text = "No Admin"
        End If
    End Sub



    Private Sub ClearRegisterForm()
        ' Asumiendo que tienes TextBoxes o controles similares para el formulario de registro
        txtRegisterUsername.Texts = String.Empty
        txtRegisterPassword.Texts = String.Empty
        checkAdmin.Checked = False


    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            ' Obtener los datos de los inputs
            Dim username As String = txtRegisterUsername.Texts.Trim()
            Dim password As String = txtRegisterPassword.Texts.Trim()
            Dim isAdmin As Boolean = checkAdmin.Checked

            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validar que la contraseña tenga al menos 8 caracteres y contenga caracteres especiales
            If password.Length < 8 OrElse Not password.Any(Function(c) Char.IsLetterOrDigit(c) = False) Then
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres y contener al menos un carácter especial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Verificar si el nombre de usuario ya existe en la base de datos
            Using context As New LibraryDbContext()
                Dim existingUser = context.Users.FirstOrDefault(Function(u) u.Username = username)
                If existingUser IsNot Nothing Then
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Encriptar la contraseña
                Dim hashedPassword As String = HashPassword(password)

                ' Crear una nueva instancia de la entidad User
                Dim newUser As New Entity.User() With {
                    .Username = username,
                    .Password = hashedPassword,
                    .IsAdmin = isAdmin
                }

                ' Guardar el nuevo usuario en la base de datos
                context.Users.Add(newUser)
                context.SaveChanges()

            End Using


            ' Mostrar un mensaje de éxito
            MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar el formulario
            ClearRegisterForm()

            ' Redirigir al formulario de login sin cerrar la aplicación
            Dim loginForm As New Login() ' Asegúrate de tener un formulario de login llamado Login
            loginForm.Show()
            Me.Hide() ' Oculta el formulario de registro en lugar de cerrarlo

        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar registrar al usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Convertir la contraseña en bytes
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            ' Aplicar SHA256
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            ' Convertir el hash a una cadena hexadecimal
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        Dim loginForm = New Login()
        loginForm.Show()

        Me.Hide()
    End Sub
End Class