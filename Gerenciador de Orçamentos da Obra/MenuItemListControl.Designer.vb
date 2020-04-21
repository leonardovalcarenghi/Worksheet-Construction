<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItemListControl
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
        Me.MenuItemPanel = New System.Windows.Forms.Panel()
        Me.MenuItemText_Label = New System.Windows.Forms.Label()
        Me.MenuItemIcon_Picturebox = New System.Windows.Forms.PictureBox()
        Me.MenuItemPanel.SuspendLayout()
        CType(Me.MenuItemIcon_Picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuItemPanel
        '
        Me.MenuItemPanel.Controls.Add(Me.MenuItemText_Label)
        Me.MenuItemPanel.Controls.Add(Me.MenuItemIcon_Picturebox)
        Me.MenuItemPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuItemPanel.ForeColor = System.Drawing.Color.White
        Me.MenuItemPanel.Location = New System.Drawing.Point(0, 5)
        Me.MenuItemPanel.Name = "MenuItemPanel"
        Me.MenuItemPanel.Size = New System.Drawing.Size(300, 40)
        Me.MenuItemPanel.TabIndex = 1
        '
        'MenuItemText_Label
        '
        Me.MenuItemText_Label.AutoSize = True
        Me.MenuItemText_Label.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuItemText_Label.Location = New System.Drawing.Point(60, 11)
        Me.MenuItemText_Label.Name = "MenuItemText_Label"
        Me.MenuItemText_Label.Size = New System.Drawing.Size(32, 19)
        Me.MenuItemText_Label.TabIndex = 2
        Me.MenuItemText_Label.Text = "text"
        '
        'MenuItemIcon_Picturebox
        '
        Me.MenuItemIcon_Picturebox.Location = New System.Drawing.Point(20, 3)
        Me.MenuItemIcon_Picturebox.Name = "MenuItemIcon_Picturebox"
        Me.MenuItemIcon_Picturebox.Size = New System.Drawing.Size(34, 34)
        Me.MenuItemIcon_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuItemIcon_Picturebox.TabIndex = 1
        Me.MenuItemIcon_Picturebox.TabStop = False
        '
        'MenuItemListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuItemPanel)
        Me.Name = "MenuItemListControl"
        Me.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Size = New System.Drawing.Size(300, 50)
        Me.MenuItemPanel.ResumeLayout(False)
        Me.MenuItemPanel.PerformLayout()
        CType(Me.MenuItemIcon_Picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItemPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuItemText_Label As System.Windows.Forms.Label
    Friend WithEvents MenuItemIcon_Picturebox As System.Windows.Forms.PictureBox

End Class
