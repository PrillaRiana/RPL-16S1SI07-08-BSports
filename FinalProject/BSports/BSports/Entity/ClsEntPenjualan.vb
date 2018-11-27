Public Class ClsEntPenjualan
    Private kodejual As String
    Private kodekkasir As String
    Private kodecust As String
    Private tanggal As Date
    Private ttl As Integer

    Public Property kode_jual() As String
        Get
            Return kodejual
        End Get
        Set(value As String)
            kodejual = value
        End Set
    End Property

    Public Property kode_kasir() As String
        Get
            Return kodekkasir
        End Get
        Set(value As String)
            kodekkasir = value
        End Set
    End Property

    Public Property kode_cus() As String
        Get
            Return kodecust
        End Get
        Set(value As String)
            kodecust = value
        End Set
    End Property

    Public Property tgl() As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return ttl
        End Get
        Set(value As Integer)
            ttl = value
        End Set
    End Property
End Class
