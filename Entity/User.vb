Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class User
        ' Define la clave primaria
        <Key>
        Public Property UserId As Integer

        ' Propiedades de la tabla
        <Required>
        <StringLength(50)>
        Public Property Username As String

        <Required>
        <StringLength(255)>
        Public Property Password As String

        Public Property IsAdmin As Boolean

        ' Navegación hacia otras entidades si es necesario
    End Class
End Namespace
