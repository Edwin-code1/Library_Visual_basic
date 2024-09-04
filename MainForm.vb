Imports Lib_Soft.Entity

Public Class MainForm
    Private Sub RjCircularPictureBox1_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox1.Click
        Dim studentForm As New Student() ' Corrected instantiation syntax

        studentForm.Show()

        Me.Hide() ' Hides the current form
    End Sub

    Private Sub RjCircularPictureBox2_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox2.Click
        Dim BooksForm As New Books() ' Corrected instantiation syntax

        BooksForm.Show()

        Me.Hide() ' Hides the current form
    End Sub

    Private Sub RjCircularPictureBox3_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox3.Click
        Dim BookIssueForm As New IssueBook()

        BookIssueForm.Show()

        Me.Hide() ' Hides the current form
    End Sub

    Private Sub RjCircularPictureBox4_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox4.Click

        Dim BookReturnForm As New BookReturns()

        BookReturnForm.Show()

        Me.Hide() ' Hides the current form
    End Sub

    Private Sub UserMenu_Click(sender As Object, e As EventArgs) Handles UserMenu.Click
        Dim UsersPage = New UsersTable()

        UsersPage.Show()

        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RjCircularPictureBox5_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox5.Click
        Dim librarians = New Librarians()

        librarians.Show()
        Me.Hide()
    End Sub

    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles BackGo.Click
        Dim loginForm = New Login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub BackRegister_Click(sender As Object, e As EventArgs) Handles BackRegister.Click
        Dim registerForm = New Register()

        registerForm.Show()

        Me.Hide()
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

    Private Sub RjCircularPictureBox6_Click(sender As Object, e As EventArgs) Handles AddSemester.Click
        Dim SemesterForm = New SemesterCreate()
        SemesterForm.Show()
        Me.Hide()
    End Sub

    Private Sub SeeDashboard_Click(sender As Object, e As EventArgs) Handles SeeDashboard.Click
        Dim Dashboard = New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class