Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Pass the panel into constructor and the control will be turned into a touch scrollable control.
''' </summary>
Public Class TouchScroll
    Private mouseDownPoint As Point
    Private parentPanel As Panel

    '''<summary>
    '''pass in the panel you would like to be touch scrollable and it will be handled here.
    '''</summary>
    '''<param name="panel">The root panel you need to scroll with</param>
    Public Sub New(panel As Panel)
        parentPanel = panel
        AssignEvent(panel)
    End Sub

    Private Sub AssignEvent(control As Control)
        AddHandler control.MouseDown, AddressOf MouseDown
        AddHandler control.MouseMove, AddressOf MouseMove
        For Each child As Control In control.Controls
            AssignEvent(child)
        Next
    End Sub

    Private Sub MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then Me.mouseDownPoint = Cursor.Position
    End Sub

    Private Sub MouseMove(sender As Object, e As MouseEventArgs)
        If (e.Button <> MouseButtons.Left) Then Return

        Dim pointDifference = New Point(Cursor.Position.X - mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y)

        If mouseDownPoint.X = Cursor.Position.X AndAlso mouseDownPoint.Y = Cursor.Position.Y Then Return

        Dim currAutoS = parentPanel.AutoScrollPosition
        parentPanel.AutoScrollPosition = New Point(Math.Abs(currAutoS.X) - pointDifference.X, Math.Abs(currAutoS.Y) - pointDifference.Y)
        mouseDownPoint = Cursor.Position
    End Sub
End Class
