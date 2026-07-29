Option Explicit On
Option Strict On

Imports System.Windows.Forms

''' <summary>Shared validation for MaskedTextBox and common UI inputs.</summary>
Public Module InputValidation

    Public Function IsMaskComplete(ByVal box As MaskedTextBox) As Boolean
        If box Is Nothing Then Return False
        Return box.MaskCompleted
    End Function

    Public Function TryGetDate(ByVal box As MaskedTextBox, ByRef value As Date) As Boolean
        value = Nothing
        If box Is Nothing Then Return False
        If Not box.MaskCompleted Then Return False
        Return SafeData.TryParseMaskedDate(box.Text, value)
    End Function

    Public Function RequireDate(ByVal box As MaskedTextBox, ByVal fieldName As String, ByRef value As Date) As Boolean
        If TryGetDate(box, value) Then Return True
        MessageBox.Show(
            "Bitte ein gültiges Datum für """ & fieldName & """ eingeben (TT.MM.JJJJ).",
            "Eingabe",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
        If box IsNot Nothing Then box.Focus()
        Return False
    End Function

    Public Function RequireNonEmpty(ByVal control As Control, ByVal fieldName As String) As Boolean
        Dim text As String = Nothing
        If TypeOf control Is TextBoxBase Then
            text = DirectCast(control, TextBoxBase).Text
        ElseIf control IsNot Nothing Then
            text = control.Text
        End If
        If Not String.IsNullOrWhiteSpace(text) Then Return True
        MessageBox.Show(
            "Bitte """ & fieldName & """ ausfüllen.",
            "Eingabe",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
        If control IsNot Nothing Then control.Focus()
        Return False
    End Function

End Module
