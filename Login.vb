Imports System.Security.Cryptography
Imports System.Text
Imports Lib_Soft.Entity

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegisterForm_Click(sender As Object, e As EventArgs) Handles btnRegisterForm.Click
        ' Crear una nueva instancia del formulario de registro
        Dim registerForm As New Register()

        ' Mostrar el formulario de registro
        registerForm.Show()

        ' Ocultar el formulario de login
        Me.Hide()
    End Sub



    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
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


    Public Function VerifyPassword(plainTextPassword As String, hashedPassword As String) As Boolean
        ' Encriptar la contraseña ingresada
        Dim hashedInputPassword As String = HashPassword(plainTextPassword)

        ' Comparar la contraseña encriptada con la almacenada
        Return hashedInputPassword.Equals(hashedPassword)
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            ' Obtener los datos de los campos de entrada
            Dim username As String = txtusernameL.Texts.Trim()
            Dim password As String = txtuserpasswordL.Texts.Trim()

            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Verificar las credenciales en la base de datos
            Using context As New LibraryDbContext()
                ' Buscar el usuario por nombre de usuario
                Dim user As Entity.User = context.Users.FirstOrDefault(Function(u) u.Username = username)


                If user Is Nothing Then
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Verificar la contraseña (se asume que HashPassword es el método que se usa para encriptar y comparar contraseñas)
                If Not VerifyPassword(password, user.Password) Then
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Credenciales correctas: mostrar mensaje de éxito y redirigir a la página principal
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Redirigir al formulario principal o al formulario de la aplicación
                Dim mainForm As New MainForm() ' Asumiendo que MainForm es el formulario principal
                mainForm.Show()

                ' Cerrar el formulario de login
                Me.Hide()
            End Using

        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
