<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaldoItemControl
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
        Me.Label_Value = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_DescriptionName = New System.Windows.Forms.Label()
        Me.Label_Date = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Value
        '
        Me.Label_Value.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_Value.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_Value.Location = New System.Drawing.Point(397, 5)
        Me.Label_Value.Name = "Label_Value"
        Me.Label_Value.Size = New System.Drawing.Size(100, 22)
        Me.Label_Value.TabIndex = 63
        Me.Label_Value.Text = "R$ 9.999,99"
        Me.Label_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(10, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 24)
        Me.Panel1.TabIndex = 64
        '
        'Label_DescriptionName
        '
        Me.Label_DescriptionName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_DescriptionName.AutoEllipsis = True
        Me.Label_DescriptionName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DescriptionName.Location = New System.Drawing.Point(18, 5)
        Me.Label_DescriptionName.Name = "Label_DescriptionName"
        Me.Label_DescriptionName.Size = New System.Drawing.Size(300, 22)
        Me.Label_DescriptionName.TabIndex = 65
        Me.Label_DescriptionName.Text = "Saldo da Aposentadoria"
        Me.Label_DescriptionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Date
        '
        Me.Label_Date.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_Date.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label_Date.Location = New System.Drawing.Point(291, 5)
        Me.Label_Date.Name = "Label_Date"
        Me.Label_Date.Size = New System.Drawing.Size(100, 22)
        Me.Label_Date.TabIndex = 66
        Me.Label_Date.Text = "99/99/9999"
        Me.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaldoItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_Date)
        Me.Controls.Add(Me.Label_DescriptionName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_Value)
        Me.Name = "SaldoItemControl"
        Me.Size = New System.Drawing.Size(500, 32)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_Value As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_DescriptionName As System.Windows.Forms.Label
    Friend WithEvents Label_Date As System.Windows.Forms.Label

End Class
