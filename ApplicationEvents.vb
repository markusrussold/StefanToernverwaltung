Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
                DatabaseBootstrap.EnsureAll(baseDir)
            Catch ex As Exception
                MessageBox.Show(
                    "Datenbanken konnten nicht vorbereitet werden:" & Environment.NewLine & ex.Message,
                    "Törnverwaltung",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
                e.Cancel = True
            End Try
        End Sub

    End Class

End Namespace
