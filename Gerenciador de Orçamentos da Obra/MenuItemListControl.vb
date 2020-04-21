Public Class MenuItemListControl

    Public Property MenuText As String
        Get
            Return MenuItemText_Label.Text
        End Get
        Set(value As String)
            MenuItemText_Label.Text = value
        End Set
    End Property

    Public Property MenuIcon As Image
        Get
            Return MenuItemIcon_Picturebox.Image
        End Get
        Set(value As Image)
            MenuItemIcon_Picturebox.Image = value
        End Set
    End Property


    Private Sub MenuItemPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemText_Label.MouseClick, MenuItemPanel.MouseClick, MenuItemIcon_Picturebox.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyBase.OnMouseClick(e) : Invalidate()
        End If
    End Sub

    Private Sub MenuItemPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuItemText_Label.MouseDown, MenuItemPanel.MouseDown, MenuItemIcon_Picturebox.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MenuItemPanel.BackColor = Color.FromArgb(65, 65, 65)
        End If
    End Sub

    Private Sub MenuItemPanel_MouseEnter(sender As Object, e As EventArgs) Handles MenuItemText_Label.MouseEnter, MenuItemPanel.MouseEnter, MenuItemIcon_Picturebox.MouseEnter
        MenuItemPanel.BackColor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub MenuItemPanel_MouseLeave(sender As Object, e As EventArgs) Handles MenuItemText_Label.MouseLeave, MenuItemPanel.MouseLeave, MenuItemIcon_Picturebox.MouseLeave
        MenuItemPanel.BackColor = Color.Transparent
    End Sub

    Private Sub MenuItemListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
    End Sub
End Class
