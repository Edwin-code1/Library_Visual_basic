Imports System.Data.Entity.Infrastructure
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports Lib_Soft.Entity
Imports OfficeOpenXml



Public Class BookReturns
    Private lblError As Object

    Private Sub BookReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentNamesWithLoans()
        CustomizeComboBox()
        DisableFields()
        LoadBookReturnsTwo()
        LoadIssuedBooksGrid()
        btnDtaProcess.Enabled = False

    End Sub





    ' Declarar el TextBox con WithEvents
    Private WithEvents txtOnlyLetters As New TextBox

    Public Sub New()
        InitializeComponent()

        ' Configurar el TextBox y agregarlo al formulario
        txtOnlyLetters.Location = New Point(10, 10)
        Me.Controls.Add(txtOnlyLetters)
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyLetters
    Private Sub txtOnlyLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyLetters.KeyPress
        ' Verifica si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, se cancela el evento (evita la entrada)
            e.Handled = True
        End If
    End Sub


    Private Sub LoadStudentNamesWithLoans()
        Try
            Using context As New LibraryDbContext()
                ' Consultar los préstamos activos y obtener los nombres de los estudiantes
                Dim studentLoans = (From loan In context.LoanProcesses
                                    Join student In context.Students
                                On loan.StudentId Equals student.StudentId
                                    Select New With {
                                    .StudentName = student.Name,
                                    .StudentId = loan.StudentId
                                }).Distinct().ToList()

                ' Verificar cuántos resultados se obtuvieron
                Console.WriteLine("Número de estudiantes con préstamos: " & studentLoans.Count)

                ' Limpiar el ComboBox antes de llenarlo
                cmbStudentName.Items.Clear()

                ' Llenar el ComboBox con los nombres de los estudiantes
                For Each student In studentLoans
                    Console.WriteLine("Añadiendo estudiante: " & student.StudentName & " con ID: " & student.StudentId)
                    cmbStudentName.Items.Add(New ComboBoxItem With {
                    .Text = student.StudentName,
                    .Value = student.StudentId
                })
                Next

                ' Configurar DisplayMember y ValueMember
                cmbStudentName.DisplayMember = "Text"
                cmbStudentName.ValueMember = "Value"

                ' Mejorar el diseño del ComboBox
                cmbStudentName.DropDownStyle = ComboBoxStyle.DropDownList ' Solo permitir seleccionar elementos de la lista
                cmbStudentName.Font = New Font("Arial", 10, FontStyle.Regular)
                cmbStudentName.ForeColor = Color.Black
                cmbStudentName.BackColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los estudiantes con préstamos: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentName.SelectedIndexChanged
        Try
            If cmbStudentName.SelectedIndex <> -1 Then
                ' Obtener el StudentId del ítem seleccionado
                Dim selectedStudentId As Integer = CType(cmbStudentName.SelectedItem, ComboBoxItem).Value
                Console.WriteLine("Estudiante seleccionado con ID: " & selectedStudentId)

                Using context As New LibraryDbContext()
                    ' Buscar el préstamo correspondiente al estudiante seleccionado
                    Dim loan = context.LoanProcesses.
                    Where(Function(l) l.StudentId = selectedStudentId).
                    OrderByDescending(Function(l) l.IssuedDate).
                    FirstOrDefault()

                    If loan IsNot Nothing Then
                        ' Poblar los campos con la información del préstamo
                        txtBookName.Texts = loan.BookName
                        booklentDate.Texts = loan.IssuedDate.ToShortDateString()
                        Console.WriteLine("Libro encontrado: " & loan.BookName & ", Fecha de préstamo: " & loan.IssuedDate.ToShortDateString())
                    Else
                        MessageBox.Show("No se encontró un préstamo activo para el estudiante seleccionado.")
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información del préstamo: " & ex.Message)
        End Try
    End Sub

    ' Clase personalizada para manejar los ítems del ComboBox
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class



    Private Sub CalculateFine()
        Try
            ' Obtener la fecha de préstamo y la fecha de devolución
            Dim lentDate As DateTime = DateTime.Parse(booklentDate.Texts)
            Dim returnDate As DateTime = DateTime.Parse(txtBookReturnedDate.Text)

            ' Calcular la diferencia en días
            Dim totalDays As Integer = (returnDate - lentDate).Days

            ' Si los días son mayores a 5, calcular la multa
            If totalDays > 5 Then
                Dim lateDays As Integer = totalDays - 5
                Dim fineAmount As Decimal = lateDays * 25
                txtBookFine.Texts = fineAmount.ToString("C")
            Else
                ' Si los días no exceden 5, no se aplica multa
                txtBookFine.Texts = "0"
            End If

        Catch ex As Exception
            ' Manejar el error al calcular la multa
            MessageBox.Show("Error al calcular la multa: " & ex.Message)
        End Try
    End Sub

    Private Sub txtBookReturnedDate_TextChanged(sender As Object, e As EventArgs) Handles txtBookReturnedDate.TextChanged
        ' Llamar al método de cálculo de multa
        CalculateFine()
    End Sub






    Private Sub DisableFields()
        ' Set the TextBox controls to read-only
        txtBookName.Enabled = False
        txtBookFine.Enabled = False
        booklentDate.Enabled = False

        ' Optional: Change the background color to indicate they are read-only
        txtBookName.BackColor = SystemColors.Control
        txtBookFine.BackColor = SystemColors.Control
        booklentDate.BackColor = SystemColors.Control
    End Sub

    Private Sub ClearFields()
        txtBookName.Texts = String.Empty
        txtBookFine.Texts = String.Empty
        booklentDate.Texts = String.Empty

        cmbStudentName.SelectedIndex = -1
        cmbStudentName.Text = String.Empty


    End Sub
    Private Sub CustomizeComboBox()
        ' Ajustar el tamaño del ComboBox
        cmbStudentName.Width = 190   ' Ajusta el ancho según lo necesario
        cmbStudentName.Height = 75   ' Ajusta el alto según lo necesario

        ' Establecer el color del borde utilizando un evento de dibujo personalizado
        AddHandler cmbStudentName.DrawItem, AddressOf cmbStudentName_DrawItem
        AddHandler cmbStudentName.MeasureItem, AddressOf cmbStudentName_MeasureItem
        cmbStudentName.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    ' Manejar el evento DrawItem para personalizar el dibujo del ComboBox
    Private Sub cmbStudentName_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then
            Return
        End If

        Dim comboBox As ComboBox = CType(sender, ComboBox)
        Dim g As Graphics = e.Graphics
        Dim rect As Rectangle = e.Bounds

        ' Dibujar fondo
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            g.FillRectangle(New SolidBrush(Color.LightBlue), rect)
        Else
            g.FillRectangle(New SolidBrush(comboBox.BackColor), rect)
        End If

        ' Dibujar texto
        Dim item As ComboBoxItem = CType(comboBox.Items(e.Index), ComboBoxItem)
        TextRenderer.DrawText(g, item.Text, comboBox.Font, rect, comboBox.ForeColor, TextFormatFlags.Left)

        ' Dibujar borde
        g.DrawRectangle(New Pen(Color.AliceBlue, 2), rect.X, rect.Y, rect.Width - 1, rect.Height - 1)

        e.DrawFocusRectangle()
    End Sub

    ' Manejar el evento MeasureItem para personalizar la altura de cada ítem en el ComboBox
    Private Sub cmbStudentName_MeasureItem(sender As Object, e As MeasureItemEventArgs)
        e.ItemHeight = 30 ' Ajusta la altura de los ítems del ComboBox
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



    Private Sub btnGobackReturned_Click(sender As Object, e As EventArgs) Handles btnGobackReturned.Click
        Dim mainForm = New MainForm()
        mainForm.Show()

        Me.Hide()

    End Sub






    Private Sub btnReturnBookSave_Click(sender As Object, e As EventArgs) Handles btnReturnBookSave.Click
        Try
            ' Verificar que los campos esenciales no estén vacíos
            If cmbStudentName.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtBookReturnedDate.Text) Then
                MessageBox.Show("Por favor, seleccione un estudiante y complete la fecha de retorno antes de guardar.")
                Return
            End If

            ' Obtener los valores de los campos
            Dim studentName As String = cmbStudentName.Text
            Dim bookName As String = txtBookName.Texts

            ' Intentar convertir el valor de la multa a Decimal
            Dim fine As Decimal
            Dim fineString As String = txtBookFine.Texts
            If Not Decimal.TryParse(fineString, NumberStyles.Currency, CultureInfo.CurrentCulture, fine) Then
                MessageBox.Show("El formato de la multa no es válido.")
                Return
            End If

            ' Obtener la fecha de retorno desde el DateTimePicker
            Dim returnDate As DateTime = txtBookReturnedDate.Value

            ' Intentar analizar la fecha de préstamo desde el TextBox
            Dim lentDate As DateTime
            Dim dateFormat As String = "d/M/yyyy" ' Formato de fecha esperado



            ' Validar el formato de la fecha de préstamo
            If Not DateTime.TryParseExact(booklentDate.Texts, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, lentDate) Then
                MessageBox.Show("El formato de la fecha de préstamo no es válido.")
                Return
            End If



            ' Obtener el StudentId a partir del nombre del estudiante
            Dim studentId As Integer
            Using context As New LibraryDbContext()
                Dim student = context.Students.FirstOrDefault(Function(s) s.Name = studentName)
                If student IsNot Nothing Then
                    studentId = student.StudentId
                Else
                    MessageBox.Show("Estudiante no encontrado.")
                    Return
                End If

                ' Buscar el préstamo correspondiente
                Dim loan = context.LoanProcesses.
            Where(Function(l) l.StudentId = studentId AndAlso l.BookName = bookName).
            OrderByDescending(Function(l) l.IssuedDate).
            FirstOrDefault()

                If loan Is Nothing Then
                    MessageBox.Show("No se encontró un préstamo activo para este libro y estudiante.")
                    Return
                End If

                ' Crear una nueva instancia de BookReturn
                Dim bookReturn As New BookReturn With {
                .StudentId = studentId,
                .BookId = loan.BookId, ' Asegúrate de que el nombre de columna sea correcto
                .Name = studentName,
                .BookName = bookName,
                .ReturnDate = returnDate,
                .IssuedDate = loan.IssuedDate,
                .Fine = fine
            }

                ' Actualizar el estado del libro (suponiendo que tienes una propiedad `Quantity` en la entidad Book)
                Dim book = context.Books.FirstOrDefault(Function(b) b.Book_Id = loan.BookId) ' Asegúrate de que el nombre de columna sea correcto
                If book IsNot Nothing Then
                    book.Quantity += 1
                End If

                ' Guardar los cambios en la base de datos
                context.BookReturns.Add(bookReturn)
                context.LoanProcesses.Remove(loan)
                context.SaveChanges()
            End Using


            LoadBookReturnsTwo()
            LoadIssuedBooksGrid()

            MessageBox.Show("El retorno del libro se ha registrado correctamente.")
            ClearFields()
        Catch ex As DbUpdateException
            ' Captura la excepción interna
            Dim sqlException = TryCast(ex.InnerException, SqlException)

            If sqlException IsNot Nothing Then
                ' Imprime el mensaje de error SQL
                MessageBox.Show("Error SQL: " & sqlException.Message)
                Console.WriteLine($"Código de Error SQL: {sqlException.Number}")
            Else
                ' Imprime el mensaje de error genérico
                MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
                Console.WriteLine($"Detalles de la excepción: {ex.ToString()}")
            End If
        Catch ex As Exception
            ' Loguear detalles del error genérico
            MessageBox.Show("Error al registrar el retorno del libro: " & ex.Message)
        End Try
    End Sub




    Private Sub LoadBookReturnsTwo()
        Try
            Using context As New LibraryDbContext()
                ' Obtener los datos de BookReturn
                Dim bookReturns = context.BookReturns.
                Select(Function(br) New With {
                    .StudentName = br.Student.Name,
                    .BookName = br.BookName,
                    .Fine = br.Fine
                }).ToList()

                ' Asignar los datos al DataGridView
                grdBooksReturned.DataSource = bookReturns

                ' Asegurarse de que las columnas no se dupliquen
                grdBooksReturned.Columns("StudentName").HeaderText = "Nombre del Estudiante"
                grdBooksReturned.Columns("BookName").HeaderText = "Nombre del Libro"
                grdBooksReturned.Columns("Fine").HeaderText = "Multa"

                ' Ajustar el ancho de las columnas
                grdBooksReturned.Columns("StudentName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                grdBooksReturned.Columns("BookName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                grdBooksReturned.Columns("Fine").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos de los retornos de libros: " & ex.Message)
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
                grdBooksIssuedTracked.DataSource = loanProcesses
            End Using

            ' Configurar las columnas del DataGridView
            grdBooksIssuedTracked.Columns("LoanID").HeaderText = "Loan ID"
            grdBooksIssuedTracked.Columns("StudentName").HeaderText = "Student Name"
            grdBooksIssuedTracked.Columns("BookName").HeaderText = "Book Name"
            grdBooksIssuedTracked.Columns("BookId").HeaderText = "Book ID"
            grdBooksIssuedTracked.Columns("IssuedDate").HeaderText = "Issued Date"

            ' Opcional: Ajustar el ancho de las columnas
            grdBooksIssuedTracked.AutoResizeColumns()

        Catch ex As Exception
            ' Manejo de errores
            Console.WriteLine("Error al cargar los préstamos en el grid: " & ex.Message)
            MessageBox.Show("Error al cargar los préstamos en el grid: " & ex.Message)
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

    Private Sub btnReturnedBookReset_Click(sender As Object, e As EventArgs) Handles btnReturnedBookReset.Click
        ClearFields()
    End Sub



    Private Sub btnReturnedBookDelete_Click(sender As Object, e As EventArgs) Handles btnReturnedBookDelete.Click
        Try
            ' Verificar que se haya seleccionado un elemento en el DataGridView
            If grdBooksReturned.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, selecciona un libro retornado para eliminar.")
                Return
            End If

            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = grdBooksReturned.SelectedRows(0)

            ' Obtener los valores de la fila seleccionada (puedes ajustar los nombres según tus columnas)
            Dim studentName As String = selectedRow.Cells("StudentName").Value.ToString()
            Dim bookName As String = selectedRow.Cells("BookName").Value.ToString()

            ' Mostrar el cuadro de diálogo de confirmación
            Dim result As DialogResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el registro del libro '{bookName}' del estudiante '{studentName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Eliminar el registro de la base de datos
                Using context As New LibraryDbContext()
                    ' Buscar el BookReturn correspondiente
                    Dim bookReturn = context.BookReturns.FirstOrDefault(Function(br) br.Student.Name = studentName AndAlso br.BookName = bookName)

                    If bookReturn IsNot Nothing Then
                        ' Remover el registro de la base de datos
                        context.BookReturns.Remove(bookReturn)
                        context.SaveChanges()

                        ' Recargar el DataGridView para reflejar los cambios
                        LoadBookReturnsTwo()

                        MessageBox.Show("El registro del libro retornado ha sido eliminado correctamente.")
                    Else
                        MessageBox.Show("No se encontró el registro del libro retornado para eliminar.")
                    End If
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar el registro del libro retornado: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnReverseProces_Click(sender As Object, e As EventArgs) Handles BtnReverseProces.Click
        Try
            ' Verificar que se haya seleccionado un elemento en el DataGridView
            If grdBooksReturned.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, selecciona un libro retornado para revertir el procesamiento.")
                Return
            End If

            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = grdBooksReturned.SelectedRows(0)

            ' Obtener los valores de la fila seleccionada
            Dim studentName As String = selectedRow.Cells("StudentName").Value.ToString()
            Dim bookName As String = selectedRow.Cells("BookName").Value.ToString()

            ' Mostrar el cuadro de diálogo de confirmación
            Dim result As DialogResult = MessageBox.Show($"¿Estás seguro de que deseas revertir el procesamiento del libro '{bookName}' para el estudiante '{studentName}'?", "Confirmar Reversión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Using context As New LibraryDbContext()
                    ' Buscar el registro de BookReturn correspondiente
                    Dim bookReturn = context.BookReturns.FirstOrDefault(Function(br) br.Student.Name = studentName AndAlso br.BookName = bookName)

                    If bookReturn IsNot Nothing Then
                        ' Restaurar el estado de préstamo usando la fecha original de emisión
                        Dim restoredLoan As New LoanProcess With {
                        .StudentId = bookReturn.StudentId,
                        .BookId = bookReturn.BookId,
                        .BookName = bookReturn.BookName,
                        .IssuedDate = bookReturn.IssuedDate ' Mantener la fecha de emisión original
                    }

                        ' Añadir el nuevo registro de préstamo
                        context.LoanProcesses.Add(restoredLoan)

                        ' Eliminar el registro de BookReturn ya que se está revirtiendo el proceso
                        context.BookReturns.Remove(bookReturn)

                        ' Guardar los cambios en la base de datos
                        context.SaveChanges()

                        ' Recargar el DataGridView para reflejar los cambios
                        LoadBookReturnsTwo()
                        LoadIssuedBooksGrid()

                        MessageBox.Show("El procesamiento del libro ha sido revertido correctamente y ahora está nuevamente prestado.")
                    Else
                        MessageBox.Show("No se encontró el registro del libro retornado para revertir.")
                    End If
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar revertir el procesamiento del libro: " & ex.Message)
        End Try
    End Sub



    Private Sub GenerateFinesReport()
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Using context As New LibraryDbContext()
                Dim finesReport = context.BookReturns.
            Where(Function(br) br.Fine > 0).
            Select(Function(br) New With {
                br.Student.Name,
                br.BookName,
                br.Fine
            }).ToList()

                Dim totalFine As Decimal = finesReport.Sum(Function(f) f.Fine)

                ' Crear el archivo Excel
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("Multas Generadas")

                    ' Encabezados
                    ws.Cells(1, 1).Value = "Nombre del Estudiante"
                    ws.Cells(1, 2).Value = "Nombre del Libro"
                    ws.Cells(1, 3).Value = "Multa"

                    ' Llenar el Excel con datos
                    Dim row As Integer = 2
                    For Each fine In finesReport
                        ws.Cells(row, 1).Value = fine.Name
                        ws.Cells(row, 2).Value = fine.BookName
                        ws.Cells(row, 3).Value = fine.Fine
                        row += 1
                    Next

                    ' Total de multas
                    ws.Cells(row, 2).Value = "Total Multas:"
                    ws.Cells(row, 3).Value = totalFine

                    ' Cuadro de diálogo para guardar archivo
                    Using saveFileDialog As New SaveFileDialog()
                        saveFileDialog.Filter = "Excel Files|*.xlsx"
                        saveFileDialog.Title = "Guardar Reporte de Multas Generadas"
                        saveFileDialog.FileName = "MultasGeneradas.xlsx"

                        If saveFileDialog.ShowDialog() = DialogResult.OK Then
                            package.SaveAs(New FileInfo(saveFileDialog.FileName))
                            MessageBox.Show("Reporte de multas generadas guardado correctamente.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte de multas generadas: " & ex.Message)
        End Try
    End Sub


    Private Sub GenerateReturnedBooksReport()
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Using context As New LibraryDbContext()
                Dim returnedBooks = context.BookReturns.Select(Function(br) New With {
                br.Student.Name,
                br.BookName,
                br.ReturnDate
            }).ToList()

                ' Crear el archivo Excel
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("Libros Retornados")

                    ' Encabezados
                    ws.Cells(1, 1).Value = "Nombre del Estudiante"
                    ws.Cells(1, 2).Value = "Nombre del Libro"
                    ws.Cells(1, 3).Value = "Fecha de Retorno"

                    ' Llenar el Excel con datos
                    Dim row As Integer = 2
                    For Each returned In returnedBooks
                        ws.Cells(row, 1).Value = returned.Name
                        ws.Cells(row, 2).Value = returned.BookName
                        ws.Cells(row, 3).Value = returned.ReturnDate.ToString("d/M/yyyy")
                        row += 1
                    Next

                    ' Cuadro de diálogo para guardar archivo
                    Using saveFileDialog As New SaveFileDialog()
                        saveFileDialog.Filter = "Excel Files|*.xlsx"
                        saveFileDialog.Title = "Guardar Reporte de Libros Retornados"
                        saveFileDialog.FileName = "LibrosRetornados.xlsx"

                        If saveFileDialog.ShowDialog() = DialogResult.OK Then
                            package.SaveAs(New FileInfo(saveFileDialog.FileName))
                            MessageBox.Show("Reporte de libros retornados guardado correctamente.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte de libros retornados: " & ex.Message)
        End Try
    End Sub




    Private Sub GenerateLoanedBooksReport()
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Using context As New LibraryDbContext()
                Dim loanedBooks = context.LoanProcesses.Select(Function(l) New With {
                l.Student.Name,
                l.BookName,
                l.IssuedDate
            }).ToList()

                ' Crear el archivo Excel
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add("Libros Prestados")

                    ' Encabezados
                    ws.Cells(1, 1).Value = "Nombre del Estudiante"
                    ws.Cells(1, 2).Value = "Nombre del Libro"
                    ws.Cells(1, 3).Value = "Fecha de Préstamo"

                    ' Llenar el Excel con datos
                    Dim row As Integer = 2
                    For Each loan In loanedBooks
                        ws.Cells(row, 1).Value = loan.Name
                        ws.Cells(row, 2).Value = loan.BookName
                        ws.Cells(row, 3).Value = loan.IssuedDate.ToString("d/M/yyyy")
                        row += 1
                    Next

                    ' Cuadro de diálogo para guardar archivo
                    Using saveFileDialog As New SaveFileDialog()
                        saveFileDialog.Filter = "Excel Files|*.xlsx"
                        saveFileDialog.Title = "Guardar Reporte de Libros Prestados"
                        saveFileDialog.FileName = "LibrosPrestados.xlsx"

                        If saveFileDialog.ShowDialog() = DialogResult.OK Then
                            package.SaveAs(New FileInfo(saveFileDialog.FileName))
                            MessageBox.Show("Reporte de libros prestados guardado correctamente.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte de libros prestados: " & ex.Message)
        End Try
    End Sub




    Private Sub ProcessBookReturn()
        Try
            ' Verificar si se ha seleccionado una fila en el DataGridView
            If grdBooksIssuedTracked.SelectedRows.Count > 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = grdBooksIssuedTracked.SelectedRows(0)

                ' Obtener los valores de las celdas de la fila seleccionada
                Dim studentName As String = selectedRow.Cells("StudentName").Value.ToString()
                Dim bookName As String = selectedRow.Cells("BookName").Value.ToString()
                Dim issuedDate As DateTime = DateTime.Parse(selectedRow.Cells("IssuedDate").Value.ToString())

                ' Mostrar mensaje de confirmación
                Dim result As DialogResult = MessageBox.Show($"¿Desea procesar el retorno del libro '{bookName}' prestado a '{studentName}'?",
                                                         "Confirmar Retorno",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Using context As New LibraryDbContext()
                        Using dbContextTransaction = context.Database.BeginTransaction()
                            Try
                                ' Obtener el StudentId a partir del nombre del estudiante
                                Dim student = context.Students.FirstOrDefault(Function(s) s.Name = studentName)
                                If student Is Nothing Then
                                    MessageBox.Show("Estudiante no encontrado.")
                                    Return
                                End If

                                ' Buscar el préstamo correspondiente
                                Dim loan = context.LoanProcesses.
                                Where(Function(l) l.StudentId = student.StudentId AndAlso l.BookName = bookName).
                                OrderByDescending(Function(l) l.IssuedDate).
                                FirstOrDefault()

                                If loan Is Nothing Then
                                    MessageBox.Show("No se encontró un préstamo activo para este libro y estudiante.")
                                    Return
                                End If

                                ' Crear un nuevo registro de retorno
                                Dim bookReturn As New BookReturn With {
                                .StudentId = student.StudentId,
                                .BookName = loan.BookName,
                                .ReturnDate = DateTime.Now,
                                .Fine = 0, ' Puedes calcular la multa si es necesario
                                .IssuedDate = loan.IssuedDate
                            }

                                ' Actualizar el estado del libro (suponiendo que tienes una propiedad `Quantity` en la entidad Book)
                                Dim book = context.Books.FirstOrDefault(Function(b) b.Book_Id = loan.BookId)
                                If book IsNot Nothing Then
                                    book.Quantity += 1
                                End If

                                ' Agregar el registro de retorno a la base de datos
                                context.BookReturns.Add(bookReturn)

                                ' Eliminar el registro del préstamo
                                context.LoanProcesses.Remove(loan)

                                ' Guardar cambios en la base de datos
                                context.SaveChanges()

                                ' Confirmar la transacción
                                dbContextTransaction.Commit()

                                MessageBox.Show("El libro ha sido procesado como retornado correctamente.")

                                ' Recargar los datos en los grids
                                LoadBookReturnsTwo()
                                LoadIssuedBooksGrid()

                            Catch ex As Exception
                                ' Si ocurre un error, revertir la transacción
                                dbContextTransaction.Rollback()
                                Throw
                            End Try
                        End Using
                    End Using
                End If
            Else
                MessageBox.Show("Por favor, seleccione una fila para procesar el retorno.")
            End If
        Catch ex As DbUpdateException
            ' Captura la excepción interna
            Dim sqlException = TryCast(ex.InnerException, SqlException)

            If sqlException IsNot Nothing Then
                ' Imprime el mensaje de error SQL
                MessageBox.Show("Error SQL: " & sqlException.Message)
                Console.WriteLine($"Código de Error SQL: {sqlException.Number}")
            Else
                ' Imprime el mensaje de error genérico
                MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
                Console.WriteLine($"Detalles de la excepción: {ex.ToString()}")
            End If
        Catch ex As Exception
            ' Loguear detalles del error genérico
            MessageBox.Show("Error al procesar el retorno del libro: " & ex.Message)
        End Try
    End Sub



    Private Sub btnLoanReport_Click(sender As Object, e As EventArgs) Handles btnLoanReport.Click
        GenerateLoanedBooksReport()
    End Sub

    Private Sub btnLoanReturns_Click(sender As Object, e As EventArgs) Handles btnLoanReturns.Click
        GenerateReturnedBooksReport()
    End Sub

    Private Sub btnFinesReport_Click(sender As Object, e As EventArgs) Handles btnFinesReport.Click
        GenerateFinesReport()
    End Sub

    Private Sub btnDtaProcess_Click(sender As Object, e As EventArgs) Handles btnDtaProcess.Click
        ProcessBookReturn()
    End Sub




    Private Sub grdReturnedBooks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBooksReturned.CellDoubleClick
        Try
            ' Verificar que se haya hecho doble clic en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = grdBooksReturned.Rows(e.RowIndex)

                ' Obtener los valores de las celdas de la fila seleccionada
                Dim studentName As String = selectedRow.Cells("StudentName").Value.ToString()
                Dim bookName As String = selectedRow.Cells("BookName").Value.ToString()
                Dim fine As Decimal = Decimal.Parse(selectedRow.Cells("Fine").Value.ToString())

                ' Llenar los campos con la información de la fila seleccionada
                cmbStudentName.Text = studentName
                txtBookName.Text = bookName
                txtBookFine.Text = fine.ToString("C") ' Formatea el valor de la multa como moneda
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub


End Class

