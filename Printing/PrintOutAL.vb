Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutAL
    '                                                      Anwesenheitsliste
    Public speicherbild As String
    Public speicherplatz As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Friend Shared Kursbez1 As String
    Public Sub PrintAnwesendListe(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xxpos As Single
        Dim xPos(8) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        Dim rNbr As Integer
        Dim ij As Integer = 0
        Dim vzname As String = " "
        Dim xxposSchrit As Single
        Dim aaa As String
        Dim enger As Single = 1.3
        Dim perz As Single = 0
        Dim prz100 As Single = 0
        Dim perz100 As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 20
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        xPos(8) = xPos(7) + 150

        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Anwesenheitsliste ", printFont, Brushes.Black, xPos(4), topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 14, FontStyle.Bold)
        ev.Graphics.DrawString(KurstermineAD.Kursbez1, printFont, Brushes.Black, xPos(4), topMargin - 25, New StringFormat())
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        zeile = 5
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(7), topMargin, New StringFormat())
        For i = 0 To KurstermineAD.jt
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
            ev.Graphics.DrawString(i + 1, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString(KurstermineAD.Kursdatum1(i, 0), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(KurstermineAD.Kursdatum1(i, 1), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString("Kurseinheiten: " + KurstermineAD.Kursdatum1(i, 2), printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
            aaa = KurstermineAD.Kursdatum1(i, 2)
            prz100 += aaa
        Next
        zeile += 1
        perz100 = prz100
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
        ev.Graphics.DrawString("        Summe: " + perz100, printFont, Brushes.Black, xPos(7), yPos, New StringFormat())

        zeile += 3
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
        xxpos = 0
        If KurstermineAD.jt > 10 Then
            xxposSchrit = 40 - (KurstermineAD.jt - 12) * 3
        Else
            xxposSchrit = 40
        End If
        For i = 0 To KurstermineAD.jt
            ev.Graphics.DrawString(i + 1, printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
            xxpos += xxposSchrit
        Next
        ev.Graphics.DrawString("%", printFont, Brushes.Black, xPos(8), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))

        row = dt.Rows(0)
        ' Print each line of the file.
        '----------------------------------------------------------- allgemeine Törndaten ------------------------------------------------
        rNbr = lastRow
        row = dt.Rows(rNbr)
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            If vzname = row(0) Then
                While ij < KurstermineAD.jt
                    xxpos += xxposSchrit
                    ij += 1
                    aaa = KurstermineAD.Kursdatum1(ij, 0)
                    If row(1) = KurstermineAD.Kursdatum1(ij, 0) Then
                        If row(2) = True Then
                            ev.Graphics.DrawString("X", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                            perz += KurstermineAD.Kursdatum1(ij, 2)
                        Else
                            ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                        End If
                        GoTo endWhile1
                    Else
                        ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                    End If
                End While
endWhile1:
            Else
                If rNbr > 0 Then
                    While ij < KurstermineAD.jt
                        ij += 1
                        xxpos += xxposSchrit
                        ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                    End While
                    ev.Graphics.DrawString(perz * 100 / prz100, printFont, Brushes.Black, xPos(8), yPos, New StringFormat())
                    perz = 0
                End If
                vzname = row(0)
                ij = 0
                xxpos = 0
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                If row(1) = KurstermineAD.Kursdatum1(ij, 0) Then
                    If row(2) = True Then
                        ev.Graphics.DrawString("X", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                        perz += KurstermineAD.Kursdatum1(ij, 2)
                    Else
                        ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                    End If
                Else
                    While ij <= KurstermineAD.jt
                        If row(1) = KurstermineAD.Kursdatum1(ij, 0) Then
                            If row(2) = True Then
                                ev.Graphics.DrawString("X", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                                perz += KurstermineAD.Kursdatum1(ij, 2)
                            Else
                                ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                            End If
                            Exit While
                        Else
                            ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                        End If
                        xxpos += xxposSchrit
                        ij += 1
                    End While
                End If
            End If


satzeinlese:
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                While ij < KurstermineAD.jt
                    ij += 1
                    xxpos += xxposSchrit
                    ev.Graphics.DrawString("--", printFont, Brushes.Black, xPos(3) + xxpos, yPos, New StringFormat())
                End While
                ev.Graphics.DrawString(perz * 100 / prz100, printFont, Brushes.Black, xPos(8), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) * enger
                ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                Exit While
            End If
            Dim vizname As String
            Dim ter As String
            vizname = row(0)
            ter = row(1)
            row = dt.Rows(rNbr)
            If vizname = row(0) And ter = row(1) Then
                GoTo satzeinlese
            End If
        End While

EndeDruck:
    End Sub
End Class
