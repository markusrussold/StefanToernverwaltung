Option Explicit On
Option Strict Off

Imports System.Windows.Forms

''' <summary>
''' Centers the main window on screen and opens child windows relative to it.
''' </summary>
Public Module FormUi

    Public Function FindMainForm() As Form
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Menü Then
                Return f
            End If
        Next
        Return Nothing
    End Function

    Public Sub CenterMain(ByVal form As Form)
        If form Is Nothing OrElse form.IsDisposed Then Return
        form.StartPosition = FormStartPosition.Manual
        Dim area As Rectangle = Screen.FromControl(form).WorkingArea
        If form.Width <= 0 OrElse form.Height <= 0 Then
            area = Screen.PrimaryScreen.WorkingArea
        End If
        Dim x As Integer = area.Left + Math.Max(0, (area.Width - form.Width) \ 2)
        Dim y As Integer = area.Top + Math.Max(0, (area.Height - form.Height) \ 2)
        form.Location = New Point(x, y)
    End Sub

    Public Sub PositionOnOwner(ByVal child As Form, ByVal owner As Form)
        If child Is Nothing OrElse owner Is Nothing Then Return
        If child.IsDisposed OrElse owner.IsDisposed Then Return

        child.StartPosition = FormStartPosition.Manual
        Dim x As Integer = owner.Left + (owner.Width - child.Width) \ 2
        Dim y As Integer = owner.Top + (owner.Height - child.Height) \ 2
        Dim area As Rectangle = Screen.FromControl(owner).WorkingArea
        If child.Width > area.Width Then x = area.Left
        If child.Height > area.Height Then y = area.Top
        x = Math.Max(area.Left, Math.Min(x, area.Right - Math.Max(child.Width, 50)))
        y = Math.Max(area.Top, Math.Min(y, area.Bottom - Math.Max(child.Height, 50)))
        child.Location = New Point(x, y)
    End Sub

    Public Sub ShowChild(ByVal child As Form, Optional ByVal owner As Form = Nothing)
        If child Is Nothing OrElse child.IsDisposed Then Return

        Dim main As Form = FindMainForm()
        If owner Is Nothing OrElse owner.IsDisposed Then
            owner = main
        End If
        If owner Is Nothing OrElse owner.IsDisposed Then
            owner = Form.ActiveForm
        End If

        If owner IsNot Nothing AndAlso Not owner.IsDisposed Then
            PositionOnOwner(child, owner)
            If child.Visible Then
                child.BringToFront()
                child.Activate()
            Else
                child.Show(owner)
                PositionOnOwner(child, owner)
            End If
        Else
            child.StartPosition = FormStartPosition.CenterScreen
            If child.Visible Then
                child.BringToFront()
                child.Activate()
            Else
                child.Show()
                CenterMain(child)
            End If
        End If
    End Sub

End Module
