Imports System.Data
Imports System.Data.OleDb

Module Module1
    Public srtUsuario As String
    Public srtGrupo As String
    Public srtSenha As String
    Public intPergunta As Integer
    Public Relatorio As String
    Public LOCAL As String

    Public Function GetConnection() As OleDbConnection
        Dim sql As String = My.Settings.dbgdaConnectionString
        Return New OleDbConnection(sql)
    End Function

    Declare Function AddFontResource Lib "gdi32" Alias "AddFontResourceA" (ByVal lpFileName As String) As Long
    Declare Function RemoveFontResource Lib "gdi32" Alias "RemoveFontResourceA" (ByVal lpFileName As String) As Long
    Sub Main()
        On Error Resume Next
        Dim L As Long
        FileCopy("BarcodeFont.ttf", "c:\windows\fonts\BarcodeFont.ttf")
        L = AddFontResource("c:\windows\fonts\BarcodeFont.ttf")
        My.Settings.Instalada = "Sim"
        End
    End Sub

End Module
