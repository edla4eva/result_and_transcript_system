

Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
'####### Use to handle Excel Application################
Public Class ClassExcel
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Private _fileNameWB As String
    Private _fileName As String
    Private _font As New Font("Arial", 50, FontStyle.Bold)
    Private _settings As Dictionary(Of String, String)
    Private _WBDataSet As DataSet

    Public Property FileNameWB() As String
        Get
            Return _fileNameWB
        End Get
        Set(ByVal value As String)
            _fileNameWB = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e)
        End Set
    End Property

    Public Property settings() As Dictionary(Of String, String)
        Get
            Return _settings
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _settings = value
        End Set
    End Property

    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
        End Set
    End Property


    Public Sub New()
        Try
            Me._font = New Font("Arial", 50, FontStyle.Bold)
            'USER_DIRECTORY
            Me._fileNameWB = USER_DIRECTORY & "\Samples\Result.xlsx"
            Me.settings = getDefaultSettings(True)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub




    Function getDefaultSettings(Optional useDefault As Boolean = False) As Dictionary(Of String, String)
        Try
            Dim tmp As New Dictionary(Of String, String)
            If useDefault = True Then
                tmp.Add("fontSize", "50")
                tmp.Add("fontFamily", "Arial")
                tmp.Add("max_Char", "160")

            Else
                tmp = Me._settings
            End If
            Return tmp
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    'TODO
    Public Sub importdatafromexcelOLEDB(ByVal excelfilepath As String)
        Dim ssqltable As String = "tdatamigrationtable"
        Dim myexceldataquery As String = "select student,rollno,course from [sheet1$]"

        Try
            Dim sexcelconnectionstring As String = "provider=microsoft.jet.oledb.4.0;data source=" & excelfilepath & ";extended properties=" & """excel 8.0;hdr=yes;"""
            Dim ssqlconnectionstring As String = "server=mydatabaseservername;user
            id = dbuserid
            password = dbuserpassword
            database = databasename
             ;"
            'first delete
            Dim sclearsql As String = "delete from " & ssqltable
            Dim sqlconn As SqlConnection = New SqlConnection(ssqlconnectionstring)
            Dim sqlcmd As SqlCommand = New SqlCommand(sclearsql, sqlconn)
            sqlconn.Open()
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

            Dim oledbconn As OleDbConnection = New OleDbConnection(sexcelconnectionstring)
            Dim oledbcmd As OleDbCommand = New OleDbCommand(myexceldataquery, oledbconn)
            oledbconn.Open()
            Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()
            Dim bulkcopy As SqlBulkCopy = New SqlBulkCopy(ssqlconnectionstring)
            bulkcopy.DestinationTableName = ssqltable

            While dr.Read()
                bulkcopy.WriteToServer(dr)
            End While

            oledbconn.Close()
        Catch ex As Exception
        End Try
    End Sub



End Class
