<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoftwareUpdatesDialog
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
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Download_Button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NoInternet_Panel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Informations_Panel = New System.Windows.Forms.Panel()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastVersion_Panel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewVersionAvailable_Panel = New System.Windows.Forms.Panel()
        Me.Description_Label = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VersionYear_Label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NewUpdate_Label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NewVersion_Label = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ActualVersion_Label = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.NoInternet_Panel.SuspendLayout()
        Me.Informations_Panel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.LastVersion_Panel.SuspendLayout()
        Me.NewVersionAvailable_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(698, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Cancel_Button)
        Me.DialogOptionsPanel.Controls.Add(Me.Download_Button)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 289)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(698, 40)
        Me.DialogOptionsPanel.TabIndex = 77
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Cancel_Button.Location = New System.Drawing.Point(587, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 30)
        Me.Cancel_Button.TabIndex = 73
        Me.Cancel_Button.Text = "&Fechar"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Download_Button
        '
        Me.Download_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Download_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Download_Button.Location = New System.Drawing.Point(427, 5)
        Me.Download_Button.Name = "Download_Button"
        Me.Download_Button.Size = New System.Drawing.Size(154, 30)
        Me.Download_Button.TabIndex = 72
        Me.Download_Button.Text = "&Baixar Atualizações"
        Me.Download_Button.UseVisualStyleBackColor = True
        Me.Download_Button.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 1)
        Me.Panel2.TabIndex = 73
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(1, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(698, 1)
        Me.Panel6.TabIndex = 72
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 330)
        Me.Panel7.TabIndex = 75
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(699, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 330)
        Me.Panel3.TabIndex = 74
        '
        'Panel5
        '
        Me.Panel5.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.Panel5.Controls.Add(Me.NoInternet_Panel)
        Me.Panel5.Controls.Add(Me.Informations_Panel)
        Me.Panel5.Controls.Add(Me.LastVersion_Panel)
        Me.Panel5.Controls.Add(Me.NewVersionAvailable_Panel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(698, 288)
        Me.Panel5.TabIndex = 76
        '
        'NoInternet_Panel
        '
        Me.NoInternet_Panel.Controls.Add(Me.Label2)
        Me.NoInternet_Panel.Controls.Add(Me.Label3)
        Me.NoInternet_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NoInternet_Panel.Location = New System.Drawing.Point(0, 441)
        Me.NoInternet_Panel.Name = "NoInternet_Panel"
        Me.NoInternet_Panel.Size = New System.Drawing.Size(698, 69)
        Me.NoInternet_Panel.TabIndex = 7
        Me.NoInternet_Panel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Não podemos buscar por atualizações enquanto seu computador estiver sem acesso à " & _
    "internet."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seu computador não está conectado à internet."
        '
        'Informations_Panel
        '
        Me.Informations_Panel.Controls.Add(Me.Status_Label)
        Me.Informations_Panel.Controls.Add(Me.ProgressBar1)
        Me.Informations_Panel.Controls.Add(Me.Title_Label)
        Me.Informations_Panel.Controls.Add(Me.MenuStrip1)
        Me.Informations_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Informations_Panel.Location = New System.Drawing.Point(0, 359)
        Me.Informations_Panel.Name = "Informations_Panel"
        Me.Informations_Panel.Size = New System.Drawing.Size(698, 82)
        Me.Informations_Panel.TabIndex = 6
        '
        'Status_Label
        '
        Me.Status_Label.AutoSize = True
        Me.Status_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Label.Location = New System.Drawing.Point(30, 66)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(39, 13)
        Me.Status_Label.TabIndex = 4
        Me.Status_Label.Text = "status..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(33, 53)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(400, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(30, 30)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(265, 17)
        Me.Title_Label.TabIndex = 2
        Me.Title_Label.Text = "Procurando por atualizações de software..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'LastVersion_Panel
        '
        Me.LastVersion_Panel.Controls.Add(Me.Label4)
        Me.LastVersion_Panel.Controls.Add(Me.Label5)
        Me.LastVersion_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LastVersion_Panel.Location = New System.Drawing.Point(0, 293)
        Me.LastVersion_Panel.Name = "LastVersion_Panel"
        Me.LastVersion_Panel.Size = New System.Drawing.Size(698, 66)
        Me.LastVersion_Panel.TabIndex = 8
        Me.LastVersion_Panel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Você está usando a útima versão disponível do XPEG Count."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Seu software está atualizado!"
        '
        'NewVersionAvailable_Panel
        '
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Description_Label)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label13)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.VersionYear_Label)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label14)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.NewUpdate_Label)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label10)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.NewVersion_Label)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label12)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label11)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.ActualVersion_Label)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label9)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label6)
        Me.NewVersionAvailable_Panel.Controls.Add(Me.Label7)
        Me.NewVersionAvailable_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NewVersionAvailable_Panel.Location = New System.Drawing.Point(0, 0)
        Me.NewVersionAvailable_Panel.Name = "NewVersionAvailable_Panel"
        Me.NewVersionAvailable_Panel.Size = New System.Drawing.Size(698, 293)
        Me.NewVersionAvailable_Panel.TabIndex = 9
        Me.NewVersionAvailable_Panel.Visible = False
        '
        'Description_Label
        '
        Me.Description_Label.AutoSize = True
        Me.Description_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_Label.Location = New System.Drawing.Point(30, 239)
        Me.Description_Label.Name = "Description_Label"
        Me.Description_Label.Size = New System.Drawing.Size(24, 13)
        Me.Description_Label.TabIndex = 14
        Me.Description_Label.Text = "text"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Descrição"
        '
        'VersionYear_Label
        '
        Me.VersionYear_Label.AutoSize = True
        Me.VersionYear_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionYear_Label.Location = New System.Drawing.Point(30, 196)
        Me.VersionYear_Label.Name = "VersionYear_Label"
        Me.VersionYear_Label.Size = New System.Drawing.Size(24, 13)
        Me.VersionYear_Label.TabIndex = 12
        Me.VersionYear_Label.Text = "text"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Ano da Versão"
        '
        'NewUpdate_Label
        '
        Me.NewUpdate_Label.AutoSize = True
        Me.NewUpdate_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUpdate_Label.Location = New System.Drawing.Point(30, 153)
        Me.NewUpdate_Label.Name = "NewUpdate_Label"
        Me.NewUpdate_Label.Size = New System.Drawing.Size(24, 13)
        Me.NewUpdate_Label.TabIndex = 10
        Me.NewUpdate_Label.Text = "text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Update"
        '
        'NewVersion_Label
        '
        Me.NewVersion_Label.AutoSize = True
        Me.NewVersion_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewVersion_Label.Location = New System.Drawing.Point(143, 110)
        Me.NewVersion_Label.Name = "NewVersion_Label"
        Me.NewVersion_Label.Size = New System.Drawing.Size(24, 13)
        Me.NewVersion_Label.TabIndex = 8
        Me.NewVersion_Label.Text = "text"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Wingdings 3", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(120, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 33)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "u"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(143, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Versão Disponível"
        '
        'ActualVersion_Label
        '
        Me.ActualVersion_Label.AutoSize = True
        Me.ActualVersion_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualVersion_Label.Location = New System.Drawing.Point(30, 110)
        Me.ActualVersion_Label.Name = "ActualVersion_Label"
        Me.ActualVersion_Label.Size = New System.Drawing.Size(24, 13)
        Me.ActualVersion_Label.TabIndex = 6
        Me.ActualVersion_Label.Text = "text"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Versão Atual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Confira abaixo algumas informações da nova versão que será baixada."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Atualização Disponível"
        '
        'SoftwareUpdatesDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 330)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SoftwareUpdatesDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SoftwareUpdatesDialog"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.NoInternet_Panel.ResumeLayout(False)
        Me.NoInternet_Panel.PerformLayout()
        Me.Informations_Panel.ResumeLayout(False)
        Me.Informations_Panel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.LastVersion_Panel.ResumeLayout(False)
        Me.LastVersion_Panel.PerformLayout()
        Me.NewVersionAvailable_Panel.ResumeLayout(False)
        Me.NewVersionAvailable_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Download_Button As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents NoInternet_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Informations_Panel As System.Windows.Forms.Panel
    Friend WithEvents Status_Label As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastVersion_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NewVersionAvailable_Panel As System.Windows.Forms.Panel
    Friend WithEvents Description_Label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents VersionYear_Label As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NewUpdate_Label As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NewVersion_Label As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ActualVersion_Label As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
