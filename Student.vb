Imports Lib_Soft.Entity
Imports System.Data.Entity.Infrastructure
Imports Entity

Public Class Student
    Private Sub pictureboxCloseIcon_Click(sender As Object, e As EventArgs) Handles pictureboxCloseIcon.Click
        ' Mostrar un modal de confirmación
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If result = DialogResult.Yes Then
            ' Si el usuario confirma, cerrar la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub btnStudentGoBack_Click(sender As Object, e As EventArgs) Handles btnStudentGoBack.Click
        Dim mainForm = New MainForm()

        mainForm.Show()

        Me.Hide()
    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdstudent.ClearSelection()
        ' Limpiar los campos del formulario y ponerlos en solo lectura
        ClearFormFields()
        SetReadOnly(False)
        ' Cargar los datos de estudiantes
        LoadStudentData()
        LoadSemesterNames()
    End Sub




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
    Private Sub txtOnlyLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyLetters.KeyPress, txtStudentName.KeyPress, txtStudentDepartment.KeyPress
        ' Verifica si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten letras en este campo")

            e.Handled = True
        End If
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyNumbers
    Private Sub txtOnlyNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyNumbers.KeyPress, txtStudentPhone.KeyPress
        ' Verifica si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, se cancela el evento (evita la entrada)
            MessageBox.Show("Solo se admiten numeros en este campo")

            e.Handled = True
        End If
    End Sub


    Private Sub LoadSemesterNames()
        Try
            Using context As New LibraryDbContext()
                ' Obtener todos los semestres de la base de datos
                Dim semesters = context.Semesters.ToList()

                ' Limpiar el ComboBox antes de llenarlo
                cmbSemester.Items.Clear()

                ' Llenar el ComboBox con los nombres de los semestres en el formato deseado
                For Each semester In semesters
                    Dim formattedName As String = $"{semester.Name}_{semester.SemesterYear}"
                    cmbSemester.Items.Add(formattedName)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los semestres: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SetReadOnly(isReadOnly As Boolean)
        txtStudentName.Enabled = Not isReadOnly
        txtStudentDepartment.Enabled = Not isReadOnly
        txtStudentPhone.Enabled = Not isReadOnly
        cmbSemester.Enabled = Not isReadOnly
        btnEditStudent.Enabled = Not isReadOnly
        btnEditStudent.Enabled = Not isReadOnly
    End Sub

    Private Sub grdstudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdstudent.CellContentClick

    End Sub
    Private Sub grdstudent_DoubleClick(sender As Object, e As EventArgs) Handles grdstudent.DoubleClick
        ' Verificar si hay una fila seleccionada en el DataGridView
        If grdstudent.SelectedRows.Count > 0 Then
            ' Poblar los campos solo al hacer doble clic en una fila
            Dim selectedRow As DataGridViewRow = grdstudent.SelectedRows(0)
            Dim studentId As Integer = Convert.ToInt32(selectedRow.Cells("StudentId").Value)

            ' Buscar el estudiante en la base de datos y poblar los campos
            Using context As New Entity.LibraryDbContext()
                Dim selectedStudent As Entity.Student = context.Students.Find(studentId)

                If selectedStudent IsNot Nothing Then
                    txtStudentName.Texts = selectedStudent.Name
                    txtStudentDepartment.Texts = selectedStudent.Department
                    txtStudentPhone.Texts = selectedStudent.Phone
                    cmbSemester.SelectedItem = selectedStudent.Semester.ToString()

                    ' Habilitar los campos para edición
                    SetReadOnly(False)
                End If
            End Using
        End If
    End Sub
    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Try
            ' Obtener y validar la entrada de datos
            Dim studentNameOriginal As String = txtStudentName.Texts.Trim()
            Dim studentDepartment As String = txtStudentDepartment.Texts.Trim()
            Dim studentPhone As String = txtStudentPhone.Texts.Trim()
            Dim studentSemester As String = cmbSemester.SelectedItem?.ToString()

            ' Validaciones de entrada
            If String.IsNullOrWhiteSpace(studentNameOriginal) Then
                Throw New ArgumentException("El nombre del estudiante no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(studentDepartment) Then
                Throw New ArgumentException("El departamento del estudiante no puede estar vacío.")
            End If
            If String.IsNullOrWhiteSpace(studentPhone) OrElse Not IsNumeric(studentPhone) OrElse studentPhone.Length < 10 Then
                Throw New ArgumentException("El teléfono debe ser un número válido y tener al menos 10 dígitos.")
            End If
            If String.IsNullOrWhiteSpace(studentSemester) Then
                Throw New ArgumentException("Debes seleccionar un semestre.")
            End If

            Using context As New Entity.LibraryDbContext()
                ' Verificar si el estudiante ya existe
                Dim existingStudent As Entity.Student = context.Students.FirstOrDefault(Function(s) s.Name = studentNameOriginal AndAlso s.Phone = studentPhone)

                If existingStudent IsNot Nothing Then
                    Throw New ArgumentException("El estudiante con el mismo nombre y teléfono ya existe.")
                End If

                ' Guardar el nuevo estudiante
                Dim newStudent As New Entity.Student() With {
                .Name = studentNameOriginal,
                .Department = studentDepartment,
                .Semester = studentSemester,  ' Semester es ahora un string
                .Phone = studentPhone
            }

                context.Students.Add(newStudent)
                context.SaveChanges()
            End Using

            ' Limpiar y habilitar los campos después de guardar
            LoadStudentData()
            ClearFormFields()
            MessageBox.Show("Estudiante agregado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Se produjo un error: " & ex.Message)
        End Try
    End Sub




    Private Sub ClearFormFields()
        txtStudentName.Texts = ""
        txtStudentDepartment.Texts = ""
        txtStudentPhone.Texts = ""
        cmbSemester.SelectedIndex = -1
        SetReadOnly(False)
    End Sub
    Private Sub LoadStudentData()
        Try
            ' Crear una instancia del contexto de Entity Framework
            Using context As New LibraryDbContext()
                ' Consultar todos los estudiantes
                Dim students = context.Students.ToList()

                ' Limpiar cualquier columna existente
                grdstudent.Columns.Clear()

                ' Crear y agregar columnas al DataGridView
                Dim columnId As New DataGridViewTextBoxColumn With {
                .Name = "StudentId",
                .HeaderText = "ID Estudiante",
                .DataPropertyName = "StudentId",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

                Dim columnName As New DataGridViewTextBoxColumn With {
                .Name = "Name",
                .HeaderText = "Nombre",
                .DataPropertyName = "Name",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

                Dim columnDepartment As New DataGridViewTextBoxColumn With {
                .Name = "Department",
                .HeaderText = "Departamento",
                .DataPropertyName = "Department",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

                Dim columnPhone As New DataGridViewTextBoxColumn With {
                .Name = "Phone",
                .HeaderText = "Teléfono",
                .DataPropertyName = "Phone",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

                Dim columnSemester As New DataGridViewTextBoxColumn With {
                .Name = "Semester",
                .HeaderText = "Semestre",
                .DataPropertyName = "Semester",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

                ' Agregar las columnas al DataGridView
                grdstudent.Columns.AddRange(New DataGridViewColumn() {columnId, columnName, columnDepartment, columnPhone, columnSemester})

                ' Asignar los datos al DataGridView
                grdstudent.DataSource = students

                ' Deseleccionar cualquier fila seleccionada
                grdstudent.ClearSelection()

            End Using

        Catch ex As Exception
            ' Manejar cualquier error que ocurra durante la carga de datos
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub OnDataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        ' Configurar los encabezados de las columnas
        Dim dgv As DataGridView = CType(sender, DataGridView)
        dgv.Columns("StudentId").HeaderText = "ID Estudiante"
        dgv.Columns("Name").HeaderText = "Nombre"
        dgv.Columns("Department").HeaderText = "Departamento"
        dgv.Columns("Phone").HeaderText = "Teléfono"
        dgv.Columns("Semester").HeaderText = "Semestre"

        ' Desvincular el manejador para evitar configuraciones repetidas
        RemoveHandler dgv.DataBindingComplete, AddressOf OnDataBindingComplete
    End Sub



    Private Sub grdstudent_SelectionChanged(sender As Object, e As EventArgs) Handles grdstudent.SelectionChanged
        ' Este evento no pobla los campos, solo habilita los botones si es necesario
        If grdstudent.SelectedRows.Count > 0 Then
            btnEditStudent.Enabled = True
        Else
            btnEditStudent.Enabled = False
        End If
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If grdstudent.SelectedRows.Count > 0 Then
            ' Confirmar la edición
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Obtener el ID del estudiante seleccionado
                Dim selectedRow As DataGridViewRow = grdstudent.SelectedRows(0)
                Dim studentId As Integer = Convert.ToInt32(selectedRow.Cells("StudentId").Value)

                ' Actualizar el estudiante en la base de datos
                Try
                    Using context As New Entity.LibraryDbContext()
                        ' Buscar el estudiante por ID
                        Dim studentToUpdate As Entity.Student = context.Students.Find(studentId)

                        If studentToUpdate IsNot Nothing Then
                            ' Verificar si ya existe un estudiante con el mismo nombre
                            Dim existingStudent As Entity.Student = context.Students.FirstOrDefault(Function(s) s.Name = txtStudentName.Texts.Trim() AndAlso s.StudentId <> studentId)

                            If existingStudent IsNot Nothing Then
                                MessageBox.Show("Un estudiante con este nombre ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Verificar si los datos han cambiado
                            If studentToUpdate.Name = txtStudentName.Texts.Trim() AndAlso
                           studentToUpdate.Department = txtStudentDepartment.Texts.Trim() AndAlso
                           studentToUpdate.Phone = txtStudentPhone.Texts.Trim() AndAlso
                           studentToUpdate.Semester = cmbSemester.SelectedItem.ToString() Then
                                MessageBox.Show("No se han detectado cambios en los datos del estudiante.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return
                            End If

                            ' Actualizar los datos del estudiante
                            studentToUpdate.Name = txtStudentName.Texts.Trim()
                            studentToUpdate.Department = txtStudentDepartment.Texts.Trim()
                            studentToUpdate.Phone = txtStudentPhone.Texts.Trim()
                            studentToUpdate.Semester = cmbSemester.SelectedItem.ToString()

                            ' Guardar los cambios en la base de datos
                            context.SaveChanges()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Estudiante actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Actualizar el DataGridView
                            LoadStudentData()
                        Else
                            MessageBox.Show("El estudiante seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Se produjo un error al intentar actualizar al estudiante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Por favor, seleccione un estudiante para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnStudentReset_Click(sender As Object, e As EventArgs) Handles btnStudentReset.Click
        ClearFormFields()
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If grdstudent.SelectedRows.Count > 0 Then
            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar al estudiante seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Obtener el ID del estudiante seleccionado
                Dim selectedRow As DataGridViewRow = grdstudent.SelectedRows(0)
                Dim studentId As Integer = Convert.ToInt32(selectedRow.Cells("StudentId").Value)

                ' Eliminar el estudiante de la base de datos
                Try
                    Using context As New Entity.LibraryDbContext()
                        ' Buscar el estudiante por ID
                        Dim studentToDelete As Entity.Student = context.Students.Find(studentId)

                        If studentToDelete IsNot Nothing Then
                            ' Eliminar el estudiante
                            context.Students.Remove(studentToDelete)
                            context.SaveChanges()

                            ' Mostrar mensaje de éxito
                            MessageBox.Show("Estudiante eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Actualizar el DataGridView
                            LoadStudentData()
                        Else
                            MessageBox.Show("El estudiante seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Se produjo un error al intentar eliminar al estudiante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Por favor, seleccione un estudiante para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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