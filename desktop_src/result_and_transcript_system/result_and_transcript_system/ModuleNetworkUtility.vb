﻿Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System
Imports System.Net.Dns
Imports System.Drawing.Bitmap
'Imports CustomControls.IconComboBox
'Imports UNOLibs.Net.ClientClass
'Imports RapChatLib.RapChatLib
Module ModuleNetworkUtility
#Region "Declarations"
    Private ip As New Net.IPAddress({127, 0, 0, 1}) '(0x2414188f, 1) 'endian val for ip 143.24.20.36 
    Public Listener As New TcpListener(ip, 65535)
    Public Client As New TcpClient
    Public Message As String = ""
    Public Listener1 As New TcpListener(ip, 65535)
    Public Client1 As New TcpClient
    Public Message1 As String = ""
    Public IPAdd As String


#End Region

    Sub initializeObjects()
        Try
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Public Sub logError(str As String)
        On Error Resume Next
        Dim fileExists As Boolean

        fileExists = My.Computer.FileSystem.FileExists(USER_DIRECTORY & "\db\error_log" & Now.Date.ToString & ".txt")
        If fileExists = True Then
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", str, True)
        Else
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", String.Empty, False)


        End If
    End Sub
End Module
