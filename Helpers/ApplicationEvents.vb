Option Explicit On
Option Strict On

Imports System.Threading
Imports System.Windows.Forms

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf OnUiThreadException
            System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf OnDomainUnhandledException

            SafeData.ApplyGermanCulture()
            AppLog.Info("Application startup")

            Try
                Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
                DatabaseBootstrap.EnsureAll(baseDir)
            Catch ex As Exception
                AppLog.ShowError(
                    "Datenbanken konnten nicht vorbereitet werden." & Environment.NewLine &
                    "Bitte prüfen Sie Jet/ACE 32-Bit und Schreibrechte im Programmordner.",
                    ex)
                e.Cancel = True
            End Try
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            AppLog.ShowError("Unerwarteter Fehler.", e.Exception)
            e.ExitApplication = False
        End Sub

        Private Sub OnUiThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
            AppLog.ShowError("Unerwarteter Fehler in der Oberfläche.", e.Exception)
        End Sub

        Private Sub OnDomainUnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            Dim ex As Exception = TryCast(e.ExceptionObject, Exception)
            AppLog.ErrorLog("Unbehandelter Fehler (AppDomain).", ex)
        End Sub

    End Class

End Namespace
