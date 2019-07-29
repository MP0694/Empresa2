Public Class RptProductosE2

    Public Sub generarReporteProductos()
        Me.ProductosTableAdapter.Fill(DataSetReportes1.productos)
    End Sub

End Class