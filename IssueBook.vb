Imports System.Linq
Public Class IssueBook
    Private Sub RjComboBox1_OnSelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RjComboBox2_OnSelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIds()
        InitializeFormFields()
        LoadBookNames()
        ClearFields()
        btnIssuedBooknEdit.Enabled = False

        LoadIssuedBooksGrid()
    End Sub




    Private Sub grdIssuedBooks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdIssuedBooks.CellDoubleClick
        ' Verificar si se ha seleccionado una fila válida
        If e.RowIndex >= 0 Then
            ' Obtener el préstamo seleccionado
            Dim selectedRow As DataGridViewRow = grdIssuedBooks.Rows(e.RowIndex)
            Dim selectedLoanId As Integer = Convert.ToInt32(selectedRow.Cells("LoanID").Value)

            ' Cargar los datos del préstamo en los controles
            Using context As New Entity.LibraryDbContext()
                Dim selectedLoan = context.LoanProcesses.FirstOrDefault(Function(lp) lp.LoanID = selectedLoanId)
                If selectedLoan IsNot Nothing Then
                    cmbStudentId.SelectedValue = selectedLoan.StudentId
                    cmbBookId.SelectedValue = selectedLoan.BookId
                    cmbBookName.Text = selectedLoan.BookName
                    txtDatedIssued.Text = selectedLoan.IssuedDate.ToString("yyyy-MM-dd")

                    ' Habilitar el botón de edición
                    btnIssuedBooknEdit.Enabled = True
                End If
            End Using
        End If
    End Sub



    Private Sub ClearFields()
        Try
            ' Limpiar los campos del formulario
            cmbStudentId.SelectedIndex = -1 ' Desseleccionar el ComboBox de StudentId
            cmbBookId.SelectedIndex = -1 ' Desseleccionar el ComboBox de BookId
            cmbBookName.SelectedIndex = -1 ' Desseleccionar el ComboBox de BookName
            ' Limpiar el campo de texto para la fecha de emisión

            ' Opcional: Enfocar el primer campo después de limpiar
            cmbStudentId.Focus()

        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al limpiar los campos: " & ex.Message)
            MessageBox.Show("Error al limpiar los campos: " & ex.Message)
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

    Private Sub btnGobackIssued_Click(sender As Object, e As EventArgs) Handles btnGobackIssued.Click
        Dim mainForm = New MainForm()

        mainForm.Show()

        Me.Hide()
    End Sub
    Private Sub btnIssuedBookSave_Click(sender As Object, e As EventArgs) Handles btnIssuedBookSave.Click
        Try
            ' Verificar que los campos no están vacíos
            If cmbStudentId.SelectedValue Is Nothing OrElse cmbBookId.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(txtDatedIssued.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.")
                Return
            End If

            ' Obtener los valores seleccionados y la fecha
            Dim studentId As Integer = Convert.ToInt32(cmbStudentId.SelectedValue)
            Dim bookId As Integer = Convert.ToInt32(cmbBookId.SelectedValue)
            Dim bookName As String = cmbBookName.Text
            Dim issuedDate As DateTime = DateTime.Parse(txtDatedIssued.Text)



            Using context As New Entity.LibraryDbContext()
                ' Verificar si el estudiante ya tiene un préstamo activo para el mismo libro
                Dim existingLoan = context.LoanProcesses.
                                Where(Function(lp) lp.StudentId = studentId AndAlso lp.BookId = bookId).
                                FirstOrDefault()

                If existingLoan IsNot Nothing Then
                    MessageBox.Show("El estudiante ya tiene un préstamo activo para este libro.")
                    Return
                End If

                ' Consultar la cantidad disponible del libro
                Dim book = context.Books.FirstOrDefault(Function(b) b.Book_Id = bookId)

                If book Is Nothing Then
                    MessageBox.Show("No se encontró el libro en la base de datos.")
                    Return
                End If

                ' Verificar si la cantidad disponible es suficiente
                If book.Quantity <= 0 Then
                    MessageBox.Show("No hay suficientes copias disponibles de este libro para prestar.")
                    Return
                End If

                ' Crear una nueva instancia de LoanProcess
                Dim newLoan As New Entity.LoanProcess() With {
                .StudentId = studentId,
                .BookId = bookId,
                .BookName = bookName,
                .IssuedDate = issuedDate
            }

                ' Guardar los cambios en la base de datos
                context.LoanProcesses.Add(newLoan)
                ' Actualizar la cantidad disponible del libro
                book.Quantity -= 1
                context.SaveChanges()
            End Using

            MessageBox.Show("El préstamo se ha registrado correctamente.")

            ClearFields()
            LoadIssuedBooksGrid()


        Catch ex As Exception
            ' Loguear detalles del error
            If ex.InnerException IsNot Nothing Then
                If ex.InnerException.InnerException IsNot Nothing Then
                End If
            End If
            MessageBox.Show("Error al registrar el préstamo: " & ex.Message)
        End Try
    End Sub





    Private Sub LoadIssuedBooksGrid()
        Try
            ' Usar el contexto de la base de datos para obtener los datos
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de préstamos de libros
                Dim loanProcesses = (From lp In context.LoanProcesses
                                     Select New With {
                                    .LoanID = lp.LoanID,
                                    .StudentName = lp.Student.Name,
                                    .BookName = lp.BookName,
                                    .BookId = lp.BookId,
                                    .IssuedDate = lp.IssuedDate
                                }).ToList()

                ' Asignar la lista al DataGridView
                grdIssuedBooks.DataSource = loanProcesses
            End Using

            ' Configurar las columnas del DataGridView
            grdIssuedBooks.Columns("LoanID").HeaderText = "Loan ID"
            grdIssuedBooks.Columns("StudentName").HeaderText = "Student Name"
            grdIssuedBooks.Columns("BookName").HeaderText = "Book Name"
            grdIssuedBooks.Columns("BookId").HeaderText = "Book ID"
            grdIssuedBooks.Columns("IssuedDate").HeaderText = "Issued Date"

            ' Opcional: Ajustar el ancho de las columnas
            grdIssuedBooks.AutoResizeColumns()

        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al cargar los préstamos en el grid: " & ex.Message)
            MessageBox.Show("Error al cargar los préstamos en el grid: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadBookNames()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de libros desde la base de datos
                Dim books = context.Books.ToList()

                ' Crear una lista de objetos anónimos con solo el Nombre para libros
                Dim bookDisplay = books.Select(Function(b) New With {
                .Name = b.Name
            }).ToList()

                ' Configurar cmbBookName
                If bookDisplay.Any() Then
                    cmbBookName.DataSource = bookDisplay
                    cmbBookName.DisplayMember = "Name"
                    cmbBookName.ValueMember = "Name"
                Else
                    cmbBookName.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los libros: " & ex.Message)
        End Try
    End Sub







    Private Sub LoadIds()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de estudiantes y libros desde la base de datos
                Dim students = context.Students.ToList()
                Dim books = context.Books.ToList()

                ' Crear una lista de objetos anónimos con ID y Nombre para estudiantes
                Dim studentDisplay = students.Select(Function(s) New With {
                .StudentId = s.StudentId,
                .DisplayMember = $"{s.StudentId} - {s.Name}"
            }).ToList()

                ' Configurar cmbStudentId
                cmbStudentId.DataSource = studentDisplay
                cmbStudentId.DisplayMember = "DisplayMember"
                cmbStudentId.ValueMember = "StudentId"

                ' Crear una lista de objetos anónimos con ID y Nombre para libros
                Dim bookDisplay = books.Select(Function(b) New With {
                .BookId = b.Book_Id,
                .DisplayMember = $"{b.Book_Id} - {b.Name}"
            }).ToList()

                ' Configurar cmbBookId
                cmbBookId.DataSource = bookDisplay
                cmbBookId.DisplayMember = "DisplayMember"
                cmbBookId.ValueMember = "BookId"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los IDs: " & ex.Message)
        End Try
    End Sub




    Private Sub InitializeFormFields()

        cmbBookName.Text = String.Empty
    End Sub




    Private Sub lblIssuedBookID_Click(sender As Object, e As EventArgs) Handles lblIssuedBookID.Click

    End Sub

    Private Sub cmbBookName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookName.SelectedIndexChanged

    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(sender As Object, e As EventArgs)

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

    Private Sub btnIssuedBookReset_Click(sender As Object, e As EventArgs) Handles btnIssuedBookReset.Click
        ClearFields()
    End Sub
    Private Sub btnIssuedBookDelete_Click(sender As Object, e As EventArgs) Handles btnIssuedBookDelete.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdIssuedBooks.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un préstamo en la tabla para eliminar.")
                Return
            End If

            ' Obtener el LoanID del préstamo seleccionado
            Dim selectedLoanId As Integer = Convert.ToInt32(grdIssuedBooks.SelectedRows(0).Cells("LoanID").Value)

            ' Preguntar al usuario si está seguro de que quiere eliminar el préstamo
            Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este préstamo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' Si el usuario selecciona 'No', cancelar la operación
            If confirmResult = DialogResult.No Then
                Return
            End If

            ' Buscar y eliminar el préstamo de libro de la base de datos
            Using context As New Entity.LibraryDbContext()
                ' Buscar el préstamo a eliminar por LoanID
                Dim loanToDelete = context.LoanProcesses.FirstOrDefault(Function(lp) lp.LoanID = selectedLoanId)

                ' Verificar si el préstamo existe
                If loanToDelete IsNot Nothing Then
                    context.LoanProcesses.Remove(loanToDelete)
                    context.SaveChanges()

                    MessageBox.Show("El préstamo ha sido eliminado correctamente.")
                    Console.WriteLine("El préstamo ha sido eliminado correctamente.")

                    ' Refrescar el DataGridView para reflejar los cambios
                    LoadIssuedBooksGrid()
                    ClearFields()
                Else
                    MessageBox.Show("No se encontró el préstamo para eliminar.")
                End If
            End Using

        Catch ex As Exception
            ' Loguear detalles del error
            Console.WriteLine("Error al eliminar el préstamo: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                Console.WriteLine("Detalles del error interno: " & ex.InnerException.Message)
                If ex.InnerException.InnerException IsNot Nothing Then
                    Console.WriteLine("Detalles del error interno adicional: " & ex.InnerException.InnerException.Message)
                End If
            End If
            MessageBox.Show("Error al eliminar el préstamo: " & ex.Message)
        End Try
    End Sub


    Private Sub btnIssuedBookEdit_Click(sender As Object, e As EventArgs) Handles btnIssuedBooknEdit.Click
        Try
            ' Verificar que los campos no están vacíos
            If cmbStudentId.SelectedValue Is Nothing OrElse cmbBookId.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(txtDatedIssued.Text) Then
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.")
                Return
            End If

            ' Obtener el LoanID del préstamo seleccionado
            Dim selectedLoanId As Integer = Convert.ToInt32(grdIssuedBooks.SelectedRows(0).Cells("LoanID").Value)
            Dim studentId As Integer = Convert.ToInt32(cmbStudentId.SelectedValue)
            Dim bookId As Integer = Convert.ToInt32(cmbBookId.SelectedValue)
            Dim bookName As String = cmbBookName.Text
            Dim issuedDate As DateTime = DateTime.Parse(txtDatedIssued.Text)

            ' Confirmar la acción de edición
            Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea editar este préstamo?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario selecciona 'No', cancelar la operación
            If confirmResult = DialogResult.No Then
                Return
            End If

            ' Actualizar el préstamo en la base de datos
            Using context As New Entity.LibraryDbContext()
                Dim loanToUpdate = context.LoanProcesses.FirstOrDefault(Function(lp) lp.LoanID = selectedLoanId)

                ' Verificar si el préstamo existe
                If loanToUpdate IsNot Nothing Then
                    ' Verificar si hay cambios
                    Dim hasChanges As Boolean = (loanToUpdate.StudentId <> studentId OrElse
                                             loanToUpdate.BookId <> bookId OrElse
                                             loanToUpdate.BookName <> bookName OrElse
                                             loanToUpdate.IssuedDate <> issuedDate)

                    If Not hasChanges Then
                        MessageBox.Show("No se han realizado cambios en el préstamo.")
                        Return
                    End If

                    ' Actualizar los valores solo si hay cambios
                    loanToUpdate.StudentId = studentId
                    loanToUpdate.BookId = bookId
                    loanToUpdate.BookName = bookName
                    loanToUpdate.IssuedDate = issuedDate

                    context.SaveChanges()

                    MessageBox.Show("El préstamo ha sido actualizado correctamente.")
                    Console.WriteLine("El préstamo ha sido actualizado correctamente.")

                    ' Refrescar el DataGridView para reflejar los cambios
                    LoadIssuedBooksGrid()
                    ClearFields()

                    ' Deshabilitar el botón de edición después de la actualización
                    btnIssuedBooknEdit.Enabled = False
                Else
                    MessageBox.Show("No se encontró el préstamo para actualizar.")
                End If
            End Using

        Catch ex As Exception
            ' Loguear detalles del error
            Console.WriteLine("Error al actualizar el préstamo: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                Console.WriteLine("Detalles del error interno: " & ex.InnerException.Message)
                If ex.InnerException.InnerException IsNot Nothing Then
                    Console.WriteLine("Detalles del error interno adicional: " & ex.InnerException.InnerException.Message)
                End If
            End If
            MessageBox.Show("Error al actualizar el préstamo: " & ex.Message)
        End Try
    End Sub


End Class