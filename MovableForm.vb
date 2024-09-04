Public Class MovableForm
    Inherits Form

    ' Definir variables para el movimiento del formulario
    Private isDragging As Boolean = False
    Private startPoint As Point = New Point(0, 0)

    ' Código para mover el formulario
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        isDragging = False
    End Sub
End Class
