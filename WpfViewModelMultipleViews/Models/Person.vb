Imports System.ComponentModel

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            If Not (value = _firstName) Then
                Me._firstName = value
                NotifyPropertyChanged("FirstName")
            End If
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            If Not (value = _lastName) Then
                Me._lastName = value
                NotifyPropertyChanged("LastName")
            End If
        End Set
    End Property

    Private _age As Integer
    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            If Not (value = _age) Then
                Me._age = value
                NotifyPropertyChanged("Age")
            End If
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return $"|{FirstName} {LastName} {Age} |"
    End Function


    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    'This function raises an (property change) event 
    'Me = this
    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub
End Class
