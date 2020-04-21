Public Class MaterialItemListControl

    Public Frm As LançarNovoOrçamentoDialog
    Public NList As Integer

    Private Sub MaterialItemListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
    End Sub

    Public Property Material_Nome As String
        Get
            Return Label_NomeDoMaterial.Text
        End Get
        Set(value As String)
            Label_NomeDoMaterial.Text = value
        End Set
    End Property

    Dim VAR_Material_ValorTotal As Decimal = 0
    Public Property Material_ValorTotal As Decimal
        Get
            Return VAR_Material_ValorTotal
        End Get
        Set(value As Decimal)
            VAR_Material_ValorTotal = value
            Label_Total.Text = "R$ " & String.Format("{0:f}", Double.Parse(VAR_Material_ValorTotal))
        End Set
    End Property

    Dim VAR_Material_ValorUnitario As Decimal = 0
    Public Property Material_ValorUnitario As Decimal
        Get
            Return VAR_Material_ValorUnitario
        End Get
        Set(value As Decimal)
            VAR_Material_ValorUnitario = value
            Label_ValorUnitario.Text = "R$ " & String.Format("{0:f}", Double.Parse(VAR_Material_ValorUnitario))
        End Set
    End Property

    Dim t As String
    Dim VAR_Material_Quantidade As Decimal = 0
    Public Property Material_Quantidade As Decimal
        Get
            Return VAR_Material_Quantidade
        End Get
        Set(value As Decimal)
            VAR_Material_Quantidade = value
            Select Case VAR_Material_TipoDeVolume
                Case TipoDeVolumeEnum.Unidade : t = " un"
                Case TipoDeVolumeEnum.Kg : t = " Kg"
                Case TipoDeVolumeEnum.M2 : t = " M²"
                Case TipoDeVolumeEnum.M3 : t = " M³"
            End Select
            Label_Quantidade.Text = VAR_Material_Quantidade & " " & t
        End Set
    End Property

    Dim VAR_Material_TipoDeVolume As TipoDeVolumeEnum
    Public Property Material_TipoDeVolume As TipoDeVolumeEnum
        Get
            Return VAR_Material_TipoDeVolume
        End Get
        Set(value As TipoDeVolumeEnum)
            VAR_Material_TipoDeVolume = value
            Select Case VAR_Material_TipoDeVolume
                Case TipoDeVolumeEnum.Unidade : t = " un"
                Case TipoDeVolumeEnum.Kg : t = " Kg"
                Case TipoDeVolumeEnum.M2 : t = " M²"
                Case TipoDeVolumeEnum.M3 : t = " M³"
            End Select
            Label_Quantidade.Text = VAR_Material_Quantidade & " " & t
        End Set
    End Property

    Public Property ShowOtions As Boolean
        Get
            Return Panel_Options.Visible
        End Get
        Set(value As Boolean)
            Panel_Options.Visible = value
        End Set
    End Property


    Public Enum TipoDeVolumeEnum
        Unidade
        Kg
        M2
        M3
    End Enum


    Private Sub Btn_Edit_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_Edit.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            With Frm
                .Button_AddOnList.Text = "Editar  Material"
                .EditItem = Me.NList

                .TextBox_NomeDoMaterial.Text = Material_Nome
                .NumericUpDown_QuantidadeComprada.Value = Material_Quantidade
                Select Case Material_TipoDeVolume
                    Case TipoDeVolumeEnum.Unidade : .RadioButton_Unidade.Checked = True
                    Case TipoDeVolumeEnum.Kg : .RadioButton_KG.Checked = True
                    Case TipoDeVolumeEnum.M2 : .RadioButton_M2.Checked = True
                    Case TipoDeVolumeEnum.M3 : .RadioButton_M3.Checked = True
                End Select
                .TextBox_ValorUnitário.Text = Material_ValorUnitario
                .TextBox_ValorTotal.Text = Material_ValorTotal
                .TabControl1.SelectedTab = .TabPage_AdicionarMaterial
            End With
        End If
    End Sub

    Private Sub Btn_Edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Edit.MouseEnter
        Btn_Edit.Image = My.Resources.Icon_EditItemList_Enter_18x18
    End Sub

    Private Sub Btn_Edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Edit.MouseLeave
        Btn_Edit.Image = My.Resources.Icon_EditItemList_Normal_18x18
    End Sub


    Private Sub Btn_DeleteItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_DeleteItem.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case MessageBox.Show("Deseja realmente remover este material do orçamento?", "Confirmação do Usuário", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Frm.LIST_ListaDeMateriais.Remove(Me)
                    Frm.TabPage_ListaDeMateriais.Controls.Remove(Me)

                    Frm.Button_AddOnList.Text = "Adicionar Material na Lista" : Frm.EditItem = Nothing
            End Select
        End If
    End Sub

    Private Sub Btn_DeleteItem_MouseEnter(sender As Object, e As EventArgs) Handles Btn_DeleteItem.MouseEnter
        Btn_DeleteItem.Image = My.Resources.Icon_DeleteItemList_Enter_18x18
    End Sub

    Private Sub Btn_DeleteItem_MouseLeave(sender As Object, e As EventArgs) Handles Btn_DeleteItem.MouseLeave
        Btn_DeleteItem.Image = My.Resources.Icon_DeleteItemList_Normal_18x18
    End Sub
End Class
