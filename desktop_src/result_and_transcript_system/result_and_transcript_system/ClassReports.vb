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

    '----bs starts here
    Public _sn As String
    Public Property sn() As String
        Get
            Return _sn
        End Get
        Set(ByVal value As String)
            _sn = value
        End Set
    End Property


    Public _fullname As String
    Public Property Fullname() As String
        Get
            Return _fullname
        End Get
        Set(ByVal value As String)
            _fullname = value
        End Set
    End Property
    Public _courseCode As String
    Public Property CourseCode() As String
        Get
            Return _courseCode
        End Get
        Set(ByVal value As String)
            _courseCode = value
        End Set
    End Property


    Public _category As String

    Public Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Public _failed As String

    Public Property Failed() As String
        Get
            Return _failed
        End Get
        Set(ByVal value As String)
            _failed = value
        End Set
    End Property

    Public _bs_session As String

    Public Property bs_session() As String
        Get
            Return _bs_session
        End Get
        Set(ByVal value As String)
            _bs_session = value
        End Set
    End Property

    Public _bs_department_name As String

    Public Property bs_department_name() As String
        Get
            Return _bs_department_name
        End Get
        Set(ByVal value As String)
            _bs_department_name = value
        End Set
    End Property

    Public _bs_faculty_name As String

    Public Property bs_faculty_name() As String
        Get
            Return _bs_faculty_name
        End Get
        Set(ByVal value As String)
            _bs_faculty_name = value
        End Set
    End Property

    Public _bs_level As String

    Public Property bs_level() As String
        Get
            Return _bs_level
        End Get
        Set(ByVal value As String)
            _bs_level = value
        End Set
    End Property

    Public _bs_footers As String

    Public Property bs_footers() As String
        Get
            Return _bs_footers
        End Get
        Set(ByVal value As String)
            _bs_footers = value
        End Set
    End Property

    Public _bs_timestamp As String

    Public Property bs_timestamp() As String
        Get
            Return _bs_timestamp
        End Get
        Set(ByVal value As String)
            _bs_timestamp = value
        End Set
    End Property

    Public _gpa100 As String

    Public Property gpa100() As String
        Get
            Return _gpa100
        End Get
        Set(ByVal value As String)
            _gpa100 = value
        End Set
    End Property

    Public _gpa200 As String

    Public Property gpa200() As String
        Get
            Return _gpa200
        End Get
        Set(ByVal value As String)
            _gpa200 = value
        End Set
    End Property

    Public _gpa300 As String

    Public Property gpa300() As String
        Get
            Return _gpa300
        End Get
        Set(ByVal value As String)
            _gpa300 = value
        End Set
    End Property

    Public _gpa400 As String

    Public Property gpa400() As String
        Get
            Return _gpa400
        End Get
        Set(ByVal value As String)
            _gpa400 = value
        End Set
    End Property

    Public _gpa500 As String

    Public Property gpa500() As String
        Get
            Return _gpa500
        End Get
        Set(ByVal value As String)
            _gpa500 = value
        End Set
    End Property

    Public _gpa600 As String

    Public Property gpa600() As String
        Get
            Return _gpa600
        End Get
        Set(ByVal value As String)
            _gpa600 = value
        End Set
    End Property

    Public _gpa700 As String

    Public Property gpa700() As String
        Get
            Return _gpa700
        End Get
        Set(ByVal value As String)
            _gpa700 = value
        End Set
    End Property

    Public _gpa800 As String

    Public Property gpa800() As String
        Get
            Return _gpa800
        End Get
        Set(ByVal value As String)
            _gpa800 = value
        End Set
    End Property

    Public _gpa900 As String

    Public Property gpa900() As String
        Get
            Return _gpa900
        End Get
        Set(ByVal value As String)
            _gpa900 = value
        End Set
    End Property

    Public _wgpa100 As String

    Public Property wgpa100() As String
        Get
            Return _wgpa100
        End Get
        Set(ByVal value As String)
            _wgpa100 = value
        End Set
    End Property

    Public _wgpa200 As String

    Public Property wgpa200() As String
        Get
            Return _wgpa200
        End Get
        Set(ByVal value As String)
            _wgpa200 = value
        End Set
    End Property

    Public _wgpa300 As String

    Public Property wgpa300() As String
        Get
            Return _wgpa300
        End Get
        Set(ByVal value As String)
            _wgpa300 = value
        End Set
    End Property

    Public _wgpa400 As String

    Public Property wgpa400() As String
        Get
            Return _wgpa400
        End Get
        Set(ByVal value As String)
            _wgpa400 = value
        End Set
    End Property

    Public _wgpa500 As String

    Public Property wgpa500() As String
        Get
            Return _wgpa500
        End Get
        Set(ByVal value As String)
            _wgpa500 = value
        End Set
    End Property

    Public _wgpa600 As String

    Public Property wgpa600() As String
        Get
            Return _wgpa600
        End Get
        Set(ByVal value As String)
            _wgpa600 = value
        End Set
    End Property

    Public _wgpa700 As String

    Public Property wgpa700() As String
        Get
            Return _wgpa700
        End Get
        Set(ByVal value As String)
            _wgpa700 = value
        End Set
    End Property

    Public _wgpa800 As String

    Public Property wgpa800() As String
        Get
            Return _wgpa800
        End Get
        Set(ByVal value As String)
            _wgpa800 = value
        End Set
    End Property

    Public _wgpa900 As String

    Public Property wgpa900() As String
        Get
            Return _wgpa900
        End Get
        Set(ByVal value As String)
            _wgpa900 = value
        End Set
    End Property

    Public _fpga As String

    Public Property fpga() As String
        Get
            Return _fpga
        End Get
        Set(ByVal value As String)
            _fpga = value
        End Set
    End Property

    Public _student_firstname As String

    Public Property student_firstname() As String
        Get
            Return _student_firstname
        End Get
        Set(ByVal value As String)
            _student_firstname = value
        End Set
    End Property

    Public _student_surname As String

    Public Property student_surname() As String
        Get
            Return _student_surname
        End Get
        Set(ByVal value As String)
            _student_surname = value
        End Set
    End Property

    Public _student_othernames As String

    Public Property student_othernames() As String
        Get
            Return _student_othernames
        End Get
        Set(ByVal value As String)
            _student_othernames = value
        End Set
    End Property

    Public _student_dept_idr As String

    Public Property student_dept_idr() As String
        Get
            Return _student_dept_idr
        End Get
        Set(ByVal value As String)
            _student_dept_idr = value
        End Set
    End Property



    Public _year_of_entry As String

    Public Property year_of_entry() As String
        Get
            Return _year_of_entry
        End Get
        Set(ByVal value As String)
            _year_of_entry = value
        End Set
    End Property

    Public _session_idr_of_entry As String

    Public Property session_idr_of_entry() As String
        Get
            Return _session_idr_of_entry
        End Get
        Set(ByVal value As String)
            _session_idr_of_entry = value
        End Set
    End Property

    Public _mode_of_entry As String

    Public Property mode_of_entry() As String
        Get
            Return _mode_of_entry
        End Get
        Set(ByVal value As String)
            _mode_of_entry = value
        End Set
    End Property




    Public _phone As String

    Public Property phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
        End Set
    End Property

    Public _email As String

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public _gender As String

    Public Property gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property




    Function creatDataSetSenate(strSQL As String) As DataSet
        'Very good!
        Dim ds As New DataSet
        Dim dsBS As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim snCoulumn, matnoCoulumn As DataColumn
        Dim nameCoulumn, surnameCoulumn, statusCoulumn, creditsCoulumn, deptNameCoulumn, SessionCoulumn As DataColumn

        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dsBS = mappDB.GetDataWhere(strSQL)   'todo: query criteria

        dt = New DataTable()

        'snCoulumn = New DataColumn("SN", Type.GetType("System.Int32"))
        'matnoCoulumn = New DataColumn("MATNO", Type.GetType("System.String"))
        'surnameCoulumn = New DataColumn("SURNAME", Type.GetType("System.String"))
        'nameCoulumn = New DataColumn("Other Names", Type.GetType("System.String"))
        'statusCoulumn = New DataColumn("Status", Type.GetType("System.String"))
        'creditsCoulumn = New DataColumn("Credits", Type.GetType("System.Double"))
        snCoulumn = New DataColumn("Col0", Type.GetType("System.String"))
        matnoCoulumn = New DataColumn("Col1", Type.GetType("System.String"))
        surnameCoulumn = New DataColumn("Col2", Type.GetType("System.String"))
        nameCoulumn = New DataColumn("Col3", Type.GetType("System.String"))
        statusCoulumn = New DataColumn("Status", Type.GetType("System.String"))
        deptNameCoulumn = New DataColumn("Col172", Type.GetType("System.String"))
        SessionCoulumn = New DataColumn("Session", Type.GetType("System.String"))


        dt.TableName = "Senate"
        dt.Columns.Add(snCoulumn)
        dt.Columns.Add(matnoCoulumn)
        dt.Columns.Add(surnameCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(statusCoulumn)
        dt.Columns.Add(deptNameCoulumn)
        dt.Columns.Add(SessionCoulumn)

        dr = dt.NewRow()
        dr("Col0") = 1
        dr("Col1") = "ENG000222111"
        dr("Col2") = "Amenaghawon OBINNA"
        dr("Col172") = "Computer Engineering"
        dr("Status") = "Successful"
        dr("Session") = "2018/2019"
        'dr("SURNAME") = "OBINNA"
        'dr("Other Names") = "Amenaghawon"
        'dr("Status") = "Successful"
        'dr("Credits") = 22

        SumDr = SumDr + 1
        dt.Rows.Add(dr)



        For i = 0 To dsBS.Tables(0).Rows.Count - 1
            dr = dt.NewRow()
            dr("Col0") = dsBS.Tables(0).Rows(i).Item("Col0").ToString
            dr("Col1") = dsBS.Tables(0).Rows(i).Item("Col1").ToString
            dr("Col2") = dsBS.Tables(0).Rows(i).Item("Col2").ToString
            dr("Col172") = dsBS.Tables(0).Rows(i).Item("Col172").ToString
            dr("Status") = "Successful"     'todo add to db
            dr("Session") = "2018/2019" 'dsBS.Tables(0).Rows(i).Item("Session").ToString
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
            dt.Rows.Add(dr)
        Next i


        ds.Tables.Add(dt)

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
