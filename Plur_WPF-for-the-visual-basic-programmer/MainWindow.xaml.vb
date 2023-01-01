Class MainWindow

    Private Sub menuitemProducts_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        'Adding the user control dynamically
        contentArea.Children.Add(New ProductDetailControl())
    End Sub
End Class
