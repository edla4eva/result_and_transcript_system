Imports Microsoft.Reporting.WinForms

Public Class ClassReports
    Public Sub New()
        m_employees.Add("item 1")
        m_employees.Add("item ")
        ds = creatDataSet()
    End Sub



    Private ds As DataSet

    Public Property getDatset() As DataSet
        Get
            Return ds
        End Get
        Set(ByVal value As DataSet)
            ds = value
        End Set
    End Property

    Private m_employees As New List(Of String)     'List(Of students)
    Public Property getemployee() As List(Of String)
        Get
            Return m_employees
        End Get
        Set(ByVal value As List(Of String))
            m_employees = value
        End Set
    End Property
    Private _matno As String
    Private _surname As String
    Private _othernames As String
    Private _credits As String
    Private _status As String
    Private _session As String

    Private _course_code_idr As String
    Private _course_title As String

    Private _session_idr As String
    Private _remarks As String
    Private _mode As String
    Private _department As String
    Private _dob As String
    Private _score As String
    Public Property MATNO() As String
        Get
            Return _matno
        End Get
        Set(ByVal value As String)
            _matno = value
        End Set
    End Property
    Public Property SURNAME() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = value
        End Set
    End Property
    Public Property OtherNames() As String
        Get
            Return _othernames
        End Get
        Set(ByVal value As String)
            _othernames = value
        End Set
    End Property
    Public Property Credits() As String
        Get
            Return _credits
        End Get
        Set(ByVal value As String)
            _credits = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
    Public Property Session() As String
        Get
            Return _session
        End Get
        Set(ByVal value As String)
            _session = value
        End Set
    End Property



    Public Property course_code_idr() As String
        Get
            Return _course_code_idr
        End Get
        Set(ByVal value As String)
            _course_code_idr = value
        End Set
    End Property
    Public Property session_idr() As String
        Get
            Return _session_idr
        End Get
        Set(ByVal value As String)
            _session_idr = value
        End Set
    End Property
    Public Property course_title() As String
        Get
            Return _course_title
        End Get
        Set(ByVal value As String)
            _course_title = value
        End Set
    End Property
    Public Property remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property
    Public Property mode() As String
        Get
            Return _mode
        End Get
        Set(ByVal value As String)
            _mode = value
        End Set
    End Property
    Public Property department() As String
        Get
            Return _department
        End Get
        Set(ByVal value As String)
            _department = value
        End Set
    End Property
    Public Property dob() As String
        Get
            Return _dob
        End Get
        Set(ByVal value As String)
            _dob = value
        End Set
    End Property
    Public Property score() As String
        Get
            Return _score
        End Get
        Set(ByVal value As String)
            _score = value
        End Set
    End Property
    Function creatDataSetSenate() As DataSet
        'Very good!
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn, matnoCoulumn As DataColumn
        Dim nameCoulumn, surnameCoulumn, statusCoulumn, creditsCoulumn As DataColumn

        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dt = New DataTable()
        idCoulumn = New DataColumn("SN", Type.GetType("System.Int32"))
        matnoCoulumn = New DataColumn("MATNO", Type.GetType("System.String"))
        surnameCoulumn = New DataColumn("SURNAME", Type.GetType("System.String"))
        nameCoulumn = New DataColumn("Other Names", Type.GetType("System.String"))
        statusCoulumn = New DataColumn("Status", Type.GetType("System.String"))
        creditsCoulumn = New DataColumn("Credits", Type.GetType("System.Double"))


        dt.TableName = "Senate"
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(matnoCoulumn)
        dt.Columns.Add(surnameCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(statusCoulumn)
        dt.Columns.Add(creditsCoulumn)

        dr = dt.NewRow()
        dr("SN") = 1
        dr("MATNO") = "ENG000222111"
        dr("SURNAME") = "OBINNA"
        dr("Other Names") = "Amenaghawon"
        dr("Status") = "Successful"
        dr("Credits") = 22
        dt.Rows.Add(dr)
        SumDr = SumDr + 1




        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i

        'Visualization
        'dgw.DataSource = ds.Tables("Senate").DefaultView

        'Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
        'Works perfectly
        Return ds
    End Function
    Function creatDataSet() As DataSet
        'Very good!
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn As DataColumn
        Dim nameCoulumn As DataColumn
        Dim drCoulumn, crCoulumn, balCoulumn As DataColumn
        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dt = New DataTable()
        idCoulumn = New DataColumn("ID", Type.GetType("System.Int32"))
        nameCoulumn = New DataColumn("Ref", Type.GetType("System.String"))
        drCoulumn = New DataColumn("Dr", Type.GetType("System.Double"))
        crCoulumn = New DataColumn("Cr", Type.GetType("System.Double"))
        balCoulumn = New DataColumn("Bal", Type.GetType("System.Double"))

        dt.TableName = "Bill"
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(drCoulumn)
        dt.Columns.Add(crCoulumn)
        dt.Columns.Add(balCoulumn)

        SumDr = 500
        sumCr = 0
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref001"
        dr("Dr") = 500
        dr("Cr") = 0
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        SumDr = SumDr + 0
        sumCr = sumCr + 700
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref002"
        dr("Dr") = 0
        dr("Cr") = 700
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i

        'Visualization
        'dgw.DataSource = ds.Tables("Bill").DefaultView

        'Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
        'Works perfectly
        Return ds
    End Function
    Sub updateReportDataSource(dsName As String, rptV As ReportViewer, dt As DataTable)
        'Report stuff
        With rptV.LocalReport

            .DataSources.Clear()
            '.ReportPath = My.Application.Info.DirectoryPath
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(dsName, dt))
        End With
        rptV.RefreshReport()
        'Works perfectly
    End Sub



    '    Class Company

    '{

    '        Private List<Employee> m_employees;



    '        Public Company()

    '        {

    '            m_employees = New List<Employee>();

    '            m_employees.Add(New Employee("Mahesh Chand", "112 New Road, Chadds Ford, PA", "123-21-1212", 30));

    '            m_employees.Add(New Employee("Jack Mohita", "Pear Lane, New York 23231", "878-12-2334", 23));

    '            m_employees.Add(New Employee("Renee Singer", "Near medow, Philadelphia, PA", "980-00-2320", 20));

    '        }

    '        Public List<Employee> GetEmployees()

    '        {

    '            Return m_employees;

    '        }

    '}  
End Class
