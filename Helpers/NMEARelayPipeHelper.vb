Imports System.IO
Imports System.IO.Pipes
Imports System.Text

Public Module NMEARelayPipeHelper

    ''' <summary>
    ''' Sends a command through a named pipe and returns the server response.
    ''' </summary>
    ''' <param name="command">Command string, e.g. "GET_LAT" or "SET_ENGINE"</param>
    ''' <returns>Server response string, or empty string for SET_ commands</returns>
    Public Function SendPipeCommand(command As String) As String
        Dim response As String = ""

        Using pipeClient As New NamedPipeClientStream(".", "NMEA_PIPE", PipeDirection.InOut)
            Try
                pipeClient.Connect(500) ' 500ms timeout

                ' Encode and send the command
                Dim commandBytes As Byte() = Encoding.ASCII.GetBytes(command)
                pipeClient.Write(commandBytes, 0, commandBytes.Length)
                pipeClient.Flush()

                ' If it's a GET_, read the response
                If command.StartsWith("GET_", StringComparison.OrdinalIgnoreCase) Then
                    Dim buffer(127) As Byte
                    Dim bytesRead As Integer = pipeClient.Read(buffer, 0, buffer.Length)
                    response = Encoding.UTF8.GetString(buffer, 0, bytesRead)
                End If

            Catch ex As TimeoutException
                response = ""
            Catch ex As Exception
                response = ""
            End Try
        End Using

        Return response
    End Function

    ''' <summary>
    ''' Checks whether the NMEA named pipe is available and responsive.
    ''' </summary>
    ''' <returns>1 if the pipe exists and can be connected, otherwise 0.</returns>
    Public Function IsPipeAvailable() As Integer
        Try
            Using pipeClient As New NamedPipeClientStream(".", "NMEA_PIPE", PipeDirection.Out)
                pipeClient.Connect(100) ' Fast timeout (100 ms)
                If pipeClient.IsConnected Then
                    Return 1
                End If
            End Using
        Catch ex As Exception
            ' Do nothing – we return 0 below
        End Try

        Return 0
    End Function

End Module
