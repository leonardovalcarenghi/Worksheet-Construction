<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LançarNovoOrçamentoDialog
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
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.FrmControls = New System.Windows.Forms.Panel()
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_InformaçõesGeraisDoOrçamento = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_LocalDaCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_DataDaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_Descrição = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_NomeDoOrçamento = New System.Windows.Forms.TextBox()
        Me.Label_NomeDaDespesa = New System.Windows.Forms.Label()
        Me.TabPage_AdicionarMaterial = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox_AutoCalc = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AddAndClear = New System.Windows.Forms.CheckBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_AddOnList = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox_ValorTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelTip_ValorUnitario = New System.Windows.Forms.Label()
        Me.Label_Legenda_ValorETipo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_ValorUnitário = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButton_M2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_M3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KG = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Unidade = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown_QuantidadeComprada = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_NomeDoMaterial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage_ListaDeMateriais = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label_TotalDoOrçamento = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_TotalDeMateriais = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.FrmControls.SuspendLayout()
        Me.Controls_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_InformaçõesGeraisDoOrçamento.SuspendLayout()
        Me.TabPage_AdicionarMaterial.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown_QuantidadeComprada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 421)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(934, 40)
        Me.DialogOptionsPanel.TabIndex = 78
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(823, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OK.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_OK.Location = New System.Drawing.Point(717, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(100, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Lançar"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(934, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'FrmControls
        '
        Me.FrmControls.Controls.Add(Me.Controls_Panel)
        Me.FrmControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmControls.Location = New System.Drawing.Point(0, 0)
        Me.FrmControls.Name = "FrmControls"
        Me.FrmControls.Size = New System.Drawing.Size(934, 421)
        Me.FrmControls.TabIndex = 79
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.TabControl1)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Controls_Panel.Size = New System.Drawing.Size(934, 421)
        Me.Controls_Panel.TabIndex = 30
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_InformaçõesGeraisDoOrçamento)
        Me.TabControl1.Controls.Add(Me.TabPage_AdicionarMaterial)
        Me.TabControl1.Controls.Add(Me.TabPage_ListaDeMateriais)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(914, 401)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage_InformaçõesGeraisDoOrçamento
        '
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.PictureBox6)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.PictureBox4)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label3)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.TextBox_LocalDaCompra)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label4)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label9)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label10)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.DateTimePicker_DataDaCompra)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label11)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.TextBox_Descrição)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label13)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label7)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.TextBox_NomeDoOrçamento)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Controls.Add(Me.Label_NomeDaDespesa)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Name = "TabPage_InformaçõesGeraisDoOrçamento"
        Me.TabPage_InformaçõesGeraisDoOrçamento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_InformaçõesGeraisDoOrçamento.Size = New System.Drawing.Size(906, 358)
        Me.TabPage_InformaçõesGeraisDoOrçamento.TabIndex = 0
        Me.TabPage_InformaçõesGeraisDoOrçamento.Text = "Informações Gerais"
        Me.TabPage_InformaçõesGeraisDoOrçamento.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Escreva aqui o nome do estabelecimento onde o orçamento foi realizado."
        '
        'TextBox_LocalDaCompra
        '
        Me.TextBox_LocalDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_LocalDaCompra.Location = New System.Drawing.Point(33, 255)
        Me.TextBox_LocalDaCompra.MaxLength = 500
        Me.TextBox_LocalDaCompra.Name = "TextBox_LocalDaCompra"
        Me.TextBox_LocalDaCompra.Size = New System.Drawing.Size(400, 25)
        Me.TextBox_LocalDaCompra.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(30, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "&Local da Compra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Selecione a data da compra do orçamento."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(30, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "&Data da Compra"
        '
        'DateTimePicker_DataDaCompra
        '
        Me.DateTimePicker_DataDaCompra.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_DataDaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_DataDaCompra.Location = New System.Drawing.Point(33, 186)
        Me.DateTimePicker_DataDaCompra.Name = "DateTimePicker_DataDaCompra"
        Me.DateTimePicker_DataDaCompra.Size = New System.Drawing.Size(170, 25)
        Me.DateTimePicker_DataDaCompra.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(284, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Escreva aqui se quiser uma breve descrição ou comentário."
        '
        'TextBox_Descrição
        '
        Me.TextBox_Descrição.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_Descrição.Location = New System.Drawing.Point(33, 117)
        Me.TextBox_Descrição.MaxLength = 500
        Me.TextBox_Descrição.Name = "TextBox_Descrição"
        Me.TextBox_Descrição.Size = New System.Drawing.Size(600, 25)
        Me.TextBox_Descrição.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(30, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "&Descrição"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Escreva o nome do orçamento."
        '
        'TextBox_NomeDoOrçamento
        '
        Me.TextBox_NomeDoOrçamento.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_NomeDoOrçamento.Location = New System.Drawing.Point(33, 48)
        Me.TextBox_NomeDoOrçamento.MaxLength = 500
        Me.TextBox_NomeDoOrçamento.Name = "TextBox_NomeDoOrçamento"
        Me.TextBox_NomeDoOrçamento.Size = New System.Drawing.Size(500, 25)
        Me.TextBox_NomeDoOrçamento.TabIndex = 30
        '
        'Label_NomeDaDespesa
        '
        Me.Label_NomeDaDespesa.AutoSize = True
        Me.Label_NomeDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NomeDaDespesa.Location = New System.Drawing.Point(30, 30)
        Me.Label_NomeDaDespesa.Name = "Label_NomeDaDespesa"
        Me.Label_NomeDaDespesa.Size = New System.Drawing.Size(120, 15)
        Me.Label_NomeDaDespesa.TabIndex = 31
        Me.Label_NomeDaDespesa.Text = "&Nome do Orçamento"
        '
        'TabPage_AdicionarMaterial
        '
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox8)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox7)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox5)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox3)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox2)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.PictureBox1)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Panel3)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Button_Clear)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Button_AddOnList)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label5)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label6)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Panel2)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.LabelTip_ValorUnitario)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label_Legenda_ValorETipo)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Panel1)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.RadioButton_M2)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.RadioButton_M3)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.RadioButton_KG)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.RadioButton_Unidade)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.NumericUpDown_QuantidadeComprada)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label14)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label15)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label1)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.TextBox_NomeDoMaterial)
        Me.TabPage_AdicionarMaterial.Controls.Add(Me.Label2)
        Me.TabPage_AdicionarMaterial.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_AdicionarMaterial.Name = "TabPage_AdicionarMaterial"
        Me.TabPage_AdicionarMaterial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_AdicionarMaterial.Size = New System.Drawing.Size(906, 358)
        Me.TabPage_AdicionarMaterial.TabIndex = 1
        Me.TabPage_AdicionarMaterial.Text = "Adicionar Material"
        Me.TabPage_AdicionarMaterial.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.CheckBox_AutoCalc)
        Me.Panel3.Controls.Add(Me.CheckBox_AddAndClear)
        Me.Panel3.Location = New System.Drawing.Point(690, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 78
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(12, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 15)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Opções do Formulário"
        '
        'CheckBox_AutoCalc
        '
        Me.CheckBox_AutoCalc.AutoSize = True
        Me.CheckBox_AutoCalc.Checked = True
        Me.CheckBox_AutoCalc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AutoCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox_AutoCalc.Location = New System.Drawing.Point(15, 39)
        Me.CheckBox_AutoCalc.Name = "CheckBox_AutoCalc"
        Me.CheckBox_AutoCalc.Size = New System.Drawing.Size(143, 19)
        Me.CheckBox_AutoCalc.TabIndex = 76
        Me.CheckBox_AutoCalc.Text = "Calcúlos Automáticos"
        Me.CheckBox_AutoCalc.UseVisualStyleBackColor = True
        '
        'CheckBox_AddAndClear
        '
        Me.CheckBox_AddAndClear.AutoSize = True
        Me.CheckBox_AddAndClear.Checked = True
        Me.CheckBox_AddAndClear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AddAndClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBox_AddAndClear.Location = New System.Drawing.Point(15, 64)
        Me.CheckBox_AddAndClear.Name = "CheckBox_AddAndClear"
        Me.CheckBox_AddAndClear.Size = New System.Drawing.Size(136, 19)
        Me.CheckBox_AddAndClear.TabIndex = 75
        Me.CheckBox_AddAndClear.Text = "Limpar ao Adicionar"
        Me.CheckBox_AddAndClear.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Clear.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Clear.Location = New System.Drawing.Point(219, 308)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 30)
        Me.Button_Clear.TabIndex = 74
        Me.Button_Clear.Text = "Limpar"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_AddOnList
        '
        Me.Button_AddOnList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_AddOnList.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_AddOnList.Location = New System.Drawing.Point(33, 308)
        Me.Button_AddOnList.Name = "Button_AddOnList"
        Me.Button_AddOnList.Size = New System.Drawing.Size(180, 30)
        Me.Button_AddOnList.TabIndex = 73
        Me.Button_AddOnList.Text = "Adicionar Material na Lista"
        Me.Button_AddOnList.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Digite o valor total que custou o material."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(30, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "&Valor Total"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox_ValorTotal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(33, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 25)
        Me.Panel2.TabIndex = 58
        '
        'TextBox_ValorTotal
        '
        Me.TextBox_ValorTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_ValorTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_ValorTotal.Location = New System.Drawing.Point(26, 0)
        Me.TextBox_ValorTotal.Name = "TextBox_ValorTotal"
        Me.TextBox_ValorTotal.Size = New System.Drawing.Size(174, 25)
        Me.TextBox_ValorTotal.TabIndex = 10
        Me.TextBox_ValorTotal.Text = "0,00"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "R$"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTip_ValorUnitario
        '
        Me.LabelTip_ValorUnitario.AutoSize = True
        Me.LabelTip_ValorUnitario.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip_ValorUnitario.Location = New System.Drawing.Point(30, 213)
        Me.LabelTip_ValorUnitario.Name = "LabelTip_ValorUnitario"
        Me.LabelTip_ValorUnitario.Size = New System.Drawing.Size(165, 13)
        Me.LabelTip_ValorUnitario.TabIndex = 57
        Me.LabelTip_ValorUnitario.Text = "Digite o valor unitário do material."
        '
        'Label_Legenda_ValorETipo
        '
        Me.Label_Legenda_ValorETipo.AutoSize = True
        Me.Label_Legenda_ValorETipo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Legenda_ValorETipo.Location = New System.Drawing.Point(30, 167)
        Me.Label_Legenda_ValorETipo.Name = "Label_Legenda_ValorETipo"
        Me.Label_Legenda_ValorETipo.Size = New System.Drawing.Size(79, 15)
        Me.Label_Legenda_ValorETipo.TabIndex = 56
        Me.Label_Legenda_ValorETipo.Text = "&Valor Unitário"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_ValorUnitário)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(33, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 25)
        Me.Panel1.TabIndex = 55
        '
        'TextBox_ValorUnitário
        '
        Me.TextBox_ValorUnitário.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_ValorUnitário.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_ValorUnitário.Location = New System.Drawing.Point(26, 0)
        Me.TextBox_ValorUnitário.Name = "TextBox_ValorUnitário"
        Me.TextBox_ValorUnitário.Size = New System.Drawing.Size(174, 25)
        Me.TextBox_ValorUnitário.TabIndex = 9
        Me.TextBox_ValorUnitário.Text = "0,00"
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 25)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "R$"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton_M2
        '
        Me.RadioButton_M2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_M2.Location = New System.Drawing.Point(341, 116)
        Me.RadioButton_M2.Name = "RadioButton_M2"
        Me.RadioButton_M2.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_M2.TabIndex = 51
        Me.RadioButton_M2.Text = "m²"
        Me.RadioButton_M2.UseVisualStyleBackColor = True
        '
        'RadioButton_M3
        '
        Me.RadioButton_M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_M3.Location = New System.Drawing.Point(391, 116)
        Me.RadioButton_M3.Name = "RadioButton_M3"
        Me.RadioButton_M3.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_M3.TabIndex = 52
        Me.RadioButton_M3.Text = "m³"
        Me.RadioButton_M3.UseVisualStyleBackColor = True
        '
        'RadioButton_KG
        '
        Me.RadioButton_KG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_KG.Location = New System.Drawing.Point(291, 116)
        Me.RadioButton_KG.Name = "RadioButton_KG"
        Me.RadioButton_KG.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_KG.TabIndex = 50
        Me.RadioButton_KG.Text = "Kg"
        Me.RadioButton_KG.UseVisualStyleBackColor = True
        '
        'RadioButton_Unidade
        '
        Me.RadioButton_Unidade.Checked = True
        Me.RadioButton_Unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_Unidade.Location = New System.Drawing.Point(199, 116)
        Me.RadioButton_Unidade.Name = "RadioButton_Unidade"
        Me.RadioButton_Unidade.Size = New System.Drawing.Size(86, 25)
        Me.RadioButton_Unidade.TabIndex = 49
        Me.RadioButton_Unidade.TabStop = True
        Me.RadioButton_Unidade.Text = "Unidade(s)"
        Me.RadioButton_Unidade.UseVisualStyleBackColor = True
        '
        'NumericUpDown_QuantidadeComprada
        '
        Me.NumericUpDown_QuantidadeComprada.DecimalPlaces = 2
        Me.NumericUpDown_QuantidadeComprada.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.NumericUpDown_QuantidadeComprada.Location = New System.Drawing.Point(33, 116)
        Me.NumericUpDown_QuantidadeComprada.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_QuantidadeComprada.Name = "NumericUpDown_QuantidadeComprada"
        Me.NumericUpDown_QuantidadeComprada.Size = New System.Drawing.Size(160, 25)
        Me.NumericUpDown_QuantidadeComprada.TabIndex = 48
        Me.NumericUpDown_QuantidadeComprada.ThousandsSeparator = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(288, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Digite a quantidade comprada e selecione o tipo de volume."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(30, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 15)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "&Quantidade Comprada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Escreva o nome do material comprado. [ Exemplo: Saco de Cimento Votorantim 50Kg ]" & _
    ""
        '
        'TextBox_NomeDoMaterial
        '
        Me.TextBox_NomeDoMaterial.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_NomeDoMaterial.Location = New System.Drawing.Point(33, 48)
        Me.TextBox_NomeDoMaterial.MaxLength = 500
        Me.TextBox_NomeDoMaterial.Name = "TextBox_NomeDoMaterial"
        Me.TextBox_NomeDoMaterial.Size = New System.Drawing.Size(500, 25)
        Me.TextBox_NomeDoMaterial.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "&Nome do Material"
        '
        'TabPage_ListaDeMateriais
        '
        Me.TabPage_ListaDeMateriais.AutoScroll = True
        Me.TabPage_ListaDeMateriais.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_ListaDeMateriais.Name = "TabPage_ListaDeMateriais"
        Me.TabPage_ListaDeMateriais.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ListaDeMateriais.Size = New System.Drawing.Size(906, 358)
        Me.TabPage_ListaDeMateriais.TabIndex = 2
        Me.TabPage_ListaDeMateriais.Text = "Lista de Materiais"
        Me.TabPage_ListaDeMateriais.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label_TotalDoOrçamento)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label_TotalDeMateriais)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(906, 358)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Orçamento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label_TotalDoOrçamento
        '
        Me.Label_TotalDoOrçamento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_TotalDoOrçamento.AutoSize = True
        Me.Label_TotalDoOrçamento.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_TotalDoOrçamento.Location = New System.Drawing.Point(190, 59)
        Me.Label_TotalDoOrçamento.Name = "Label_TotalDoOrçamento"
        Me.Label_TotalDoOrçamento.Size = New System.Drawing.Size(52, 19)
        Me.Label_TotalDoOrçamento.TabIndex = 76
        Me.Label_TotalDoOrçamento.Text = "R$ 0,00"
        Me.Label_TotalDoOrçamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(30, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 19)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "Total do Orçamento:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalDeMateriais
        '
        Me.Label_TotalDeMateriais.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_TotalDeMateriais.AutoSize = True
        Me.Label_TotalDeMateriais.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_TotalDeMateriais.Location = New System.Drawing.Point(190, 30)
        Me.Label_TotalDeMateriais.Name = "Label_TotalDeMateriais"
        Me.Label_TotalDeMateriais.Size = New System.Drawing.Size(16, 19)
        Me.Label_TotalDeMateriais.TabIndex = 74
        Me.Label_TotalDeMateriais.Text = "0"
        Me.Label_TotalDeMateriais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(30, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 19)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Total de Itens:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_serrote_50
        Me.PictureBox3.Location = New System.Drawing.Point(840, 226)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_rolo_de_pintura_50
        Me.PictureBox2.Location = New System.Drawing.Point(774, 292)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_carrinho_de_mão_50
        Me.PictureBox1.Location = New System.Drawing.Point(840, 292)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_chave_inglesa_50
        Me.PictureBox8.Location = New System.Drawing.Point(774, 226)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 86
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_pá_50
        Me.PictureBox7.Location = New System.Drawing.Point(840, 160)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 85
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_furadeira_50
        Me.PictureBox5.Location = New System.Drawing.Point(708, 292)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 83
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_caixa_de_ferramentas_50
        Me.PictureBox6.Location = New System.Drawing.Point(840, 222)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 86
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_estilete_50
        Me.PictureBox4.Location = New System.Drawing.Point(776, 291)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 85
        Me.PictureBox4.TabStop = False
        '
        'LançarNovoOrçamentoDialog
        '
        Me.AcceptButton = Me.Button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(934, 461)
        Me.Controls.Add(Me.FrmControls)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LançarNovoOrçamentoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Novo Orçamento"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.FrmControls.ResumeLayout(False)
        Me.Controls_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_InformaçõesGeraisDoOrçamento.ResumeLayout(False)
        Me.TabPage_InformaçõesGeraisDoOrçamento.PerformLayout()
        Me.TabPage_AdicionarMaterial.ResumeLayout(False)
        Me.TabPage_AdicionarMaterial.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown_QuantidadeComprada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents FrmControls As System.Windows.Forms.Panel
    Friend WithEvents Controls_Panel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_InformaçõesGeraisDoOrçamento As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NomeDoOrçamento As System.Windows.Forms.TextBox
    Friend WithEvents Label_NomeDaDespesa As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Descrição As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_DataDaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox_LocalDaCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage_AdicionarMaterial As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NomeDoMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_ValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelTip_ValorUnitario As System.Windows.Forms.Label
    Friend WithEvents Label_Legenda_ValorETipo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_ValorUnitário As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButton_M2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_M3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KG As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Unidade As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown_QuantidadeComprada As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage_ListaDeMateriais As System.Windows.Forms.TabPage
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_AddOnList As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_AutoCalc As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AddAndClear As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label_TotalDoOrçamento As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalDeMateriais As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox

End Class
