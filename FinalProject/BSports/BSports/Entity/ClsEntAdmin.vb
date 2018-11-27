Public Class ClsEntAdmin
    Private idadmin As String
    Private usrnm As String
    Private pswd As String

    Public Property id_admin() As String
        Get
            Return idadmin
        End Get
        Set(value As String)
            idadmin = value
        End Set
    End Property

    Public Property username_admin() As String
        Get
            Return usrnm
        End Get
        Set(value As String)
            usrnm = value
        End Set
    End Property

    Public Property pwd_admin() As String
        Get
            Return pswd
        End Get
        Set(value As String)
            pswd = value
        End Set
    End Property
End Class
