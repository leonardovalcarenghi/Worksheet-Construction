Imports System.IO

Public Class OrçamentoItem2Control


    Public Property OrçamentoPath As String

    Private Sub OrçamentoItem2Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
        ImportarInformações()
    End Sub

    Private Sub ImportarInformações()
        Dim File_ As String = OrçamentoPath & "\file.ini"
        'Nome do Orçamento
        Label_NomeDoOrçamento.Text = _INI.ReadIniFile(File_, "ORÇAMENTO", "nome")
        'Local da Compra
        Label_LocalDaCompra.Text = _INI.ReadIniFile(File_, "ORÇAMENTO", "local")
        'Data da Compra
        Label_DatadaCompra.Text = _INI.ReadIniFile(File_, "ORÇAMENTO", "data")
        'Valor da Compra

        Label_Total.Text = "R$ " & String.Format("{0:f}", Double.Parse(ValorDoOrçamento(OrçamentoPath)))

    End Sub

  

    Function ValorDoOrçamento(ByVal orçamento_path As String) As Decimal
        Dim ValorTotal As Decimal = 0
        Dim FolderPath As DirectoryInfo = New DirectoryInfo(orçamento_path)
        Dim FilesInFolder() As FileInfo = FolderPath.GetFiles()
        For Each i As FileInfo In FilesInFolder
            If i.Name <> "file.ini" Then
                ValorTotal += _INI.ReadIniFile(i.FullName, "VALORES", "total", 0)
            End If
        Next
        Return ValorTotal
    End Function



    Private Sub Control_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel5.MouseClick, Panel4.MouseClick, Panel3.MouseClick, Panel2.MouseClick, Panel1.MouseClick, Label_Total.MouseClick, Label_NomeDoOrçamento.MouseClick, Label_LocalDaCompra.MouseClick, Label_DatadaCompra.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then _AbrirOrçamento(OrçamentoPath)
    End Sub

    Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown, Panel4.MouseDown, Panel3.MouseDown, Panel2.MouseDown, Panel1.MouseDown, Label_Total.MouseDown, Label_NomeDoOrçamento.MouseDown, Label_LocalDaCompra.MouseDown, Label_DatadaCompra.MouseDown
        Panel1.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub Control_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter, Panel4.MouseEnter, Panel3.MouseEnter, Panel2.MouseEnter, Panel1.MouseEnter, Label_Total.MouseEnter, Label_NomeDoOrçamento.MouseEnter, Label_LocalDaCompra.MouseEnter, Label_DatadaCompra.MouseEnter
        Panel1.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub Control_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave, Panel4.MouseLeave, Panel3.MouseLeave, Panel2.MouseLeave, Panel1.MouseLeave, Label_Total.MouseLeave, Label_NomeDoOrçamento.MouseLeave, Label_LocalDaCompra.MouseLeave, Label_DatadaCompra.MouseLeave
        Panel1.BackColor = Color.Transparent
    End Sub
End Class
