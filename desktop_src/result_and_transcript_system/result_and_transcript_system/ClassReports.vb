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

    Private m_employees As List(Of String)     'List(Of students)
    Public Property getemployee() As List(Of String)
        Get
            Return m_employees
        End Get
        Set(ByVal value As List(Of String))
            m_employees = value
        End Set
    End Property
    Function creatDataSet() As DataSet
        'Very good!

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
    Sub updateReportDataSource()
        'Visualization
        'Dim ds As New DataSet
        'Dim dt As DataTable
        'Dim dr As DataRow
        'dgw.DataSource = ds.Tables("Bill").DefaultView

        'Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
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
