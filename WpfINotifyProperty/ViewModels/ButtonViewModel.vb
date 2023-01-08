Public Class ButtonViewModel
    Public Property ButtonCommand As ButtonCommand

    Sub New()
        ButtonCommand = New ButtonCommand(Me)
    End Sub

    Sub OnExecute()
        MsgBox("ICommand - Button Clicked")
    End Sub
End Class
