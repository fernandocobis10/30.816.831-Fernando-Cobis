<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblEstado = New Label()
        btnVerificar = New Button()
        SuspendLayout()
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(340, 45)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(41, 15)
        lblEstado.TabIndex = 0
        lblEstado.Text = "Label1"
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(301, 98)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(110, 23)
        btnVerificar.TabIndex = 1
        btnVerificar.Text = "Verificar Estado del Libro"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerificar)
        Controls.Add(lblEstado)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEstado As Label
    Friend WithEvents btnVerificar As Button
End Class
