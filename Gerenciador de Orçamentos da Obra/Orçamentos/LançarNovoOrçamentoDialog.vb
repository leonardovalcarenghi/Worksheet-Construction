Imports System.Windows.Forms

Public Class LançarNovoOrçamentoDialog
    Public LIST_ListaDeMateriais As New List(Of MaterialItemListControl)


#Region "Adicionar Material na Lista"

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        LimparCampos()
    End Sub

    Private Sub Button_AddOnList_Click(sender As Object, e As EventArgs) Handles Button_AddOnList.Click
        ChecarCampos()
    End Sub

    Private Sub ChecarCampos()
        If TextBox_NomeDoMaterial.Text = Nothing Then
            MessageBox.Show("Digite o nome do material que você comprou.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_NomeDoMaterial.Focus() : TextBox_NomeDoMaterial.Select()
        Else
            If Val(NumericUpDown_QuantidadeComprada.Value) = 0 Then
                MessageBox.Show("Digite a quantidade comprada do meterial.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NumericUpDown_QuantidadeComprada.Focus() : NumericUpDown_QuantidadeComprada.Select()
            Else
                If TextBox_ValorUnitário.Text = Nothing Then
                    MessageBox.Show("Digite o valor unitario/kg/m²/m² do material.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TextBox_ValorUnitário.Focus() : TextBox_ValorUnitário.Select()
                Else
                    If Not IsNumeric(TextBox_ValorUnitário.Text) Then
                        MessageBox.Show("Valor digitado é inválido.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TextBox_ValorUnitário.Focus() : TextBox_ValorUnitário.Select()
                    Else
                        If Val(TextBox_ValorUnitário.Text) <= 0 Then
                            MessageBox.Show("Valor digitado é inválido.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            TextBox_ValorUnitário.Focus() : TextBox_ValorUnitário.Select()
                        Else
                            If TextBox_ValorTotal.Text = Nothing Then
                                MessageBox.Show("Digite o valor total que custou o meterial.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                TextBox_ValorTotal.Focus() : TextBox_ValorTotal.Select()
                            Else
                                If Not IsNumeric(TextBox_ValorTotal.Text) Then
                                    MessageBox.Show("Valor digitado é inválido.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    TextBox_ValorTotal.Focus() : TextBox_ValorTotal.Select()
                                Else
                                    If Val(TextBox_ValorTotal.Text) <= 0 Then
                                        MessageBox.Show("Valor digitado é inválido.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        TextBox_ValorTotal.Focus() : TextBox_ValorTotal.Select()
                                    Else
                                        Select Case EditItem
                                            Case Nothing : AdicionarNaLista()
                                            Case Else : EditarItemDaLista()
                                        End Select
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public EditItem As String
    Private Sub AdicionarNaLista()
        Dim Item As New MaterialItemListControl : Item = New MaterialItemListControl : Item.Frm = Me : Item.NList = LIST_ListaDeMateriais.Count
        Item.Material_Nome = Me.TextBox_NomeDoMaterial.Text
        Item.Material_Quantidade = Me.NumericUpDown_QuantidadeComprada.Value
        Item.Material_TipoDeVolume = Me.TipoDeVolume
        Item.Material_ValorUnitario = Me.TextBox_ValorUnitário.Text
        Item.Material_ValorTotal = Me.TextBox_ValorTotal.Text

        LIST_ListaDeMateriais.Add(Item)
        TabPage_ListaDeMateriais.Controls.Add(Item) : Item.BringToFront()
        If _ParOuImpar(TabPage_ListaDeMateriais.Controls.Count) = True Then Item.BackColor = Color.FromArgb(230, 230, 230)



        Select Case CheckBox_AddAndClear.Checked
            Case True
                Me.TextBox_NomeDoMaterial.Text = ""
                Me.NumericUpDown_QuantidadeComprada.Value = 0
                Me.TextBox_ValorUnitário.Text = "0,00"
                Me.TextBox_ValorTotal.Text = "0,00"
                TextBox_NomeDoMaterial.Select() : TextBox_NomeDoMaterial.Focus()
        End Select

    End Sub

    Private Sub EditarItemDaLista()
        Dim Item = LIST_ListaDeMateriais.Item(EditItem)
        Item.Material_Nome = Me.TextBox_NomeDoMaterial.Text
        Item.Material_Quantidade = Me.NumericUpDown_QuantidadeComprada.Value
        Item.Material_TipoDeVolume = Me.TipoDeVolume
        Item.Material_ValorUnitario = Me.TextBox_ValorUnitário.Text
        Item.Material_ValorTotal = Me.TextBox_ValorTotal.Text

        Select Case CheckBox_AddAndClear.Checked
            Case Windows.Forms.DialogResult.Yes
                Me.TextBox_NomeDoMaterial.Text = ""
                Me.NumericUpDown_QuantidadeComprada.Value = 0
                Me.TextBox_ValorUnitário.Text = "0,00"
                Me.TextBox_ValorTotal.Text = "0,00"
                TextBox_NomeDoMaterial.Select() : TextBox_NomeDoMaterial.Focus()
        End Select


        Button_AddOnList.Text = "Adicionar Material na Lista"
        EditItem = Nothing
    End Sub

    Private Sub LimparCampos()
        Select Case MessageBox.Show("Deseja limpar todas as informações fornecidas?", "Confirmação do Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Me.TextBox_NomeDoMaterial.Text = ""
                Me.NumericUpDown_QuantidadeComprada.Value = 0
                Me.TextBox_ValorUnitário.Text = "0,00"
                Me.TextBox_ValorTotal.Text = "0,00"
                TextBox_NomeDoMaterial.Select() : TextBox_NomeDoMaterial.Focus()
        End Select

        Button_AddOnList.Text = "Adicionar Material na Lista"
        EditItem = Nothing
    End Sub

#End Region

#Region "Selecionar Tipo de Volume"
    Public Enum TipoDeVolumeEnum : Unidade : Kg : M2 : M3 : End Enum
    Dim TipoDeVolume As TipoDeVolumeEnum

    Private Sub RadioButton_Unidade_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Unidade.CheckedChanged
        If RadioButton_Unidade.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor Unitário"
            LabelTip_ValorUnitario.Text = "Digite o valor unitário do material."
            TipoDeVolume = TipoDeVolumeEnum.Unidade
        End If
    End Sub

    Private Sub RadioButton_KG_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_KG.CheckedChanged
        If RadioButton_KG.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por Kg"
            LabelTip_ValorUnitario.Text = "Digite o valor por Kg do material."
            TipoDeVolume = TipoDeVolumeEnum.Kg
        End If
    End Sub

    Private Sub RadioButton_M2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_M2.CheckedChanged
        If RadioButton_M2.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por m²"
            LabelTip_ValorUnitario.Text = "Digite o valor por m² do material."
            TipoDeVolume = TipoDeVolumeEnum.M2
        End If
    End Sub

    Private Sub RadioButton_M3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_M3.CheckedChanged
        If RadioButton_M3.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por m³"
            LabelTip_ValorUnitario.Text = "Digite o valor por m³ do material."
            TipoDeVolume = TipoDeVolumeEnum.M3
        End If
    End Sub
#End Region

#Region "Calcular Valores do Orçamento "
    Dim Total As Decimal
    Private Sub TabPage_ListaDeMateriais_ControlRemoved(sender As Object, e As ControlEventArgs) Handles TabPage_ListaDeMateriais.ControlRemoved
        For i = 0 To LIST_ListaDeMateriais.Count - 1
            If _ParOuImpar(i) = False Then LIST_ListaDeMateriais.Item(i).BackColor = Color.FromArgb(230, 230, 230) Else LIST_ListaDeMateriais.Item(i).BackColor = Color.Transparent
        Next

        Label_TotalDeMateriais.Text = LIST_ListaDeMateriais.Count

        Total = 0
        For i = 0 To LIST_ListaDeMateriais.Count - 1 : Total += LIST_ListaDeMateriais.Item(i).Material_ValorTotal : Next
        Label_TotalDoOrçamento.Text = "R$ " & String.Format("{0:f}", Double.Parse(Total))
    End Sub

    Private Sub TabPage_ListaDeMateriais_ControlAdded(sender As Object, e As ControlEventArgs) Handles TabPage_ListaDeMateriais.ControlAdded
        Label_TotalDeMateriais.Text = LIST_ListaDeMateriais.Count

        Total = 0
        For i = 0 To LIST_ListaDeMateriais.Count - 1 : Total += LIST_ListaDeMateriais.Item(i).Material_ValorTotal : Next
        Label_TotalDoOrçamento.Text = "R$ " & String.Format("{0:f}", Double.Parse(Total))
    End Sub
#End Region

#Region "Calculos Automatico"
    Private Sub NumericUpDown_QuantidadeComprada_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_QuantidadeComprada.ValueChanged
        Select Case CheckBox_AutoCalc.Checked
            Case True
                Try : TextBox_ValorTotal.Text = (System.Convert.ToDecimal(NumericUpDown_QuantidadeComprada.Value) * (System.Convert.ToDecimal(TextBox_ValorUnitário.Text))) : Catch : End Try
        End Select
    End Sub

    Private Sub TextBox_ValorUnitário_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ValorUnitário.TextChanged
        Select Case CheckBox_AutoCalc.Checked
            Case True
                Try : TextBox_ValorTotal.Text = (System.Convert.ToDecimal(NumericUpDown_QuantidadeComprada.Value) * (System.Convert.ToDecimal(TextBox_ValorUnitário.Text))) : Catch : End Try
        End Select
    End Sub
#End Region
 

   
    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        If TextBox_NomeDoOrçamento.Text = Nothing Then
            MsgBox("Digite o nome do seu orçamento", MsgBoxStyle.Critical)
        Else
            If TextBox_LocalDaCompra.Text = Nothing Then
                MsgBox("Digite o local da compra", MsgBoxStyle.Critical)
            Else
                If LIST_ListaDeMateriais.Count = 0 Then
                    MsgBox("Não é possível lançar o orçamento no sistema, sem adicionar primeiro materiais na lista.", MsgBoxStyle.Critical)
                Else
                    CriarOrçamento()
                End If
            End If
        End If
    End Sub

    Function GerarCodigoDoOrçamento() As String
        Dim Gerador As New Random
        Dim ABC() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z"}
        Dim N123() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

        Dim Letras = ""
        Dim Numeros = ""

        For A = 1 To 5
            Dim i As Integer = Gerador.Next(0, ABC.Length)
            Letras = Letras + ABC(i)
        Next

        For B = 1 To 5
            Dim i As Integer = Gerador.Next(0, N123.Length)
            Numeros = Numeros + N123(i)
        Next

        Return Letras & Numeros
    End Function

    Private Sub CriarOrçamento()
        Dim CódigoDoOrçamento = GerarCodigoDoOrçamento()
        While IO.Directory.Exists(_DIRECTORY_Orçamentos & CódigoDoOrçamento)
            CódigoDoOrçamento = GerarCodigoDoOrçamento()
        End While

        Dim FolderPath As String = _DIRECTORY_Orçamentos & CódigoDoOrçamento & "\" : IO.Directory.CreateDirectory(FolderPath)

        'Nome do Orçamento
        _INI.WriteIniFile(FolderPath & "file.ini", "ORÇAMENTO", "nome", TextBox_NomeDoOrçamento.Text)
        'Descrição do Orçamento
        _INI.WriteIniFile(FolderPath & "file.ini", "ORÇAMENTO", "descrição", TextBox_Descrição.Text)
        'Data do Orçamento
        _INI.WriteIniFile(FolderPath & "file.ini", "ORÇAMENTO", "data", DateTimePicker_DataDaCompra.Value.Date)
        'Local da Compra
        _INI.WriteIniFile(FolderPath & "file.ini", "ORÇAMENTO", "local", TextBox_LocalDaCompra.Text)

        For i = 0 To LIST_ListaDeMateriais.Count - 1 Step 1
            Dim Item = LIST_ListaDeMateriais.Item(i)
            'Nome do Material
            _INI.WriteIniFile(FolderPath & i & ".ini", "MATERIAL", "nome", Item.Material_Nome)
            'Valor Unitário do Material
            _INI.WriteIniFile(FolderPath & i & ".ini", "VALORES", "unitario", Item.Material_ValorUnitario)
            'Valor Total do Material
            _INI.WriteIniFile(FolderPath & i & ".ini", "VALORES", "total", Item.Material_ValorTotal)
            'Quantidade do Material
            _INI.WriteIniFile(FolderPath & i & ".ini", "QUANTIDADE", "quantidade", Item.Material_Quantidade)
            'Tipo de Volume
            _INI.WriteIniFile(FolderPath & i & ".ini", "QUANTIDADE", "tipo", Item.Material_TipoDeVolume)
        Next

        MessageBox.Show("Seu orçamento foi lançado com sucesso ao sistema do software.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SoftwareHomeForm.ImportarOrçamentos()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LançarNovoOrçamentoDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
