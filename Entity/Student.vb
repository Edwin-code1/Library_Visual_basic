Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entity
    Public Class Student
        ' Define la clave primaria
        <Key>
        Public Property StudentId As Integer

        ' Propiedades de la tabla
        <Required>
        Public Property Name As String

        Public Property Department As String

        Public Property Semester As String

        Public Property Phone As String

        ' Navegación hacia otras entidades
        Public Overridable Property BookIssues As ICollection(Of BookIssue)
        Public Overridable Property BookReturns As ICollection(Of BookReturn)
        Public Overridable Property LoanProcesses As ICollection(Of LoanProcess)

    End Class
End Namespace
