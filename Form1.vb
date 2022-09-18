Public Class Form1
    Private Client As TcpController

    Private Sub SendMessage()
        If Client.Client.Connected Then
            Client.Send(TxtNome.Text & "diz: " & txtMensagem.Text)
        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If TxtNome.TextLength = 0 Then
            MessageBox.Show("Digite seu nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNome.Focus()
            Exit Sub
        End If
        Me.Client = New TcpController("10.0.0.104", 8888)
        If Client.Client.Connected Then
            TxtNome.Enabled = False
            btnConectar.Text = "Conectado"
            btnConectar.Enabled = False
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        SendMessage()
        txtMensagem.Clear()
        txtMensagem.Focus()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
        If Client.Client.Connected Then
            Client.MsgStream.Close()
            Client.Client.Close()
        End If
    End Sub

    Private Sub txtMensagem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMensagem.KeyDown
        If e.KeyCode = Keys.Enter And txtMensagem.TextLength > 0 Then
            btnEnviar_Click(Nothing, Nothing)
        End If
    End Sub
End Class
