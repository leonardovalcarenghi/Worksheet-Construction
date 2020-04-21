Imports System.IO

Public Class SoftwareHomeForm

    Dim SaldoDisponivel As Decimal
    Dim TotalOrçado As Decimal = 0
    Dim OldSystem As Boolean = False

    Public LIST_OrçamentosNome As New List(Of String)
    Public LIST_OrçamentosItem As New List(Of OrçamentoItem2Control)


    Private Sub SoftwareHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPanel.Width = 0 : MenuPanel.BringToFront()
        _CreateDirectorys() : ImportarOrçamentos()

        NomeDaObra_Label.Text = My.Settings.OBRA_Name

    End Sub


    Public Sub ImportarOrçamentos()
        OrçamentoLista_PAnel.Controls.Clear()  'Limpar Lista
        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORY_Orçamentos)
        Dim OrçamentosNewSystem() As DirectoryInfo = DirPath.GetDirectories
        Dim Orçamentos() As FileInfo = DirPath.GetFiles()


        ''SISTEMA NOVO''
        If OldSystem = False Then
            For Each A As DirectoryInfo In OrçamentosNewSystem
                Dim Item As New OrçamentoItem2Control : Item = New OrçamentoItem2Control
                Item.OrçamentoPath = A.FullName
                OrçamentoLista_PAnel.Controls.Add(Item) : Item.BringToFront()

                Dim File_ As String = A.FullName & "\file.ini"
                LIST_OrçamentosNome.Add(_INI.ReadIniFile(File_, "ORÇAMENTO", "nome"))
                LIST_OrçamentosItem.Add(Item)
            Next
        End If
      

        ''SISTEMA VELHO''
        For Each B As FileInfo In Orçamentos
            If OldSystem = True Then
                Dim ItemOld As New OrçamentoItemControl : ItemOld = New OrçamentoItemControl
                ItemOld.OrçamentoFile = B.FullName : OrçamentoLista_PAnel.Controls.Add(ItemOld) : ItemOld.BringToFront()
            End If
        Next
        If Orçamentos.Length = 0 Then MenuItemListControl_OldSystem.Visible = False
       

        'Número de Orçamentos
        NúmeroDeOrçamentos_Label.Text = OrçamentosNewSystem.Length

        'Gerar Valor dos Orçamentos
        OrçamentoGasto()
    End Sub


    Public Sub OrçamentoGasto()
        TotalOrçado = 0
        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORY_Orçamentos)
        Dim OrçamentosNewSystem() As DirectoryInfo = DirPath.GetDirectories
        Dim Orçamentos() As FileInfo = DirPath.GetFiles()

        ''SISTEMA NOVO''
        For Each A As DirectoryInfo In OrçamentosNewSystem

            Dim MateriaisFiles() As FileInfo = A.GetFiles
            For Each AA As FileInfo In MateriaisFiles
                If Not AA.Name.Contains("file.ini") Then
                    Dim Valor As Decimal = _INI.ReadIniFile(AA.FullName, "VALORES", "total")
                    TotalOrçado += Valor
                End If
            Next

        Next

        ''SISTEMA VELHO''
        For Each B As FileInfo In Orçamentos
            Dim Valor As Decimal = _INI.ReadIniFile(B.FullName, "VALORES", "total")
            TotalOrçado += Valor
        Next

        'Total Orçado
        OrçamentoGasto_Label.Text = ("R$ " & String.Format("{0:f}", Double.Parse(TotalOrçado)))

        'Importar Saldo Disponível
        ImportSaldos()
    End Sub


    Public Sub ImportSaldos()
        SaldoDisponivel = 0
        Dim DirDirectorie As DirectoryInfo = New DirectoryInfo(_DIRECTORY_Saldos)
        Dim SaldosFile() As FileInfo = DirDirectorie.GetFiles()
        For Each i As FileInfo In SaldosFile
            Dim Valor As String = _INI.ReadIniFile(i.FullName, "SALDO", "valor")
            SaldoDisponivel = SaldoDisponivel + Valor
        Next

        SaldoDisponivel = Val(SaldoDisponivel - TotalOrçado)
        SaldoEmCaixa_Label.Text = "R$ " & String.Format("{0:f}", Double.Parse(SaldoDisponivel))
    End Sub



#Region "Botão - Abrir Menu"

    Private Sub Btn_OpenMenu_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_OpenMenu.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case ModeSearch
                Case False
                    MenuPanel.Width = 300
                Case True
                    ModeSearch = False
                    Btn_OpenMenu.Image = My.Resources.Icon_MenuApp_28x28
                    ImportarOrçamentos()
                    NomeDaObra_Label.Text = My.Settings.OBRA_Name
                    HeaderPanel.Height = 161 : DashboradBackgroundPanel.Show()
            End Select

        End If
    End Sub

    Private Sub Btn_OpenMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_OpenMenu.MouseDown
        Select Case ModeSearch
            Case False
                If e.Button = Windows.Forms.MouseButtons.Left Then Btn_OpenMenu.Image = My.Resources.Icon_MenuApp_Down_28x28
            Case True

        End Select

    End Sub

    Private Sub Btn_OpenMenu_MouseEnter(sender As Object, e As EventArgs) Handles Btn_OpenMenu.MouseEnter
        Select Case ModeSearch
            Case False
                Btn_OpenMenu.Image = My.Resources.Icon_MenuApp_Enter_28x28
            Case True
                Btn_OpenMenu.BackColor = Color.FromArgb(230, 230, 230)
        End Select
    End Sub

    Private Sub Btn_OpenMenu_MouseLeave(sender As Object, e As EventArgs) Handles Btn_OpenMenu.MouseLeave
        Select Case ModeSearch
            Case False
                Btn_OpenMenu.Image = My.Resources.Icon_MenuApp_28x28
        End Select
        Btn_OpenMenu.BackColor = Color.Transparent
    End Sub

    Private Sub MenuPanel_MouseCaptureChanged(sender As Object, e As EventArgs) Handles MenuPanel.MouseCaptureChanged
        MenuPanel.Width = 0
    End Sub

