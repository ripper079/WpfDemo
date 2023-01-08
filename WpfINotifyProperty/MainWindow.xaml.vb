
Class MainWindow
    Public Property personobj As Person
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        personobj = New Person() With {.FirstName = "Donald", .LastName = "Trump", .Age = 58}
        Me.DataContext = personobj
    End Sub

    'Private Sub NewCommand_CanExecute(sender As Object, e As CanExecuteRoutedEventArgs)
    '    e.CanExecute = True
    'End Sub

    ''Ctrl + n
    'Private Sub NewCommand_Executed(sender As Object, e As ExecutedRoutedEventArgs)
    '    MsgBox("The new command was executed")
    'End Sub

    Private Sub btnClick_Click(sender As Object, e As RoutedEventArgs)
        MsgBox("Event Handler - ButtonClick Buttonclick Buttonclick")
    End Sub
End Class
