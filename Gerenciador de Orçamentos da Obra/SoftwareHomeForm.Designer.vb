<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoftwareHomeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.DashboradBackgroundPanel = New System.Windows.Forms.Panel()
        Me.DashboradPanel = New System.Windows.Forms.Panel()
        Me.Separator01 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DashboardPanel_ExpensesValue = New System.Windows.Forms.Panel()
        Me.NúmeroDeOrçamentos_Label = New System.Windows.Forms.Label()
        Me.Label_Orçamentos = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.DashboardPanel_RestToPayValue = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OrçamentoGasto_Label = New System.Windows.Forms.Label()
        Me.Label_Orçamento = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.DashboardPanel_ValuePaid = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaldoEmCaixa_Label = New System.Windows.Forms.Label()
        Me.Label_Saldo = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NomeDaObra_Label = New System.Windows.Forms.Label()
        Me.TextBox_ChangeNomeDaObra = New System.Windows.Forms.TextBox()
        Me.OrçamentoLista_PAnel = New System.Windows.Forms.Panel()
        Me.SeparatorPanel = New System.Windows.Forms.Panel()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.FrmControls = New System.Windows.Forms.Panel()
        Me.ControlsPanel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchNotFound = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_OpenMenu = New System.Windows.Forms.PictureBox()
        Me.MenuItemListControl_Sair = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_Sobre = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_SoftwareUpdates = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_OldSystem = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_Pesquisar = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_ConsultarValores = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_LançarValores = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.MenuItemListControl_NovoOrçamento = New Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl()
        Me.HeaderPanel.SuspendLayout()
        Me.DashboradBackgroundPanel.SuspendLayout()
        Me.DashboradPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.DashboardPanel_ExpensesValue.SuspendLayout()
        Me.DashboardPanel_RestToPayValue.SuspendLayout()
        Me.DashboardPanel_ValuePaid.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.OrçamentoLista_PAnel.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.FrmControls.SuspendLayout()
        Me.ControlsPanel.SuspendLayout()
        Me.SearchNotFound.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_OpenMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.HeaderPanel.Controls.Add(Me.DashboradBackgroundPanel)
        Me.HeaderPanel.Controls.Add(Me.Panel5)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(784, 161)
        Me.HeaderPanel.TabIndex = 1
        '
        'DashboradBackgroundPanel
        '
        Me.DashboradBackgroundPanel.Controls.Add(Me.DashboradPanel)
        Me.DashboradBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboradBackgroundPanel.Location = New System.Drawing.Point(0, 45)
        Me.DashboradBackgroundPanel.Name = "DashboradBackgroundPanel"
        Me.DashboradBackgroundPanel.Size = New System.Drawing.Size(784, 116)
        Me.DashboradBackgroundPanel.TabIndex = 0
        '
        'DashboradPanel
        '
        Me.DashboradPanel.BackColor = System.Drawing.Color.White
        Me.DashboradPanel.Controls.Add(Me.Separator01)
        Me.DashboradPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.DashboradPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboradPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboradPanel.Name = "DashboradPanel"
        Me.DashboradPanel.Size = New System.Drawing.Size(784, 116)
        Me.DashboradPanel.TabIndex = 10
        '
        'Separator01
        '
        Me.Separator01.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Separator01.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Separator01.Location = New System.Drawing.Point(0, 115)
        Me.Separator01.Name = "Separator01"
        Me.Separator01.Size = New System.Drawing.Size(784, 1)
        Me.Separator01.TabIndex = 18
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_ExpensesValue, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_RestToPayValue, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_ValuePaid, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 8)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 100)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'DashboardPanel_ExpensesValue
        '
        Me.DashboardPanel_ExpensesValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashboardPanel_ExpensesValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.NúmeroDeOrçamentos_Label)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Label_Orçamentos)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel12)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel17)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel18)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel19)
        Me.DashboardPanel_ExpensesValue.Location = New System.Drawing.Point(509, 3)
        Me.DashboardPanel_ExpensesValue.Name = "DashboardPanel_ExpensesValue"
        Me.DashboardPanel_ExpensesValue.Size = New System.Drawing.Size(248, 94)
        Me.DashboardPanel_ExpensesValue.TabIndex = 2
        '
        'NúmeroDeOrçamentos_Label
        '
        Me.NúmeroDeOrçamentos_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NúmeroDeOrçamentos_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.NúmeroDeOrçamentos_Label.ForeColor = System.Drawing.Color.White
        Me.NúmeroDeOrçamentos_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NúmeroDeOrçamentos_Label.Location = New System.Drawing.Point(14, 30)
        Me.NúmeroDeOrçamentos_Label.Name = "NúmeroDeOrçamentos_Label"
        Me.NúmeroDeOrçamentos_Label.Size = New System.Drawing.Size(219, 50)
        Me.NúmeroDeOrçamentos_Label.TabIndex = 6
        Me.NúmeroDeOrçamentos_Label.Text = "0"
        Me.NúmeroDeOrçamentos_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Orçamentos
        '
        Me.Label_Orçamentos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Orçamentos.AutoSize = True
        Me.Label_Orçamentos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Orçamentos.ForeColor = System.Drawing.Color.White
        Me.Label_Orçamentos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Orçamentos.Location = New System.Drawing.Point(75, 8)
        Me.Label_Orçamentos.Name = "Label_Orçamentos"
        Me.Label_Orçamentos.Size = New System.Drawing.Size(99, 21)
        Me.Label_Orçamentos.TabIndex = 5
        Me.Label_Orçamentos.Text = "Orçamentos"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(0, 1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1, 92)
        Me.Panel12.TabIndex = 4
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(247, 1)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1, 92)
        Me.Panel17.TabIndex = 3
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(0, 93)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(248, 1)
        Me.Panel18.TabIndex = 2
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(248, 1)
        Me.Panel19.TabIndex = 1
        '
        'DashboardPanel_RestToPayValue
        '
        Me.DashboardPanel_RestToPayValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashboardPanel_RestToPayValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Label4)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.OrçamentoGasto_Label)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Label_Orçamento)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel13)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel14)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel15)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel16)
        Me.DashboardPanel_RestToPayValue.Location = New System.Drawing.Point(256, 3)
        Me.DashboardPanel_RestToPayValue.Name = "DashboardPanel_RestToPayValue"
        Me.DashboardPanel_RestToPayValue.Size = New System.Drawing.Size(247, 94)
        Me.DashboardPanel_RestToPayValue.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total gasto com a obra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrçamentoGasto_Label
        '
        Me.OrçamentoGasto_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrçamentoGasto_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.OrçamentoGasto_Label.ForeColor = System.Drawing.Color.White
        Me.OrçamentoGasto_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OrçamentoGasto_Label.Location = New System.Drawing.Point(14, 25)
        Me.OrçamentoGasto_Label.Name = "OrçamentoGasto_Label"
        Me.OrçamentoGasto_Label.Size = New System.Drawing.Size(219, 50)
        Me.OrçamentoGasto_Label.TabIndex = 6
        Me.OrçamentoGasto_Label.Text = "R$ 0,00"
        Me.OrçamentoGasto_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Orçamento
        '
        Me.Label_Orçamento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Orçamento.AutoSize = True
        Me.Label_Orçamento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Orçamento.ForeColor = System.Drawing.Color.White
        Me.Label_Orçamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Orçamento.Location = New System.Drawing.Point(54, 8)
        Me.Label_Orçamento.Name = "Label_Orçamento"
        Me.Label_Orçamento.Size = New System.Drawing.Size(138, 21)
        Me.Label_Orçamento.TabIndex = 5
        Me.Label_Orçamento.Text = "Orçamento Gasto"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 1)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1, 92)
        Me.Panel13.TabIndex = 4
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(246, 1)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 92)
        Me.Panel14.TabIndex = 3
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(0, 93)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(247, 1)
        Me.Panel15.TabIndex = 2
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(247, 1)
        Me.Panel16.TabIndex = 1
        '
        'DashboardPanel_ValuePaid
        '
        Me.DashboardPanel_ValuePaid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashboardPanel_ValuePaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Label2)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.SaldoEmCaixa_Label)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Label_Saldo)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel11)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel10)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel9)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel8)
        Me.DashboardPanel_ValuePaid.Location = New System.Drawing.Point(3, 3)
        Me.DashboardPanel_ValuePaid.Name = "DashboardPanel_ValuePaid"
        Me.DashboardPanel_ValuePaid.Size = New System.Drawing.Size(247, 94)
        Me.DashboardPanel_ValuePaid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(1, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Valor disponível para gastar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaldoEmCaixa_Label
        '
        Me.SaldoEmCaixa_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaldoEmCaixa_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
        Me.SaldoEmCaixa_Label.ForeColor = System.Drawing.Color.White
        Me.SaldoEmCaixa_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SaldoEmCaixa_Label.Location = New System.Drawing.Point(14, 25)
        Me.SaldoEmCaixa_Label.Name = "SaldoEmCaixa_Label"
        Me.SaldoEmCaixa_Label.Size = New System.Drawing.Size(219, 50)
        Me.SaldoEmCaixa_Label.TabIndex = 6
        Me.SaldoEmCaixa_Label.Text = "R$ 0,00"
        Me.SaldoEmCaixa_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Saldo
        '
        Me.Label_Saldo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Saldo.AutoSize = True
        Me.Label_Saldo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Saldo.ForeColor = System.Drawing.Color.White
        Me.Label_Saldo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Saldo.Location = New System.Drawing.Point(98, 8)
        Me.Label_Saldo.Name = "Label_Saldo"
        Me.Label_Saldo.Size = New System.Drawing.Size(51, 21)
        Me.Label_Saldo.TabIndex = 5
        Me.Label_Saldo.Text = "Saldo"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1, 92)
        Me.Panel11.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(246, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 92)
        Me.Panel10.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 93)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(247, 1)
        Me.Panel9.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(247, 1)
        Me.Panel8.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Btn_OpenMenu)
        Me.Panel5.Controls.Add(Me.NomeDaObra_Label)
        Me.Panel5.Controls.Add(Me.TextBox_ChangeNomeDaObra)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(784, 45)
        Me.Panel5.TabIndex = 8
        '
        'NomeDaObra_Label
        '
        Me.NomeDaObra_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NomeDaObra_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NomeDaObra_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NomeDaObra_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NomeDaObra_Label.Location = New System.Drawing.Point(92, 5)
        Me.NomeDaObra_Label.Name = "NomeDaObra_Label"
        Me.NomeDaObra_Label.Size = New System.Drawing.Size(600, 35)
        Me.NomeDaObra_Label.TabIndex = 1
        Me.NomeDaObra_Label.Text = "Orçamento de Materiais da Casa Nova"
        Me.NomeDaObra_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.NomeDaObra_Label, "Duplo Clique: Alterar o nome da planilha.")
        '
        'TextBox_ChangeNomeDaObra
        '
        Me.TextBox_ChangeNomeDaObra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox_ChangeNomeDaObra.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox_ChangeNomeDaObra.Location = New System.Drawing.Point(92, 6)
        Me.TextBox_ChangeNomeDaObra.MaxLength = 50
        Me.TextBox_ChangeNomeDaObra.Name = "TextBox_ChangeNomeDaObra"
        Me.TextBox_ChangeNomeDaObra.Size = New System.Drawing.Size(600, 32)
        Me.TextBox_ChangeNomeDaObra.TabIndex = 4
        Me.TextBox_ChangeNomeDaObra.Text = "Orçamento de Materiais da Casa Nova"
        Me.TextBox_ChangeNomeDaObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_ChangeNomeDaObra.Visible = False
        '
        'OrçamentoLista_PAnel
        '
        Me.OrçamentoLista_PAnel.AutoScroll = True
        Me.OrçamentoLista_PAnel.Controls.Add(Me.SearchNotFound)
        Me.OrçamentoLista_PAnel.Controls.Add(Me.SeparatorPanel)
        Me.OrçamentoLista_PAnel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrçamentoLista_PAnel.Location = New System.Drawing.Point(0, 0)
        Me.OrçamentoLista_PAnel.Name = "OrçamentoLista_PAnel"
        Me.OrçamentoLista_PAnel.Size = New System.Drawing.Size(784, 325)
        Me.OrçamentoLista_PAnel.TabIndex = 2
        '
        'SeparatorPanel
        '
        Me.SeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.SeparatorPanel.Name = "SeparatorPanel"
        Me.SeparatorPanel.Size = New System.Drawing.Size(784, 1)
        Me.SeparatorPanel.TabIndex = 3
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_Sair)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_Sobre)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_SoftwareUpdates)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_OldSystem)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_Pesquisar)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_ConsultarValores)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_LançarValores)
        Me.MenuPanel.Controls.Add(Me.MenuItemListControl_NovoOrçamento)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.MenuPanel.Size = New System.Drawing.Size(300, 486)
        Me.MenuPanel.TabIndex = 12
        '
        'FrmControls
        '
        Me.FrmControls.Controls.Add(Me.ControlsPanel)
        Me.FrmControls.Controls.Add(Me.HeaderPanel)
        Me.FrmControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmControls.Location = New System.Drawing.Point(300, 0)
        Me.FrmControls.Name = "FrmControls"
        Me.FrmControls.Size = New System.Drawing.Size(784, 486)
        Me.FrmControls.TabIndex = 13
        '
        'ControlsPanel
        '
        Me.ControlsPanel.Controls.Add(Me.OrçamentoLista_PAnel)
        Me.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsPanel.Location = New System.Drawing.Point(0, 161)
        Me.ControlsPanel.Name = "ControlsPanel"
        Me.ControlsPanel.Size = New System.Drawing.Size(784, 325)
        Me.ControlsPanel.TabIndex = 2
        '
        'SearchNotFound
        '
        Me.SearchNotFound.Controls.Add(Me.Label3)
        Me.SearchNotFound.Controls.Add(Me.Label1)
        Me.SearchNotFound.Controls.Add(Me.PictureBox1)
        Me.SearchNotFound.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchNotFound.Location = New System.Drawing.Point(0, 1)
        Me.SearchNotFound.Name = "SearchNotFound"
        Me.SearchNotFound.Size = New System.Drawing.Size(784, 50)
        Me.SearchNotFound.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(41, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nenhum resultado foi encontrado..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(604, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Desculpe, mas não encontramos o seu orçamento, tente digitar algo diferente no ca" & _
    "mpo de busca."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_nada_foi_encontrado_28
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Btn_OpenMenu
        '
        Me.Btn_OpenMenu.Image = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuApp_28x28
        Me.Btn_OpenMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_OpenMenu.Location = New System.Drawing.Point(6, 5)
        Me.Btn_OpenMenu.Name = "Btn_OpenMenu"
        Me.Btn_OpenMenu.Size = New System.Drawing.Size(35, 35)
        Me.Btn_OpenMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_OpenMenu.TabIndex = 12
        Me.Btn_OpenMenu.TabStop = False
        '
        'MenuItemListControl_Sair
        '
        Me.MenuItemListControl_Sair.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_Sair.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_Sair.Location = New System.Drawing.Point(0, 380)
        Me.MenuItemListControl_Sair.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuSaida_28x28
        Me.MenuItemListControl_Sair.MenuText = "Sair"
        Me.MenuItemListControl_Sair.Name = "MenuItemListControl_Sair"
        Me.MenuItemListControl_Sair.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_Sair.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_Sair.TabIndex = 4
        '
        'MenuItemListControl_Sobre
        '
        Me.MenuItemListControl_Sobre.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_Sobre.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_Sobre.Location = New System.Drawing.Point(0, 330)
        Me.MenuItemListControl_Sobre.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuInfo_28x28
        Me.MenuItemListControl_Sobre.MenuText = "Sobre"
        Me.MenuItemListControl_Sobre.Name = "MenuItemListControl_Sobre"
        Me.MenuItemListControl_Sobre.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_Sobre.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_Sobre.TabIndex = 3
        '
        'MenuItemListControl_SoftwareUpdates
        '
        Me.MenuItemListControl_SoftwareUpdates.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_SoftwareUpdates.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_SoftwareUpdates.Location = New System.Drawing.Point(0, 280)
        Me.MenuItemListControl_SoftwareUpdates.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuUpdates_28x28
        Me.MenuItemListControl_SoftwareUpdates.MenuText = "Atualizações de Software"
        Me.MenuItemListControl_SoftwareUpdates.Name = "MenuItemListControl_SoftwareUpdates"
        Me.MenuItemListControl_SoftwareUpdates.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_SoftwareUpdates.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_SoftwareUpdates.TabIndex = 5
        '
        'MenuItemListControl_OldSystem
        '
        Me.MenuItemListControl_OldSystem.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_OldSystem.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_OldSystem.Location = New System.Drawing.Point(0, 230)
        Me.MenuItemListControl_OldSystem.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_passado_28__1_
        Me.MenuItemListControl_OldSystem.MenuText = "Visualizar Itens do Sistema Antigo"
        Me.MenuItemListControl_OldSystem.Name = "MenuItemListControl_OldSystem"
        Me.MenuItemListControl_OldSystem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_OldSystem.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_OldSystem.TabIndex = 6
        '
        'MenuItemListControl_Pesquisar
        '
        Me.MenuItemListControl_Pesquisar.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_Pesquisar.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_Pesquisar.Location = New System.Drawing.Point(0, 180)
        Me.MenuItemListControl_Pesquisar.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.icons8_pesquisar_28
        Me.MenuItemListControl_Pesquisar.MenuText = "Pesquisar"
        Me.MenuItemListControl_Pesquisar.Name = "MenuItemListControl_Pesquisar"
        Me.MenuItemListControl_Pesquisar.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_Pesquisar.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_Pesquisar.TabIndex = 7
        '
        'MenuItemListControl_ConsultarValores
        '
        Me.MenuItemListControl_ConsultarValores.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_ConsultarValores.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_ConsultarValores.Location = New System.Drawing.Point(0, 130)
        Me.MenuItemListControl_ConsultarValores.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuConsultarSaldo_28x28
        Me.MenuItemListControl_ConsultarValores.MenuText = "Consultar Saldo"
        Me.MenuItemListControl_ConsultarValores.Name = "MenuItemListControl_ConsultarValores"
        Me.MenuItemListControl_ConsultarValores.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_ConsultarValores.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_ConsultarValores.TabIndex = 2
        '
        'MenuItemListControl_LançarValores
        '
        Me.MenuItemListControl_LançarValores.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_LançarValores.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_LançarValores.Location = New System.Drawing.Point(0, 80)
        Me.MenuItemListControl_LançarValores.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuLançarSaldo_28x28
        Me.MenuItemListControl_LançarValores.MenuText = "Lançar Saldo"
        Me.MenuItemListControl_LançarValores.Name = "MenuItemListControl_LançarValores"
        Me.MenuItemListControl_LançarValores.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_LançarValores.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_LançarValores.TabIndex = 1
        '
        'MenuItemListControl_NovoOrçamento
        '
        Me.MenuItemListControl_NovoOrçamento.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl_NovoOrçamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl_NovoOrçamento.Location = New System.Drawing.Point(0, 30)
        Me.MenuItemListControl_NovoOrçamento.MenuIcon = Global.Gerenciador_de_Orçamentos_da_Obra.My.Resources.Resources.Icon_MenuAdd_28x28
        Me.MenuItemListControl_NovoOrçamento.MenuText = "Novo Orçamento"
        Me.MenuItemListControl_NovoOrçamento.Name = "MenuItemListControl_NovoOrçamento"
        Me.MenuItemListControl_NovoOrçamento.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuItemListControl_NovoOrçamento.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemListControl_NovoOrçamento.TabIndex = 0
        '
        'SoftwareHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 486)
        Me.Controls.Add(Me.FrmControls)
        Me.Controls.Add(Me.MenuPanel)
        Me.MinimumSize = New System.Drawing.Size(1100, 525)
        Me.Name = "SoftwareHomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet Construction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HeaderPanel.ResumeLayout(False)
        Me.DashboradBackgroundPanel.ResumeLayout(False)
        Me.DashboradPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.DashboardPanel_ExpensesValue.ResumeLayout(False)
        Me.DashboardPanel_ExpensesValue.PerformLayout()
        Me.DashboardPanel_RestToPayValue.ResumeLayout(False)
        Me.DashboardPanel_RestToPayValue.PerformLayout()
        Me.DashboardPanel_ValuePaid.ResumeLayout(False)
        Me.DashboardPanel_ValuePaid.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.OrçamentoLista_PAnel.ResumeLayout(False)
        Me.MenuPanel.ResumeLayout(False)
        Me.FrmControls.ResumeLayout(False)
        Me.ControlsPanel.ResumeLayout(False)
        Me.SearchNotFound.ResumeLayout(False)
        Me.SearchNotFound.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_OpenMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents DashboradBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents DashboradPanel As System.Windows.Forms.Panel
    Friend WithEvents Separator01 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DashboardPanel_ExpensesValue As System.Windows.Forms.Panel
    Friend WithEvents NúmeroDeOrçamentos_Label As System.Windows.Forms.Label
    Friend WithEvents Label_Orçamentos As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents DashboardPanel_RestToPayValue As System.Windows.Forms.Panel
    Friend WithEvents OrçamentoGasto_Label As System.Windows.Forms.Label
    Friend WithEvents Label_Orçamento As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents DashboardPanel_ValuePaid As System.Windows.Forms.Panel
    Friend WithEvents SaldoEmCaixa_Label As System.Windows.Forms.Label
    Friend WithEvents Label_Saldo As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents NomeDaObra_Label As System.Windows.Forms.Label
    Friend WithEvents OrçamentoLista_PAnel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuPanel As System.Windows.Forms.Panel
    Friend WithEvents FrmControls As System.Windows.Forms.Panel
    Friend WithEvents ControlsPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuItemListControl_NovoOrçamento As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents Btn_OpenMenu As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItemListControl_Sair As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents MenuItemListControl_Sobre As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents MenuItemListControl_ConsultarValores As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents MenuItemListControl_LançarValores As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents MenuItemListControl_SoftwareUpdates As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents SeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuItemListControl_OldSystem As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents TextBox_ChangeNomeDaObra As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuItemListControl_Pesquisar As Gerenciador_de_Orçamentos_da_Obra.MenuItemListControl
    Friend WithEvents SearchNotFound As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
