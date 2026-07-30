Option Explicit On
Option Strict On

''' <summary>
''' Settings for "Daten holen" in the logbook: optionally copy weather/drive
''' fields from the previous entry of the same day.
''' </summary>
Public Module LogbookDatenHolenSettings

    Private Const AppName As String = "Logbuch"
    Private Const Section As String = "DatenHolen"

    Public Property CopyFromPreviousEnabled As Boolean
        Get
            Return GetBool("Enabled", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Enabled", value)
        End Set
    End Property

    Public Property CopyWindRichtung As Boolean
        Get
            Return GetBool("WindRichtung", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("WindRichtung", value)
        End Set
    End Property

    Public Property CopyWindstaerke As Boolean
        Get
            Return GetBool("Windstaerke", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Windstaerke", value)
        End Set
    End Property

    Public Property CopySeegang As Boolean
        Get
            Return GetBool("Seegang", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Seegang", value)
        End Set
    End Property

    Public Property CopyLuftdruck As Boolean
        Get
            Return GetBool("Luftdruck", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Luftdruck", value)
        End Set
    End Property

    Public Property CopyWolken As Boolean
        Get
            Return GetBool("Wolken", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Wolken", value)
        End Set
    End Property

    Public Property CopyAntriebsart As Boolean
        Get
            Return GetBool("Antriebsart", True)
        End Get
        Set(ByVal value As Boolean)
            SetBool("Antriebsart", value)
        End Set
    End Property

    Private Function GetBool(ByVal key As String, ByVal defaultValue As Boolean) As Boolean
        Dim raw As String = AppSettings.GetString(AppName, Section, key, If(defaultValue, "1", "0"))
        Return raw = "1" OrElse String.Equals(raw, "true", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Sub SetBool(ByVal key As String, ByVal value As Boolean)
        AppSettings.SetString(AppName, Section, key, If(value, "1", "0"))
    End Sub

End Module
