Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Public Class SoftwareUpdatesDialog




    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Dim WithEvents Webbrowser_ConnectToServer As New WebBrowser
    Dim WithEvents Webbrowser_GetInformations As New WebBrowser
    Private Sub CheckForUpdatesDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartCheckForUpdates()
    End Sub

    Public Sub StartCheckForUpdates()
        'Verificar se tem internet:
        If My.Computer.Network.IsAvailable Then
            Me.Cursor = Cursors.WaitCursor
            Informations_Panel.Show()
            NoInternet_Panel.Hide()
            Webbrowser_ConnectToServer.Navigate(My.Settings.server_url) 'Conectar ao servidor
        Else
            Informations_Panel.Hide()
            NoInternet_Panel.Show()
        End If
    End Sub

    Dim HtmlFromDiv As String
    Private Sub Webbrowser_ConnectToServer_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Webbrowser_ConnectToServer.DocumentCompleted
        Status_Label.Text = "Obtendo informações..."
        HtmlFromDiv = Webbrowser_ConnectToServer.Document.GetElementById(My.Settings.server_id).InnerHtml 'Obter informações
        Threading.Thread.Sleep(1000)
        Status_Label.Text = "Processando informações..."
        Webbrowser_GetInformations.DocumentText = HtmlFromDiv 'Mandar DIV com informações pro outro Webbrouser.

    End Sub

    Private Sub Webbrowser_ConnectToServer_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles Webbrowser_ConnectToServer.Navigating
        Status_Label.Text = "Conectando ao servidor..."
    End Sub

    Dim WEB_Update As String
    Dim WEB_Version As String
    Dim WEB_Year As String
    Dim WEB_Description As String
    Dim WEB_LinkForDownload As String


    Private Sub Webbrowser_GetInformations_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Webbrowser_GetInformations.DocumentCompleted
        Me.Cursor = Cursors.Default
        'WEB_Update = Webbrowser_GetInformations.Document.GetElementById("update").InnerText
        WEB_Version = Webbrowser_GetInformations.Document.GetElementById("version").InnerText
        Try
            WEB_Year = Webbrowser_GetInformations.Document.GetElementById("year").InnerText
            WEB_Description = Webbrowser_GetInformations.Document.GetElementById("description").InnerText
            WEB_LinkForDownload = Webbrowser_GetInformations.Document.GetElementById("link").InnerText
        Catch ex As Exception

        End Try
        If WEB_Version > My.Settings.SOFTWARE_Version Then 'Se a versão disponivel na web for maior que a atual

            'Versão Atual
            ActualVersion_Label.Text = My.Settings.SOFTWARE_Version

            'Nova Versão Disponível
            NewVersion_Label.Text = WEB_Version

            'Novo Update
            NewUpdate_Label.Text = "null" ' WEB_Update

            'Ano da Versão
            VersionYear_Label.Text = WEB_Year

            'Descrição da Versão
            Description_Label.Text = WEB_Description

            Informations_Panel.Hide() : NewVersionAvailable_Panel.Show() : Download_Button.Show()
            If Me.Visible = False Then Me.ShowDialog()

        Else
            Informations_Panel.Hide()
            LastVersion_Panel.Show()
        End If


    End Sub

    Public WithEvents DownloadUpdate As WebClient
    Dim File_SetupPath As String
    Private Sub Download_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Download_Button.Click
        DialogOptionsPanel.Hide() : Me.ControlBox = False
        Informations_Panel.Show() : NewVersionAvailable_Panel.Hide()
        Title_Label.Text = "Baixando Atualização..."
        Status_Label.Text = "Inicializando o download..."

        Threading.Thread.Sleep(3000)
        Dim NameToFile As String = "Instalador do Worksheet Construction (" & WEB_Version & ").exe"
        File_SetupPath = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & NameToFile
        DownloadUpdate = New WebClient
        DownloadUpdate.DownloadFileAsync(New Uri(WEB_LinkForDownload), File_SetupPath)


    End Sub

    Private Sub DownloadUpdate_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles DownloadUpdate.DownloadFileCompleted
        Title_Label.Text = "Download Concluído"
        If MessageBox.Show("Deseja iniciar a instalação agora?", "Download Concluído", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Process.Start(File_SetupPath)
            End 'Encerrar Programa
        Else
            Me.Close()
        End If
    End Sub

    Private Sub DownloadUpdate_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles DownloadUpdate.DownloadProgressChanged

        Status_Label.Text = e.ProgressPercentage & "%"
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class
