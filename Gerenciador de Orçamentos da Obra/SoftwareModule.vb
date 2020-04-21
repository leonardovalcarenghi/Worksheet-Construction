Imports System.Text

Module SoftwareModule

    Public _INI As New ClassINI
    Public _DIRECTORY_Orçamentos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Gerenciador de Orçamentos da Obra\Orçamentos\"
    Public _DIRECTORY_Saldos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Gerenciador de Orçamentos da Obra\Saldos\"





    Public Sub _CreateDirectorys()
        If Not IO.Directory.Exists(_DIRECTORY_Orçamentos) Then
            IO.Directory.CreateDirectory(_DIRECTORY_Orçamentos)
        End If

        If Not IO.Directory.Exists(_DIRECTORY_Saldos) Then
            IO.Directory.CreateDirectory(_DIRECTORY_Saldos)
        End If

    End Sub



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="n"></param>
    ''' <returns>TRUE = Par / FALSE = Ímpar</returns>
    ''' <remarks></remarks>
    Function _ParOuImpar(ByVal n As Integer) As Boolean
        If n Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function




    Public _LIST_OrçamentosAbertos As New List(Of String)
    Public _LIST_OrçamentosAbertosForms As New List(Of VisualizarOrçamentoDialog)

    Public Sub _AbrirOrçamento(ByVal OrçamentoPath As String)
        If Not _LIST_OrçamentosAbertos.Contains(OrçamentoPath) Then
            Dim ViewOrçamento As New VisualizarOrçamentoDialog : ViewOrçamento = New VisualizarOrçamentoDialog
            ViewOrçamento.ORÇAMENTO_Path = OrçamentoPath

            ViewOrçamento.Show()

            _LIST_OrçamentosAbertos.Add(OrçamentoPath)
            _LIST_OrçamentosAbertosForms.Add(ViewOrçamento)

        Else

            Dim item = _LIST_OrçamentosAbertosForms.Item(_LIST_OrçamentosAbertos.IndexOf(OrçamentoPath))

            item.WindowState = FormWindowState.Normal
            item.TopMost = True
            item.Show()
            item.TopMost = False

        End If
    End Sub
End Module



Public Class ClassINI

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="_file">Nome do arquivo para salvar</param>
    ''' <param name="_key">Chave</param>
    ''' <param name="_section">Seção</param>
    ''' <param name="_value">Valor a ser escrito</param>
    ''' <remarks></remarks>
    Public Sub WriteIniFile(ByVal _file As String, ByVal _section As String, ByVal _key As String, ByVal _value As String)
        WritePrivateProfileString(_section, _key, _value, _file)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="_file">Nome do arquivo para salvar</param>
    ''' <param name="_key">Chave</param>
    ''' <param name="_section">Seção</param>
    ''' <param name="_default_value">Valor de backup, caso não seja carregado nada</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ReadIniFile(ByVal _file As String, ByVal _section As String, ByVal _key As String, Optional ByVal _default_value As String = "") As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)

        GetPrivateProfileString(_section, _key, _default_value, string_builder, MAX_LENGTH, _file)
        '   GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)

        Return string_builder.ToString()
    End Function
End Class

