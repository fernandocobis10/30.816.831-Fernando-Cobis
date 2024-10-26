<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        txtAnioPublicacion = New TextBox()
        btnPrestar = New Button()
        btnDevolver = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnVerificar = New Button()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(112, 115)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(100, 23)
        txtTitulo.TabIndex = 0
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(330, 115)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(100, 23)
        txtAutor.TabIndex = 1
        ' 
        ' txtAnioPublicacion
        ' 
        txtAnioPublicacion.Location = New Point(554, 115)
        txtAnioPublicacion.Name = "txtAnioPublicacion"
        txtAnioPublicacion.Size = New Size(100, 23)
        txtAnioPublicacion.TabIndex = 2
        ' 
        ' btnPrestar
        ' 
        btnPrestar.BackColor = SystemColors.ButtonHighlight
        btnPrestar.Location = New Point(229, 226)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(89, 23)
        btnPrestar.TabIndex = 3
        btnPrestar.Text = "Prestar Libro"
        btnPrestar.UseVisualStyleBackColor = False
        ' 
        ' btnDevolver
        ' 
        btnDevolver.Location = New Point(455, 226)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(92, 23)
        btnDevolver.TabIndex = 4
        btnDevolver.Text = "Devolver Libro"
        btnDevolver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(137, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 21)
        Label1.TabIndex = 6
        Label1.Text = "Libro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(361, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 21)
        Label2.TabIndex = 7
        Label2.Text = "Autor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(540, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 21)
        Label3.TabIndex = 8
        Label3.Text = "Año de publicacion"
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(330, 307)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(110, 23)
        btnVerificar.TabIndex = 10
        btnVerificar.Text = "Verificar Estado del Libro"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(799, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.Location = New Point(317, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 37)
        Label4.TabIndex = 12
        Label4.Text = "Biblioteca"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(274, 392)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 21)
        Label5.TabIndex = 13
        Label5.Text = "Fernando Cobis / 30.816.831"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnVerificar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDevolver)
        Controls.Add(btnPrestar)
        Controls.Add(txtAnioPublicacion)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtAnioPublicacion As TextBox
    Friend WithEvents btnPrestar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
