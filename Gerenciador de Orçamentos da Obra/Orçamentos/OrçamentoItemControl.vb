Public Class OrçamentoItemControl

    Public OrçamentoFile As String

    Private Sub OrçamentoItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent

        ObterInformações()
    End Sub

    Private Sub ObterInformações()
        'NOME
        Label_NomeDoMaterial.Text = _INI.ReadIniFile(OrçamentoFile, "MATERIAL", "nome")

        'DESCRIÇÃO
        Dim DescriçãoDoItem As String = _INI.ReadIniFile(OrçamentoFile, "DESCRIÇÃO", "texto")
        If DescriçãoDoItem <> Nothing Then
            Label_NomeDoMaterial.Top = 5
            Label_Descrição.Text = DescriçãoDoItem
        Else
            Label_NomeDoMaterial.Top = (Panel1.Height - Label_NomeDoMaterial.Height) / 2
            Label_Descrição.Text = Nothing
        End If

        'QUANTIDADE / TIPO DE VOLUME
        Dim QuantidadeComprada As Decimal = _INI.ReadIniFile(OrçamentoFile, "QUANTIDADE", "quantidade", 0)
        Dim TipoDeVolume As TipoDeVolumeEnum = _INI.ReadIniFile(OrçamentoFile, "QUANTIDADE", "tipo", 0)
        Dim TipoDeVolumeStringVar As String
        Select Case TipoDeVolume
            Case TipoDeVolumeEnum.Unidade : TipoDeVolumeStringVar = " un"
            Case TipoDeVolumeEnum.Kg : TipoDeVolumeStringVar = " Kg"
            Case TipoDeVolumeEnum.M2 : TipoDeVolumeStringVar = " M²"
            Case TipoDeVolumeEnum.M3 : TipoDeVolumeStringVar = " M³"
        End Select
        Label_Quantidade.Text = QuantidadeComprada & TipoDeVolumeStringVar


        'VALOR UNITÁRIO
        Dim ValorUnitario As Decimal = _INI.ReadIniFile(OrçamentoFile, "VALORES", "unitario")
        Label_ValorUnitario.Text = "R$ " & String.Format("{0:f}", Double.Parse(ValorUnitario))

        'VALOR TOTAL
        Dim ValorTotal As Decimal = _INI.ReadIniFile(OrçamentoFile, "VALORES", "total")
        Label_Total.Text = "R$ " & String.Format("{0:f}", Double.Parse(ValorTotal))

        'Data
        Dim DataDaCompra As Date = _INI.ReadIniFile(OrçamentoFile, "COMPRADO", "data")
        Label_DatadaCompra.Text = DataDaCompra.Date

        'Local
        Label_LocalDaCompra.Text = _INI.ReadIniFile(OrçamentoFile, "COMPRADO", "local")
    End Sub

    Public Enum TipoDeVolumeEnum
        Unidade
        Kg
        M2
        M3
    End Enum

End Class
