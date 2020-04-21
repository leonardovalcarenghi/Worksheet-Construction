<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrçamentoItem2Control
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label_NomeDoOrçamento = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label_LocalDaCompra = New System.Windows.Forms.Label()
        Me.Label_DatadaCompra = New System.Windows.Forms.Label()
        Me.Label_Total = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 34)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label_NomeDoOrçamento)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(12, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(206, 34)
        Me.Panel4.TabIndex = 38
        '
        'Label_NomeDoOrçamento
        '
        Me.Label_NomeDoOrçamento.AutoEllipsis = True
        Me.Label_NomeDoOrçamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_NomeDoOrçamento.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NomeDoOrçamento.Location = New System.Drawing.Point(0, 0)
        Me.Label_NomeDoOrçamento.Name = "Label_NomeDoOrçamento"
        Me.Label_NomeDoOrçamento.Size = New System.Drawing.Size(206, 34)
        Me.Label_NomeDoOrçamento.TabIndex = 28
        Me.Label_NomeDoOrçamento.Text = "Meu Orçamento"
        Me.Label_NomeDoOrçamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.Controls.Add(Me.Label_LocalDaCompra)
        Me.Panel5.Controls.Add(Me.Label_DatadaCompra)
        Me.Panel5.Controls.Add(Me.Label_Total)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(218, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 34)
        Me.Panel5.TabIndex = 40
        '
        'Label_LocalDaCompra
        '
        Me.Label_LocalDaCompra.AutoEllipsis = True
        Me.Label_LocalDaCompra.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_LocalDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_LocalDaCompra.Location = New System.Drawing.Point(0, 0)
        Me.Label_LocalDaCompra.Name = "Label_LocalDaCompra"
        Me.Label_LocalDaCompra.Size = New System.Drawing.Size(200, 34)
        Me.Label_LocalDaCompra.TabIndex = 40
        Me.Label_LocalDaCompra.Text = "local"
        Me.Label_LocalDaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_DatadaCompra
        '
        Me.Label_DatadaCompra.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_DatadaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_DatadaCompra.Location = New System.Drawing.Point(200, 0)
        Me.Label_DatadaCompra.Name = "Label_DatadaCompra"
        Me.Label_DatadaCompra.Size = New System.Drawing.Size(100, 34)
        Me.Label_DatadaCompra.TabIndex = 37
        Me.Label_DatadaCompra.Text = "00/00/0000"
        Me.Label_DatadaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Total
        '
        Me.Label_Total.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label_Total.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Total.Location = New System.Drawing.Point(300, 0)
        Me.Label_Total.Name = "Label_Total"
        Me.Label_Total.Size = New System.Drawing.Size(100, 34)
        Me.Label_Total.TabIndex = 36
        Me.Label_Total.Text = "R$ 0,00"
        Me.Label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(12, 34)
        Me.Panel3.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 28)
        Me.Panel2.TabIndex = 36
        '
        'OrçamentoItem2Control
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OrçamentoItem2Control"
        Me.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Size = New System.Drawing.Size(618, 44)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_NomeDoOrçamento As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label_DatadaCompra As System.Windows.Forms.Label
    Friend WithEvents Label_Total As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label_LocalDaCompra As System.Windows.Forms.Label

End Class
