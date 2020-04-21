<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoOrçamentoDialog
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_NomeDoMaterial = New System.Windows.Forms.TextBox()
        Me.Label_NomeDaDespesa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown_QuantidadeComprada = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_Unidade = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KG = New System.Windows.Forms.RadioButton()
        Me.RadioButton_M3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_M2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_LocalDaCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_ValorUnitário = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelTip_ValorUnitario = New System.Windows.Forms.Label()
        Me.Label_Legenda_ValorETipo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox_ValorTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker_DataDaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_Descrição = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown_QuantidadeComprada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(412, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Escreva o nome do material comprado. [ Exemplo: Saco de Cimento Votorantim 50Kg ]" & _
    ""
        '
        'TextBox_NomeDoMaterial
        '
        Me.TextBox_NomeDoMaterial.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_NomeDoMaterial.Location = New System.Drawing.Point(23, 42)
        Me.TextBox_NomeDoMaterial.MaxLength = 500
        Me.TextBox_NomeDoMaterial.Name = "TextBox_NomeDoMaterial"
        Me.TextBox_NomeDoMaterial.Size = New System.Drawing.Size(500, 25)
        Me.TextBox_NomeDoMaterial.TabIndex = 1
        '
        'Label_NomeDaDespesa
        '
        Me.Label_NomeDaDespesa.AutoSize = True
        Me.Label_NomeDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NomeDaDespesa.Location = New System.Drawing.Point(20, 24)
        Me.Label_NomeDaDespesa.Name = "Label_NomeDaDespesa"
        Me.Label_NomeDaDespesa.Size = New System.Drawing.Size(103, 15)
        Me.Label_NomeDaDespesa.TabIndex = 27
        Me.Label_NomeDaDespesa.Text = "&Nome do Material"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Digite a quantidade comprada e selecione o tipo de volume."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(20, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "&Quantidade Comprada"
        '
        'NumericUpDown_QuantidadeComprada
        '
        Me.NumericUpDown_QuantidadeComprada.DecimalPlaces = 2
        Me.NumericUpDown_QuantidadeComprada.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.NumericUpDown_QuantidadeComprada.Location = New System.Drawing.Point(23, 318)
        Me.NumericUpDown_QuantidadeComprada.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_QuantidadeComprada.Name = "NumericUpDown_QuantidadeComprada"
        Me.NumericUpDown_QuantidadeComprada.Size = New System.Drawing.Size(160, 25)
        Me.NumericUpDown_QuantidadeComprada.TabIndex = 4
        Me.NumericUpDown_QuantidadeComprada.ThousandsSeparator = True
        '
        'RadioButton_Unidade
        '
        Me.RadioButton_Unidade.Checked = True
        Me.RadioButton_Unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_Unidade.Location = New System.Drawing.Point(189, 318)
        Me.RadioButton_Unidade.Name = "RadioButton_Unidade"
        Me.RadioButton_Unidade.Size = New System.Drawing.Size(86, 25)
        Me.RadioButton_Unidade.TabIndex = 5
        Me.RadioButton_Unidade.TabStop = True
        Me.RadioButton_Unidade.Text = "Unidade(s)"
        Me.RadioButton_Unidade.UseVisualStyleBackColor = True
        '
        'RadioButton_KG
        '
        Me.RadioButton_KG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_KG.Location = New System.Drawing.Point(281, 318)
        Me.RadioButton_KG.Name = "RadioButton_KG"
        Me.RadioButton_KG.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_KG.TabIndex = 6
        Me.RadioButton_KG.Text = "Kg"
        Me.RadioButton_KG.UseVisualStyleBackColor = True
        '
        'RadioButton_M3
        '
        Me.RadioButton_M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_M3.Location = New System.Drawing.Point(381, 318)
        Me.RadioButton_M3.Name = "RadioButton_M3"
        Me.RadioButton_M3.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_M3.TabIndex = 8
        Me.RadioButton_M3.Text = "m³"
        Me.RadioButton_M3.UseVisualStyleBackColor = True
        '
        'RadioButton_M2
        '
        Me.RadioButton_M2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton_M2.Location = New System.Drawing.Point(331, 318)
        Me.RadioButton_M2.Name = "RadioButton_M2"
        Me.RadioButton_M2.Size = New System.Drawing.Size(44, 25)
        Me.RadioButton_M2.TabIndex = 7
        Me.RadioButton_M2.Text = "m²"
        Me.RadioButton_M2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Escreva aqui o nome do estabelecimento onde o matereial foi comprado."
        '
        'TextBox_LocalDaCompra
        '
        Me.TextBox_LocalDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_LocalDaCompra.Location = New System.Drawing.Point(23, 249)
        Me.TextBox_LocalDaCompra.MaxLength = 500
        Me.TextBox_LocalDaCompra.Name = "TextBox_LocalDaCompra"
        Me.TextBox_LocalDaCompra.Size = New System.Drawing.Size(400, 25)
        Me.TextBox_LocalDaCompra.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "&Local da Compra"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_ValorUnitário)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(23, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 25)
        Me.Panel1.TabIndex = 41
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
        'LabelTip_ValorUnitario
        '
        Me.LabelTip_ValorUnitario.AutoSize = True
        Me.LabelTip_ValorUnitario.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip_ValorUnitario.Location = New System.Drawing.Point(20, 415)
        Me.LabelTip_ValorUnitario.Name = "LabelTip_ValorUnitario"
        Me.LabelTip_ValorUnitario.Size = New System.Drawing.Size(165, 13)
        Me.LabelTip_ValorUnitario.TabIndex = 44
        Me.LabelTip_ValorUnitario.Text = "Digite o valor unitário do material."
        '
        'Label_Legenda_ValorETipo
        '
        Me.Label_Legenda_ValorETipo.AutoSize = True
        Me.Label_Legenda_ValorETipo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Legenda_ValorETipo.Location = New System.Drawing.Point(20, 369)
        Me.Label_Legenda_ValorETipo.Name = "Label_Legenda_ValorETipo"
        Me.Label_Legenda_ValorETipo.Size = New System.Drawing.Size(79, 15)
        Me.Label_Legenda_ValorETipo.TabIndex = 42
        Me.Label_Legenda_ValorETipo.Text = "&Valor Unitário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Digite o valor total que custou o material."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(20, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "&Valor Total"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox_ValorTotal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(23, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 25)
        Me.Panel2.TabIndex = 45
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
        'DateTimePicker_DataDaCompra
        '
        Me.DateTimePicker_DataDaCompra.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_DataDaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_DataDaCompra.Location = New System.Drawing.Point(23, 180)
        Me.DateTimePicker_DataDaCompra.Name = "DateTimePicker_DataDaCompra"
        Me.DateTimePicker_DataDaCompra.Size = New System.Drawing.Size(170, 25)
        Me.DateTimePicker_DataDaCompra.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Selecione a data da compra do material."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(20, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "&Data da Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(284, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Escreva aqui se quiser uma breve descrição ou comentário."
        '
        'TextBox_Descrição
        '
        Me.TextBox_Descrição.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_Descrição.Location = New System.Drawing.Point(23, 111)
        Me.TextBox_Descrição.MaxLength = 500
        Me.TextBox_Descrição.Name = "TextBox_Descrição"
        Me.TextBox_Descrição.Size = New System.Drawing.Size(600, 25)
        Me.TextBox_Descrição.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(20, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "&Descrição"
        '
        'Button_Ok
        '
        Me.Button_Ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_Ok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ok.Location = New System.Drawing.Point(10, 479)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(150, 30)
        Me.Button_Ok.TabIndex = 55
        Me.Button_Ok.Text = "Lançar no Sistema"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(166, 479)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(90, 30)
        Me.Button_Cancel.TabIndex = 56
        Me.Button_Cancel.Text = "Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.PictureBox8)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Button_Cancel)
        Me.Panel3.Controls.Add(Me.Button_Ok)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(717, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 521)
        Me.Panel3.TabIndex = 58
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_chave_inglesa_50
        Me.PictureBox8.Location = New System.Drawing.Point(192, 372)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 64
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_pá_50
        Me.PictureBox7.Location = New System.Drawing.Point(176, 264)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 63
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_caixa_de_ferramentas_50
        Me.PictureBox6.Location = New System.Drawing.Point(30, 132)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 62
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_furadeira_50
        Me.PictureBox5.Location = New System.Drawing.Point(46, 240)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 61
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_estilete_50
        Me.PictureBox4.Location = New System.Drawing.Point(160, 156)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 60
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_serrote_50
        Me.PictureBox3.Location = New System.Drawing.Point(144, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_rolo_de_pintura_50
        Me.PictureBox2.Location = New System.Drawing.Point(62, 348)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_carrinho_de_mão_50
        Me.PictureBox1.Location = New System.Drawing.Point(14, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'NovoOrçamentoDialog
        '
        Me.AcceptButton = Me.Button_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(984, 521)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox_Descrição)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker_DataDaCompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelTip_ValorUnitario)
        Me.Controls.Add(Me.Label_Legenda_ValorETipo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_LocalDaCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton_M2)
        Me.Controls.Add(Me.RadioButton_M3)
        Me.Controls.Add(Me.RadioButton_KG)
        Me.Controls.Add(Me.RadioButton_Unidade)
        Me.Controls.Add(Me.NumericUpDown_QuantidadeComprada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_NomeDoMaterial)
        Me.Controls.Add(Me.Label_NomeDaDespesa)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovoOrçamentoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Novo Orçamento"
        CType(Me.NumericUpDown_QuantidadeComprada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NomeDoMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label_NomeDaDespesa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_QuantidadeComprada As System.Windows.Forms.NumericUpDown
    Friend WithEvents RadioButton_Unidade As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KG As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_M3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_M2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_LocalDaCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_ValorUnitário As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelTip_ValorUnitario As System.Windows.Forms.Label
    Friend WithEvents Label_Legenda_ValorETipo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_ValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_DataDaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Descrição As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button_Ok As System.Windows.Forms.Button
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox

End Class
