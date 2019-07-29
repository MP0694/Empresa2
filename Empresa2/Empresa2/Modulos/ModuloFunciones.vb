Imports System.Data.SqlClient
Module ModuloFunciones

    Public conexion As SqlConnection
    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=DESKTOP-4HLAE6I;Initial Catalog=SDFacturacion;User ID=sd;Password=BDSD*2016+")
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
            conexion.Close()
        End Try
    End Sub


End Module
