Imports System.IO
Imports System.Net.Sockets
Imports System.Net

Public Class TcpController
    Public Client As TcpClient
    Public MsgStream As StreamWriter

    Public Sub Send(Mensagem As String)
        Me.MsgStream.Write(Mensagem & vbCrLf)
        Me.MsgStream.Flush()
    End Sub

    Public Sub New(Host As String, Port As Integer)
        Me.Client = New TcpClient(Host, Port)
        Me.MsgStream = New StreamWriter(Client.GetStream)
    End Sub
End Class
