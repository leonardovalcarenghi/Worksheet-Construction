Imports System.Windows.Forms

Public Class PesquisarOrçamentosDialog
    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        If TextBox_Search.Text <> Nothing Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
