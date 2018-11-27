Public Class ClsEntKasir
    Private kodekasir As String
    Private namakasir As String
    Private ussrname As String
    Private pwd As String
    Private almt As String



    Public Property kode_kasir() As String
        Get
            Return kodekasir
        End Get
        Set(value As String)
            kodekasir = value
        End Set
    End Property

    Public Property nama_kasir() As String
        Get
            Return namakasir
        End Get
        Set(value As String)
            namakasir = value
        End Set
    End Property

    Public Property username() As String
        Get
            Return ussrname
        End Get
        Set(value As String)
            ussrname = value
        End Set
    End Property

    Public Property pass() As String
        Get
            Return pwd
        End Get
        Set(value As String)
            pwd = value
        End Set
    End Property

    Public Property alamat() As Integer
        Get
            Return almt
        End Get
        Set(value As Integer)
            almt = value
        End Set
    End Property
End Class
