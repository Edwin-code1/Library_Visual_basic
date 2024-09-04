Imports System.Data.Entity.Infrastructure

Public Class Librarians

    ' Declarar los TextBox
    Private WithEvents txtOnlyLetters As New TextBox
    Private WithEvents txtOnlyNumbers As New TextBox

    Public Sub New()
        ' Llamar al método InitializeComponent (necesario para inicializar el formulario)
        InitializeComponent()

        ' Configurar el TextBox para solo letras
        txtOnlyLetters.Location = New Point(10, 10)
        txtOnlyLetters.Width = 150
        Me.Controls.Add(txtOnlyLetters)

        ' Configurar el TextBox para solo números
        txtOnlyNumbers.Location = New Point(10, 40)
        txtOnlyNumbers.Width = 150
        Me.Controls.Add(txtOnlyNumbers)
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyLetters
    Private Sub txtOnlyLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyLetters.KeyPress, txtLibrarianName.KeyPress
        ' Verifica si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten letras en este campo")
            e.Handled = True
        End If
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyNumbers
    Private Sub txtOnlyNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyNumbers.KeyPress, txtLibrarianPhone.KeyPress
        ' Verifica si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten numeros en este campo")

            e.Handled = True
        End If
    End Sub

    Private Sub Librarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLibrarians()
        btnLibrarianEdit.Enabled = False

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

    Private Sub btnLibrarianBack_Click(sender As Object, e As EventArgs) Handles btnLibrarianBack.Click
        Dim mainForm = New MainForm()

        mainForm.Show()

        Me.Hide()
    End Sub

    Private Sub btnLibrarianSave_Click(sender As Object, e As EventArgs) Handles btnLibrarianSave.Click
        Try
            ' Obtener y validar la entrada de datos
            Dim librarianName As String = txtLibrarianName.Texts.Trim()
            Dim librarianPhone As String = txtLibrarianPhone.Texts.Trim()
            Dim librarianPassword As String = txtLibrarianPassword.Texts.Trim()

            ' Verificar si algún campo está vacío
            If String.IsNullOrWhiteSpace(librarianName) Then
                Throw New ArgumentException("El nombre del bibliotecario no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(librarianPhone) OrElse Not IsNumeric(librarianPhone) OrElse librarianPhone.Length < 10 Then
                Throw New ArgumentException("El teléfono debe ser un número válido y tener al menos 10 dígitos.")
            End If
            If String.IsNullOrWhiteSpace(librarianPassword) Then
                Throw New ArgumentException("La contraseña no puede estar vacía.")
            End If

            ' Crear una nueva instancia del contexto
            Using context As New Entity.LibraryDbContext()
                ' Verificar si ya existe un bibliotecario con el mismo nombre y teléfono
                Dim existingLibrarian As Entity.Librarian = context.Librarians.FirstOrDefault(Function(l) l.Name = librarianName AndAlso l.Phone = librarianPhone)

                If existingLibrarian IsNot Nothing Then
                    MessageBox.Show("Ya existe un bibliotecario con este nombre y teléfono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Crear un nuevo bibliotecario
                Dim newLibrarian As New Entity.Librarian() With {
                    .Name = librarianName,
                    .Phone = librarianPhone,
                    .Password = librarianPassword
                }

                ' Agregar el nuevo bibliotecario al DbSet
                context.Librarians.Add(newLibrarian)

                ' Guardar los cambios en la base de datos
                context.SaveChanges()
            End Using

            ' Limpiar los campos del formulario
            ClearLibrarianFormFields()

            LoadLibrarians()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Bibliotecario agregado exitosamente.")

        Catch ex As ArgumentException
            MessageBox.Show("Error en los datos: " & ex.Message)
        Catch ex As DbUpdateException
            MessageBox.Show("Error al guardar los cambios en la base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Se produjo un error inesperado: " & ex.Message)
        End Try
    End Sub


    Private Sub ClearLibrarianFormFields()
        txtLibrarianName.Texts = ""
        txtLibrarianPhone.Texts = ""
        txtLibrarianPassword.Texts = ""
    End Sub

    ' Private Sub grdLibrarianList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLibrarianList.CellContentClick
    ' Verificar que se haya hecho clic en una celda válida
    'If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    ' Obtener la fila seleccionada
    'Dim selectedRow As DataGridViewRow = grdLibrarianList.Rows(e.RowIndex)

    ' Obtener el ID del bibliotecario desde la celda correspondiente (asumiendo que tienes una columna "LibrarianId")
    'Dim librarianId As Integer = Convert.ToInt32(selectedRow.Cells("LibrarianId").Value)

    ' Buscar el bibliotecario en la base de datos y cargar sus datos en los controles
    'context As New Entity.LibraryDbContext()
    'Dim selectedLibrarian As Entity.Librarian = context.Librarians.Find(librarianId)

    'If selectedLibrarian IsNot Nothing Then
    ' Cargar los datos del bibliotecario en los controles
    '' txtLibrarianName.Texts = selectedLibrarian.Name
    '  txtLibrarianPhone.Texts = selectedLibrarian.Phone
    'txtLibrarianPassword.Texts = selectedLibrarian.Password

    ' Habilitar los campos para la edición
    ' SetLibrarianFieldsReadOnly(False)
    'End If
    'End Using
    'End If
    ' End Sub



    Private Sub SetLibrarianFieldsReadOnly(isReadOnly As Boolean)
        txtLibrarianName.Enabled = Not isReadOnly
        txtLibrarianPhone.Enabled = Not isReadOnly
        txtLibrarianPassword.Enabled = Not isReadOnly
        btnLibrarianSave.Enabled = Not isReadOnly
    End Sub


    Private Sub LoadLibrarians()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de bibliotecarios desde la base de datos
                Dim librarians = context.Librarians.ToList()

                ' Configurar el DataGridView con la lista de bibliotecarios
                grdLibrarianList.DataSource = librarians
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los bibliotecarios: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLibrarianReset_Click(sender As Object, e As EventArgs) Handles btnLibrarianReset.Click
        ClearLibrarianFormFields()
    End Sub

    Private Sub btnLibrarianDelete_Click(sender As Object, e As EventArgs) Handles btnLibrarianDelete.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdLibrarianList.SelectedRows.Count > 0 Then
                ' Confirmar la eliminación
                Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar al bibliotecario seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Obtener el ID del bibliotecario seleccionado
                    Dim selectedRow As DataGridViewRow = grdLibrarianList.SelectedRows(0)
                    Dim librarianId As Integer = Convert.ToInt32(selectedRow.Cells("LibrarianId").Value)

                    ' Eliminar el bibliotecario de la base de datos
                    Using context As New Entity.LibraryDbContext()
                        ' Buscar el bibliotecario por ID
                        Dim librarianToDelete As Entity.Librarian = context.Librarians.Find(librarianId)

                        If librarianToDelete IsNot Nothing Then
                            ' Eliminar el bibliotecario
                            context.Librarians.Remove(librarianToDelete)
                            context.SaveChanges()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Bibliotecario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Actualizar el DataGridView
                            LoadLibrarians()
                        Else
                            MessageBox.Show("El bibliotecario seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Por favor, seleccione un bibliotecario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar eliminar al bibliotecario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLibrarianEdit_Click(sender As Object, e As EventArgs) Handles btnLibrarianEdit.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdLibrarianList.SelectedRows.Count > 0 Then
                ' Confirmar la edición
                Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Obtener el ID del bibliotecario seleccionado
                    Dim selectedRow As DataGridViewRow = grdLibrarianList.SelectedRows(0)
                    Dim librarianId As Integer = Convert.ToInt32(selectedRow.Cells("LibrarianId").Value)

                    ' Actualizar el bibliotecario en la base de datos
                    Using context As New Entity.LibraryDbContext()
                        ' Buscar el bibliotecario por ID
                        Dim librarianToUpdate As Entity.Librarian = context.Librarians.Find(librarianId)

                        If librarianToUpdate IsNot Nothing Then
                            ' Verificar si ya existe un bibliotecario con el mismo nombre o teléfono
                            Dim existingLibrarian As Entity.Librarian = context.Librarians.FirstOrDefault(Function(l) l.Name = txtLibrarianName.Texts.Trim() AndAlso l.LibrarianId <> librarianId)

                            If existingLibrarian IsNot Nothing Then
                                MessageBox.Show("Un bibliotecario con este nombre ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Verificar si los datos han cambiado
                            If librarianToUpdate.Name = txtLibrarianName.Texts.Trim() AndAlso
                               librarianToUpdate.Phone = txtLibrarianPhone.Texts.Trim() AndAlso
                               librarianToUpdate.Password = txtLibrarianPassword.Texts.Trim() Then
                                MessageBox.Show("No se han detectado cambios en los datos del bibliotecario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return
                            End If

                            ' Actualizar los datos del bibliotecario
                            librarianToUpdate.Name = txtLibrarianName.Texts.Trim()
                            librarianToUpdate.Phone = txtLibrarianPhone.Texts.Trim()
                            librarianToUpdate.Password = txtLibrarianPassword.Texts.Trim()

                            ' Guardar los cambios en la base de datos
                            context.SaveChanges()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Bibliotecario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Actualizar el DataGridView
                            LoadLibrarians()
                        Else
                            MessageBox.Show("El bibliotecario seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Por favor, seleccione un bibliotecario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar actualizar al bibliotecario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub grdLibrarianList_DoubleClick(sender As Object, e As EventArgs) Handles grdLibrarianList.DoubleClick
        If grdLibrarianList.SelectedRows.Count > 0 Then
            ' Habilitar el botón de edición
            btnLibrarianEdit.Enabled = True

            ' Poblar los campos con la información del bibliotecario seleccionado
            Dim selectedRow As DataGridViewRow = grdLibrarianList.SelectedRows(0)
            txtLibrarianName.Texts = selectedRow.Cells("Name").Value.ToString()
            txtLibrarianPhone.Texts = selectedRow.Cells("Phone").Value.ToString()
            txtLibrarianPassword.Texts = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Try
            ' Confirmación de cierre de sesión
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then


                Dim loginForm As New Login() ' Asume que tienes un formulario de inicio de sesión llamado LoginForm
                loginForm.Show()

                ' Cierra el formulario actual, lo que efectivamente cierra la sesión
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al cerrar la sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grdLibrarianList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLibrarianList.CellContentClick

    End Sub
End Class