Option Explicit On
Option Strict On

Imports System.Globalization

''' <summary>
''' Single source of truth for the application version (X.ZZ.Y).
''' X  = database / breaking change
''' ZZ = feature
''' Y  = bugfix
''' Bump with: powershell -File tools\bump-version.ps1 -Part patch|minor|major
''' </summary>
Public Module AppVersion

    ''' <summary>Display / product version, zero-padded minor (e.g. 13.02.04).</summary>
    Public Const Number As String = "13.02.06"

    Public ReadOnly Property DisplayTitle As String
        Get
            Return "Törnverwaltung Version " & Number
        End Get
    End Property

    Public ReadOnly Property Major As Integer
        Get
            Return ParsePart(0)
        End Get
    End Property

    Public ReadOnly Property Minor As Integer
        Get
            Return ParsePart(1)
        End Get
    End Property

    Public ReadOnly Property Patch As Integer
        Get
            Return ParsePart(2)
        End Get
    End Property

    Public ReadOnly Property MajorString As String
        Get
            Return Major.ToString(CultureInfo.InvariantCulture)
        End Get
    End Property

    ''' <summary>Assembly-style version without zero padding (e.g. 13.2.4.0).</summary>
    Public ReadOnly Property AssemblyVersion As String
        Get
            Return Major.ToString(CultureInfo.InvariantCulture) & "." &
                   Minor.ToString(CultureInfo.InvariantCulture) & "." &
                   Patch.ToString(CultureInfo.InvariantCulture) & ".0"
        End Get
    End Property

    Private Function ParsePart(ByVal index As Integer) As Integer
        Dim parts() As String = Number.Split("."c)
        Dim value As Integer
        If index >= 0 AndAlso index < parts.Length AndAlso
           Integer.TryParse(parts(index), NumberStyles.Integer, CultureInfo.InvariantCulture, value) Then
            Return value
        End If
        Return 0
    End Function

End Module
