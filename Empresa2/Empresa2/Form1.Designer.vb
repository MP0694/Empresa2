<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnVerReporte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnVerReporte
        '
        Me.BtnVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerReporte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerReporte.ForeColor = System.Drawing.Color.White
        Me.BtnVerReporte.Location = New System.Drawing.Point(90, 113)
        Me.BtnVerReporte.Name = "BtnVerReporte"
        Me.BtnVerReporte.Size = New System.Drawing.Size(216, 88)
        Me.BtnVerReporte.TabIndex = 1
        Me.BtnVerReporte.Text = "Ver Reporte"
        Me.BtnVerReporte.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(397, 315)
        Me.Controls.Add(Me.BtnVerReporte)
        Me.Name = "Form1"
        Me.Text = "FORMULARIO DE PRODUCTOS EMPRESA2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnVerReporte As Button
End Class