#End Region

#Region "Menu"

    Private Sub MenuItemListControl_NovoOrçamento_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_NovoOrçamento.MouseClick
        MenuPanel.Width = 0
        Dim NovoOrçamento As New LançarNovoOrçamentoDialog : NovoOrçamento = New LançarNovoOrçamentoDialog
        NovoOrçamento.ShowDialog()
    End Sub

    Private Sub MenuItemListControl_LançarValores_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_LançarValores.MouseClick
        MenuPanel.Width = 0
        Dim AddSaldo As New AdicionarSaldoDialog : AddSaldo = New AdicionarSaldoDialog
        AddSaldo.ShowDialog()
    End Sub

    Private Sub MenuItemListControl_ConsultarValores_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_ConsultarValores.MouseClick
        MenuPanel.Width = 0
        Dim Saldos As New SaldosDialog : Saldos = New SaldosDialog
        Saldos.ShowDialog()
    End Sub

    Dim ModeSearch As Boolean = False
    Private Sub MenuItemListControl_Pesquisar_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_Pesquisar.MouseClick
        MenuPanel.Width = 0
        Dim Pesquisar As New PesquisarOrçamentosDialog : Pesquisar = New PesquisarOrçamentosDialog
        If Pesquisar.ShowDialog = Windows.Forms.DialogResult.OK Then
            ModeSearch = True
            Btn_OpenMenu.Image = My.Resources.icons8_voltar_28
            OrçamentoLista_PAnel.Controls.Clear()
            NomeDaObra_Label.Text = "Resultados da Busca para: " & """" & Pesquisar.TextBox_Search.Text & """"
            HeaderPanel.Height = 45 : DashboradBackgroundPanel.Hide()

            Dim Resultados As New List(Of String)
            For Each line In LIST_OrçamentosNome
                If line.StartsWith(Pesquisar.TextBox_Search.Text) Then
                    Resultados.Add(line)
                End If
            Next
            If Resultados.Count = 0 Then
                OrçamentoLista_PAnel.Controls.Add(SearchNotFound)
            Else
                For i = 0 To Resultados.Count - 1
                    Dim IndexL As Integer = LIST_OrçamentosNome.IndexOf(Resultados.Item(i))
                    OrçamentoLista_PAnel.Controls.Add(LIST_OrçamentosItem.Item(IndexL))
                Next
            End If
        End If
    End Sub

    Private Sub MenuItemListControl_OldSystem_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_OldSystem.MouseClick
        MenuPanel.Width = 0
        Select Case OldSystem
            Case True : OldSystem = False : MenuItemListControl_OldSystem.MenuText = "Visualizar Itens do Sistema Antigo" : MenuItemListControl_Pesquisar.Show()
            Case False : OldSystem = True : MenuItemListControl_OldSystem.MenuText = "Visualizar Itens do Sistema Atual" : MenuItemListControl_Pesquisar.Hide()
        End Select
        ImportarOrçamentos()
    End Sub

    Private Sub MenuItemListControl_SoftwareUpdates_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_SoftwareUpdates.MouseClick
        MenuPanel.Width = 0
        Dim CheckForUpdates As New SoftwareUpdatesDialog : CheckForUpdates = New SoftwareUpdatesDialog
        CheckForUpdates.ShowDialog()
    End Sub

    Private Sub MenuItemListControl_Sobre_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_Sobre.MouseClick
        MenuPanel.Width = 0
        AboutSoftwareDialog.ShowDialog()
    End Sub

    Private Sub MenuItemListControl_Sair_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl_Sair.MouseClick
        MenuPanel.Width = 0
        End 'Encerrar Programa
    End Sub

#End Region


 

    Private Sub NomeDaObra_Label_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NomeDaObra_Label.MouseDoubleClick
        If ModeSearch = False Then
            TextBox_ChangeNomeDaObra.Text = My.Settings.OBRA_Name
            TextBox_ChangeNomeDaObra.Show()
            NomeDaObra_Label.Hide()
        End If
    End Sub

    Private Sub TextBox_ChangeNomeDaObra_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_ChangeNomeDaObra.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                My.Settings.OBRA_Name = TextBox_ChangeNomeDaObra.Text
                NomeDaObra_Label.Text = TextBox_ChangeNomeDaObra.Text
                TextBox_ChangeNomeDaObra.Hide()
                NomeDaObra_Label.Show()
            Case Keys.Escape
                TextBox_ChangeNomeDaObra.Hide()
                NomeDaObra_Label.Show()
        End Select
    End Sub

    Private Sub TextBox_ChangeNomeDaObra_LostFocus(sender As Object, e As EventArgs) Handles TextBox_ChangeNomeDaObra.LostFocus
        TextBox_ChangeNomeDaObra.Hide()
        NomeDaObra_Label.Show()
    End Sub

   
End Class
