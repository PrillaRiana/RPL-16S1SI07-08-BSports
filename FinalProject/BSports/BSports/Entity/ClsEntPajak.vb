Public Class ClsEntPajak
    Private nopajak As String
    Private kodedp As String
    Private besarpjk As Double
    Private tot As Integer


    Public Property no_pajak() As String
        Get
            Return nopajak
        End Get
        Set(value As String)
            nopajak = value
        End Set
    End Property

    Public Property kode_dp() As String
        Get
            Return kodedp
        End Get
        Set(value As String)
            kodedp = value
        End Set
    End Property

    Public Property besar_pajak() As Double
        Get
            Return besarpjk
        End Get
        Set(value As Double)
            besarpjk = value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return tot
        End Get
        Set(value As Integer)
            tot = value
        End Set
    End Property
End Class
