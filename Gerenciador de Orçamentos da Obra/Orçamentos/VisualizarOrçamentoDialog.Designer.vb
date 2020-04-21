<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarOrçamentoDialog
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_InformaçõesGeraisDoOrçamento = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ValorDoOrçamento_Panel = New System.Windows.Forms.Panel()
        Me.ValorDoOrçamento_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataDoOrçamento_Panel = New System.Windows.Forms.Panel()
        Me.StartDate_Label = New System.Windows.Forms.Label()
        Me.Label_DataInicial = New System.Windows.Forms.Label()
        Me.LocalDaCompra_Panel = New System.Windows.Forms.Panel()
        Me.LocalDaCompra_Label = New System.Windows.Forms.Label()
        Me.Label_LocalDaCompra = New System.Windows.Forms.Label()
        Me.TotalDeItens_Panel = New System.Windows.Forms.Panel()
        Me.TotaldeItens_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage_ListaDeMateriais = New System.Windows.Forms.TabPage()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.PanelHearder = New System.Windows.Forms.Panel()
        Me.NomeDoOrçamento_Label = New System.Windows.Forms.Label()
        Me.DescriçãoDoOrçamento_Label = New System.Windows.Forms.Label()
        Me.Separator01 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Controls_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_InformaçõesGeraisDoOrçamento.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ValorDoOrçamento_Panel.SuspendLayout()
        Me.DataDoOrçamento_Panel.SuspendLayout()
        Me.LocalDaCompra_Panel.SuspendLayout()
        Me.TotalDeItens_Panel.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.PanelHearder.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.TabControl1)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 100)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Controls_Panel.Size = New System.Drawing.Size(884, 321)
        Me.Controls_Panel.TabIndex = 31
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_InformaçõesGeraisDoOrçamento)
        Me.TabControl1.Controls.Add(Me.TabPage_ListaDeMateriais)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 301)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage_InformaçõesGeraisDoOrçamento
        '
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Name = "TabPage_InformaçõesGeraisDoOrçamento"
        Me.TabPage_InformaçõesGeraisDoOrçamento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Size = New System.Drawing.Size(856, 258)
        Me.TabPage_InformaçõesGeraisDoOrçamento.TabIndex = 0
        Me.TabPage_InformaçõesGeraisDoOrçamento.Text = "Orçamento"
        Me.TabPage_InformaçõesGeraisDoOrçamento.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ValorDoOrçamento_Panel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DataDoOrçamento_Panel)
        Me.FlowLayoutPanel1.Controls.Add(Me.LocalDaCompra_Panel)
        Me.FlowLayoutPanel1.Controls.Add(Me.TotalDeItens_Panel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(30)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(850, 252)
        Me.FlowLayoutPanel1.TabIndex = 67
        '
        'ValorDoOrçamento_Panel
        '
        Me.ValorDoOrçamento_Panel.Controls.Add(Me.ValorDoOrçamento_Label)
        Me.ValorDoOrçamento_Panel.Controls.Add(Me.PictureBox2)
        Me.ValorDoOrçamento_Panel.Controls.Add(Me.Label2)
        Me.ValorDoOrçamento_Panel.Location = New System.Drawing.Point(33, 33)
        Me.ValorDoOrçamento_Panel.Name = "ValorDoOrçamento_Panel"
        Me.ValorDoOrçamento_Panel.Size = New System.Drawing.Size(350, 50)
        Me.ValorDoOrçamento_Panel.TabIndex = 63
        '
        'ValorDoOrçamento_Label
        '
        Me.ValorDoOrçamento_Label.AutoSize = True
        Me.ValorDoOrçamento_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ValorDoOrçamento_Label.Location = New System.Drawing.Point(50, 26)
        Me.ValorDoOrçamento_Label.Name = "ValorDoOrçamento_Label"
        Me.ValorDoOrçamento_Label.Size = New System.Drawing.Size(52, 19)
        Me.ValorDoOrçamento_Label.TabIndex = 58
        Me.ValorDoOrçamento_Label.Text = "R$ 0,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(50, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Valor do Orçamento"
        '
        'DataDoOrçamento_Panel
        '
        Me.DataDoOrçamento_Panel.Controls.Add(Me.StartDate_Label)
        Me.DataDoOrçamento_Panel.Controls.Add(Me.PictureBox4)
        Me.DataDoOrçamento_Panel.Controls.Add(Me.Label_DataInicial)
        Me.DataDoOrçamento_Panel.Location = New System.Drawing.Point(33, 89)
        Me.DataDoOrçamento_Panel.Name = "DataDoOrçamento_Panel"
        Me.DataDoOrçamento_Panel.Size = New System.Drawing.Size(350, 50)
        Me.DataDoOrçamento_Panel.TabIndex = 65
        '
        'StartDate_Label
        '
        Me.StartDate_Label.AutoSize = True
        Me.StartDate_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.StartDate_Label.Location = New System.Drawing.Point(50, 26)
        Me.StartDate_Label.Name = "StartDate_Label"
        Me.StartDate_Label.Size = New System.Drawing.Size(70, 19)
        Me.StartDate_Label.TabIndex = 58
        Me.StartDate_Label.Text = "MM/YYYY"
        '
        'Label_DataInicial
        '
        Me.Label_DataInicial.AutoSize = True
        Me.Label_DataInicial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_DataInicial.Location = New System.Drawing.Point(50, 5)
        Me.Label_DataInicial.Name = "Label_DataInicial"
        Me.Label_DataInicial.Size = New System.Drawing.Size(43, 21)
        Me.Label_DataInicial.TabIndex = 57
        Me.Label_DataInicial.Text = "Data"
        '
        'LocalDaCompra_Panel
        '
        Me.LocalDaCompra_Panel.Controls.Add(Me.LocalDaCompra_Label)
        Me.LocalDaCompra_Panel.Controls.Add(Me.PictureBox1)
        Me.LocalDaCompra_Panel.Controls.Add(Me.Label_LocalDaCompra)
        Me.LocalDaCompra_Panel.Location = New System.Drawing.Point(33, 145)
        Me.LocalDaCompra_Panel.Name = "LocalDaCompra_Panel"
        Me.LocalDaCompra_Panel.Size = New System.Drawing.Size(350, 50)
        Me.LocalDaCompra_Panel.TabIndex = 62
        '
        'LocalDaCompra_Label
        '
        Me.LocalDaCompra_Label.AutoSize = True
        Me.LocalDaCompra_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.LocalDaCompra_Label.Location = New System.Drawing.Point(50, 26)
        Me.LocalDaCompra_Label.Name = "LocalDaCompra_Label"
        Me.LocalDaCompra_Label.Size = New System.Drawing.Size(30, 19)
        Me.LocalDaCompra_Label.TabIndex = 58
        Me.LocalDaCompra_Label.Text = "text"
        '
        'Label_LocalDaCompra
        '
        Me.Label_LocalDaCompra.AutoSize = True
        Me.Label_LocalDaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_LocalDaCompra.Location = New System.Drawing.Point(50, 5)
        Me.Label_LocalDaCompra.Name = "Label_LocalDaCompra"
        Me.Label_LocalDaCompra.Size = New System.Drawing.Size(132, 21)
        Me.Label_LocalDaCompra.TabIndex = 57
        Me.Label_LocalDaCompra.Text = "Local da Compra"
        '
        'TotalDeItens_Panel
        '
        Me.TotalDeItens_Panel.Controls.Add(Me.TotaldeItens_Label)
        Me.TotalDeItens_Panel.Controls.Add(Me.PictureBox3)
        Me.TotalDeItens_Panel.Controls.Add(Me.Label3)
        Me.TotalDeItens_Panel.Location = New System.Drawing.Point(389, 33)
        Me.TotalDeItens_Panel.Name = "TotalDeItens_Panel"
        Me.TotalDeItens_Panel.Size = New System.Drawing.Size(350, 50)
        Me.TotalDeItens_Panel.TabIndex = 66
        '
        'TotaldeItens_Label
        '
        Me.TotaldeItens_Label.AutoSize = True
        Me.TotaldeItens_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TotaldeItens_Label.Location = New System.Drawing.Point(50, 26)
        Me.TotaldeItens_Label.Name = "TotaldeItens_Label"
        Me.TotaldeItens_Label.Size = New System.Drawing.Size(16, 19)
        Me.TotaldeItens_Label.TabIndex = 58
        Me.TotaldeItens_Label.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(50, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Total de Itens"
        '
        'TabPage_ListaDeMateriais
        '
        Me.TabPage_ListaDeMateriais.AutoScroll = True
        Me.TabPage_ListaDeMateriais.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_ListaDeMateriais.Name = "TabPage_ListaDeMateriais"
        Me.TabPage_ListaDeMateriais.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ListaDeMateriais.Size = New System.Drawing.Size(856, 258)
        Me.TabPage_ListaDeMateriais.TabIndex = 2
        Me.TabPage_ListaDeMateriais.Text = "Lista de Materiais"
        Me.TabPage_ListaDeMateriais.UseVisualStyleBackColor = True
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 421)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(884, 40)
        Me.DialogOptionsPanel.TabIndex = 40
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(884, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'PanelHearder
        '
        Me.PanelHearder.BackColor = System.Drawing.Color.White
        Me.PanelHearder.Controls.Add(Me.NomeDoOrçamento_Label)
        Me.PanelHearder.Controls.Add(Me.DescriçãoDoOrçamento_Label)
        Me.PanelHearder.Controls.Add(Me.Separator01)
        Me.PanelHearder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHearder.Location = New System.Drawing.Point(0, 0)
        Me.PanelHearder.Name = "PanelHearder"
        Me.PanelHearder.Size = New System.Drawing.Size(884, 100)
        Me.PanelHearder.TabIndex = 41
        '
        'NomeDoOrçamento_Label
        '
        Me.NomeDoOrçamento_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NomeDoOrçamento_Label.AutoSize = True
        Me.NomeDoOrçamento_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.NomeDoOrçamento_Label.Location = New System.Drawing.Point(25, 25)
        Me.NomeDoOrçamento_Label.Name = "NomeDoOrçamento_Label"
        Me.NomeDoOrçamento_Label.Size = New System.Drawing.Size(137, 32)
        Me.NomeDoOrçamento_Label.TabIndex = 2
        Me.NomeDoOrçamento_Label.Text = "Orçamento"
        '
        'DescriçãoDoOrçamento_Label
        '
        Me.DescriçãoDoOrçamento_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DescriçãoDoOrçamento_Label.AutoSize = True
        Me.DescriçãoDoOrçamento_Label.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriçãoDoOrçamento_Label.Location = New System.Drawing.Point(28, 57)
        Me.DescriçãoDoOrçamento_Label.Name = "DescriçãoDoOrçamento_Label"
        Me.DescriçãoDoOrçamento_Label.Size = New System.Drawing.Size(64, 19)
        Me.DescriçãoDoOrçamento_Label.TabIndex = 16
        Me.DescriçãoDoOrçamento_Label.Text = "descrição"
        '
        'Separator01
        '
        Me.Separator01.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Separator01.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Separator01.Location = New System.Drawing.Point(0, 99)
        Me.Separator01.Name = "Separator01"
        Me.Separator01.Size = New System.Drawing.Size(884, 1)
        Me.Separator01.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_Value_32x32
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_Calendar_32x32
        Me.PictureBox4.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_marcador_32
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_lista_numerada_32
        Me.PictureBox3.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'VisualizarOrçamentoDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.Controls_Panel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.PanelHearder)
        Me.Name = "VisualizarOrçamentoDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_InformaçõesGeraisDoOrçamento.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ValorDoOrçamento_Panel.ResumeLayout(False)
        Me.ValorDoOrçamento_Panel.PerformLayout()
        Me.DataDoOrçamento_Panel.ResumeLayout(False)
        Me.DataDoOrçamento_Panel.PerformLayout()
        Me.LocalDaCompra_Panel.ResumeLayout(False)
        Me.LocalDaCompra_Panel.PerformLayout()
        Me.TotalDeItens_Panel.ResumeLayout(False)
        Me.TotalDeItens_Panel.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.PanelHearder.ResumeLayout(False)
        Me.PanelHearder.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Controls_Panel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ListaDeMateriais As System.Windows.Forms.TabPage
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents TabPage_InformaçõesGeraisDoOrçamento As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ValorDoOrçamento_Panel As System.Windows.Forms.Panel
    Friend WithEvents ValorDoOrçamento_Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataDoOrçamento_Panel As System.Windows.Forms.Panel
    Friend WithEvents StartDate_Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_DataInicial As System.Windows.Forms.Label
    Friend WithEvents LocalDaCompra_Panel As System.Windows.Forms.Panel
    Friend WithEvents LocalDaCompra_Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_LocalDaCompra As System.Windows.Forms.Label
    Friend WithEvents TotalDeItens_Panel As System.Windows.Forms.Panel
    Friend WithEvents TotaldeItens_Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelHearder As System.Windows.Forms.Panel
    Friend WithEvents NomeDoOrçamento_Label As System.Windows.Forms.Label
    Friend WithEvents DescriçãoDoOrçamento_Label As System.Windows.Forms.Label
    Friend WithEvents Separator01 As System.Windows.Forms.Panel
End Class
