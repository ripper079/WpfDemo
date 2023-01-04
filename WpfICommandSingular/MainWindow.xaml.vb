Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'Binding
        DataContext = New MessageViewModel()
    End Sub

End Class
