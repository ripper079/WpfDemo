Class PageVeriEdit
    Public Event NavigateBackToMain(fromPage As String)

    Private Sub BackToMain_Click(sender As Object, e As RoutedEventArgs)
        RaiseEvent NavigateBackToMain("Event raised from PageVeriEdit...")
    End Sub
End Class
