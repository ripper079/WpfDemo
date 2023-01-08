Class PageVeriCreate
    'Johan Johan Johan Johan Johan
    Public Event NavigateBack()

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        PopulateCmb()
    End Sub

    'Fetch Data from DB to populate comboboxes?
    Private Sub PopulateCmb()
        Dim listOfEndPoints As List(Of Integer) = New List(Of Integer)
        listOfEndPoints = FetchEndPointsId()

        'Populate the Endpoint combobox
        For Each anEndPointId As Integer In listOfEndPoints
            cmbEndpointId.Items.Add(anEndPointId)
        Next

        ' Select/set the first element in the combobox
        cmbEndpointId.SelectedItem = listOfEndPoints.ElementAt(0)

        'Now the operators
        Dim listOfOperators As List(Of Integer) = New List(Of Integer)
        listOfOperators = FetchOperatorsId()

        For Each anOperatorId As Integer In listOfOperators
            cmbOperatorId.Items.Add(anOperatorId)
        Next

        'Populate the OperatorId combobox
        cmbOperatorId.SelectedItem = listOfOperators.ElementAt(0)

    End Sub

    'Test data aka fake (simulate call to DB)
    Private Function FetchEndPointsId()
        Dim listOfInteger As List(Of Integer) = New List(Of Integer)
        listOfInteger.Add(1)
        listOfInteger.Add(5)
        listOfInteger.Add(3)
        listOfInteger.Add(10)
        listOfInteger.Add(13)
        listOfInteger.Add(35)
        listOfInteger.Add(22)
        listOfInteger.Add(67)

        listOfInteger.Sort()

        Return listOfInteger
    End Function

    'Test data aka fake  (simulate call to DB)
    Private Function FetchOperatorsId()
        Dim listOfInteger As List(Of Integer) = New List(Of Integer)
        listOfInteger.Add(45)
        listOfInteger.Add(21)
        listOfInteger.Add(19)
        listOfInteger.Add(11)
        listOfInteger.Add(52)
        listOfInteger.Add(7)

        listOfInteger.Sort()

        Return listOfInteger
    End Function

    Private Sub btnOkForCreate_Click(sender As Object, e As RoutedEventArgs)
        ' Johan Johan Johan Johan Johan        
        RaiseEvent NavigateBack()

    End Sub

    Private Sub radioUserBasedLova_Checked(sender As Object, e As RoutedEventArgs)


        If (gridOtherSpecify Is Nothing) Then
            Return

        End If
        If (radioUserBasedLova.IsChecked) Then
            brdOtherSelected.Visibility = Visibility.Collapsed
            brdLovaSelected.Visibility = Visibility.Visible
        ElseIf (radioUserBasedRoom.IsChecked) Then
            brdOtherSelected.Visibility = Visibility.Collapsed
            brdLovaSelected.Visibility = Visibility.Collapsed
        ElseIf (radioUserBasedOther.IsChecked) Then
            brdOtherSelected.Visibility = Visibility.Visible
            brdLovaSelected.Visibility = Visibility.Collapsed
        Else
            MsgBox("Should be unreachable code")
        End If
    End Sub

    'Private Sub chkAddDaysToCodeExpir_Checked(sender As Object, e As RoutedEventArgs)



    'End Sub

    Private Sub chkAddDaysToCodeExpir_Click(sender As Object, e As RoutedEventArgs)

        If (chkAddDaysToCodeExpir.IsChecked) Then
            cmbAddDaysCodexpiration.Visibility = Visibility.Visible
        Else
            cmbAddDaysCodexpiration.Visibility = Visibility.Collapsed
        End If
    End Sub
End Class
