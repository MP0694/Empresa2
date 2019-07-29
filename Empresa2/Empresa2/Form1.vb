Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Public Class Form1
    Private Sub BtnVerReporte_Click(sender As Object, e As EventArgs) Handles BtnVerReporte.Click
        Dim _report As New RptProductosE2
        _report.generarReporteProductos()
        _report.ShowRibbonPreviewDialog
    End Sub
End Class
