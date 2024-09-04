Imports Lib_Soft.Entity
Imports System.Data.Entity.Infrastructure
Imports System.IO
Imports OfficeOpenXml

Public Class Books



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
    Private Sub txtOnlyLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyLetters.KeyPress, txtBookPublisher.KeyPress, txtBookName.KeyPress, txtBookAuthor.KeyPress
        ' Verifica si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten letras en este campo")

            e.Handled = True
        End If
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyNumbers
    Private Sub txtOnlyNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyNumbers.KeyPress, txtBookPrice.KeyPress, txtBookQuantity.KeyPress
        ' Verifica si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten numeros en este campo")

            e.Handled = True
        End If
    End Sub



    Private Sub BookCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
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

    Private Sub btnBookBack_Click(sender As Object, e As EventArgs) Handles btnBookBack.Click
        Dim mainForm = New MainForm()
        mainForm.Show()

        Me.Hide()
    End Sub


    Private Sub btnBookSave_Click(sender As Object, e As EventArgs) Handles btnBookSave.Click
        Try
            ' Obtener y validar la entrada de datos
            Dim bookName As String = txtBookName.Texts.Trim()
            Dim bookAuthor As String = txtBookAuthor.Texts.Trim()
            Dim bookPublisher As String = txtBookPublisher.Texts.Trim()
            Dim bookPrice As Decimal
            Dim bookQuantity As Integer

            ' Verificar si algún campo está vacío
            If String.IsNullOrWhiteSpace(bookName) Then
                Throw New ArgumentException("El nombre del libro no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(bookAuthor) Then
                Throw New ArgumentException("El autor del libro no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(bookPublisher) Then
                Throw New ArgumentException("El editor del libro no puede estar vacío.")
            End If

            ' Validar el precio
            If Not Decimal.TryParse(txtBookPrice.Texts.Trim(), bookPrice) OrElse bookPrice < 0 Then
                Throw New FormatException("El precio del libro debe ser un número decimal positivo.")
            End If

            ' Validar la cantidad
            If Not Integer.TryParse(txtBookQuantity.Texts.Trim(), bookQuantity) OrElse bookQuantity < 0 Then
                Throw New FormatException("La cantidad del libro debe ser un número entero positivo.")
            End If

            ' Crear una nueva instancia del contexto
            Using context As New Entity.LibraryDbContext()
                ' Verificar si ya existe un libro con el mismo nombre y autor
                Dim existingBook As Entity.Book = context.Books.FirstOrDefault(Function(b) b.Name = bookName AndAlso b.Author = bookAuthor)

                If existingBook IsNot Nothing Then
                    MessageBox.Show("Ya existe un libro con este nombre y autor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Crear un nuevo libro
                Dim newBook As New Entity.Book() With {
                .Name = bookName,
                .Author = bookAuthor,
                .Publisher = bookPublisher,
                .Price = bookPrice,
                .Quantity = bookQuantity
            }

                ' Agregar el nuevo libro al DbSet
                context.Books.Add(newBook)

                ' Guardar los cambios en la base de datos
                context.SaveChanges()
            End Using

            ' Limpiar los campos del formulario
            ClearBookFormFields()

            LoadBooks()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Libro agregado exitosamente.")

        Catch ex As FormatException
            MessageBox.Show("Error en el formato de entrada: " & ex.Message)
        Catch ex As ArgumentException
            MessageBox.Show("Error en los datos: " & ex.Message)
        Catch ex As DbUpdateException
            MessageBox.Show("Error al guardar los cambios en la base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Se produjo un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearBookFormFields()
        txtBookName.Texts = ""
        txtBookAuthor.Texts = ""
        txtBookPublisher.Texts = ""
        txtBookPrice.Texts = ""
        txtBookQuantity.Texts = ""
    End Sub



    Private Sub LoadBooks()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de libros desde la base de datos
                Dim books = context.Books.ToList()

                ' Configurar el DataGridView
                grdBookList.DataSource = books
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los libros: " & ex.Message)
        End Try
    End Sub




    Private Sub btnBookDelete_Click(sender As Object, e As EventArgs) Handles btnBookDelete.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdBookList.SelectedRows.Count > 0 Then
                ' Obtener el ID del libro seleccionado
                Dim selectedRow As DataGridViewRow = grdBookList.SelectedRows(0)
                Dim bookId As Integer = Convert.ToInt32(selectedRow.Cells("book_Id").Value)

                ' Confirmar la eliminación
                Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este libro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Using context As New LibraryDbContext()
                        ' Buscar el libro en la base de datos
                        Dim bookToDelete As Book = context.Books.Find(bookId)

                        If bookToDelete IsNot Nothing Then
                            ' Eliminar el libro de la base de datos
                            context.Books.Remove(bookToDelete)
                            context.SaveChanges()

                            ' Actualizar el DataGridView
                            LoadBooks()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Libro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("El libro seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Por favor, seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar eliminar el libro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetReadOnly(isReadOnly As Boolean)
        txtBookName.Enabled = Not isReadOnly
        txtBookAuthor.Enabled = Not isReadOnly
        txtBookPublisher.Enabled = Not isReadOnly
        txtBookPrice.Enabled = Not isReadOnly
        txtBookQuantity.Enabled = Not isReadOnly
        btnBookEdit.Enabled = Not isReadOnly
        btnBookDelete.Enabled = Not isReadOnly
    End Sub



    Private Sub grdBookList_DoubleClick(sender As Object, e As EventArgs) Handles grdBookList.DoubleClick
        ' Verificar si hay una fila seleccionada en el DataGridView
        If grdBookList.SelectedRows.Count > 0 Then
            ' Habilitar los campos para edición
            SetReadOnly(False)

            ' Habilitar el botón de editar
            btnBookEdit.Enabled = True

            ' Cargar los datos del libro en los controles
            Dim selectedRow As DataGridViewRow = grdBookList.SelectedRows(0)
            txtBookName.Texts = selectedRow.Cells("Name").Value.ToString()
            txtBookAuthor.Texts = selectedRow.Cells("Author").Value.ToString()
            txtBookPublisher.Texts = selectedRow.Cells("Publisher").Value.ToString()
            txtBookPrice.Texts = selectedRow.Cells("Price").Value.ToString()
            txtBookQuantity.Texts = selectedRow.Cells("Quantity").Value.ToString()
        End If
    End Sub

    Private Sub btnBookEdit_Click(sender As Object, e As EventArgs) Handles btnBookEdit.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdBookList.SelectedRows.Count > 0 Then
                ' Confirmar la edición
                Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Obtener el ID del libro seleccionado
                    Dim selectedRow As DataGridViewRow = grdBookList.SelectedRows(0)
                    Dim bookId As Integer = Convert.ToInt32(selectedRow.Cells("book_Id").Value)

                    ' Actualizar el libro en la base de datos
                    Using context As New Entity.LibraryDbContext()
                        ' Buscar el libro por ID
                        Dim bookToUpdate As Entity.Book = context.Books.Find(bookId)

                        If bookToUpdate IsNot Nothing Then
                            ' Verificar si los datos han cambiado
                            If bookToUpdate.Name = txtBookName.Texts.Trim() AndAlso
                           bookToUpdate.Author = txtBookAuthor.Texts.Trim() AndAlso
                           bookToUpdate.Publisher = txtBookPublisher.Texts.Trim() AndAlso
                           bookToUpdate.Price = Convert.ToDecimal(txtBookPrice.Texts.Trim()) AndAlso
                           bookToUpdate.Quantity = Convert.ToInt32(txtBookQuantity.Texts.Trim()) Then
                                MessageBox.Show("No se han detectado cambios en los datos del libro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return
                            End If

                            ' Actualizar los datos del libro
                            bookToUpdate.Name = txtBookName.Texts.Trim()
                            bookToUpdate.Author = txtBookAuthor.Texts.Trim()
                            bookToUpdate.Publisher = txtBookPublisher.Texts.Trim()
                            bookToUpdate.Price = Convert.ToDecimal(txtBookPrice.Texts.Trim())
                            bookToUpdate.Quantity = Convert.ToInt32(txtBookQuantity.Texts.Trim())

                            ' Guardar los cambios en la base de datos
                            context.SaveChanges()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Libro actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Actualizar el DataGridView
                            LoadBooks()

                            ' Limpiar los campos del formulario
                            ClearBookFormFields()
                        Else
                            MessageBox.Show("El libro seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Por favor, seleccione un libro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As FormatException
            MessageBox.Show("Error en el formato de entrada: " & ex.Message)
        Catch ex As ArgumentException
            MessageBox.Show("Error en los datos: " & ex.Message)
        Catch ex As DbUpdateException
            MessageBox.Show("Error al guardar los cambios en la base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Se produjo un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBookReset_Click(sender As Object, e As EventArgs) Handles btnBookReset.Click
        ClearBookFormFields()
    End Sub

    Private Sub btnBookExport_Click(sender As Object, e As EventArgs) Handles btnBookExport.Click
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Excel Files|*.xlsx"
                sfd.Title = "Guardar libros como archivo de Excel"
                sfd.FileName = "BooksExport.xlsx"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Using package As New ExcelPackage()
                        Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Books")

                        worksheet.Cells(1, 1).Value = "ID"
                        worksheet.Cells(1, 2).Value = "Name"
                        worksheet.Cells(1, 3).Value = "Author"
                        worksheet.Cells(1, 4).Value = "Publisher"
                        worksheet.Cells(1, 5).Value = "Price"
                        worksheet.Cells(1, 6).Value = "Quantity"

                        Using context As New Entity.LibraryDbContext()
                            Dim books = context.Books.ToList()

                            For i As Integer = 0 To books.Count - 1
                                worksheet.Cells(i + 2, 1).Value = books(i).Book_Id
                                worksheet.Cells(i + 2, 2).Value = books(i).Name
                                worksheet.Cells(i + 2, 3).Value = books(i).Author
                                worksheet.Cells(i + 2, 4).Value = books(i).Publisher
                                worksheet.Cells(i + 2, 5).Value = books(i).Price
                                worksheet.Cells(i + 2, 6).Value = books(i).Quantity
                            Next
                        End Using

                        package.SaveAs(New FileInfo(sfd.FileName))
                    End Using

                    MessageBox.Show("Libros exportados exitosamente a " & sfd.FileName, "Exportación Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Se produjo un error al exportar los libros: " & ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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





End Class