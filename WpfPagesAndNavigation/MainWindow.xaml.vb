Class MainWindow
    'Initialize window
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        frmMainFrame.Content = New OperationPicker()
        EnableButtonsForMainPage()
    End Sub


    'Button tooglers
    Private Sub EnableButtonsForMainPage()
        btnNavCreate.Visibility = Visibility.Visible
        btnNavEdit.Visibility = Visibility.Visible
        btnNavBackToMain.Visibility = Visibility.Hidden
    End Sub

    Private Sub EnableButtonsForCreatePage()
        btnNavCreate.Visibility = Visibility.Hidden
        btnNavEdit.Visibility = Visibility.Hidden
        btnNavBackToMain.Visibility = Visibility.Visible
    End Sub

    Private Sub EnableButtonsForEditPage()
        btnNavCreate.Visibility = Visibility.Hidden
        btnNavEdit.Visibility = Visibility.Hidden
        btnNavBackToMain.Visibility = Visibility.Visible
    End Sub

    'Navigation handlers
    Private Sub btnNavEdit_Click(sender As Object, e As RoutedEventArgs)
        EnableButtonsForEditPage()

        Dim editPage As New PageVeriEdit()

        AddHandler editPage.NavigateBackToMain, Sub(sourceComponent As String)
                                                    EnableButtonsForMainPage()
                                                    Dispatcher.BeginInvoke(Sub() frmMainFrame.Content = New OperationPicker())
                                                End Sub
        frmMainFrame.Content = editPage

    End Sub

    Private Sub btnNavCreate_Click(sender As Object, e As RoutedEventArgs)
        EnableButtonsForCreatePage()
        'Create Create page
        'Johan Johan Johan Johan
        Dim createPage As New PageVeriCreate()

        'Johan Johan Johan Johan
        AddHandler createPage.NavigateBack, Sub()
                                                EnableButtonsForMainPage()
                                                Dispatcher.BeginInvoke(Sub() frmMainFrame.Content = New OperationPicker())
                                            End Sub
        'Johan Johan Johan Johan
        frmMainFrame.Content = createPage

    End Sub

    Private Sub btnBackToMain_Click(sender As Object, e As RoutedEventArgs)
        EnableButtonsForMainPage()
        'Create main picker page
        frmMainFrame.Content = New OperationPicker()
    End Sub

End Class
