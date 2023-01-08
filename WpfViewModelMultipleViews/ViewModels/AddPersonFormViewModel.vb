Public Class AddPersonFormViewModel
    'Fields in the form
    Public Property AddAPerson As Person

    Public Property LastNameRequired As Boolean
    Public Property UserBasedOnRoom As Boolean
    Public Property UserBasedOnLova As Boolean
    Public Property UserBasedOnOther As Boolean
    Public Property IsAddDaysCodeExpiration As Boolean
    Public Property AddDaysCodeExpiration As Integer
    Public Property EndPointId As Integer
    Public Property OperatorID As Integer
    Public Property EmailsContactPerson As List(Of String)
    Public Property EmailsPersonel As List(Of String)


    'Should only be set once
    Public ReadOnly Property CommandAddAPerson As AddPersonCommand

    Public Sub New()
        AddAPerson = New Person
        SetInitStatePerson()

        CommandAddAPerson = New AddPersonCommand(AddressOf AddPersonDB)
    End Sub

    Private Sub SetInitStatePerson()

        With AddAPerson
            .FirstName = "Default Firstname"
            .LastName = "Default Lastname"
            .Age = 18
        End With


    End Sub

    'Invoked through A Command
    Public Sub AddPersonDB()
        MsgBox($"Adding person: '{AddAPerson.FirstName} {AddAPerson.LastName} {AddAPerson.Age}' to DB")
        SetInitStatePerson()
    End Sub
End Class
