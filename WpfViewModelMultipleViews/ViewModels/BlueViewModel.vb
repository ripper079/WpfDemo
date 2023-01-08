Public Class BlueViewModel
    Public Property MessageTextBlue As String
    Public Property APerson As Person
    Public Property DisplayBlueSong As BlueMessageCommand

    Public Sub New()
        MessageTextBlue = "Its a blue world"
        APerson = New Person With {.FirstName = "Blueman", .LastName = "Skyflyier", .Age = 69}
        DisplayBlueSong = New BlueMessageCommand(AddressOf DisplayAndSing)

    End Sub

    Public Sub DisplayAndSing()
        MsgBox($"This is a song about blue blue blue")
    End Sub

    Public Sub MakeWaterFall()
        MsgBox($"Waterfall is generated")
    End Sub

End Class
