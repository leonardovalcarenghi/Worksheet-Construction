<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrçamentoItemControl
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
        Me.Label_Descrição = New System.Windows.Forms.Label()
        Me.Label_NomeDoMaterial = New System.Windows.Forms.Label()
        Me.Label_DatadaCompra = New System.Windows.Forms.Label()
        Me.Label_LocalDaCompra = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_DatadaCompra)
        Me.Panel1.Controls.Add(Me.Label_Quantidade)
        Me.Panel1.Controls.Add(Me.Label_ValorUnitario)
        Me.Panel1.Controls.Add(Me.Label_Total)
        Me.Panel1.Controls.Add(Me.Label_Descrição)
        Me.Panel1.Controls.Add(Me.Label_NomeDoMaterial)
        Me.Panel1.Controls.Add(Me.Label_LocalDaCompra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label_Quantidade
        '
        Me.Label_Quantidade.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_Quantidade.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label_Quantidade.Location = New System.Drawing.Point(675, 10)
        Me.Label_Quantidade.Name = "Label_Quantidade"
        Me.Label_Quantidade.Size = New System.Drawing.Size(130, 30)
        Me.Label_Quantidade.TabIndex = 33
        Me.Label_Quantidade.Text = "0"
        Me.Label_Quantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_ValorUnitario
        '
        Me.Label_ValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_ValorUnitario.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label_ValorUnitario.Location = New System.Drawing.Point(811, 10)
        Me.Label_ValorUnitario.Name = "Label_ValorUnitario"
        Me.Label_ValorUnitario.Size = New System.Drawing.Size(130, 30)
        Me.Label_ValorUnitario.TabIndex = 32
        Me.Label_ValorUnitario.Text = "R$ 0,00"
        Me.Label_ValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Total
        '
        Me.Label_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_Total.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Total.Location = New System.Drawing.Point(947, 10)
        Me.Label_Total.Name = "Label_Total"
        Me.Label_Total.Size = New System.Drawing.Size(130, 30)
        Me.Label_Total.TabIndex = 31
        Me.Label_Total.Text = "R$ 0,00"
        Me.Label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Descrição
        '
        Me.Label_Descrição.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Descrição.AutoSize = True
        Me.Label_Descrição.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_Descrição.Location = New System.Drawing.Point(10, 26)
        Me.Label_Descrição.Name = "Label_Descrição"
        Me.Label_Descrição.Size = New System.Drawing.Size(75, 19)
        Me.Label_Descrição.TabIndex = 30
        Me.Label_Descrição.Text = "description"
        '
        'Label_NomeDoMaterial
        '
        Me.Label_NomeDoMaterial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_NomeDoMaterial.AutoSize = True
        Me.Label_NomeDoMaterial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NomeDoMaterial.Location = New System.Drawing.Point(10, 5)
        Me.Label_NomeDoMaterial.Name = "Label_NomeDoMaterial"
        Me.Label_NomeDoMaterial.Size = New System.Drawing.Size(39, 21)
        Me.Label_NomeDoMaterial.TabIndex = 28
        Me.Label_NomeDoMaterial.Text = "title"
        '
        'Label_DatadaCompra
        '
        Me.Label_DatadaCompra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_DatadaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_DatadaCompra.Location = New System.Drawing.Point(539, 10)
        Me.Label_DatadaCompra.Name = "Label_DatadaCompra"
        Me.Label_DatadaCompra.Size = New System.Drawing.Size(130, 30)
        Me.Label_DatadaCompra.TabIndex = 34
        Me.Label_DatadaCompra.Text = "00/00/0000"
        Me.Label_DatadaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_LocalDaCompra
        '
        Me.Label_LocalDaCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_LocalDaCompra.AutoEllipsis = True
        Me.Label_LocalDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_LocalDaCompra.Location = New System.Drawing.Point(383, 10)
        Me.Label_LocalDaCompra.Name = "Label_LocalDaCompra"
        Me.Label_LocalDaCompra.Size = New System.Drawing.Size(150, 30)
        Me.Label_LocalDaCompra.TabIndex = 35
        Me.Label_LocalDaCompra.Text = "local"
        Me.Label_LocalDaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrçamentoItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OrçamentoItemControl"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1090, 60)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_NomeDoMaterial As System.Windows.Forms.Label
    Friend WithEvents Label_Descrição As System.Windows.Forms.Label
    Friend WithEvents Label_Quantidade As System.Windows.Forms.Label
    Friend WithEvents Label_ValorUnitario As System.Windows.Forms.Label
    Friend WithEvents Label_Total As System.Windows.Forms.Label
    Friend WithEvents Label_DatadaCompra As System.Windows.Forms.Label
    Friend WithEvents Label_LocalDaCompra As System.Windows.Forms.Label

End Class
