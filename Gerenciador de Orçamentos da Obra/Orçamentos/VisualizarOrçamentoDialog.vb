Imports System.IO

Public Class VisualizarOrçamentoDialog

    Public ORÇAMENTO_Path As String

    Private Sub VisualizarOrçamentoDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim item As Integer = _LIST_OrçamentosAbertosForms.IndexOf(Me)
        _LIST_OrçamentosAbertosForms.RemoveAt(item) : _LIST_OrçamentosAbertos.RemoveAt(item)
    End Sub

    Private Sub VisualizarOrçamentoDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInformations()
        CarregarListaDeMateriais()
        ValorDoOrçamento()

    End Sub

    Private Sub LoadInformations()
        Dim Nome As String = _INI.ReadIniFile(ORÇAMENTO_Path & "\file.ini", "ORÇAMENTO", "nome")
        Dim Descrição As String = _INI.ReadIniFile(ORÇAMENTO_Path & "\file.ini", "ORÇAMENTO", "descrição", Nothing)



        Me.Text = "Visualizar Orçamento - " & Nome
        NomeDoOrçamento_Label.Text = Nome
        Select Case Descrição
            Case Nothing
                NomeDoOrçamento_Label.Top = (PanelHearder.Height - NomeDoOrçamento_Label.Height) / 2
                DescriçãoDoOrçamento_Label.Text = ""
            Case Else
                NomeDoOrçamento_Label.Top = 25
                DescriçãoDoOrçamento_Label.Text = Descrição
        End Select

        'DATA
        Dim DataDoOrçamento As Date = _INI.ReadIniFile(ORÇAMENTO_Path & "\file.ini", "ORÇAMENTO", "data")
        StartDate_Label.Text = DataDoOrçamento.Day & " de " & MonthName(DataDoOrçamento.Month) & " de " & DataDoOrçamento.Year

        'LOCAL
        Dim LocalDaCompra = _INI.ReadIniFile(ORÇAMENTO_Path & "\file.ini", "ORÇAMENTO", "local")
        LocalDaCompra_Label.Text = LocalDaCompra
    End Sub

    Private Sub CarregarListaDeMateriais()
        Dim FolderPath As DirectoryInfo = New DirectoryInfo(ORÇAMENTO_Path)
        Dim FilesInFolder() As FileInfo = FolderPath.GetFiles()

        For Each i As FileInfo In FilesInFolder
            Dim Item As New MaterialItemListControl
            Item = New MaterialItemListControl
            Item.ShowOtions = False

            If i.Name <> "file.ini" Then
                Dim FileMaterial As String = i.FullName

                'Nome
                Item.Material_Nome = _INI.ReadIniFile(FileMaterial, "MATERIAL", "nome")

                'Valor Unitario
                Item.Material_ValorUnitario = _INI.ReadIniFile(FileMaterial, "VALORES", "unitario")

                'Total
                Item.Material_ValorTotal = _INI.ReadIniFile(FileMaterial, "VALORES", "total")

                'Quantidade
                Item.Material_Quantidade = _INI.ReadIniFile(FileMaterial, "QUANTIDADE", "quantidade")

                'Tipo de Volume
                Item.Material_TipoDeVolume = _INI.ReadIniFile(FileMaterial, "QUANTIDADE", "tipo")

                TabPage_ListaDeMateriais.Controls.Add(Item) : Item.BringToFront()
                If _ParOuImpar(TabPage_ListaDeMateriais.Controls.Count) = True Then Item.BackColor = Color.FromArgb(230, 230, 230)
            End If
        Next
        TotaldeItens_Label.Text = FilesInFolder.Length - 1
    End Sub

    Private Sub ValorDoOrçamento()
        Dim ValorTotal As Decimal = 0
        Dim FolderPath As DirectoryInfo = New DirectoryInfo(ORÇAMENTO_Path)
        Dim FilesInFolder() As FileInfo = FolderPath.GetFiles()
        For Each i As FileInfo In FilesInFolder
            If i.Name <> "file.ini" Then
                ValorTotal += _INI.ReadIniFile(i.FullName, "VALORES", "total", 0)
            End If
        Next
        ValorDoOrçamento_Label.Text = "R$ " & String.Format("{0:f}", Double.Parse(ValorTotal))
    End Sub
End Class