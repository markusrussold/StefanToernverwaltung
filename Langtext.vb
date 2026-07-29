Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class Langtext
    Public Shared Function LangtextDrucken(ByRef quelle, ByVal zeile, ByVal ypos, ByVal printFont, ByVal xpos, ByVal ev, ByVal ZeilenAnzahl)
        Dim routelange As Integer
        Dim zeilenanf As Integer
        Dim zs As Integer
        Dim zeilentext As String
        Dim zr As Integer
        Dim zletzte As Integer
        Dim topMargin As Single = ev.MarginBounds.Top
        If Not DBNull.Value.Equals(quelle) Then
            If quelle.Length > 1 Then
                routelange = quelle.Length                     ' Gesamtlänge des Textes
                zs = Menü.druckzeile                           ' max. Zeichenanzahl in der Druckzeile ohne vbLf
                zletzte = zs
                zeilenanf = 0
                For zl = 0 To 80
                    If routelange < zeilenanf + zs Then
                        zs = routelange - zeilenanf
                    End If
                    For i = zeilenanf To routelange - 1
                        If quelle.Substring(i, 1) = vbLf Or quelle.Substring(i, 1) = vbCrLf Or i = zeilenanf + zs - 1 Then
                            If i < zeilenanf + zs - 1 Then
                                zeilentext = quelle.Substring(zeilenanf, i - zeilenanf + 1)
                                zeilenanf = i + 1
                            Else
                                If zletzte = zs Then
                                    zr = Leerstelle.letzteLeerstelle(quelle.Substring(zeilenanf, zs))
                                Else
                                    zr = 0
                                End If
                                zeilentext = quelle.Substring(zeilenanf, zs - zr)
                                zeilenanf = i - zr + 1
                            End If
                            zeile += 1
                            ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(quelle), "", zeilentext), printFont, Brushes.Black, xpos, ypos, New StringFormat())
                        End If
                        If zeile >= ZeilenAnzahl Then
                            Menü.RestText = quelle.Substring(zeilenanf, routelange - zeilenanf)
                            GoTo endetext
                        End If
                    Next
                    If zeilenanf + 1 >= routelange Then
                        GoTo endetext
                    End If
                Next

            End If
        End If
endetext:

        Return zeile
    End Function
End Class
