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
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.labelNome = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.LabelMensagem = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(112, 28)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(342, 23)
        Me.TxtNome.TabIndex = 0
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(112, 87)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(342, 85)
        Me.txtMensagem.TabIndex = 1
        '
        'labelNome
        '
        Me.labelNome.AutoSize = True
        Me.labelNome.Location = New System.Drawing.Point(23, 36)
        Me.labelNome.Name = "labelNome"
        Me.labelNome.Size = New System.Drawing.Size(43, 15)
        Me.labelNome.TabIndex = 2
        Me.labelNome.Text = "Nome:"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(169, 197)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 3
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'LabelMensagem
        '
        Me.LabelMensagem.AutoSize = True
        Me.LabelMensagem.Location = New System.Drawing.Point(23, 90)
        Me.LabelMensagem.Name = "LabelMensagem"
        Me.LabelMensagem.Size = New System.Drawing.Size(69, 15)
        Me.LabelMensagem.TabIndex = 4
        Me.LabelMensagem.Text = "Mensagem:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(290, 197)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 283)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.LabelMensagem)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.labelNome)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.TxtNome)
        Me.Name = "Form1"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNome As TextBox
    Friend WithEvents txtMensagem As TextBox
    Friend WithEvents labelNome As Label
    Friend WithEvents btnConectar As Button
    Friend WithEvents LabelMensagem As Label
    Friend WithEvents btnEnviar As Button
End Class
