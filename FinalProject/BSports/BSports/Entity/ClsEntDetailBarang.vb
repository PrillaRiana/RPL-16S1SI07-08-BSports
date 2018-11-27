Public Class ClsEntDetailBarang
    Private kodebrg As String
    Private jnsbrg As String
    Private ukur As String

    Public Property kode_barang() As String
        Get
            Return kodebrg
        End Get
        Set(value As String)
            kodebrg = value
        End Set
    End Property

    Public Property jenis_barang() As String
        Get
            Return jnsbrg
        End Get
        Set(value As String)
            jnsbrg = value
        End Set
    End Property

    Public Property ukuran() As String
        Get
            Return ukur
        End Get
        Set(value As String)
            ukur = value
        End Set
    End Property

End Class
