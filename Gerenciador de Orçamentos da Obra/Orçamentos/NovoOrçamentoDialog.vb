Imports System.Windows.Forms

Public Class NovoOrçamentoDialog

    Dim PerguntarSaida As Boolean = True
    Dim TipoDeQuanti As TipoDeVolumeEnum
    Private Sub RadioButton_Unidade_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Unidade.CheckedChanged
        If RadioButton_Unidade.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor Unitário"
            LabelTip_ValorUnitario.Text = "Digite o valor unitário do material."
            TipoDeQuanti = TipoDeVolumeEnum.Unidade
        End If
    End Sub

    Private Sub RadioButton_KG_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_KG.CheckedChanged
        If RadioButton_KG.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por Kg"
            LabelTip_ValorUnitario.Text = "Digite o valor por Kg do material."
            TipoDeQuanti = TipoDeVolumeEnum.Kg
        End If
    End Sub

    Private Sub RadioButton_M2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_M2.CheckedChanged
        If RadioButton_M2.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por m²"
            LabelTip_ValorUnitario.Text = "Digite o valor por m² do material."
            TipoDeQuanti = TipoDeVolumeEnum.M2
        End If
    End Sub

    Private Sub RadioButton_M3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_M3.CheckedChanged
        If RadioButton_M3.Checked Then
            Label_Legenda_ValorETipo.Text = "&Valor por m³"
            LabelTip_ValorUnitario.Text = "Digite o valor por m³ do material."
            TipoDeQuanti = TipoDeVolumeEnum.M3
        End If
    End Sub

    Private Sub NovoOrçamentoDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If PerguntarSaida = True Then
            Select Case MessageBox.Show("Deseja realmente sair da tela de novo orçamento?" & vbNewLine & "As alterações feitas serão perdidas.", "Confirmação do Usuário", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Case Windows.Forms.DialogResult.Yes : e.Cancel = False
                Case Windows.Forms.DialogResult.No, Windows.Forms.DialogResult.Cancel : e.Cancel = True
            End Select
        Else
            e.Cancel = False
        End If
  
    End Sub

  Public Enum TipoDeVolumeEnum
        Unidade
        Kg
        M2
        M3
    End Enum


    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        ChecarCampos()
    End Sub

    Private Sub ChecarCampos()
        If TextBox_NomeDoMaterial.Text = Nothing Then
            MessageBox.Show("Digite o nome do material que você comprou.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_NomeDoMaterial.Focus() : TextBox_NomeDoMaterial.Select()
        Else
            If TextBox_LocalDaCompra.Text = Nothing Then
                MessageBox.Show("Digite o nome do estabelecimento em que você compro este material.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox_LocalDaCompra.Focus() : TextBox_LocalDaCompra.Select()
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
                                            SalvarOrçamento()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub SalvarOrçamento()
        Dim CódigoDoOrçamento = GerarCodigoDoOrçamento()
        While IO.File.Exists(_DIRECTORY_Orçamentos & CódigoDoOrçamento & ".ini")
            CódigoDoOrçamento = GerarCodigoDoOrçamento()
        End While

        Dim FilePath As String = _DIRECTORY_Orçamentos & CódigoDoOrçamento & ".ini"


        'Nome
        _INI.WriteIniFile(FilePath, "MATERIAL", "nome", TextBox_NomeDoMaterial.Text)

        'Descrição
        _INI.WriteIniFile(FilePath, "DESCRIÇÃO", "texto", TextBox_Descrição.Text)

        'Valor Unitario
        _INI.WriteIniFile(FilePath, "VALORES", "unitario", TextBox_ValorUnitário.Text)

        'Valor Total
        _INI.WriteIniFile(FilePath, "VALORES", "total", TextBox_ValorTotal.Text)

        'Quantidade
        _INI.WriteIniFile(FilePath, "QUANTIDADE", "quantidade", NumericUpDown_QuantidadeComprada.Value)

        'Tipo de Quantidade
        _INI.WriteIniFile(FilePath, "QUANTIDADE", "tipo", TipoDeQuanti)

        'Local da Compra
        _INI.WriteIniFile(FilePath, "COMPRADO", "local", TextBox_LocalDaCompra.Text)

        'Data da Compra
        _INI.WriteIniFile(FilePath, "COMPRADO", "data", DateTimePicker_DataDaCompra.Value.Date)


        MessageBox.Show("O orçamento foi lançado com exitô no sistema", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SoftwareHomeForm.ImportarOrçamentos()
        PerguntarSaida = False
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
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

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        PerguntarSaida = True
        Me.Close()
    End Sub


    Private Sub NumericUpDown_QuantidadeComprada_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_QuantidadeComprada.ValueChanged
        Try
            Dim T As Decimal = Val(TextBox_ValorUnitário.Text) * Val(NumericUpDown_QuantidadeComprada.Value)
            TextBox_ValorTotal.Text = String.Format("{0:f}", Double.Parse(T))
        Catch : End Try
    End Sub

    Private Sub TextBox_ValorUnitário_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ValorUnitário.TextChanged
        Try
            Dim T As Decimal = Val(TextBox_ValorUnitário.Text) * Val(NumericUpDown_QuantidadeComprada.Value)
            TextBox_ValorTotal.Text = String.Format("{0:f}", Double.Parse(T))
        Catch : End Try
    End Sub

    Private Sub NovoOrçamentoDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
