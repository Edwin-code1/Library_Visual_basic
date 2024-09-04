Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class LoanProcess
        ' Define la clave primaria
        <Key>
        Public Property LoanID As Integer

        ' Define la clave foránea
        <ForeignKey("Student")>
        Public Property StudentId As Integer

        ' Propiedades de la tabla con nombres de columna correctos
        <Column("Book_Name")>
        Public Property BookName As String

        <Column("Book_Id")>
        Public Property BookId As Integer

        <Column("Issued_Date")>
        Public Property IssuedDate As Date

        ' Navegación hacia la entidad Student
        Public Overridable Property Student As Student
    End Class
End Namespace
