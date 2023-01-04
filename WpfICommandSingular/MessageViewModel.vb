Public Class MessageViewModel
    Public Property MessageText As String
    Public Property DisplayMessageCommand As MessageCommand

    Public Sub New()
        DisplayMessageCommand = New MessageCommand(AddressOf DisplayMessage)
    End Sub

    Public Sub DisplayMessage()
        MsgBox($"{MessageText}")
    End Sub
End Class
