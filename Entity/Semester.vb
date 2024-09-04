Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class Semester
        ' Define la clave primaria
        <Key>
        Public Property SemesterId As Integer

        ' Propiedades de la tabla
        <Required>
        Public Property Name As String

        <Required>
        Public Property SemesterYear As Integer

        <Required>
        Public Property Department As String

        <Required>
        Public Property Career As String
    End Class
End Namespace
