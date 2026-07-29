Option Explicit On
Option Strict On

Imports System.Globalization

''' <summary>
''' Locale-safe helpers for dates, money, substrings, SQL literals and DBNull.
''' German formats are preferred for compatibility with existing UI/masks.
''' </summary>
Public Module SafeData

    Private ReadOnly De As CultureInfo = CultureInfo.GetCultureInfo("de-DE")
    Private ReadOnly Invariant As CultureInfo = CultureInfo.InvariantCulture

    Public Sub ApplyGermanCulture()
        Dim culture As CultureInfo = CultureInfo.GetCultureInfo("de-DE")
        System.Threading.Thread.CurrentThread.CurrentCulture = culture
        System.Threading.Thread.CurrentThread.CurrentUICulture = culture
        Try
            CultureInfo.DefaultThreadCurrentCulture = culture
            CultureInfo.DefaultThreadCurrentUICulture = culture
        Catch
        End Try
    End Sub

    Public Function SafeSubstring(ByVal value As Object, ByVal startIndex As Integer, ByVal length As Integer, Optional ByVal fallback As String = "") As String
        Dim s As String = If(value Is Nothing OrElse IsDBNull(value), "", Convert.ToString(value))
        If String.IsNullOrEmpty(s) Then Return fallback
        If startIndex < 0 OrElse length < 0 OrElse startIndex >= s.Length Then Return fallback
        If startIndex + length > s.Length Then
            Return s.Substring(startIndex)
        End If
        Return s.Substring(startIndex, length)
    End Function

    Public Function LeftSafe(ByVal value As Object, ByVal length As Integer) As String
        Dim s As String = If(value Is Nothing OrElse IsDBNull(value), "", Convert.ToString(value))
        If length <= 0 OrElse s.Length = 0 Then Return ""
        If s.Length <= length Then Return s
        Return s.Substring(0, length)
    End Function

    Public Function IsBlankOrMask(ByVal text As String) As Boolean
        If text Is Nothing Then Return True
        Dim t As String = text.Trim()
        If t.Length = 0 Then Return True
        t = t.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "").Replace("_", "").Replace(":", "").Replace(" ", "")
        Return t.Length = 0
    End Function

    Public Function TryParseDate(ByVal value As Object, ByRef result As Date) As Boolean
        result = Date.MinValue
        If value Is Nothing OrElse IsDBNull(value) Then Return False
        If TypeOf value Is Date Then
            result = CDate(value)
            Return True
        End If
        If TypeOf value Is DateTime Then
            result = CType(value, DateTime)
            Return True
        End If

        Dim s As String = Convert.ToString(value).Trim()
        If IsBlankOrMask(s) Then Return False

        Dim styles As DateTimeStyles = DateTimeStyles.AllowWhiteSpaces
        Dim formats() As String = {
            "dd.MM.yyyy", "d.M.yyyy", "dd.MM.yy", "d.M.yy",
            "dd/MM/yyyy", "d/M/yyyy",
            "yyyy-MM-dd", "yyyy-MM-ddTHH:mm:ss",
            "dd.MM.yyyy HH:mm:ss", "dd.MM.yyyy HH:mm",
            "MM/dd/yyyy", "M/d/yyyy",
            "dd-MM-yyyy"
        }

        If DateTime.TryParseExact(s, formats, De, styles, result) Then Return True
        If DateTime.TryParseExact(s, formats, Invariant, styles, result) Then Return True
        If DateTime.TryParse(s, De, styles, result) Then Return True
        If DateTime.TryParse(s, Invariant, styles, result) Then Return True
        If DateTime.TryParse(s, CultureInfo.CurrentCulture, styles, result) Then Return True
        Return False
    End Function

    Public Function ParseDateOrMin(ByVal value As Object) As Date
        Dim d As Date
        If TryParseDate(value, d) Then Return d
        Return Date.MinValue
    End Function

    Public Function TryParseMaskedDate(ByVal maskedText As String, ByRef result As Date) As Boolean
        If IsBlankOrMask(maskedText) Then
            result = Date.MinValue
            Return False
        End If
        Return TryParseDate(maskedText, result)
    End Function

    Public Function FormatDateDe(ByVal value As Object, Optional ByVal fallback As String = "") As String
        Dim d As Date
        If TryParseDate(value, d) Then
            Return d.ToString("dd.MM.yyyy", De)
        End If
        Return fallback
    End Function

    Public Function FormatDateTimeDe(ByVal value As Object, Optional ByVal fallback As String = "") As String
        Dim d As Date
        If TryParseDate(value, d) Then
            Return d.ToString("dd.MM.yyyy HH:mm:ss", De)
        End If
        Return fallback
    End Function

    Public Function FormatTimeHm(ByVal value As Object, Optional ByVal fallback As String = "") As String
        Dim d As Date
        If TryParseDate(value, d) Then
            Return d.ToString("HH:mm", De)
        End If
        Dim s As String = Convert.ToString(value)
        If s.Length >= 16 Then
            Return SafeSubstring(s, 11, 5, fallback)
        End If
        Return fallback
    End Function

    Public Function TryParseNumber(ByVal value As Object, ByRef result As Double) As Boolean
        result = 0
        If value Is Nothing OrElse IsDBNull(value) Then Return False
        If TypeOf value Is Double OrElse TypeOf value Is Single OrElse TypeOf value Is Decimal OrElse TypeOf value Is Integer OrElse TypeOf value Is Long OrElse TypeOf value Is Short Then
            result = Convert.ToDouble(value, CultureInfo.InvariantCulture)
            Return True
        End If

        Dim s As String = Convert.ToString(value).Trim()
        If s.Length = 0 Then Return False
        s = s.Replace("€", "").Replace("EUR", "").Replace(" ", "").Trim()

        If Double.TryParse(s, NumberStyles.Any, De, result) Then Return True
        If Double.TryParse(s, NumberStyles.Any, Invariant, result) Then Return True
        If Double.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, result) Then Return True
        Return False
    End Function

    Public Function ParseNumberOrZero(ByVal value As Object) As Double
        Dim n As Double
        If TryParseNumber(value, n) Then Return n
        Return 0
    End Function

    Public Function ParseSingleOrZero(ByVal value As Object) As Single
        Return CSng(ParseNumberOrZero(value))
    End Function

    ''' <summary>Parses money text that may end with " €" or similar suffix.</summary>
    Public Function ParseMoneyText(ByVal text As String) As Double
        If String.IsNullOrEmpty(text) Then Return 0
        Dim s As String = text.Trim()
        If s.EndsWith("€", StringComparison.Ordinal) Then
            s = s.Substring(0, s.Length - 1).Trim()
        End If
        If s.EndsWith("EUR", StringComparison.OrdinalIgnoreCase) Then
            s = s.Substring(0, s.Length - 3).Trim()
        End If
        Return ParseNumberOrZero(s)
    End Function

    Public Function FormatMoneyDe(ByVal amount As Double) As String
        Return amount.ToString("##,##0.00", De) & " €"
    End Function

    Public Function SqlQuote(ByVal value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then Return ""
        Return Convert.ToString(value).Replace("'", "''")
    End Function

    Public Function IsNullOrEmptyValue(ByVal value As Object) As Boolean
        If value Is Nothing OrElse IsDBNull(value) Then Return True
        Return String.IsNullOrWhiteSpace(Convert.ToString(value))
    End Function

    Public Function CoalesceString(ByVal value As Object, Optional ByVal fallback As String = "") As String
        If IsNullOrEmptyValue(value) Then Return fallback
        Return Convert.ToString(value)
    End Function

    Public Function DbValueOrDbNull(ByVal value As Object) As Object
        If IsNullOrEmptyValue(value) Then Return DBNull.Value
        Return value
    End Function

    Public Function DbNumberOrZero(ByVal value As Object) As Object
        Dim n As Double
        If TryParseNumber(value, n) Then Return n
        Return 0
    End Function

    Public Function ExtractVersionMajor(ByVal titleOrVersion As String) As Integer
        ' Expects "... Version XX.YY.ZZ" or "XX.YY.ZZ"
        Dim s As String = If(titleOrVersion, "")
        Dim idx As Integer = s.IndexOf("Version ", StringComparison.OrdinalIgnoreCase)
        Dim ver As String
        If idx >= 0 Then
            ver = s.Substring(idx + 8).Trim()
        Else
            ver = s.Trim()
        End If
        Dim majorPart As String = ver.Split("."c)(0)
        Dim major As Integer
        If Integer.TryParse(majorPart, NumberStyles.Integer, Invariant, major) Then Return major
        Return 0
    End Function

    Public Function ExtractVersionStamp(ByVal titleOrVersion As String) As String
        Dim s As String = If(titleOrVersion, "")
        Dim idx As Integer = s.IndexOf("Version ", StringComparison.OrdinalIgnoreCase)
        Dim ver As String
        If idx >= 0 Then
            ver = s.Substring(idx + 8).Trim()
        Else
            ver = s.Trim()
        End If
        If ver.Length >= 8 Then Return ver.Substring(0, 8)
        Return ver
    End Function

    Public Function VersionAtLeast(ByVal storedMajor As Object, ByVal requiredMajor As Integer) As Boolean
        Dim stored As Integer
        If Not Integer.TryParse(Convert.ToString(storedMajor), NumberStyles.Integer, Invariant, stored) Then
            stored = 0
        End If
        Return stored >= requiredMajor
    End Function

End Module
