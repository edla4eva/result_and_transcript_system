

Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
'####### Use to handle Excel Application################
Public Class ClassExcel
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Private _fileNameWB As String
    Private _previewImageFileName As String
    Private slideStrValue As String
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
            Return _previewImageFileName
        End Get
        Set(ByVal value As String)
            _previewImageFileName = value
        End Set
    End Property


    Public Sub New()
        Try
            Me._font = New Font("Arial", 50, FontStyle.Bold)
            'USER_DIRECTORY
            Me._fileNameWB = USER_DIRECTORY & "\Samples\Result.xlsx"
            Me.slideStrValue = "In the begining God created the heaven and the earth."
            Me.settings = getSettings(True)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub




    Function getSettings(Optional useDefault As Boolean = False) As Dictionary(Of String, String)
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



End Class
