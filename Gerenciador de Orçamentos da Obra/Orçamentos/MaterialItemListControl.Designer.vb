<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialItemListControl
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Quantidade = New System.Windows.Forms.Label()
        Me.Label_ValorUnitario = New System.Windows.Forms.Label()
        Me.Label_Total = New System.Windows.Forms.Label()
        Me.Label_NomeDoMaterial = New System.Windows.Forms.Label()
        Me.Panel_Options = New System.Windows.Forms.Panel()
        Me.Btn_Edit = New System.Windows.Forms.PictureBox()
        Me.Btn_DeleteItem = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel_Options.SuspendLayout()
        CType(Me.Btn_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_DeleteItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Quantidade)
        Me.Panel1.Controls.Add(Me.Label_ValorUnitario)
        Me.Panel1.Controls.Add(Me.Label_Total)
        Me.Panel1.Controls.Add(Me.Label_NomeDoMaterial)
        Me.Panel1.Controls.Add(Me.Panel_Options)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 30)
        Me.Panel1.TabIndex = 0
        '
        'Label_Quantidade
        '
        Me.Label_Quantidade.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_Quantidade.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_Quantidade.Location = New System.Drawing.Point(432, 0)
        Me.Label_Quantidade.Name = "Label_Quantidade"
        Me.Label_Quantidade.Size = New System.Drawing.Size(130, 30)
        Me.Label_Quantidade.TabIndex = 36
        Me.Label_Quantidade.Text = "0"
        Me.Label_Quantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_ValorUnitario
        '
        Me.Label_ValorUnitario.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_ValorUnitario.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_ValorUnitario.Location = New System.Drawing.Point(562, 0)
        Me.Label_ValorUnitario.Name = "Label_ValorUnitario"
        Me.Label_ValorUnitario.Size = New System.Drawing.Size(130, 30)
        Me.Label_ValorUnitario.TabIndex = 35
        Me.Label_ValorUnitario.Text = "R$ 0,00"
        Me.Label_ValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Total
        '
        Me.Label_Total.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_Total.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_Total.Location = New System.Drawing.Point(692, 0)
        Me.Label_Total.Name = "Label_Total"
        Me.Label_Total.Size = New System.Drawing.Size(130, 30)
        Me.Label_Total.TabIndex = 34
        Me.Label_Total.Text = "R$ 0,00"
        Me.Label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_NomeDoMaterial
        '
        Me.Label_NomeDoMaterial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_NomeDoMaterial.AutoSize = True
        Me.Label_NomeDoMaterial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NomeDoMaterial.Location = New System.Drawing.Point(10, 8)
        Me.Label_NomeDoMaterial.Name = "Label_NomeDoMaterial"
        Me.Label_NomeDoMaterial.Size = New System.Drawing.Size(103, 15)
        Me.Label_NomeDoMaterial.TabIndex = 28
        Me.Label_NomeDoMaterial.Text = "&Nome do Material"
        '
        'Panel_Options
        '
        Me.Panel_Options.Controls.Add(Me.Btn_Edit)
        Me.Panel_Options.Controls.Add(Me.Btn_DeleteItem)
        Me.Panel_Options.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Options.Location = New System.Drawing.Point(822, 0)
        Me.Panel_Options.Name = "Panel_Options"
        Me.Panel_Options.Size = New System.Drawing.Size(70, 30)
        Me.Panel_Options.TabIndex = 37
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Edit.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_EditItemList_Normal_18x18
        Me.Btn_Edit.Location = New System.Drawing.Point(8, 3)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(24, 24)
        Me.Btn_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_Edit.TabIndex = 1
        Me.Btn_Edit.TabStop = False
        '
        'Btn_DeleteItem
        '
        Me.Btn_DeleteItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_DeleteItem.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_DeleteItemList_Normal_18x18
        Me.Btn_DeleteItem.Location = New System.Drawing.Point(38, 3)
        Me.Btn_DeleteItem.Name = "Btn_DeleteItem"
        Me.Btn_DeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.Btn_DeleteItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_DeleteItem.TabIndex = 0
        Me.Btn_DeleteItem.TabStop = False
        '
        'MaterialItemListControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MaterialItemListControl"
        Me.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Size = New System.Drawing.Size(892, 34)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Options.ResumeLayout(False)
        CType(Me.Btn_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_DeleteItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_NomeDoMaterial As System.Windows.Forms.Label
    Friend WithEvents Label_Quantidade As System.Windows.Forms.Label
    Friend WithEvents Label_ValorUnitario As System.Windows.Forms.Label
    Friend WithEvents Label_Total As System.Windows.Forms.Label
    Friend WithEvents Panel_Options As System.Windows.Forms.Panel
    Friend WithEvents Btn_Edit As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_DeleteItem As System.Windows.Forms.PictureBox

End Class
