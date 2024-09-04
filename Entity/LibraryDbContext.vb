Imports System.Data.Entity

Namespace Entity
    Public Class LibraryDbContext
        Inherits DbContext


        Public Property Students As DbSet(Of Student)
        Public Property Users As DbSet(Of User)
        Public Property BookIssues As DbSet(Of BookIssue)
        Public Property Librarians As DbSet(Of Librarian)
        Public Property Books As DbSet(Of Book)
        Public Property BookReturns As DbSet(Of BookReturn)
        Public Property Semesters As DbSet(Of Semester)
        Public Property LoanProcesses As DbSet(Of LoanProcess)



        Public Sub New()
            MyBase.New("name=LibraryDbContext")
            Me.Configuration.LazyLoadingEnabled = False
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            ' Configuración para la tabla Student
            modelBuilder.Entity(Of Student)() _
                .ToTable("Student") _
                .HasKey(Function(s) s.StudentId)

            ' Configuración para la tabla User
            modelBuilder.Entity(Of User)() _
                .ToTable("User") _
                .HasKey(Function(u) u.UserId)

            ' Configuración para la tabla BookIssue
            modelBuilder.Entity(Of BookIssue)() _
            .ToTable("Books_Issue_Table") _
            .HasKey(Function(b) b.IssueId) _
            .HasRequired(Function(b) b.Student) _
            .WithMany(Function(s) s.BookIssues) _
            .HasForeignKey(Function(b) b.StudentId) _
            .WillCascadeOnDelete(False)

            ' Configuración de nombres de columnas usando atributos en la clase BookIssue
            modelBuilder.Entity(Of BookIssue)().Property(Function(b) b.BookName).HasColumnName("Book_Name")
            modelBuilder.Entity(Of BookIssue)().Property(Function(b) b.BookId).HasColumnName("Book_Id")
            modelBuilder.Entity(Of BookIssue)().Property(Function(b) b.IssuedDate).HasColumnName("Issued_Date")


            ' Configuración para la tabla Librarian
            modelBuilder.Entity(Of Librarian)() _
                .ToTable("Librarians") _
                .HasKey(Function(l) l.LibrarianId)

            ' Configuración para la tabla Book
            modelBuilder.Entity(Of Book)() _
                .ToTable("Books") _
                .HasKey(Function(b) b.Book_Id)

            ' Configuración para la tabla BookReturn
            modelBuilder.Entity(Of BookReturn)() _
            .ToTable("Book_Returned") _
            .HasKey(Function(b) b.ReturnId) _
            .HasRequired(Function(b) b.Student) _
            .WithMany(Function(s) s.BookReturns) _
            .HasForeignKey(Function(b) b.StudentId) _
            .WillCascadeOnDelete(False)

            ' Configuración de columnas específicas
            modelBuilder.Entity(Of BookReturn)() _
                .Property(Function(b) b.BookId) _
                .HasColumnName("Book_Id")

            modelBuilder.Entity(Of BookReturn)() _
                .Property(Function(b) b.BookName) _
                .HasColumnName("Book_Name")

            modelBuilder.Entity(Of BookReturn)() _
                .Property(Function(b) b.ReturnDate) _
                .HasColumnName("Return_Date")

            modelBuilder.Entity(Of BookReturn)() _
                .Property(Function(b) b.IssuedDate) _
                .HasColumnName("Issued_Date")


            modelBuilder.Entity(Of Semester)() _
                .ToTable("Semester") _
                .HasKey(Function(s) s.SemesterId)


            modelBuilder.Entity(Of BookReturn)() _
                .HasRequired(Function(b) b.Book) _
                .WithMany(Function(bk) bk.BookReturns) _
                .HasForeignKey(Function(b) b.BookId) _
                .WillCascadeOnDelete(False) ' Evita la eliminación en cascada

            ' Configuración para la tabla LoanProcess
            modelBuilder.Entity(Of LoanProcess)() _
            .ToTable("Loans_Process") _
            .HasKey(Function(l) l.LoanID) _
            .HasRequired(Function(l) l.Student) _
            .WithMany(Function(s) s.LoanProcesses) _
            .HasForeignKey(Function(l) l.StudentId) _
            .WillCascadeOnDelete(False) ' Evita la eliminación en cascada

            ' Configuración de columnas
            modelBuilder.Entity(Of LoanProcess)() _
            .Property(Function(l) l.BookName) _
            .HasColumnName("Book_Name")

            modelBuilder.Entity(Of LoanProcess)() _
            .Property(Function(l) l.BookId) _
            .HasColumnName("Book_Id")

            modelBuilder.Entity(Of LoanProcess)() _
            .Property(Function(l) l.IssuedDate) _
            .HasColumnName("Issued_Date")
        End Sub
    End Class
End Namespace
