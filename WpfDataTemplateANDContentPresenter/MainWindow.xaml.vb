Class MainWindow
    Public Property myPerson As Person

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        myPerson = New Person() With
        {
            .Name = "Daniel Oikarainen",
            .Age = 43,
            .hasChildren = True
        }

        Me.DataContext = Me
    End Sub
End Class
