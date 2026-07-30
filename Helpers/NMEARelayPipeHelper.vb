Imports System.IO
Imports System.IO.Pipes
Imports System.Text

''' <summary>
''' Named-pipe client for the NMEA relay. All public methods are fail-safe:
''' missing or busy pipes never throw to the UI.
''' </summary>
Public Module NMEARelayPipeHelper

    Private Const PipeName As String = "NMEA_PIPE"
    Private Const ConnectTimeoutMs As Integer = 500
    Private Const ProbeTimeoutMs As Integer = 100

    ' Exclusive navigation/drive status commands (no =0|1 payload).
    Public Const CmdSetSail As String = "SET_SAIL"
    Public Const CmdSetEngineSail As String = "SET_ENGINESAIL"
    Public Const CmdSetEngine As String = "SET_ENGINE"

    ''' <summary>
    ''' Sends a command through a named pipe and returns the server response.
    ''' </summary>
    ''' <param name="command">Command string, e.g. "GET_LATLON" or "SET_SAIL"</param>
    ''' <returns>Server response for GET_ commands; empty string for SET_ or on failure</returns>
    Public Function SendPipeCommand(ByVal command As String) As String
        Dim response As String = ""
        If String.IsNullOrWhiteSpace(command) Then Return response

        Try
            Using pipeClient As New NamedPipeClientStream(".", PipeName, PipeDirection.InOut)
                pipeClient.Connect(ConnectTimeoutMs)

                Dim commandBytes As Byte() = Encoding.ASCII.GetBytes(command.Trim())
                pipeClient.Write(commandBytes, 0, commandBytes.Length)
                pipeClient.Flush()

                If command.StartsWith("GET_", StringComparison.OrdinalIgnoreCase) Then
                    Dim buffer(127) As Byte
                    Dim bytesRead As Integer = pipeClient.Read(buffer, 0, buffer.Length)
                    If bytesRead > 0 Then
                        response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim()
                    End If
                End If
            End Using
        Catch ex As Exception
            AppLog.Warn("NMEA pipe command failed (" & command & "): " & ex.Message)
            response = ""
        End Try

        Return response
    End Function

    ''' <summary>
    ''' Checks whether the NMEA named pipe is available and responsive.
    ''' </summary>
    ''' <returns>1 if the pipe exists and can be connected, otherwise 0.</returns>
    Public Function IsPipeAvailable() As Integer
        Try
            Using pipeClient As New NamedPipeClientStream(".", PipeName, PipeDirection.Out)
                pipeClient.Connect(ProbeTimeoutMs)
                If pipeClient.IsConnected Then Return 1
            End Using
        Catch
        End Try
        Return 0
    End Function

    Public Function IsRelayOnline() As Boolean
        Return IsPipeAvailable() = 1
    End Function

    ''' <summary>Short German status text for UI labels.</summary>
    Public Function GetRelayStatusText() As String
        If IsRelayOnline() Then
            Return "NMEA-Relay: online"
        End If
        Return "NMEA-Relay: offline"
    End Function

    ''' <summary>
    ''' Publishes one exclusive drive status command from Antriebsart text
    ''' (e.g. "M GR", "m GE"). No-ops when pipe is down or status is unrecognized.
    ''' </summary>
    Public Function TryPublishDriveStatus(ByVal antriebsart As String) As Boolean
        Try
            If String.IsNullOrWhiteSpace(antriebsart) Then Return False

            Dim command As String = MapAntriebsartToPipeCommand(antriebsart)
            If String.IsNullOrEmpty(command) Then Return False
            If IsPipeAvailable() <> 1 Then Return False

            SendPipeCommand(command)
            Return True
        Catch ex As Exception
            AppLog.Warn("TryPublishDriveStatus: " & ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Maps logbook Antriebsart / status text to a single SET_* pipe command.
    ''' </summary>
    Public Function MapAntriebsartToPipeCommand(ByVal antriebsart As String) As String
        If String.IsNullOrWhiteSpace(antriebsart) Then Return Nothing
        Dim raw As String = antriebsart.Trim()

        Dim motorOn As Boolean = HasExactToken(raw, "M")
        Dim sailOn As Boolean = HasExactToken(raw, "GR") OrElse HasExactToken(raw, "GE")

        If motorOn AndAlso sailOn Then
            Return CmdSetEngineSail
        End If
        If sailOn AndAlso Not motorOn Then
            Return CmdSetSail
        End If
        If motorOn AndAlso Not sailOn Then
            Return CmdSetEngine
        End If

        Return Nothing
    End Function

    Private Function HasExactToken(ByVal text As String, ByVal token As String) As Boolean
        If String.IsNullOrWhiteSpace(text) OrElse String.IsNullOrEmpty(token) Then Return False
        Dim parts() As String = text.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        For Each part As String In parts
            If String.Equals(part, token, StringComparison.Ordinal) Then Return True
        Next
        Return False
    End Function

End Module
