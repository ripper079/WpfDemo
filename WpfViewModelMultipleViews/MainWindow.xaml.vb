Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        DataContext = New DefaultMainViewModel()
    End Sub


    Private Sub RedView_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New RedViewModel()
    End Sub

    Private Sub BlueView_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New BlueViewModel()
    End Sub

    Private Sub OrangeView_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New OrangeViewModel()

    End Sub

    Private Sub PurpleView_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New PurpleViewModel()
    End Sub

    Private Sub AddPersonForm_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New AddPersonFormViewModel()
    End Sub

    Private Sub MainHomeView_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New DefaultMainViewModel()
    End Sub

    Private Sub EditPersonForm_Click(sender As Object, e As RoutedEventArgs)
        DataContext = New EditPersonFormViewModel()
    End Sub
End Class
