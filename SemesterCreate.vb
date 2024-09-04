Imports Lib_Soft.Entity

Public Class SemesterCreate

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
    Private Sub txtOnlyLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyLetters.KeyPress, txtSemester.KeyPress, txtDepartment.KeyPress, txtCareer.KeyPress
        ' Verifica si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es una letra ni una tecla de control, se cancela el evento (evita la entrada)

            MessageBox.Show("Solo se admiten letras en este campo")

            e.Handled = True
        End If
    End Sub

    ' Este método maneja el evento KeyPress para txtOnlyNumbers
    Private Sub txtOnlyNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnlyNumbers.KeyPress, txtYear.KeyPress
        ' Verifica si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, se cancela el evento (evita la entrada)

            MessageBox.Show("Solo se admiten numeros en este campo")

            e.Handled = True
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



    Private Sub btnSaveSemester_Click(sender As Object, e As EventArgs) Handles btnSaveSemester.Click
        Try
            ' Verificar que todos los campos necesarios estén llenos
            If String.IsNullOrWhiteSpace(txtSemester.Texts) OrElse
           String.IsNullOrWhiteSpace(txtYear.Texts) OrElse
           String.IsNullOrWhiteSpace(txtDepartment.Texts) OrElse
           String.IsNullOrWhiteSpace(txtCareer.Texts) Then
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Intentar convertir el año a un entero
            Dim semesterYear As Integer
            If Not Integer.TryParse(txtYear.Texts, semesterYear) Then
                MessageBox.Show("El año del semestre debe ser un número entero válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using context As New Entity.LibraryDbContext()
                If txtSemester.Tag Is Nothing Then
                    ' Verificar si ya existe un semestre con el mismo nombre y año
                    Dim existingSemester = context.Semesters.FirstOrDefault(Function(s) s.Name = txtSemester.Texts AndAlso s.SemesterYear = semesterYear)
                    If existingSemester IsNot Nothing Then
                        MessageBox.Show("Ya existe un semestre con el mismo nombre y año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Crear un nuevo semestre
                    Dim newSemester As New Entity.Semester() With {
                    .Name = txtSemester.Texts,
                    .SemesterYear = semesterYear, ' Guardar como entero
                    .Department = txtDepartment.Texts,
                    .Career = txtCareer.Texts
                }
                    context.Semesters.Add(newSemester)
                    MessageBox.Show("Semestre guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Editar un semestre existente
                    Dim semesterId As Integer = CInt(txtSemester.Tag)
                    Dim existingSemester = context.Semesters.FirstOrDefault(Function(s) s.SemesterId = semesterId)
                    If existingSemester IsNot Nothing Then
                        ' Verificar si los datos han cambiado
                        If existingSemester.Name = txtSemester.Texts AndAlso
                       existingSemester.SemesterYear = semesterYear AndAlso
                       existingSemester.Department = txtDepartment.Texts AndAlso
                       existingSemester.Career = txtCareer.Texts Then
                            MessageBox.Show("No se han realizado cambios en el semestre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        existingSemester.Name = txtSemester.Texts
                        existingSemester.SemesterYear = semesterYear ' Actualizar como entero
                        existingSemester.Department = txtDepartment.Texts
                        existingSemester.Career = txtCareer.Texts
                        MessageBox.Show("Semestre actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Semestre no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                ' Guardar los cambios en la base de datos
                context.SaveChanges()
                ClearSemesterFormFields()
                LoadSemesters()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar el semestre: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub









    Private Sub ClearSemesterFormFields()
        txtSemester.Texts = ""
        txtYear.Texts = ""
        txtDepartment.Texts = ""
        txtCareer.Texts = ""
    End Sub


    Private Sub LoadSemesters()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la lista de semestres desde la base de datos
                Dim semesters = context.Semesters.ToList()

                ' Configurar el DataGridView
                grdSemester.DataSource = semesters
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los semestres: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SemesterCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEditSemester.Enabled = False

        LoadSemesters()
    End Sub
    Private Sub btnDeleteSemester_Click(sender As Object, e As EventArgs) Handles btnDeleteSemester.Click
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If grdSemester.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un semestre de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el semestre seleccionado
            Dim selectedRow As DataGridViewRow = grdSemester.SelectedRows(0)
            Dim semesterId As Integer = CInt(selectedRow.Cells("SemesterId").Value)
            Dim semesterName As String = selectedRow.Cells("Name").Value.ToString()

            ' Preguntar si el administrador realmente desea eliminar el semestre
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el semestre '" & semesterName & "'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Eliminar el semestre de la base de datos
                Using context As New Entity.LibraryDbContext()
                    Dim semester = context.Semesters.FirstOrDefault(Function(s) s.SemesterId = semesterId)
                    If semester IsNot Nothing Then
                        context.Semesters.Remove(semester)
                        context.SaveChanges()
                        MessageBox.Show("Semestre eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Recargar la lista de semestres en el DataGridView
                        LoadSemesters()
                    Else
                        MessageBox.Show("Semestre no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar eliminar el semestre: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearSemesterFormFields()
    End Sub


    Private Sub btnEditSemester_Click(sender As Object, e As EventArgs) Handles btnEditSemester.Click
        Try
            ' Verificar que haya una fila seleccionada
            If grdSemester.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un semestre para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtener el semestre seleccionado
            Dim selectedRow As DataGridViewRow = grdSemester.SelectedRows(0)
            Dim semesterId As Integer = CInt(selectedRow.Cells("SemesterId").Value)
            Dim semesterName As String = selectedRow.Cells("Name").Value.ToString()
            Dim semesterYear As Integer = CInt(selectedRow.Cells("SemesterYear").Value)
            Dim department As String = selectedRow.Cells("Department").Value.ToString()
            Dim career As String = selectedRow.Cells("Career").Value.ToString()

            ' Mostrar los datos del semestre en los campos de texto para edición
            txtSemester.Texts = semesterName
            txtYear.Texts = semesterYear.ToString()
            txtDepartment.Texts = department
            txtCareer.Texts = career

            ' Cambiar el texto del botón a "Guardar" o algo similar
            btnSaveSemester.Text = "Save"
            ' Agregar un campo oculto para saber si estamos editando o agregando
            txtSemester.Tag = semesterId
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar cargar los datos del semestre: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub grdSemester_SelectionChanged(sender As Object, e As EventArgs) Handles grdSemester.SelectionChanged
        ' Habilitar el botón de editar si hay una fila seleccionada
        btnEditSemester.Enabled = grdSemester.SelectedRows.Count > 0
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class