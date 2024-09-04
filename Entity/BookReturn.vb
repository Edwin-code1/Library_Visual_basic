Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class BookReturn
        ' Define la clave primaria
        <Key>
        Public Property ReturnId As Integer

        ' Define las claves foráneas
        <ForeignKey("Student")>
        Public Property StudentId As Integer

        <Column("Name")>
        Public Property Name As String

        <ForeignKey("Book")>
        Public Property BookId As Integer

        ' Propiedades de la tabla con nombres de columna específicos
        <Column("Book_Name")>
        Public Property BookName As String

        <Column("Return_Date")>
        Public Property ReturnDate As Date

        <Column("Issued_Date")>
        Public Property IssuedDate As Date

        Public Property Fine As Decimal?

        ' Navegación hacia las entidades Student y Book
        Public Overridable Property Student As Student
        Public Overridable Property Book As Book
    End Class
End Namespace
