Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class Librarian
        ' Define la clave primaria
        <Key>
        Public Property LibrarianId As Integer

        ' Propiedades de la tabla
        <Required>
        Public Property Name As String

        Public Property Phone As String

        <Required>
        Public Property Password As String

        ' Navegación hacia otras entidades si es necesario
    End Class
End Namespace
