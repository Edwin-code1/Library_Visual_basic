Imports Lib_Soft.Entity

Public Class Dashboard
    Private Sub btnStudentGoBack_Click(sender As Object, e As EventArgs) Handles btnStudentGoBack.Click
        Dim mainForm = New MainForm()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles dashboardUsers.Click

    End Sub

    Private Sub UpdateUserCount()
        Try
            Using context As New LibraryDbContext()
                ' Obtener la cantidad total de usuarios
                Dim totalUsers As Integer = context.Users.Count()

                ' Mostrar el total en el label
                dashboardUsers.Text = totalUsers.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total de usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUserCount()
        UpdateStudentCount()
        UpdateBooksCount()
        UpdateLibrariansCount()
        UpdateSemesterCount()
        UpdateLoanCount()
        MakeLabelsClickable()
        UpdateReturnsCount()

        lblUsers.Font = New Font(lblUsers.Font, FontStyle.Underline)
        lblStudents.Font = New Font(lblStudents.Font, FontStyle.Underline)
        lblBooks.Font = New Font(lblBooks.Font, FontStyle.Underline)
        lblLibrarians.Font = New Font(lblLibrarians.Font, FontStyle.Underline)
        lblLoans.Font = New Font(lblLoans.Font, FontStyle.Underline)
        lblSemester.Font = New Font(lblSemester.Font, FontStyle.Underline)
        lblReturns.Font = New Font(lblReturns.Font, FontStyle.Underline)

    End Sub

    Private Sub UpdateStudentCount()
        Try
            Using context As New LibraryDbContext()
                ' Obtener la cantidad total de estudiantes
                Dim totalStudents As Integer = context.Students.Count()

                ' Mostrar el total en el label
                dashboardStudent.Text = totalStudents.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total de estudiantes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateBooksCount()
        Try
            Using context As New LibraryDbContext()
                Dim totalBooks As Integer = context.Books.Count()

                dashboardBooks.Text = totalBooks.ToString()
            End Using
        Catch ex As Exception

            MessageBox.Show("Error al obtener los libros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub UpdateLibrariansCount()
        Try
            Using context As New LibraryDbContext()
                Dim TotalLibrarians As Integer = context.Librarians.Count()

                dashboardLibrarians.Text = TotalLibrarians.ToString()

            End Using
        Catch ex As Exception

            MessageBox.Show("Error al obtener los Bibliotecarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub





    Private Sub MakeLabelsClickable()
        ' Cambiar el cursor y aplicar underline a cada label
        Dim labels As Label() = {lblStudents, lblBooks, lblLibrarians, lblLoans, lblSemester, lblReturns, lblUsers}

        For Each lbl As Label In labels
            ' Aplicar estilo subrayado
            lbl.Font = New Font(lbl.Font, FontStyle.Underline)
            ' Cambiar el cursor a "Hand" para indicar que es clicable
            lbl.Cursor = Cursors.Hand
            ' Agregar un controlador de eventos para manejar el hover y click
            AddHandler lbl.MouseEnter, AddressOf Label_MouseEnter
            AddHandler lbl.MouseLeave, AddressOf Label_MouseLeave
        Next
    End Sub

    ' Evento para cuando el mouse entra en el label
    Private Sub Label_MouseEnter(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = Color.Blue ' Cambiar color al hacer hover, opcional
    End Sub

    ' Evento para cuando el mouse sale del label
    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.ForeColor = SystemColors.ControlText ' Restaurar color original, opcional
    End Sub



    Private Sub UpdateSemesterCount()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la cantidad total de semestres
                Dim totalSemesters = context.Semesters.Count()

                ' Mostrar el total en el label
                dashboardSemester.Text = totalSemesters.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total de Semestres: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub UpdateLoanCount()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la cantidad total de semestres
                Dim totalLoans = context.LoanProcesses.Count()

                ' Mostrar el total en el label
                dashboardLoans.Text = totalLoans.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total de prestamos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click
        Dim usersTable = New UsersTable()

        usersTable.Show()

        Me.Hide()
    End Sub

    Private Sub lblStudents_Click(sender As Object, e As EventArgs) Handles lblStudents.Click
        Dim studentTable = New Student()

        studentTable.Show()
        Me.Hide()
    End Sub

    Private Sub lblBooks_Click(sender As Object, e As EventArgs) Handles lblBooks.Click
        Dim booksTable = New Books()
        booksTable.Show()
        Me.Hide()
    End Sub

    Private Sub lblLibrarians_Click(sender As Object, e As EventArgs) Handles lblLibrarians.Click
        Dim librariansTable = New Librarians()

        librariansTable.Show()
        Me.Hide()
    End Sub

    Private Sub lblLoans_Click(sender As Object, e As EventArgs) Handles lblLoans.Click
        Dim LoansTable = New IssueBook()

        LoansTable.Show()

        Me.Show()
    End Sub

    Private Sub lblSemester_Click(sender As Object, e As EventArgs) Handles lblSemester.Click
        Dim semesterTable = New SemesterCreate()

        semesterTable.Show()

        Me.Hide()
    End Sub

    Private Sub lblReturns_Click(sender As Object, e As EventArgs) Handles lblReturns.Click
        Dim returnsTable = New BookReturns()

        returnsTable.Show()

        Me.Hide()
    End Sub



    Private Sub UpdateReturnsCount()
        Try
            Using context As New Entity.LibraryDbContext()
                ' Obtener la cantidad total de semestres
                Dim TotalBookReturns = context.BookReturns.Count()

                ' Mostrar el total en el label
                lblBookReturns.Text = TotalBookReturns.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total de prestamos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class