Imports System.IO

Public Class SaldosDialog

    Private Sub SaldosDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImportSaldos()
    End Sub


    Private Sub ImportSaldos()
        Dim Total As Decimal = 0
        Dim DirDirectorie As DirectoryInfo = New DirectoryInfo(_DIRECTORY_Saldos)
        Dim SaldosFile() As FileInfo = DirDirectorie.GetFiles()
        For Each i As FileInfo In SaldosFile
            Dim Descrição As String = _INI.ReadIniFile(i.FullName, "SALDO", "description", "Sem descrição...")
            Dim Valor As String = _INI.ReadIniFile(i.FullName, "SALDO", "valor")
            Dim Data As Date = _INI.ReadIniFile(i.FullName, "SALDO", "data")

            Dim Item As New SaldoItemControl : Item = New SaldoItemControl
            Item.Label_DescriptionName.Text = Descrição
            Item.Label_Date.Text = Data
            Item.Label_Value.Text = "R$ " & String.Format("{0:f}", Double.Parse(Valor))

            SaldoListControlPanel.Controls.Add(Item) : Item.BringToFront()

            Total = Total + Valor
        Next
        Label_Total.Text = "R$ " & String.Format("{0:f}", Double.Parse(Total))
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class