Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class Book
        ' Define la clave primaria
        <Key>
        Public Property Book_Id As Integer

        ' Propiedades de la tabla
        <Required>
        Public Property Name As String

        Public Property Author As String

        Public Property Publisher As String

        Public Property Price As Decimal?

        Public Property Quantity As Integer?

        ' Navegación hacia otras entidades
        Public Overridable Property BookIssues As ICollection(Of BookIssue)
        Public Overridable Property BookReturns As ICollection(Of BookReturn)
    End Class
End Namespace
