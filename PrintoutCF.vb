Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutCF
    '                                                                                                                        Drucken Crew Formular
    Public speicherbild As String
    Private printFont As Font
    Private printFFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Public Sub PrintCrewFormular(ByVal tIn As DataTable)
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
    Public Sub PrintCrewAergenzung(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pdae As New PrintDocument()
        AddHandler pdae.PrintPage, AddressOf Me.pdae_PrintPage
        pdae.Print()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(6) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 3
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 120
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 40
        xPos(4) = xPos(3) + 200
        xPos(5) = xPos(4) + 30
        xPos(6) = xPos(5) + 70

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Crew Aufnahmeformular", printFont, Brushes.Black, xPos(1) + 50, topMargin, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())
        printFFont = New Font("Arial", 10, FontStyle.Bold)
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 80
        xPos(2) = xPos(1) + 200
        xPos(3) = xPos(2) + 120
        zeile += 5
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Name*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("Geburtsdatum*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Vorname*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("Geburtsort/Land*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Strasse*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("Reisepass Nr.*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Plz:*", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("Nationalität*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Ort:* ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("Segelschein/Nr.:*", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Handy: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("ausgestellt am: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("e-mail: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("ausgestellt von: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Funklizenz:*", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
        zeile += 2
        yPos = topMargin + 61 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Alle Angaben werden elektronisch gespeichert; die mit * bezeichnete Daten werden in der Crewliste ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

        yPos = topMargin + 62 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("an die Charterfirma und an ausländische Einklarierungsbehörde übergeben. ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

    End Sub
    Private Sub pdae_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(6) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 3
        Dim rNbr As Integer
        Dim aaa As String
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 120
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 40
        xPos(4) = xPos(3) + 200
        xPos(5) = xPos(4) + 30
        xPos(6) = xPos(5) + 70
         rNbr = lastRow
        row = dt.Rows(rNbr)

        aaa = row(0)
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Crew Aufnahmeformular", printFont, Brushes.Black, xPos(1) + 50, topMargin, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())
        printFFont = New Font("Arial", 10, FontStyle.Bold)
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 80
        xPos(2) = xPos(1) + 200
        xPos(3) = xPos(2) + 120
        zeile += 5
        '
        ' "0Zuname", "1Vorname", "2Anrede", "3Handy", "4email", "5straße", "6plz", "7ort", "8Reisepassnr", "9gebdatum", "10gebort", "11funk", "12segelschein", "13nationalitaet"
        '
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Name*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "___________________", row(0)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Geburtsdatum*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "___________________", row(9)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Vorname*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "___________________", row(1)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Geburtsort/Land*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "___________________", row(10)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Strasse*: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "___________________", row(5)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Reisepass Nr.*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "___________________", row(8)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Plz:*", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "___________________", row(6)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Nationalität*: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(13)), "___________________", row(13)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Ort:* ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "___________________", row(7)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Segelschein/Nr.:*", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(12)), "___________________", row(12)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Handy: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "___________________", row(3)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("ausgestellt am: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("e-mail: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "___________________", row(4)), printFFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("ausgestellt von: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString("___________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())                   'Name
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Funklizenz:*", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())                   'Name
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "___________________", row(11)), printFFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
        zeile += 2
        yPos = topMargin + 61 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Alle Angaben werden elektronisch gespeichert; die mit * bezeichnete Daten werden in der Crewliste ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

        yPos = topMargin + 62 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("an die Charterfirma und an ausländische Einklarierungsbehörde übergeben. ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

    End Sub
End Class
