Public Class ButtonCommand
    Implements ICommand

    Private _buttonViewModel As ButtonViewModel

    Sub New(viewModel As ButtonViewModel)
        _buttonViewModel = viewModel
    End Sub

    'This is an eent when the logic determining CanExeecute has changed
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    'This is what determines wheter the command can be executed
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function

    'This, in a very straingt forward way, executes the command. It must take a parameter of object, but ii goes not have to be used
    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        _buttonViewModel.OnExecute()

    End Sub

End Class
