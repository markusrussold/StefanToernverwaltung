Partial Class ToernverwaltungDataSet
    Partial Class BordkassaDataTable

        Private Sub BordkassaDataTable_BordkassaRowChanging(ByVal sender As System.Object, ByVal e As BordkassaRowChangeEvent) Handles Me.BordkassaRowChanging

        End Sub

    End Class

    Partial Class AgenturDataTable

        Private Sub AgenturDataTable_AgenturRowChanging(ByVal sender As System.Object, ByVal e As AgenturRowChangeEvent) Handles Me.AgenturRowChanging

        End Sub

    End Class

    Partial Class ToernnameDataTable

        Private Sub ToernnameDataTable_ToernnameRowChanging(ByVal sender As System.Object, ByVal e As ToernnameRowChangeEvent) Handles Me.ToernnameRowChanging

        End Sub

    End Class

    Partial Class ToernKalkulationDataTable

        Private Sub ToernKalkulationDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RouteColumn.ColumnName) Then
                'Benutzercode hier einfügen
            End If

        End Sub

        Private Sub ToernKalkulationDataTable_ToernKalkulationRowChanging(sender As System.Object, e As ToernKalkulationRowChangeEvent) Handles Me.ToernKalkulationRowChanging

        End Sub

    End Class

End Class
