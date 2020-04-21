Imports System.Windows.Forms

Public Class AboutSoftwareDialog
  
    Private Sub AboutSoftwareDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Version_Label.Text = My.Settings.SOFTWARE_Version
    End Sub

    Private Sub LinkLabel_IconsSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_IconsSite.LinkClicked
        Process.Start("https://icons8.com.br")
    End Sub
End Class
