Imports System.Windows.Forms

Public Class AdicionarSaldoDialog

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        If TextBox_Saldo.Text = Nothing Then
            MsgBox("Digite o Saldo", MsgBoxStyle.Critical)
        Else
            If Not IsNumeric(TextBox_Saldo.Text) Then
                MsgBox("O valor digitado não é válido.", MsgBoxStyle.Critical)
            Else
                If Val(TextBox_Saldo.Text) <= 0 Then
                    MsgBox("O valor digitado não é válido.", MsgBoxStyle.Critical)
                Else
                    Dim R As New Random
                    Dim Code = R.Next
                    _INI.WriteIniFile(_DIRECTORY_Saldos & Code & ".ini", "SALDO", "valor", TextBox_Saldo.Text)
                    _INI.WriteIniFile(_DIRECTORY_Saldos & Code & ".ini", "SALDO", "data", DateTimePicker_Date.Value.Date)
                    _INI.WriteIniFile(_DIRECTORY_Saldos & Code & ".ini", "SALDO", "description", TextBox_Description.Text)
                    SoftwareHomeForm.ImportSaldos()
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
