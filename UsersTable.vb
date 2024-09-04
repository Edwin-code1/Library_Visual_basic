Imports Lib_Soft.Entity

Public Class UsersTable
    Private Sub dgrdUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrdUsers.CellContentClick

    End Sub

    Private Sub UsersTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            ' Crear una nueva instancia del contexto de la base de datos
            Using context As New LibraryDbContext()
                ' Obtener la lista de usuarios desde la base de datos
                Dim users = context.Users.ToList()

                ' Asignar la lista de usuarios como la fuente de datos del DataGridView
                dgrdUsers.DataSource = users
            End Using

            ' Configurar las columnas que se mostrarán en el DataGridView
            dgrdUsers.Columns("Password").Visible = False ' Ocultar la columna de la contraseña
            dgrdUsers.Columns("UserId").HeaderText = "ID"
            dgrdUsers.Columns("Username").HeaderText = "Nombre de Usuario"
            dgrdUsers.Columns("IsAdmin").HeaderText = "Es Administrador"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMakeAdmin_Click(sender As Object, e As EventArgs) Handles btnmakeAdmin.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If dgrdUsers.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el usuario seleccionado
            Dim selectedRow As DataGridViewRow = dgrdUsers.SelectedRows(0)
            Dim userId As Integer = CInt(selectedRow.Cells("UserId").Value)
            Dim username As String = selectedRow.Cells("Username").Value.ToString()

            ' Preguntar si el administrador realmente desea otorgar privilegios de admin
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea otorgar privilegios de administrador al usuario '" & username & "'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Actualizar el estado de admin en la base de datos
                Using context As New LibraryDbContext()
                    Dim user = context.Users.FirstOrDefault(Function(u) u.UserId = userId)
                    If user IsNot Nothing Then
                        user.IsAdmin = True
                        context.SaveChanges()
                        MessageBox.Show("Privilegios de administrador otorgados al usuario '" & username & "'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                ' Recargar la lista de usuarios en el DataGridView
                LoadUsers()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar otorgar privilegios de administrador: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pictureboxCloseIcon_Click(sender As Object, e As EventArgs) Handles pictureboxCloseIcon.Click
        ' Mostrar un modal de confirmación
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If result = DialogResult.Yes Then
            ' Si el usuario confirma, cerrar la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnUserDelete.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If dgrdUsers.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el usuario seleccionado
            Dim selectedRow As DataGridViewRow = dgrdUsers.SelectedRows(0)
            Dim userId As Integer = CInt(selectedRow.Cells("UserId").Value)
            Dim username As String = selectedRow.Cells("Username").Value.ToString()

            ' Confirmación antes de eliminar
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar al usuario '" & username & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Eliminar el usuario de la base de datos
                Using context As New LibraryDbContext()
                    Dim user = context.Users.FirstOrDefault(Function(u) u.UserId = userId)
                    If user IsNot Nothing Then
                        context.Users.Remove(user)
                        context.SaveChanges()
                        MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("El usuario no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                ' Recargar la lista de usuarios en el DataGridView
                LoadUsers()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar eliminar al usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim mainForm = New MainForm()

        mainForm.Show()

        Me.Hide()

    End Sub

    Private Sub btnRemoveAdmin_Click(sender As Object, e As EventArgs) Handles btnRemoveAdmin.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If dgrdUsers.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el usuario seleccionado
            Dim selectedRow As DataGridViewRow = dgrdUsers.SelectedRows(0)
            Dim userId As Integer = CInt(selectedRow.Cells("UserId").Value)
            Dim username As String = selectedRow.Cells("Username").Value.ToString()

            ' Preguntar si el administrador realmente desea quitar los privilegios de admin
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea quitar los privilegios de administrador al usuario '" & username & "'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Actualizar el estado de admin en la base de datos
                Using context As New LibraryDbContext()
                    Dim user = context.Users.FirstOrDefault(Function(u) u.UserId = userId)
                    If user IsNot Nothing Then
                        user.IsAdmin = False
                        context.SaveChanges()
                        MessageBox.Show("Privilegios de administrador eliminados para el usuario '" & username & "'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                ' Recargar la lista de usuarios en el DataGridView
                LoadUsers()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar quitar los privilegios de administrador: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class