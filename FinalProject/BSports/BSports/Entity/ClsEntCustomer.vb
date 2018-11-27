Public Class ClsEntCustomer
    Private kodecust As String
    Private namacust As String
    Private almt As String
    Private telp As String


    Public Property kode_cus() As String
        Get
            Return kodecust
        End Get
        Set(value As String)
            kodecust = value
        End Set
    End Property

    Public Property nama_cus() As String
        Get
            Return namacust
        End Get
        Set(value As String)
            namacust = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return almt
        End Get
        Set(value As String)
            almt = value
        End Set
    End Property

    Public Property no_telp() As String
        Get
            Return telp
        End Get
        Set(value As String)
            telp = value
        End Set
    End Property

End Class
