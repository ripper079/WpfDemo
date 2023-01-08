Imports System.ComponentModel

Public Class Person
    Implements INotifyPropertyChanged

    Public Property Age As Integer
    Public Property HireDay As DateTime
    Public Property Salary As Decimal


    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return Me._firstName
        End Get
        Set(ByVal value As String)
            If Not (value = _firstName) Then
                Me._firstName = value
                NotifyPropertyChanged("FirstName")
                NotifyPropertyChanged("FullName")
            End If
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return Me._lastName
        End Get
        Set(ByVal value As String)
            If Not (value = _lastName) Then
                Me._lastName = value
                NotifyPropertyChanged("LastName")
                NotifyPropertyChanged("FullName")
            End If
        End Set
    End Property


    Private _FullName As String
    Public Property FullName() As String
        Get
            _FullName = FirstName + " " + LastName
            Return Me._FullName
        End Get
        Set(ByVal value As String)
            If Not (value = _FullName) Then
                Me._FullName = value
                NotifyPropertyChanged("FullName")
            End If
        End Set
    End Property




    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    'This function raises an (property change) event 
    'Me = this
    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub


End Class
