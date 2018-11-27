Public Class ClsEntDetailPembelian
    Private kodebrg As String
    Private kodebeli As String
    Private hrg As Integer
    Private qt As Integer
    Private subtot As Integer
    Private stat As String

    Public Property kode_barang() As String
        Get
            Return kodebrg
        End Get
        Set(value As String)
            kodebrg = value
        End Set
    End Property

    Public Property kode_beli() As String
        Get
            Return kodebeli
        End Get
        Set(value As String)
            kodebeli = value
        End Set
    End Property

    Public Property harga_beli() As Integer
        Get
            Return hrg
        End Get
        Set(value As Integer)
            hrg = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return qt
        End Get
        Set(value As Integer)
            qt = value
        End Set
    End Property

    Public Property sub_total() As Integer
        Get
            Return subtot
        End Get
        Set(value As Integer)
            subtot = value
        End Set
    End Property

    Public Property status_pembayaran() As String
        Get
            Return stat
        End Get
        Set(value As String)
            stat = value
        End Set
    End Property
End Class
