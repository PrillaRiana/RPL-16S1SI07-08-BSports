Public Class ClsEntBarang

    Private kodebrg As String
    Private kodejenis As String
    Private namabrg As String
    Private hrg As Integer
    Private jml As Integer



    Public Property kode_barang() As String
        Get
            Return kodebrg
        End Get
        Set(value As String)
            kodebrg = value
        End Set
    End Property

    Public Property kode_jenis() As String
        Get
            Return kodejenis
        End Get
        Set(value As String)
            kodejenis = value
        End Set
    End Property

    Public Property nama_barang() As String
        Get
            Return namabrg
        End Get
        Set(value As String)
            namabrg = value
        End Set
    End Property

    Public Property harga() As Integer
            Get
                Return hrg
            End Get
            Set(value As Integer)
                hrg = value
            End Set
        End Property

    Public Property qty() As Integer
        Get
            Return jml
        End Get
        Set(value As Integer)
            jml = value
        End Set
    End Property
End Class
