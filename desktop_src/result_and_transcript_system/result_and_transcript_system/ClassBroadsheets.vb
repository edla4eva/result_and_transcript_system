'Imports Microsoft.Office.Interop.Excel
Imports ExcelInterop = Microsoft.Office.Interop.Excel

Public Class ClassBroadsheets
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Public Delegate Sub OnProgressChanged(ByVal sender As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPrgressChanged(ByVal sender As Object, e As ClassAnswerEventArgs) 'support for events

    Public Sub New()
        Try
            'Me._excelWB.FileNameWB = PROG_DIRECTORY & "\templates\broadsheet.xltx"
            _broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
            '_excelWB = New ExcelInterop.Workbook

            _levelCGPAPercentages(0) = 0.05
            _levelCGPAPercentages(1) = 0.1
            _levelCGPAPercentages(2) = 0.15
            _levelCGPAPercentages(3) = 0.2
            _levelCGPAPercentages(4) = 0.5
            _levelCGPAPercentages(5) = 0
            _levelCGPAPercentages(6) = 0
            _levelCGPAPercentages(7) = 0
            _levelCGPAPercentages(8) = 0

            'Todo get from database
            ' _levelCGPAPercentages = mappDB.get_levelCGPAPercentages()

        Catch ex As Exception
            MsgBox("Cannot create Excel Automation Object" & vbCrLf & ex.Message)
        End Try
    End Sub
#Region "Broadsheet Properties"
    Private _broadsheetSemester As String = ""
    Private _strMATNO As String() = Nothing
    Private _broadsheetFileName As String = Nothing
    Private _progress As Integer = 0
    Private _progressStr As String = ""
    Private _excelWB As ExcelInterop.Workbook
    Private _regInfoCoursesFirstSem As List(Of String)
    Private _regInfoCoursesSecondSem As List(Of String)
    Private _processedBroadsheetFileName As String = Nothing
    Private _broadsheetDataDS As DataSet
    Private _levelCGPAPercentages(9) As Double
    Private _dts(0 To 1) As DataTable

    Private _dean As String = "Name of Dean"
    Private _hod As String = "Name of HOD"
    Private _courseAdviser As String = "Name of Course Adviser"
    Private _session As String = "2018/2019"
    Private _level As Integer = 100
    Private _departmentName As String = "Department Name"
    Private _facultyName As String = "Faculty Name"
    Private _schoolName As String = "University Name"
    Private _deptId As Integer = 1


    Public Property dataTablesScoresAndGrades() As DataTable()
        Get
            Return _dts
        End Get
        Set(ByVal value As DataTable())
            _dts = value
        End Set
    End Property
    Public Property levelCGPaPercentages() As Double()
        Get
            Return _levelcGPAPercentages
        End Get
        Set(ByVal value As Double())
            _levelcGPAPercentages = value
        End Set
    End Property
    Public Property processedBroadsheetFileName() As String
        Get
            Return _processedBroadsheetFileName
        End Get
        Set(ByVal value As String)
            _processedBroadsheetFileName = value
        End Set
    End Property
    Public Property regInfoCoursesSecondSem() As List(Of String)
        Get
            Return _regInfoCoursesSecondSem
        End Get
        Set(ByVal value As List(Of String))
            _regInfoCoursesSecondSem = value
        End Set
    End Property
    Public Property regInfoCoursesFirstSem() As List(Of String)
        Get
            Return _regInfoCoursesFirstSem
        End Get
        Set(ByVal value As List(Of String))
            _regInfoCoursesFirstSem = value
        End Set
    End Property
    Public Property excelWB() As ExcelInterop.Workbook
        Get
            Return _excelWB
        End Get
        Set(ByVal value As ExcelInterop.Workbook)
            _excelWB = value
        End Set
    End Property
    Public Property progress() As Integer
        Get
            Return _progress
        End Get
        Set(ByVal value As Integer)
            _progress = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = value
            RaiseEvent myEventOnPrgressChanged(Me, e) 'MATNOChanged
        End Set
    End Property
    Public Property progressStr() As String
        Get
            Return _progressStr
        End Get
        Set(ByVal value As String)
            _progressStr = value
        End Set
    End Property
    Public Property broadsheetFileName() As String
        Get
            Return _broadsheetFileName
        End Get
        Set(ByVal value As String)
            _broadsheetFileName = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e) 'MATNOChanged
        End Set
    End Property

    Public Property broadsheetDataDS() As DataSet
        Get
            Return _broadsheetDataDS
        End Get
        Set(ByVal value As DataSet)
            _broadsheetDataDS = value
            'Dim e As New ClassAnswerEventArgs
            'e.VariableChanged = True
            'e.Ans = -1
            'RaiseEvent myEventOnPropertyChanged(Me, e) 'ds
        End Set
    End Property
    Public Property strMATNO() As String()
        Get
            Return _strMATNO
        End Get
        Set(ByVal value As String())
            _strMATNO = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e) 'MATNOChanged
        End Set
    End Property
    Public Property HOD() As String
        Get
            Return _hod
        End Get
        Set(ByVal value As String)
            _hod = value
        End Set
    End Property
    Public Property Dean() As String
        Get
            Return _dean
        End Get
        Set(ByVal value As String)
            _dean = value
        End Set
    End Property
    Public Property CourseAdviser() As String
        Get
            Return _courseAdviser
        End Get
        Set(ByVal value As String)
            _courseAdviser = value
        End Set
    End Property
    Public Property broadsheetSemester() As String
        Get
            Return _broadsheetSemester
        End Get
        Set(ByVal value As String)
            _broadsheetSemester = value
        End Set
    End Property
    Public Property DepartmentName() As String
        Get
            Return _departmentName
        End Get
        Set(ByVal value As String)
            _departmentName = value
        End Set
    End Property
    Public Property FacultyName() As String
        Get
            Return _facultyName
        End Get
        Set(ByVal value As String)
            _facultyName = value
        End Set
    End Property
    Public Property SchoolName() As String
        Get
            Return _schoolName
        End Get
        Set(ByVal value As String)
            _schoolName = value
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
    Public Property DeptId() As Integer
        Get
            Return _deptId
        End Get
        Set(ByVal value As Integer)
            _deptId = value
        End Set
    End Property
    Public Property Level() As Integer
        Get
            Return _level
        End Get
        Set(ByVal value As Integer)
            _level = value
        End Set
    End Property

#End Region
    '
    ' Summary:
    '     Creates a Dataset containing the broadsheet processed from results
    '     obtained from db.
    '
    ' Parameters:
    '   course_dept_idr:
    '     An integer representing the department ID.
    Function createBroadsheetData(course_dept_idr As Integer, session_idr As String, course_level As String, Optional isInterrop As Boolean = False) As DataSet
        'Algo
        '1. create fixed cols datatable
        '2. use list of ordered couses (check sem to see if it exists) to change namme of col7-51 and56-100
        'for each col.name
        '   query students, left join results (convert null to NA -3
        '   transfer query result col to dataset col
        'next

        '#1 count courseCodes in result table = j
        Dim countC, countReg, countResultsBS As Integer
        Dim AllCoursesDS, coursesOrderDS, RegStudentsDS, FSBroadsheetDS As DataSet
        Dim dictCourseCodeKeyCourseOrderSNVal_1 As New Dictionary(Of Integer, String)
        Dim dictCourseCodeKeyCourseOrderSNVal_2 As New Dictionary(Of Integer, String)
        Dim dictCoursesOrder As New Dictionary(Of Integer, String)

        Dim dictRegistered_1 As New Dictionary(Of String, String)
        Dim dictRegistered_2 As New Dictionary(Of String, String)
        Dim strSQLRegStudents, strSQLAllCourses, strSQLCoursesOrder, strSQLJoin As String
        Dim tmpStr, tmpStrMATNO, tmpStrCourseCode As String
        Dim tmpInt As Integer = -4

        Dim courses(LAST_COL) As String
        Dim credits(LAST_COL) As Integer

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim dictCol, dictMATNO As New Dictionary(Of String, Integer)
        'Dim Registered(120) as string


        'strSQLJoin = "SELECT Reg.MatNo, Last(Results.total) AS LastOftotal, Results.course_code_idr, 
        '              Results.Session_idr  FROM Reg INNER JOIN Results ON Reg.MatNo = Results.matno GROUP BY Reg.MatNo, Results.course_code_idr,  
        '              Results.Session_idr HAVING (((Results.course_code_idr)='{0}') AND ((Results.Session_idr)='{1}'));"
        'strSQLAllCourses = "SELECT Courses.course_code, Courses.course_level, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order, Count(Courses.course_order) AS CountOfcourse_order
        '          FROM Courses
        '         GROUP BY Courses.course_level, Courses.course_code, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order
        '         HAVING (((Courses.course_semester)>0))
        '         ORDER BY Courses.course_level, Courses.course_order;" 'and level
        'strSQLCoursesOrder = "SELECT * FROM Courses_order WHERE (session_idr='{0}' AND dept_idr={1}) ORDER BY sn;" 'and level

        'strSQLRegStudents = "SELECT Reg.MatNo, Reg.session_idr, Reg.CourseCode_1, Reg.CourseCode_2, Reg.Fees_Status, Reg.level, Reg.dept_idr,   
        '                    students.student_firstname, students.student_surname, students.student_othernames, 
        '                    students.mode_of_entry, students.session_idr_of_entry, students.year_of_entry, 
        '                    students.status
        '                    FROM Reg INNER JOIN students ON Reg.MatNo = students.matno 
        '                    WHERE (((Reg.session_idr)='{0}' AND (Reg.dept_idr)={1}));"
        strSQLJoin = STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_INSERT_IN_BROADSHEET
        strSQLAllCourses = STR_ALL_COURSES_ORDERED
        strSQLCoursesOrder = STR_COURSES_ORDER_GENERAL
        strSQLRegStudents = STR_SQL_REGISTERED_STUDENTS
        RegStudentsDS = mappDB.GetDataWhere(String.Format(strSQLRegStudents, session_idr, course_dept_idr, course_level), "Reg")
        coursesOrderDS = mappDB.GetDataWhere(String.Format(strSQLCoursesOrder, session_idr, course_dept_idr), "Courses")    'TODO Every inserts in courses_order table mus be 15*5 rows. sn can be used to order
        AllCoursesDS = mappDB.getAllCourses()   'Get All Courses in Array
        If coursesOrderDS.Tables(0).Rows.Count < 1 Then
            'maybe session does not exist, use default
            coursesOrderDS = mappDB.GetDataWhere(String.Format(strSQLCoursesOrder, "2018/2019", 1), "Courses")    'TODO Every inserts in courses_order table mus be 15*5 rows. sn can be used to order
            If coursesOrderDS.Tables(0).Rows.Count < 1 Then
                'give up
                dt.Columns.Add("Error")
                dt.Rows.Add("There is no record for the how the Courses should be ordered in the Broadsheet for this session and Department")
                ds.Tables.Add(dt)
                Return ds
                'Dim exInn As New Exception("There is no record for the how the Courses should be ordered in the Broadsheet for this session and Department")
                'Throw exInn
            End If
        End If
        If RegStudentsDS.Tables(0).Rows.Count < 1 Then
            dt.Columns.Add("Error")
            dt.Rows.Add("There is no record of Registered Students")
            ds.Tables.Add(dt)
            Return ds
            'Throw New Exception("There is no record of Registered Students")
        End If

        countC = AllCoursesDS.Tables(0).Rows.Count
        countReg = RegStudentsDS.Tables(0).Rows.Count

        '#2 Dataset creation 
        dt.TableName = "BroadsheetFS"
        dt = createColS(dt) '## Create Fixed Cols TODO: put in sub

        '##'Get mat nos
        For i = 0 To countReg - 1
            dictMATNO.Add(RegStudentsDS.Tables(0).Rows(i).Item("matno"), -4)   'add disting students
            dictRegistered_1.Add(RegStudentsDS.Tables(0).Rows(i).Item("matno"), RegStudentsDS.Tables(0).Rows(i).Item("CourseCode_1"))
            dictRegistered_2.Add(RegStudentsDS.Tables(0).Rows(i).Item("matno"), RegStudentsDS.Tables(0).Rows(i).Item("CourseCode_2"))
            'add em rows
            dr = dt.NewRow()
            dr("matno") = RegStudentsDS.Tables(0).Rows(i).Item("matno")
            dr("Surname") = RegStudentsDS.Tables(0).Rows(i).Item("student_surname")
            dr("FullName") = RegStudentsDS.Tables(0).Rows(i).Item("student_firstname") & " " & RegStudentsDS.Tables(0).Rows(i).Item("student_othernames") & " " & RegStudentsDS.Tables(0).Rows(i).Item("student_surname")
            dr("sn") = (i + 1).ToString
            dt.Rows.Add(dr)
        Next


        dictCourseCodeKeyCourseOrderSNVal_1.Clear()
        dictCourseCodeKeyCourseOrderSNVal_2.Clear()
        objBroadsheet.progressStr = "Creating DataSets " & " ..."
        '# Rename Cols with Course Code 'Use the Courses_order take one by one and check if it exists.  'If it exists in coursesAllList, add it to courses for each level
        Dim colStartPos As Integer = 0
        For i = 0 To NUM_LEVELS - 1
            colStartPos = COURSE_START_COL + (i * NUM_COURSES_PER_LEVEL_1)
            For j = 0 To 15 - 1 'create columns for courses 'TODO: 1st and second
                tmpStr = "FS" & (i + 1).ToString & "00L"
                tmpStr = coursesOrderDS.Tables(0).Rows(j).Item(tmpStr).ToString ''TODO: throws error if session does not exist an error once e.g coursesOrderDS.Tables(0).Rows(j).Item("FS100L").ToString
                'tmpStr = coursesOrderDS.Tables(0).Rows(j).Item("FS100L").ToString
                courses(colStartPos + j) = "ColUNIQUE" & (colStartPos + j).ToString     'initialize on the fly to avoid nulls
                If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpStr) Then
                    'dictCourseCodeKeyCourseOrderSNVal_1.Add(0 + j, tmpStr)
                    dt.Columns(colStartPos + j).ColumnName = tmpStr
                    courses(colStartPos + j) = tmpStr
                End If
                tmpStr = "SS" & (i + 1).ToString & "00L"
                tmpStr = coursesOrderDS.Tables(0).Rows(j).Item(tmpStr).ToString 'e.g coursesOrderDS.Tables(0).Rows(j).Item("FS100L").ToString
                'tmpStr = coursesOrderDS.Tables(0).Rows(j).Item("SS100L").ToString
                If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpStr) Then
                    'dictCourseCodeKeyCourseOrderSNVal_2.Add(0 + j, tmpStr)
                    dt.Columns(colStartPos + MAX_COURSES_1 + 4 + j).ColumnName = tmpStr
                    courses(colStartPos + MAX_COURSES_1 + NUM_COLS_BETWEEN_COURSES_1_AND_COURSES_2 + j) = tmpStr
                End If
            Next
        Next



        'For each ColName(CourseCode), query database to get result scores for that course
        'NB: in broadsheet template scores starts From col H (i.e 7 counting From 0)
        Dim inxC As Integer = 0
        Dim levelPos = 0


        Dim dtGrades As New DataTable

        For inxC = COURSE_START_COL To COURSE_START_COL_2 + MAX_COURSES_2 - 1
            If dt.Columns(inxC).ColumnName.Contains("REPEATED") Or dt.Columns(inxC).ColumnName.Contains("TCF_") Then Continue For
            If dt.Columns(inxC).ColumnName.Contains("TCP_") Or dt.Columns(inxC).ColumnName.Contains("TCR_") Then Continue For
            If Not dt.Columns(inxC).ColumnName.Contains("ColUNIQUE") Then
                'Now query db with coursecode
                tmpStrCourseCode = dt.Columns(inxC).ColumnName
                If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(tmpStrCourseCode) Then
                    If dictAllCourseCodeKeyAndCourseLevelVal(tmpStrCourseCode) > course_level Then Continue For  'ignore higher levels
                End If
                objBroadsheet.progressStr = "Generating results for " & tmpStrCourseCode & " ..."
                tmpStr = String.Format(strSQLJoin, tmpStrCourseCode, session_idr)   'SELECT ... LEFT JOIN
                FSBroadsheetDS = mappDB.GetDataWhere(tmpStr, "FSBroadsheetDS")
                countResultsBS = FSBroadsheetDS.Tables(0).Rows.Count
                dictCol.Clear()
                '|-
                dictCol = doMATNos(dictCol, FSBroadsheetDS)
                '|----
                dictMATNO = doCourses(dictMATNO, dictCol, dictRegistered_1, dictRegistered_2, tmpStrCourseCode) 'transfer matching score to dictMATNO
                '|----
                '---#Update dataset with result values
                If dictCol.Count > 0 Then
                    For iMainDS = 0 To dt.Rows.Count - 1
                        'dt.Rows(i).Item("matno") = colKeys(i)   'already there no need to rewrite
                        tmpStrCourseCode = dt.Columns(inxC).ColumnName
                        tmpStrMATNO = dt.Rows(iMainDS).Item("matno")
                        If dictMATNO.ContainsKey(tmpStrMATNO) Then
                            'todo
                            dt.Rows(iMainDS).Item(tmpStrCourseCode) = dictMATNO(tmpStrMATNO) '.ToString & ", " & tmpStrCourseCode
                        Else
                            dt.Rows(iMainDS).Item(tmpStrCourseCode) = -3
                        End If

                    Next
                End If

            End If

            objBroadsheet.progress = (inxC / (COURSE_START_COL_2 + MAX_COURSES_1 - 1)) * 85
        Next

        dtGrades = dt.Copy

        'Now Update calculated fields in dataSet

        Dim dts(0 To 1) As DataTable
        If isInterrop Then  'TODO: impliment condition
            dts = updateDatasetWithFomula(dt, dtGrades, dictAllCourseCodeKeyAndCourseUnitVal, courses, credits)
        Else
            dts = updateDatasetWithComputedValues(dt, dtGrades, dictAllCourseCodeKeyAndCourseUnitVal, courses, credits, course_level, dictAllCourseCodeKeyAndCourseLevelVal, dictRegistered_1) 'Update dt Datatable with scores
        End If

        dt = dts(0)
        dtGrades = dts(1)
        objBroadsheet.dataTablesScoresAndGrades = dts

        'Retain global copy of useful data stored in dictionaries
        objBroadsheet.Level = course_level
        objBroadsheet.Session = session_idr
        objBroadsheet.progressStr = "Done!"
        objBroadsheet.progress = 99 'update progress
        ds.Tables.Add(dt)

        'TODO: ds(0) - for bs with scores, 
        'ds(1) - for broadsheet with grades
        Return ds
    End Function
    Function createColS(dt As DataTable) As DataTable
        Dim tmpCol As DataColumn    'Dim Coulumn, matnoCoulumn, nameCoulumn As DataColumn Dim caCoulumn, scoreCoulumn, examCoulumn, surnameCoulumn, otherNameCoulumn As DataColumn
        dt.Columns.Clear()
        tmpCol = New DataColumn("sn", Type.GetType("System.String")) '1
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("matno", Type.GetType("System.String")) '2
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("FullName", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("OtherNames", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("Surname", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("RepeatAll", Type.GetType("System.String")) '6
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("RepeatCourses_1", Type.GetType("System.String")) '7 syst
        dt.Columns.Add(tmpCol)
        For j = COURSE_START_COL To COURSE_START_COL + MAX_COURSES_1 - 1 '7 + 55 - 1 =61'create columns for courses 'TODO: 1st and second
            tmpCol = New DataColumn("ColUNIQUE" & j, Type.GetType("System.String"))  '8 OR (7) ZERO INDEX System.Int32"
            dt.Columns.Add(tmpCol)
        Next
        tmpCol = New DataColumn("TCF_1", Type.GetType("System.String")) '62
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCP_1", Type.GetType("System.String")) '63
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCR_1", Type.GetType("System.String")) '64
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("RepeatCourses_2", Type.GetType("System.String")) '65
        dt.Columns.Add(tmpCol)
        For j = COURSE_START_COL_2 To COURSE_START_COL_2 + MAX_COURSES_2 - 1 '7 + 55 - 1 'create columns for courses 'TODO: 1st and second
            tmpCol = New DataColumn("ColUNIQUE" & j, Type.GetType("System.String"))
            dt.Columns.Add(tmpCol)
        Next
        tmpCol = New DataColumn("TCF_2", Type.GetType("System.String")) '121
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCP_2", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCR_2", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCF", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCP", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("TCR", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        '...
        tmpCol = New DataColumn("GPA", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("Class", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("Status", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)
        tmpCol = New DataColumn("Failed", Type.GetType("System.String"))
        dt.Columns.Add(tmpCol)

        'others
        tmpCol = New DataColumn("Session", Type.GetType("System.String"))   '131
        dt.Columns.Add(tmpCol)

        'gpa100
        'gpa200
        '...
        'wgpa100
        '...
        'fgpa
        'dob
        'session_of_entry
        'mode_of_entry
        'CourseCode_1

        Return dt
    End Function
    Function doMATNos(dictCol As Dictionary(Of String, Integer), FSBroadsheetDS As DataSet) As Dictionary(Of String, Integer)
        Dim tmpstr As String
        For iBSRow = 0 To FSBroadsheetDS.Tables(0).Rows.Count - 1
            tmpstr = FSBroadsheetDS.Tables(0).Rows(iBSRow).Item("matno")
            If Not dictCol.ContainsKey(tmpstr) Then
                dictCol.Add(tmpstr, FSBroadsheetDS.Tables(0).Rows(iBSRow).Item("LastOftotal"))   'add disting students
            Else
                'todo: handle these duplicate results somehow
            End If
            'OR 'dictCol(tmpStr) = findMATNO(FSBroadsheetDS.Tables(0).Rows(i).Item("matno"), dictCol(i).key.name)   '
        Next
        Return dictCol
    End Function
    Function doCourses(dictMATNO As Dictionary(Of String, Integer), dictCol As Dictionary(Of String, Integer), dictRegistered_1 As Dictionary(Of String, String), dictRegistered_2 As Dictionary(Of String, String), tmpStrCourseCode As String) As Dictionary(Of String, Integer)
        '--transfer  the matching scores to dictMATNO
        Dim colKeys() As String = dictMATNO.Keys.ToArray
        If dictCol.Count > 0 Then
            For Each colkey In colKeys
                Dim tmpVal As Integer = dictMATNO(colkey)
                If dictCol.ContainsKey(colkey) Then tmpVal = dictCol(colkey) Else tmpVal = DEFAULT_CODE 'change the value
                If (IsRegistered(tmpStrCourseCode, dictRegistered_1, colkey) = False And (IsRegistered(tmpStrCourseCode, dictRegistered_2, colkey) = False)) Then
                    tmpVal = NR_CODE  'ignore not registered NR courses
                Else 'it is a registered course
                    If tmpVal < 0 Then tmpVal = ABS_CODE  'ABS 'if no score for registered then it is absent
                End If
                'todo: check if probated and handle by gettig prvious result *67, *45 etc
                dictMATNO(colkey) = tmpVal
            Next colkey

        Else
            'No need to iterate through scores because no result was found
        End If
        Return dictMATNO
    End Function
    'TODO: improve code quality by avoiding modyfying parameters dt and dtGrades
    Function updateDatasetWithComputedValues(dt As DataTable, dtGrades As DataTable, dictAllCourseCodeKeyAndCourseUnitVal As Dictionary(Of String, Integer), courses As String(), credits As Integer(), course_level As String, dictAllCourseCodeKeyAndCourseLevelVal As Dictionary(Of String, Integer), dictRegistered_1 As Dictionary(Of String, String)) As DataTable()
        'compute every thing first
        Dim dts(0 To 1) As DataTable
        Dim countRows As Integer = dt.Rows.Count - 1    'todo: move up
        Dim iScore As Integer = 0
        Dim iMarker(5) As Integer
        Dim tmpStrColName As String = ""
        Dim tmpStrR As String = ""
        Dim tmpStrRGrades As String = ""
        Dim scores(160) As String
        Dim grades(160) As String
        Dim scores_1(NUM_COURSES_PER_LEVEL_1 * NUM_LEVELS) As String
        Dim grades_1(NUM_COURSES_PER_LEVEL_1 * NUM_LEVELS) As String
        Dim credits_1(NUM_COURSES_PER_LEVEL_1 * NUM_LEVELS) As Integer

        Dim scores_2(NUM_COURSES_PER_LEVEL_2 * NUM_LEVELS) As String
        Dim grades_2(NUM_COURSES_PER_LEVEL_2 * NUM_LEVELS) As String
        Dim credits_2(NUM_COURSES_PER_LEVEL_2 * NUM_LEVELS) As Integer


        Dim gradePoints(160) As Integer
        Dim passedCourses(160) As Boolean
        Dim gpa As Double
        Dim TCRs(3) As Integer
        Dim TCPs(3) As Integer
        objBroadsheet.progressStr = "Computing scores " & " ..."
        For i = 0 To countRows - 1
            For j = COURSE_START_COL To COURSE_START_COL + MAX_COURSES_1 - 1 'First Semester
                tmpStrColName = dt.Columns(j).ColumnName
                scores(j) = -4.ToString 'initialize on the fly  'TODO
                credits(j) = 0 'initialize on the fly  'TODO
                ''Attempt to seperate 1st nd nd semester scores/credits
                'If j <= scores_1.Length - 1 Then scores_1(j) = scores(j)
                'If j <= credits_1.Length - 1 Then credits_1(j) = credits(j)

                courses(j) = tmpStrColName
                If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpStrColName) And Not tmpStrColName.Contains("ColUNIQUE") Then
                    scores(j) = dt.Rows(i).Item(j).ToString
                    credits(j) = dictAllCourseCodeKeyAndCourseUnitVal(tmpStrColName)
                    ''Attempt to seperate 1st nd nd semester scores/credits
                    'If j <= scores_1.Length - 1 Then scores_1(j) = scores(j)
                    'If j <= credits_1.Length - 1 Then credits_1(j) = credits(j)
                    iScore = iScore + 1
                    'compile repeated registered courses for 1st semester
                    If tmpStrR = "" And dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j)) Then    'only lower level courses
                        If dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < CInt(course_level) And IsRegisteredScore(scores(j)) Then
                            tmpStrR = tmpStrR & courses(j) & "/" & credits(j) & "/" & scores(j)   'avoid leading ","
                            tmpStrRGrades = tmpStrRGrades & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)   'avoid leading ","
                        End If
                    ElseIf dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j)) Then
                        If dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < CInt(course_level) And IsRegisteredScore(scores(j)) Then
                            tmpStrR = tmpStrR & ", " & courses(j) & "/" & credits(j) & "/" & scores(j)
                            tmpStrRGrades = tmpStrRGrades & ", " & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)
                        End If
                    End If
                Else
                    scores(j) = 0
                    If iMarker(0) = Nothing Then iMarker(0) = j   'on off marker
                End If
                'dtGrades.Columns(j).DataType = Type.GetType("System.String")
                If IsDBNull(dt.Rows(i).Item(j)) Then dt.Rows(i).Item(j) = ""
                dtGrades.Rows(i).Item(j) = getGRADE(dt.Rows(i).Item(j), Nothing, Nothing)
                objBroadsheet.progress = (i / countRows * 90)
            Next
            dt.Rows(i).Item("RepeatCourses_1") = tmpStrR
            dtGrades.Rows(i).Item("RepeatCourses_1") = tmpStrRGrades

            tmpStrR = ""
            tmpStrRGrades = ""
            For j = COURSE_START_COL_2 To COURSE_END_COL_2 - 1  'Second semester
                tmpStrColName = dt.Columns(j).ColumnName
                scores(j) = -4.ToString 'initialize on the fly  'TODO
                credits(j) = 0 'initialize on the fly  'TODO
                ''attempt to seperate 1st and 2nd sem courses
                'If j - COURSE_START_COL_2 <= scores_2.Length - 1 Then scores_1(j - COURSE_START_COL_2) = scores(j)
                'If j - COURSE_START_COL_2 <= scores_2.Length - 1 Then credits_2(j - COURSE_START_COL_2) = 0
                courses(j) = tmpStrColName
                If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpStrColName) And Not tmpStrColName.Contains("ColUNIQUE") Then
                    scores(j) = dt.Rows(i).Item(j).ToString
                    credits(j) = dictAllCourseCodeKeyAndCourseUnitVal(tmpStrColName)
                    ''Attempt to seperate 1st and 2nd semester scores/credits
                    'If j - COURSE_START_COL_2 <= scores_2.Length - 1 Then scores_1(j - COURSE_START_COL_2) = scores(j)
                    'If j - COURSE_START_COL_2 <= credits_2.Length - 1 Then scores_1(j - COURSE_START_COL_2) = credits(j)

                    iScore = iScore + 1
                    'compile repeated registered courses for 2nd semester
                    If tmpStrR = "" And dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j).ToString) Then    'only lower level courses
                        If (dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < CInt(course_level)) And IsRegisteredScore(scores(j)) Then
                            tmpStrR = tmpStrR & courses(j) & "/" & credits(j) & "/" & scores(j)   'avoid leading ","
                            tmpStrRGrades = tmpStrRGrades & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)   'avoid leading ","
                        End If
                    ElseIf dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j).ToString) Then
                        If (dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < CInt(course_level)) And IsRegisteredScore(scores(j)) Then
                            tmpStrR = tmpStrR & ", " & courses(j) & "/" & credits(j) & "/" & scores(j)
                            tmpStrRGrades = tmpStrRGrades & ", " & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)
                        End If
                    End If
                Else
                    scores(j) = 0
                    If iMarker(1) = Nothing Then iMarker(1) = j
                End If
                If IsDBNull(dt.Rows(i).Item(j)) Then dt.Rows(i).Item(j) = ""
                dtGrades.Rows(i).Item(j) = getGRADE(dt.Rows(i).Item(j), Nothing, Nothing)
                objBroadsheet.progress = (j / COURSE_END_COL_2 * 95)
            Next
            dt.Rows(i).Item("RepeatCourses_2") = tmpStrR
            dtGrades.Rows(i).Item("RepeatCourses_2") = tmpStrRGrades

            dt.Rows(i).Item("RepeatAll") = dt.Rows(i).Item("RepeatCourses_1") & " " & dt.Rows(i).Item("RepeatCourses_2")
            dtGrades.Rows(i).Item("RepeatAll") = dt.Rows(i).Item("RepeatCourses_1") & " " & dt.Rows(i).Item("RepeatCourses_2")

            objBroadsheet.progressStr = "Computing grades " & " ..."
            grades = getGRADES(scores, Nothing, Nothing)
            objBroadsheet.progressStr = "Computing grade points " & " ..."
            gradePoints = getGRADESPoints(grades)
            objBroadsheet.progressStr = "Computing grade GPA " & " ..."

            'Dim levelPercentages(9) As Double ' todo
            'levelPercentages(0) = 0.05
            'levelPercentages(1) = 0.1
            'levelPercentages(2) = 0.15
            'levelPercentages(3) = 0.2
            'levelPercentages(4) = 0.5
            'levelPercentages(5) = 0
            'levelPercentages(6) = 0
            'levelPercentages(7) = 0
            'levelPercentages(8) = 0
            'objBroadsheet.levelcgpaPercentages = levelPercentages

            gpa = CalcGPA(gradePoints, credits, objBroadsheet.Level, objBroadsheet.levelCGPaPercentages)
            dt.Rows(i).Item("GPA") = gpa.ToString
            objBroadsheet.progressStr = "Computing Credits registered" & " ..."
            TCRs = getAllTCR(scores, credits, objBroadsheet.Level)
            objBroadsheet.progressStr = "Computing Credits passed" & " ..."
            TCPs = getAllTCP(scores, credits, objBroadsheet.Level)
            objBroadsheet.progressStr = "Computing Credits failed" & " ..."
            dt.Rows(i).Item("TCR_1") = TCRs(0)
            dt.Rows(i).Item("TCP_1") = TCPs(0)
            dt.Rows(i).Item("TCF_1") = dt.Rows(i).Item("TCR_1") - dt.Rows(i).Item("TCP_1")

            dt.Rows(i).Item("TCR_2") = TCRs(1)
            dt.Rows(i).Item("TCP_2") = TCPs(1)
            dt.Rows(i).Item("TCF_2") = dt.Rows(i).Item("TCR_2") - dt.Rows(i).Item("TCP_2")

            dt.Rows(i).Item("TCR") = TCRs(2)
            dt.Rows(i).Item("TCP") = TCPs(2)
            dt.Rows(i).Item("TCF") = dt.Rows(i).Item("TCR") - dt.Rows(i).Item("TCP")

            objBroadsheet.progress = (i / countRows * 95)  'max 80+16 = 96%
        Next
        dts(0) = dt
        dts(1) = dtGrades
        Return dts
    End Function
    Function createBroadsheetGrades(dt As DataTable) As DataTable
        Dim countRows As Integer = dt.Rows.Count
        Dim countCols As Integer = dt.Columns.Count
        Dim dScores(0 To countCols - 1) As String
        Dim dGrades(0 To countRows - 1) As String
        Dim dtNew As New DataTable
        Dim tmpCol As DataColumn

        For j = 0 To dt.Columns.Count - 1
            tmpCol = New DataColumn(dt.Columns(j).ColumnName, Type.GetType("System.String")) '1
            dtNew.Columns.Add(tmpCol)
        Next

        For i = 0 To countRows - 1
            For j = 0 To dt.Columns.Count - 1
                If j >= COURSE_START_COL And j <= COURSE_END_COL Then
                    dScores(j) = toNum(dt.Rows(i).Item(j).ToString)
                ElseIf j >= COURSE_START_COL_2 And j <= COURSE_END_COL_2 Then
                    dScores(j) = toNum(dt.Rows(i).Item(j).ToString)
                Else

                End If
            Next
            dGrades = getGRADES(dScores, Nothing, Nothing)  'todo dont get graes for tcp
            dtNew.Rows.Add(dGrades)
        Next
        'Now overwrite matno name etc
        Dim tmpRepeated As String() = {}
        For i = 0 To countRows - 1
            For j = 0 To dt.Columns.Count - 1
                If j < COURSE_START_COL Then
                    dtNew.Rows(i).Item(j) = dt.Rows(i).Item(j)
                ElseIf j > COURSE_END_COL And j < COURSE_start_COL_2 Then
                    dtNew.Rows(i).Item(j) = dt.Rows(i).Item(j)
                ElseIf j > COURSE_END_COL_2 And j <= dt.Columns.Count - 1 Then
                    dtNew.Rows(i).Item(j) = dt.Rows(i).Item(j)
                ElseIf j = REPEATED_1_COL Then
                    'tmpRepeated = Split(dt.Rows(i).Item(j), ", ")
                    'For Each strT In tmpRepeated
                    '    strT.Substring(strT.IndexOf("/", 0, 2)
                    'Next
                ElseIf j = REPEATED_2_COL Then

                ElseIf j = REPEATED_ALL_COL Then
                    dtNew.Rows(i).Item(j) = dtNew.Rows(i).Item(REPEATED_1_COL) & ", " & dtNew.Rows(i).Item(REPEATED_2_COL)
                End If
            Next
        Next

        'todo: handle repeated and failed
        Dim tmpStrColName As String
        Dim tmpStrR As String = ""
        Dim courses(LAST_COL) As String
        Dim scores(LAST_COL) As String
        Dim credits(LAST_COL) As Integer
        For i = 0 To countRows - 1
            For j = COURSE_START_COL To COURSE_START_COL + MAX_COURSES_1 - 1 'First Semester
                tmpStrColName = dt.Columns(j).ColumnName
                scores(j) = -4.ToString 'initialize on the fly  'TODO
                credits(j) = 0 'initialize on the fly  'TOD

                courses(j) = tmpStrColName
                If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpStrColName) And Not tmpStrColName.Contains("ColUNIQUE") Then
                    scores(j) = dt.Rows(i).Item(j).ToString
                    credits(j) = dictAllCourseCodeKeyAndCourseUnitVal(tmpStrColName)
                    'compile repeated registered courses for 1st semester
                    If tmpStrR = "" And dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j)) Then    'only lower level courses
                        If dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < objBroadsheet.Level And IsRegisteredScore(scores(j)) Then tmpStrR = tmpStrR & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)   'avoid leading ","
                    ElseIf dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(courses(j)) Then
                        If dictAllCourseCodeKeyAndCourseLevelVal(courses(j)) < objBroadsheet.Level And IsRegisteredScore(scores(j)) Then tmpStrR = tmpStrR & ", " & courses(j) & "/" & credits(j) & "/" & getGRADE(scores(j), Nothing, Nothing)
                    End If
                Else
                    scores(j) = 0
                End If

                dtNew.Rows(i).Item(j) = tmpStrR
            Next
        Next
        Return dtNew
    End Function
    Function updateDatasetWithFomula(dt As DataTable, dtgrades As DataTable, dictAllCourseCodeKeyAndCourseUnitVal As Dictionary(Of String, Integer), courses As String(), credits As Integer()) As DataTable()
        'fml stuff special consideration for excel 
        'add formula
        'Dim fsFml, ssFml As String
        'Dim fml As String()
        'fml = objBroadsheet.generateFormulaCO()
        'fsFml = fml(0)
        'ssFml = fml(1)
        Return Nothing
    End Function
    'renames here as backup in case we screw up the function
    Function backup_createBroadsheetData(course_dept_idr As Integer, session_idr As String, course_level As String, Optional isInterrop As Boolean = False) As DataSet
        ''Algo
        ''1. count courseCodes in result table = j
        ''2. create dataset with j no of cols
        ''for each col.name
        ''   query students, left join results (convert null to NA -3
        ''   transfer query result col to dataset col
        ''next

        ''#1 count courseCodes in result table = j
        'Dim countC, countReg, countResultsBS As Integer
        'Dim coursesDS, coursesLevelDS, RegStudentsDS, FSBroadsheetDS As DataSet
        'Dim dictCoursesLevel As New Dictionary(Of Integer, String)
        'Dim strSQL, strSQLJoin As String
        'Dim tmpStr, tmpStrMATNO, tmpStrCourseCode As String
        'Dim tmpInt As Integer = -4
        'Dim scores(110) As String
        'Dim courses(110) As String
        'Dim credits(110) As Integer
        'Dim grades(110) As String
        'Dim gradePoints(110) As Integer
        'Dim passedCourses(110) As Boolean
        'Dim gpa As Double
        'strSQL = "SELECT Courses.course_code, Courses.course_level, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order, Count(Courses.course_order) AS CountOfcourse_order
        '          FROM Courses
        '         GROUP BY Courses.course_level, Courses.course_code, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order
        '         HAVING (((Courses.course_semester)=1) AND ((Courses.course_dept_idr)={0}) AND ((Count(Courses.course_order))>0))
        '         ORDER BY Courses.course_level, Courses.course_order;" 'and level
        ''or'strSQL = "SELECT course_code,course_unit FROM QueryFS_Coursers_Ordered"
        'coursesDS = mappDB.GetDataWhere(String.Format(strSQL, course_dept_idr), "Courses")
        'coursesLevelDS = coursesDS
        'coursesLevelDS.Tables(0).DefaultView.RowFilter = "course_level=" & course_level 'do use this for ui/ux

        'countC = coursesDS.Tables(0).Rows.Count
        'strSQL = "SELECT reg.matno FROM reg WHERE session_idr='{0}'"    'and level=course_level 
        'RegStudentsDS = mappDB.GetDataWhere(String.Format(strSQL, session_idr), "Reg")
        'countReg = RegStudentsDS.Tables(0).Rows.Count

        'strSQLJoin = "SELECT Reg.MatNo, Last(Results.total) AS LastOftotal, Results.course_code_idr, 
        '              Results.Session_idr  FROM Reg INNER JOIN Results ON Reg.MatNo = Results.matno GROUP BY Reg.MatNo, Results.course_code_idr,  
        '              Results.Session_idr HAVING (((Results.course_code_idr)='{0}') AND ((Results.Session_idr)='{1}'));"



        ''#2 Dataset creation 
        ''--------------------------
        ''Very good!
        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'Dim dr As DataRow
        'Dim tmpCol As DataColumn    'Dim Coulumn, matnoCoulumn, nameCoulumn As DataColumn Dim caCoulumn, scoreCoulumn, examCoulumn, surnameCoulumn, otherNameCoulumn As DataColumn
        'Dim dictCol, dictMATNO As New Dictionary(Of String, Integer)
        'dt.TableName = "BroadsheetFS"

        ''Create Fixed Cols TODO: put in sub
        'tmpCol = New DataColumn("sn", Type.GetType("System.String")) '1
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("matno", Type.GetType("System.String")) '2
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("FullName", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("OtherNames", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("Surname", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("RepeatAll", Type.GetType("System.String")) '6
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("RepeatFirstSem", Type.GetType("System.String")) '6 syst
        'dt.Columns.Add(tmpCol)

        ''Get mat nos
        'For i = 0 To countReg - 1
        '    dictMATNO.Add(RegStudentsDS.Tables(0).Rows(i).Item("matno"), -4)   'add disting students
        '    'add em rows
        '    dr = dt.NewRow()
        '    dr("matno") = RegStudentsDS.Tables(0).Rows(i).Item("matno")
        '    dr("sn") = (i + 1).ToString
        '    dt.Rows.Add(dr)
        'Next

        ''worked TODO: let courses iterate like this in next loops
        'For j = 0 To countC - 1 'create columns for courses 'TODO: 1st and second
        '    tmpCol = New DataColumn(coursesDS.Tables(0).Rows(j).Item("course_code"), Type.GetType("System.Int32"))
        '    dt.Columns.Add(tmpCol)
        '    credits(j) = CInt(coursesDS.Tables(0).Rows(j).Item("course_unit").ToString) 'todo: issues <110 courses
        '    courses(j) = coursesDS.Tables(0).Rows(j).Item("course_code").ToString 'todo: issues <110 courses
        '    If CInt(coursesDS.Tables(0).Rows(j).Item("course_level").ToString) >= CInt(course_level) Then       'level and higer level courses cannot be repeated
        '        dictCoursesLevel.Add(j, coursesDS.Tables(0).Rows(j).Item("course_code").ToString)
        '    End If
        'Next


        ''from broadsheet template courses start from col H = 8 (i.e 7 counting from 0)
        'For jCourseCol = 7 To countC - 1 ' for each col(ie course code) put rows in result table in dictC
        '    'HINT: this wrong line gave me problem for days strSQLJoin = String.Format(strSQLJoin, dt.Columns(jCourseCol).ColumnName, session_idr) 
        '    tmpStr = String.Format(strSQLJoin, dt.Columns(jCourseCol).ColumnName, session_idr)   'SELECT ... LEFT JOIN

        '    FSBroadsheetDS = mappDB.GetDataWhere(tmpStr, "FSBroadsheetDS")

        '    'SELECT Reg.MatNo, Reg.session_idr, Results.total, Results.course_code_idr From Reg LEFT Join Results On Reg.MatNo = Results.matno'Where (((Reg.session_idr) = "2018/2019") And ((Results.course_code_idr) = "CPE301"));
        '    'TODO: posible duplicate MATNO in query if duplicate result is in result table
        '    'Approach 1: avoid duplicate in result table           'Approach 2: use agregate first or last           'Approach 3: use data structures list, array
        '    countResultsBS = FSBroadsheetDS.Tables(0).Rows.Count
        '    dictCol.Clear()

        '    For iBSRow = 0 To countResultsBS - 1
        '        tmpStr = FSBroadsheetDS.Tables(0).Rows(iBSRow).Item("matno")
        '        'Debug.Print(FSBroadsheetDS.Tables(0).Rows(i).Item(tmpCol.ColumnName))
        '        'Debug.Print(FSBroadsheetDS.Tables(0).Rows(i).Item("total"))
        '        If Not dictCol.ContainsKey(tmpStr) Then
        '            dictCol.Add(tmpStr, FSBroadsheetDS.Tables(0).Rows(iBSRow).Item("LastOftotal"))   'add disting students
        '        Else
        '            'todo: handle these duplicate results somehow
        '        End If
        '        'OR 'dictCol(tmpStr) = findMATNO(FSBroadsheetDS.Tables(0).Rows(i).Item("matno"), dictCol(i).key.name)   '
        '    Next

        '    'Debug.Print("MATNO: ")
        '    'Debug.Print(String.Join(", ", dictMATNO.Values.ToArray.ToString))
        '    'Debug.Print("Values: ")
        '    'Debug.Print(String.Join(", ", dictCol.Values.ToArray.ToString))
        '    'transfer  the matching scores to dictMATNO
        '    Dim colKeys() As String = dictMATNO.Keys.ToArray
        '    If dictCol.Count > 0 Then
        '        For Each colkey In colKeys
        '            Dim tmpVal As Integer = dictMATNO(colkey)
        '            Debug.Print(colkey & ": " & dictMATNO(colkey).ToString & ", score: " & tmpVal) 'dictMATNO.ContainsValue("4"),  dictMATNO.containskey("4")

        '            If dictCol.ContainsKey(colkey) Then tmpVal = dictCol(colkey) Else tmpVal = -5 'change the value
        '            dictMATNO(colkey) = tmpVal
        '        Next colkey


        '        'Update dataset with result values
        '        For iMainDS = 0 To dt.Rows.Count - 1
        '            'dt.Rows(i).Item("matno") = colKeys(i)   'already there no need to rewrite
        '            tmpStrCourseCode = dt.Columns(jCourseCol).ColumnName
        '            tmpStrMATNO = dt.Rows(iMainDS).Item("matno")
        '            If dictMATNO.ContainsKey(tmpStrMATNO) Then
        '                'todo
        '                dt.Rows(iMainDS).Item(tmpStrCourseCode) = dictMATNO(tmpStrMATNO) '.ToString & ", " & tmpStrCourseCode
        '            Else
        '                dt.Rows(iMainDS).Item(tmpStrCourseCode) = -7
        '            End If
        '        Next

        '    Else
        '        'No need to iterate through scores because no result was found
        '    End If
        '    objBroadsheet.progress = jCourseCol / countC * 80
        'Next    'end for  each col(ie course code)


        'tmpCol = New DataColumn("RepeatCourses_1", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("TCF_1", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("TCP_1", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("TCR_1", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)

        ''others
        'tmpCol = New DataColumn("Session", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)
        'tmpCol = New DataColumn("GPA", Type.GetType("System.String"))
        'dt.Columns.Add(tmpCol)


        ''Now Update result in Dataset
        'If isInterrop Then  'TODO: impliment condition
        '    'fml stuff special consideration for excel 
        '    'add formula
        '    'Dim fsFml, ssFml As String
        '    'Dim fml As String()
        '    'fml = objBroadsheet.generateFormulaCO()
        '    'fsFml = fml(0)
        '    'ssFml = fml(1)

        'Else
        '    'compute every thing first


        '    'credits=From db query courses
        '    Dim countRows As Integer = dt.Rows.Count - 1    'todo: move up
        '    For i = 0 To countRows - 1
        '        For j = 8 To 20 '63
        '            scores(j - 8) = dt.Rows(i).Item(j).ToString
        '            'passedCourses(j - 8) = isPassed(dt.Rows(i).Item(j).ToString)
        '        Next
        '        grades = getGRADES(scores, Nothing, Nothing)
        '        gradePoints = getGRADESPoints(grades)
        '        gpa = CalcGPA(gradePoints, credits)
        '        dt.Rows(i).Item("GPA") = gpa.ToString
        '        dt.Rows(i).Item("TCR_1") = TCR(grades, credits)
        '        dt.Rows(i).Item("TCP_1") = TCP(grades, credits)

        '        dt.Rows(i).Item("RepeatCourses_1") = getRepeatCourses(scores, credits, CInt(course_level), courses, dictCoursesLevel)
        '        dt.Rows(i).Item("RepeatFirstSem") = dt.Rows(i).Item("RepeatCourses_1")


        '        objBroadsheet.progress = 80 + (i / countRows * 16)  'max 80+16 = 96%
        '    Next

        'End If


        'objBroadsheet.progress = 97 'update progress
        'ds.Tables.Add(dt)

        'Return ds
        Return Nothing
    End Function

    Function createDataSetHowTo(strArrayMATNO As String()) As DataSet
        '# How to perform Dataset creation  'Very good!
        '-------------------------
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim snCoulumn, matnoCoulumn, nameCoulumn As DataColumn

        dt = New DataTable()
        snCoulumn = New DataColumn("SN", Type.GetType("System.Int32"))
        matnoCoulumn = New DataColumn("MATNO", Type.GetType("System.String"))
        nameCoulumn = New DataColumn("NAME", Type.GetType("System.String"))

        dt.TableName = "Result"
        dt.Columns.Add(snCoulumn)
        dt.Columns.Add(matnoCoulumn)
        dt.Columns.Add(nameCoulumn)

        For i = 0 To strArrayMATNO.Length - 1
            dr = dt.NewRow()
            dr("SN") = i + 1
            dr("MATNO") = strArrayMATNO(i)
            dr("NAME") = "Firstname SURNAME"
            dt.Rows.Add(dr)
        Next
        ds.Tables.Add(dt)

        Return ds
    End Function

    Function openBroadsheetExcelWBInterop() As Boolean

        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        ' Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArrayTOTAL, strArraySURNAME, strArrayOtherNames As String()
        Try
            excelApp = New ExcelInterop.Application

            If _broadsheetFileName = Nothing Or Not System.IO.File.Exists(_broadsheetFileName) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(Me.broadsheetFileName)
            excelWS = CType(excelWB.Sheets(1), ExcelInterop.Worksheet)
            'show it
            excelApp.Visible = False

            Dim strCellContent As String = ""
            Dim MATNoFound As Boolean = False
            r = 8 'textbox
            'Search for MATNO Column
            For i = 1 To 20
                strCellContent = excelWS.Cells(i, ExcelColumns.colB).text
                If strCellContent.Contains("MAT") Then
                    startRow = i + 1
                    MATNoFound = True
                    Exit For
                End If
            Next
            If MATNoFound = False Then
                For i = 1 To 20
                    strCellContent = excelWS.Cells(i, ExcelColumns.colA).text
                    If strCellContent.Contains("MAT") Then
                        startRow = i + 1
                        MATNoFound = True
                        Exit For
                    End If
                Next
            End If
            objBroadsheet.progress = 30

            '-----------------------------------------
            '#  Pupulate broadsheet with data
            '------------------------------------------
            'objbroadsheet.sturecord.MATNO.sort()
            'Add serial numbers, matno etc
            For i = startRow To 50
                excelWS.Cells(i, ExcelColumns.colA) = i
                excelWS.Cells(i, ExcelColumns.colB) = i * 345 'TODO: place holder for MAT
                excelWS.Cells(i, ExcelColumns.colC) = "=D" & i & "+E" & i ' "First Name SURNAME" 'TODO: place holder Name
                excelWS.Cells(i, ExcelColumns.colD) = "First Name" & i
                excelWS.Cells(i, ExcelColumns.colE) = "SURNAME" & i
                excelWS.Cells(i, ExcelColumns.colF) = "CPE333/2/55, CPE311/3/75," 'TODO: place holder CO  objbroadsheet.sturecord(MATNO).co
                excelWS.Cells(i, ExcelColumns.colG) = "*79" 'TODO: place holder course  objbroadsheet.sturecord(MATNO).co
                excelWS.Cells(i, ExcelColumns.colH) = "80" 'objbroadsheet.sturecord(MATNO).COURSE002.score
                excelWS.Cells(i, ExcelColumns.colI) = "68" 'objbroadsheet.sturecord(MATNO).COURSE003.score
                '...


                excelWS.Cells(i, ExcelColumns.colO) = "3" 'objbroadsheet.sturecord(MATNO).COURSE003.FAILED1STsEM  or calcFailed(courses1stSem)
                excelWS.Cells(i, ExcelColumns.colP) = "24" 'objbroadsheet.sturecord(MATNO).COURSE003.Passed1STsEM  or calcPassed(courses1stSem)
                excelWS.Cells(i, ExcelColumns.colQ) = "27"


                excelWS.Cells(i, ExcelColumns.colAJ) = "3.579" 'GP AJ, Class AK, Status AL
                excelWS.Cells(i, ExcelColumns.colAK) = "2.1"
                excelWS.Cells(i, ExcelColumns.colAJ) = "A"


                excelWS.Cells(i, ExcelColumns.colAM) = "CPE211 (WAIVED)" 'cOURSE fAILED tRAILED
                If i Mod 2 = 0 Then objBroadsheet.progress = objBroadsheet.progress + 1
                GC.KeepAlive(Me)
            Next

            excelApp.Visible = True

            objBroadsheet.progress = 95 'update progress bar
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function
    Function serializeCourses(dt As DataTable) As String
        'todo: take courses order from datagrid (or excel) and save in a comma seperated string in sessions table
        'select * from cOURSES_ORDER
        Return ""
    End Function
    Function expandCourses(courses As String) As DataTable
        'TOD: consider using a dedicated table fo this
        'SESSION|100FS|200FS.....100SS|200LSS
        Return Nothing
    End Function
    Function generateFormulaCO() As String()
        'carry over
        'sample formula (full)
        '=IF(H12<>"", $H$7 & "/" & $H$9 & "/" & H12 & ", ","") & IF(I12<>"", $I$7 & "/" & $I$9 & "/" & I12 & ", ","") & IF(J12<>"", $J$7 & "/" & $J$9 & "/" & J12 & ", ","") & IF(K12<>"", $K$7 & "/" & $K$9 & "/" & K12 & ", ","") & IF(L12<>"", $L$7 & "/" & $L$9 & "/" & L12 & ", ","") & IF(M12<>"", $M$7 & "/" & $M$9 & "/" & M12 & ", ","") & IF(N12<>"", $N$7 & "/" & $N$9 & "/" & N12 & ", ","") & IF(O12<>"", $O$7 & "/" & $O$9 & "/" & O12 & ", ","") & IF(P12<>"", $P$7 & "/" & $P$9 & "/" & P12 & ", ","") & IF(Q12<>"", $Q$7 & "/" & $Q$9 & "/" & Q12 & ", ","") & IF(R12<>"", $R$7 & "/" & $R$9 & "/" & R12 & ", ","") & IF(S12<>"", $S$7 & "/" & $S$9 & "/" & S12 & ", ","") & IF(T12<>"", $T$7 & "/" & $T$9 & "/" & T12 & ", ","") & IF(AY12<>"", $AY$7 & "/" & $AY$9 & "/" & AY12 & ", ","") & IF(AZ12<>"", $AZ$7 & "/" & $AZ$9 & "/" & AZ12 & ", ","") & IF(BA12<>"", $BA$7 & "/" & $BA$9 & "/" & BA12 & ", ","") & IF(BB12<>"", $BB$7 & "/" & $BB$9 & "/" & BB12 & ", ","") & IF(BC12<>"", $BC$7 & "/" & $BC$9 & "/" & BC12 & ", ","") & IF(BD12<>"", $BD$7 & "/" & $BD$9 & "/" & BD12 & ", ","") & IF(BE12<>"", $BE$7 & "/" & $BE$9 & "/" & BE12 & ", ","") & IF(BF12<>"", $BF$7 & "/" & $BF$9 & "/" & BF12 & ", ","") & IF(BG12<>"", $BG$7 & "/" & $BG$9 & "/" & BG12 & ", ","") & IF(BH12<>"", $BH$7 & "/" & $BH$9 & "/" & BH12 & ", ","") & IF(BI12<>"", $BI$7 & "/" & $BI$9 & "/" & BI12 & ", ","") & IF(BJ12<>"", $BJ$7 & "/" & $BJ$9 & "/" & BJ12 & ", ","")
        Dim strRet(2) As String
        'iterate formula

        Dim Col As String = numToLetter(startCol)

        'First Semester
        Dim strFml As String = "="
        For j = startCol To startCol + maxCoursesFS
            Col = numToLetter(j)
            strFml = strFml & String.Format("IF({0}{1}<>``, ${0}${2} & `/` & ${0}${3} & `/` & {0}{1} & `, `,``)", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("`"c, """"c)
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace("&"c, "")  'remoe trailing &
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace(","c, "")  'remoe trailing &
        strFml = Trim(strFml)
        Debug.Print(strFml)
        strRet(0) = strFml

        '2nd Semester  Skip 4 cols for TCF, TCP, TC and Repeat 2nd
        strFml = "="
        startCol = (startCol + maxCoursesFS + 4) - 1    'excellent
        For j = startCol To startCol + maxCoursesSS
            Col = numToLetter(j)
            strFml = strFml & String.Format("IF({0}{1}<>``, ${0}${2} & `/` & ${0}${3} & `/` & {0}{1} & `, `,``)", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("`"c, """"c)
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace("&"c, "")  'remoe trailing &
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace(","c, "")  'remoe trailing &
        strFml = Trim(strFml)
        Debug.Print(strFml)
        strRet(1) = strFml

        'Generate formula for TCR_first
        '=SUM(IF(BO10>data!$I$9,Broadsheet!$BO$9,0),IF(BP10>data!$I$9,Broadsheet!$BP$9,0),IF(BQ10>data!$I$9,Broadsheet!$BQ$9,0),IF(BR10>data!$I$9,Broadsheet!$BR$9,0),IF(BS10>data!$I$9,Broadsheet!$BS$9,0),IF(BT10>data!$I$9,Broadsheet!$BT$9,0),IF(BU10>data!$I$9,Broadsheet!$BU$9,0),IF(BV10>data!$I$9,Broadsheet!$BV$9,0),IF(BW10>data!$I$9,Broadsheet!$BW$9,0),IF(BX10>data!$I$9,Broadsheet!$BX$9,0),IF(BY10>data!$I$9,Broadsheet!$BY$9,0),IF(BZ10>data!$I$9,Broadsheet!$BZ$9,0),IF(CA10>data!$I$9,Broadsheet!$CA$9,0),IF(CB10>data!$I$9,Broadsheet!$CB$9,0),IF(DG10>data!$I$9,Broadsheet!$DG$9,0),IF(DH10>data!$I$9,Broadsheet!$DH$9,0),IF(DI10>data!$I$9,Broadsheet!$DI$9,0),IF(DJ10>data!$I$9,Broadsheet!$DJ$9,0),IF(DK10>data!$I$9,Broadsheet!$DK$9,0),IF(DL10>data!$I$9,Broadsheet!$DL$9,0),IF(DM10>data!$I$9,Broadsheet!$DM$9,0),IF(DN10>data!$I$9,Broadsheet!$DN$9,0),IF(DO10>data!$I$9,Broadsheet!$DO$9,0),IF(DP10>data!$I$9,Broadsheet!$DP$9,0),IF(DQ10>data!$I$9,Broadsheet!$DQ$9,0))
        '=SUM(IF(BO10>data!$I$9,Broadsheet!$BO$9,0),
        strFml = "="
        For j = startCol To startCol + maxCoursesFS
            Col = numToLetter(j)
            strFml = strFml & String.Format("IF({0}{1}>data!$I$9, ${0}${2}, 0)+", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("+"c, """"c)
        Debug.Print(strFml)



        'TCP
        '=SUM(IF(AK10>data!$I$9,Broadsheet!$AK$9,0),IF(AL10>data!$I$9,Broadsheet!$AL$9,0),IF(AM10>data!$I$9,Broadsheet!$AM$9,0),IF(AN10>data!$I$9,Broadsheet!$AN$9,0))
        Return strRet
    End Function
    Function updateExcelBroadSheetInterop(dv As DataView, resultfileNameValue As String, generatedBroadsheetFileName As String) As String
        Dim dt As DataTable = dv.ToTable
        Dim strCriteria As String = String.Empty
        Dim defaultStartRow As Integer = 1

        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        Dim tmpStr As String = Nothing
        Dim tmpCount As Integer = 0

        Dim strCellContent As String = ""
        Dim strCellContent2 As String = ""

        Dim templateCourses1(55) As String
        Dim templateCourses2(55) As String

        Dim fn As String = Nothing

        'template matching numbers
        startRow = 10
        headerRow = 7

        'broadshet data numbers
        endRow = dt.Rows.Count

        Try
            excelApp = New ExcelInterop.Application
            If resultfileNameValue = Nothing Or Not System.IO.File.Exists(resultfileNameValue) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(resultfileNameValue)
            excelWS = CType(excelWB.Sheets(1), ExcelInterop.Worksheet)

            'The Courses in the template (Use assuming it overrides soft)
            tmpCount = templateCourses1.Count
            For j = firstSemStartCol To tmpCount - 1
                templateCourses1(i) = dt.Rows(headerRow).Item(j).ToString          'excelWS.Cells(headerRow, ExcelColumns.colH + j)
            Next
            Me.progress = 30 'update progress bar
        Catch ex As Exception
            Throw ex
        End Try


        excelApp.Visible = True

        MsgBox("Excel will be launched make sure it is running properlyy with no dialog box open then clic ok to continue")

        Dim strFormulaTC As String = "=H{0} + I{0} + J{0}" ' "=H9 + I9 + J9"
        Dim strFormulaFullName As String = "=D{0} + E{0}" ' D9+E9" wont need fml if template is good
        Dim endDGVCol As Integer
        endDGVCol = dt.Columns.Count

        If endDGVCol <> endCol Then
            MsgBox("The generated broadsheet data does not match the template",, "Warning!")
            endCol = endDGVCol
        End If

        'Delete extra rows early to make spreadsheet lighter
        excelWS.Rows(endRow & ":200").delete() 'e.g 60:200    excelWS.Cells.Range("A" & endRow & ":Z150").Delete()
        'resultfileNameValue = "Processed-" & Now & "-" & resultfileNameValue    'todo: avoid extension .xls
        'excelWS.SaveAs(resultfileNameValue)
        objBroadsheet.progress = 40
        'TODO: modifying cells when a dialog is open in excel (eg unlicenced version) throws error. tip sendkeyd(enter) on error
        For i = 0 To startRow - 1
            'headers The header rows dont come from datagrid view
            If i = 1 Then excelWS.Cells(i, 1) = "Department Name"
            If i = 2 Then excelWS.Cells(i, 1) = "Faculty Name"
            If i = 3 Then excelWS.Cells(i, 1) = "University  Name"
            If i = 4 Then excelWS.Cells(i, 1) = "2020/2021 Academic Session "
        Next


        'data row headings
        For j = 0 To endDGVCol - 1
            If Not (IsDBNull(dt.Rows(headerRow).Item(j)) Or dt.Columns(j).ColumnName Is Nothing) Then
                excelWS.Cells(headerRow + 1, j + 1) = dt.Columns(j).ColumnName 'excelWS.Cells(i, ExcelColumns.colA) = i
            Else
                excelWS.Cells(headerRow + 1, j + 1) = "Error"
            End If
            objBroadsheet.progress = j / endDGVCol * 60
        Next



        For i = startRow To endRow - 1
            'students info
            For j = 0 To firstSemStartCol - 1
                If Not (IsDBNull(dt.Rows(i).Item(j)) Or dt.Rows(i - startRow).Item(j).ToString Is Nothing) Then
                    excelWS.Cells(i, (j + 1)) = dt.Rows(i - startRow).Item(j).ToString
                ElseIf (j >= firstSemStartCol And j <= firstSemEndCol) Then
                    excelWS.Cells(i, (j + 1)) = "-6"    'String.Format(strFormulaFullName, i, i, i) 
                Else
                    'do nothing
                End If
            Next
            'first sem esults
            For j = firstSemStartCol To firstSemEndCol - 1  'first semester
                'excelWS.Cells(i + 1, j + 1) = dt.Rows(i).Item(j).ToString 'excelWS.Cells(i, ExcelColumns.colA) = i
                'String.Format(strFormulaFullName, i, i, i) 
            Next
            For j = secondSemStartCol To endCol - 1 '2nd semester less 
                excelWS.Cells(i, (j + 1)) = dt.Rows(i).Item(j).ToString 'excelWS.Cells(i, ExcelColumns.colA) = i
                'String.Format(strFormulaFullName, i, i, i) 
            Next
            'Pecific cols
            excelWS.Cells(i + 1, ExcelColumns.colZ + 1) = "GPA" '=calcGPA(array_of_scores)
            excelWS.Cells(i + 1, ExcelColumns.colY + 1) = "2.5"
            excelWS.Cells(i + 1, ExcelColumns.colQ + 1) = String.Format(strFormulaTC, i, i, i)  'gpa formula
            objBroadsheet.progress = i / endRow * 80
        Next






        'With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeLeft)
        '    excelWS.Cells.Range("B" & startRow & ":B" & r).Select() 'select rows
        'End With
        'excelWS.Cells.Range("B" & startRow & ":B" & r).Copy()
        'Debug.Print(My.Computer.Clipboard.GetData("range").ToString)
        'Call selectCells("A" & lastRow & ":Z150" )


        'clean up
        Try
            fn = broadsheetFileName & "_saved" & endRow & Rnd(5).ToString
            If Not System.IO.File.Exists(generatedBroadsheetFileName) Then
                excelWB.SaveAs(generatedBroadsheetFileName)
            Else
                Throw New Exception("RTPS Error: Excel File Already Exists!")
            End If
            'excelWB.Save()
            excelApp.Quit()

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS)
            'clean up variables
            objBroadsheet.progress = 90
            dt = Nothing
            startRow = Nothing
            excelWS = Nothing
            excelWB = Nothing
            excelApp = Nothing

            'to do track process id of excel and kill it
            GC.Collect() 'Best way to close excel NOTE: It works in release but youmay not notice in debug mode

        Catch ex As Exception
            MsgBox(ex.Message)

            'Some errors the object has disconnected with the client
        End Try


        'Scrap stuff--------------------


        Return fn
    End Function
    Function updateExcelBroadSheetInteropManualwithoutTemplateMatching(resultfileNameValue As String, dt As DataSet) As String
        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim headerRow As Integer = 8
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        Dim strMATNO As String = Nothing
        'Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArraySCORE, strArraySURNAME, strArrayOtherNames As String()

        Dim strCellContent As String = ""
        Dim strCellContent2 As String = ""
        Dim MATNoFound As Boolean = False
        Dim templateCourses(50) As String
        Dim fn As String = Nothing
        Try
            excelApp = New ExcelInterop.Application

            If resultfileNameValue = Nothing Or Not System.IO.File.Exists(resultfileNameValue) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(resultfileNameValue)
            excelWS = CType(excelWB.Sheets(1), ExcelInterop.Worksheet)


            r = 8 'textbox
            'Search for MATNO Column
            For i = 1 To 20
                strCellContent = excelWS.Cells(i, ExcelColumns.colB).text
                strCellContent2 = excelWS.Cells(i, ExcelColumns.colA).text
                If strCellContent.ToUpper.Contains("MAT") Or strCellContent2.ToUpper.Contains("MAT") Then
                    startRow = i + 2    'allow one for course credit
                    MATNoFound = True
                    Exit For
                End If
            Next
            headerRow = i
            'The Courses in the template (Use assuming it overrides soft)
            For j = 0 To templateCourses.Count - 1
                templateCourses(i) = excelWS.Cells(headerRow, ExcelColumns.colH + j)

            Next
            'check for last row
            'TODO: use a better method to check for usedrange
            'endRow = excelWS.UsedRange.Rows.Count
            'For i = startRow To 300
            '    strCellContent = excelWS.Cells(i, ExcelColumns.colB).text

            '    If strCellContent.ToString.Length = 0 Then
            '        endRow = i - 1
            '        Exit For
            '    End If
            'Next
            endRow = dt.Tables(0).Rows.Count
            Me.progress = 30 'update progress bar
        Catch ex As Exception
            Throw ex
        End Try


        excelApp.Visible = True 'TODO: check


        Dim strFormulaTC As String = "H{0} + I{0} + J{0}" ' "=H9 + I9 + J9"
        Dim strFormulaFullName As String = "D{0} + E{0}" ' D9+E9" wont need fml if template is good
        For i = startRow To 50
            excelWS.Cells(i, ExcelColumns.colA) = i
            excelWS.Cells(i, ExcelColumns.colB) = i * 345 'TODO: place holder for MAT
            excelWS.Cells(i, ExcelColumns.colC) = String.Format(strFormulaFullName, i, i, i) ' "First Name SURNAME" 'TODO: place holder Name
            excelWS.Cells(i, ExcelColumns.colD) = "First Name" & i

            excelWS.Cells(i, ExcelColumns.colE) = dt.Tables(0).Rows(i).Item("Surname") ' "SURNAME" & i
            excelWS.Cells(i, ExcelColumns.colF) = "CPE333/2/55, CPE311/3/75," 'TODO: place holder CO  objbroadsheet.sturecord(MATNO).co
            excelWS.Cells(i, ExcelColumns.colG) = "*79" 'TODO: place holder course  objbroadsheet.sturecord(MATNO).co
            excelWS.Cells(i, ExcelColumns.colH) = "80" 'objbroadsheet.sturecord(MATNO).COURSE002.score
            excelWS.Cells(i, ExcelColumns.colI) = "68"
            excelWS.Cells(i, ExcelColumns.colI) = dt.Tables(0).Rows(i).Item(templateCourses(0))
            '...

            'Total credits
            excelWS.Cells(i, ExcelColumns.colO) = "3" 'objbroadsheet.sturecord(MATNO).COURSE003.FAILED1STsEM  or calcFailed(courses1stSem)
            excelWS.Cells(i, ExcelColumns.colP) = "24" 'objbroadsheet.sturecord(MATNO).COURSE003.Passed1STsEM  or calcPassed(courses1stSem)
            excelWS.Cells(i, ExcelColumns.colQ) = String.Format(strFormulaTC, i, i, i)
        Next
        Debug.Print(excelWS.UsedRange.Rows.Count) ',  'excelWS.UsedRange.FillDown(), 'excelWS.UsedRange.Hidden, 'excelWS.UsedRange.RowHeight = 3
        'excelWS.UsedRange.ShrinkToFit, 'excelWS.UsedRange.Cells.Text  'excelApp.ExecuteExcel4Macro()  excelApp.Version
        Debug.Print(excelWS.UsedRange.Cells.Text)
        'If r > 6 Then Call selectCells("B9:B" & r)
        'With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeLeft)
        '    excelWS.Cells.Range("B" & startRow & ":B" & r).Select() 'select rows
        'End With
        'excelWS.Cells.Range("B" & startRow & ":B" & r).Copy()
        'Debug.Print(My.Computer.Clipboard.GetData("range").ToString)
        strMATNO = My.Computer.Clipboard.GetData("range")

        'clean up
        Try
            fn = broadsheetFileName & "_saved" & endRow & Rnd(5).ToString
            excelWB.SaveAs(broadsheetFileName & "_saved" & endRow & Rnd(5).ToString)
            excelApp.Quit()

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS)
            'clean up variables

            r = Nothing
            excelWS = Nothing
            excelWB = Nothing
            excelApp = Nothing

            GC.Collect() 'Best way to close excel NOTE: It works in release but youmay not notice in debug mode

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'Scrap stuff--------------------


        Return fn
    End Function

    Function iterateRegisteredCoursesAndAddToBroadsheetTemplate() As String()
        Dim firstSemCourses As List(Of String) = Nothing
        Dim secondSemCourses As List(Of String) = Nothing

        ' possibilities: secondSemCourses.Contains(), secondSemCourses.FindAll, secondSemCourses.ToLookup


        'firstsemcourses.sort ?   
        'for each matno in me.reginfo
        ' in not firstsemcourses.contains(Me._regInfoCoursesFirstSem.course(i)) then firstsemcourses.add(Me.reginfo.course(i))

        'next
        Return Nothing
    End Function

    'Function openBroadsheetExcelWB() As Boolean
    '    Me.excelWB.openBroadsheetExcelWB()

    '    Return True
    'End Function
    Function getGRADES(strScore As String(), rulesMax As Integer(), rulesMin As Integer()) As String()
        Dim tmpGrades As String()
        ReDim tmpGrades(strScore.Count - 1)
        For i = 0 To strScore.Count - 1
            tmpGrades(i) = getGRADE(strScore(i), rulesMax, rulesMin)
        Next
        Return tmpGrades

    End Function
    Function getGRADE(strScore As String, rulesMax As Integer(), rulesMin As Integer()) As String
        Dim score As Integer
        Dim dGrade As String
        Try
            If rulesMax Is Nothing Then rulesMax = {100, 69, 59, 49, 44, 39}    'todo: use params
            If rulesMin Is Nothing Then rulesMin = {70, 60, 50, 45, 40, 0}
            dGrade = "**"
            'error chechs
            If strScore = "" Then
                Return ""
                Exit Function
            ElseIf IsDBNull(strScore) Then
                Return ""
                Exit Function
            ElseIf (strScore = "ABS") Then
                Return "ABS"
                Exit Function
            ElseIf (strScore = "NR") Then
                Return "NR"
                Exit Function
            ElseIf (strScore = "NA") Or (strScore = "N/A") Then
                Return "NA"
                Exit Function
            End If

            score = toNum(strScore)

            If score = -4 Then
                Return ""
                Exit Function
            End If

            Dim amax, bmax, cmax, dmax, emax, fmax, amin, bmin, cmin, dmin, emin, fmin As Integer

            'Get max
            amax = rulesMax(0)
            bmax = rulesMax(1)
            cmax = rulesMax(2)
            dmax = rulesMax(3)
            emax = rulesMax(4)
            fmax = rulesMax(5)
            'Get min
            amin = rulesMin(0)
            bmin = rulesMin(1)
            cmin = rulesMin(2)
            dmin = rulesMin(3)
            emin = rulesMin(4)
            fmin = rulesMin(5)

            If score >= amin And score <= amax Then
                dGrade = "A"
            ElseIf score >= bmin And score <= bmax Then
                dGrade = "B"
            ElseIf score >= cmin And score <= cmax Then
                dGrade = "C"
            ElseIf score >= dmin And score <= dmax Then
                dGrade = "D"
            ElseIf score >= emin And score <= emax Then
                dGrade = "E"
            ElseIf score >= fmin And score <= fmax Then
                dGrade = "F"
            ElseIf score = abs_code Then
                dGrade = ABS_DISP
            ElseIf score = NR_CODE Then
                dGrade = NR_DISP
            ElseIf score = NA_CODE Then
                dGrade = NA_DISP
            ElseIf score < DEFAULT_CODE Then
                dGrade = DEFAULT_DISP
            Else
                dGrade = DEFAULT_DISP
            End If

            Return dGrade


        Catch ex As Exception

        End Try

    End Function
    Function getGRADESPoints(strGrades As String()) As Integer()
        Dim tmpGradePoints As Integer()
        ReDim tmpGradePoints(strGrades.Count - 1)
        For i = 0 To strGrades.Count - 1
            tmpGradePoints(i) = getGradePointFromGrade(strGrades(i))
        Next
        Return tmpGradePoints

    End Function
    Function getGradePointFromGrade(strGrade As String) As Integer

        Dim dPoint As String
        ' score = strScore
        Try
            If strGrade = "A" Then
                dPoint = "5"
            ElseIf strGrade = "B" Then
                dPoint = "4"
            ElseIf strGrade = "C" Then
                dPoint = "3"
            ElseIf strGrade = "D" Then
                dPoint = "2"
            ElseIf strGrade = "E" Then
                dPoint = "1"
            ElseIf strGrade = "F" Then
                dPoint = "0"
            ElseIf strGrade = "ABS" Or strGrade = "NR" Or strGrade = "NA" Then
                dPoint = "0"
            ElseIf strGrade = "" Then
                dPoint = "0"
            Else
                dPoint = "0"
            End If

            Return CInt(dPoint)


        Catch ex As Exception
            Return -1
        End Try

    End Function
    Function toNum(str As String) As Integer
        Try
            Dim strR As String = ""
            Dim i As Integer
            For i = 1 To Len(str)
                Select Case Asc(Mid(str, i, 1))
                    Case 48 To 57
                        strR = strR & Mid(str, i, 1)
                End Select
            Next
            If str = "" Then strR = -4
            Return CInt(strR)
        Catch ex As Exception
            Return -4
        End Try
    End Function
    Function IsRegistered(tmpStrCourseCode As String, dictRegistered_n As Dictionary(Of String, String), dMatno As String) As Boolean
        Dim returnVal As Boolean = False
        If dictRegistered_n.ContainsKey(dMatno) Then
            If dictRegistered_n(dMatno).Contains(tmpStrCourseCode) Then
                returnVal = True
            Else
                returnVal = False
            End If
        End If
        Return returnVal
    End Function

    Function IsRegisteredGrade(dGrade As String) As Boolean
        Try
            If dGrade = "R" Then
                Return True        'error
            ElseIf dGrade = "NR" Or dGrade = "NA" Or dGrade = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    'Used to compile CA courses or 1st and 2nd semester
    'used to calc TCP
    Function IsRegisteredScore(dscore As String, Optional NRCode As Integer = Nothing) As Boolean
        If NRCode = Nothing Then NRCode = NR_CODE
        Try
            Return CInt(dscore) > NRCode
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function isPassed(dScore As Integer, Optional passScore As Integer = 40) As Boolean 'todo: const PASS_SCORE
        Try
            If dScore < 0 Then
                Return False        'error
                Exit Function
            ElseIf dScore >= passScore Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function getRegisteredCourse(dScore As String) As Boolean
        Try
            If dScore = "" Or dScore = "NR" Or dScore = "NA" Then
                Return False        'error
            ElseIf dScore = "R" Then
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getRepeatCourses(scores As String(), dCredit As Integer(), dLevel As Integer, dCourses As String(), dLevelCourses As Dictionary(Of Integer, String)) As String
        Dim tmpStr As String = ""

        Return -4
    End Function
    'Function TCP(scores As String(), dCredit As Integer()) As Integer
    '    Dim sumTCP As Integer
    '    Try
    '        sumTCP = 0
    '        For i = 0 To scores.Count - 1
    '            If isPassed(toNum(scores(i))) Then sumTCP = sumTCP + dCredit(i)
    '        Next
    '        Return sumTCP

    '    Catch ex As Exception
    '        Return -4
    '    End Try
    'End Function
    'Function TCR(dGrade As String(), dCredit As Integer()) As Integer
    '    Dim sumTCP As Integer
    '    Try
    '        sumTCP = 0
    '        For i = 0 To dGrade.Count - 1
    '            If IsRegisteredGrade(dGrade(i)) Then sumTCP = sumTCP + dCredit(i)
    '        Next
    '        Return sumTCP

    '    Catch ex As Exception
    '        Return -4
    '    End Try
    'End Function
    Function getAllTCP(dScore As String(), dCredit As Integer(), dlevel As Integer) As Integer()
        Dim sumTCP_1, sumTCP_2, sumTCP As Integer
        Dim retVal(3) As Integer

        Dim nLastColInSem_1_ForLevel As Integer = LastColInSem_1_ForLevel(dlevel)
        Dim nLastColInSem_2_ForLevel As Integer = LastColInSem_2_ForLevel(dlevel)
        Try
            sumTCP = 0
            For i = 0 To dScore.Count - 1
                'If isPassed(toNum(dScore(i))) Then sumTCP = sumTCP + dCredit(i)
                If i >= COURSE_START_COL And i <= nLastColInSem_1_ForLevel Then 'dScore_1.lenght - 1 Then

                    If isPassed(toNum(dScore(i))) Then sumTCP_1 = sumTCP_1 + dCredit(i)
                ElseIf i >= COURSE_START_COL_2 And i <= nLastColInSem_2_ForLevel Then
                    If isPassed(toNum(dScore(i))) Then sumTCP_2 = sumTCP_2 + dCredit(i)
                End If
            Next
            retVal(0) = sumTCP_1
            retVal(1) = sumTCP_2
            retVal(2) = sumTCP_1 + sumTCP_2
            Return retVal

        Catch ex As Exception
            Return {-4, -4, -4}
        End Try
    End Function
    'Returns array wrth computd values for
    'Toal Crdits Registered For 1S Semeser TCR(0)
    'Toal Crdits Registered For 2nd Semeser TCR(1)
    'Toal Crdits Registered For session TCR(2)
    Function getAllTCR(dScore As String(), dCredit As Integer(), dlevel As Integer) As Integer()
        Dim sumTCR_1, sumTCR_2, sumTCR As Integer
        Dim retVal(3) As Integer

        Dim nLastColInSem_1_ForLevel As Integer = LastColInSem_1_ForLevel(dlevel)
        Dim nLastColInSem_2_ForLevel As Integer = LastColInSem_2_ForLevel(dlevel)
        Try
            sumTCR_1 = 0
            sumTCR_2 = 0
            sumTCR = 0
            For i = 0 To dScore.Count - 1

                If i >= COURSE_START_COL And i <= nLastColInSem_1_ForLevel Then 'dScore_1.lenght - 1 Then
                    If IsRegisteredScore(toNum(dScore(i))) Then sumTCR_1 = sumTCR_1 + dCredit(i)
                ElseIf i >= COURSE_START_COL_2 And i <= nLastColInSem_2_ForLevel Then
                    If IsRegisteredScore(toNum(dScore(i))) Then sumTCR_2 = sumTCR_2 + dCredit(i)
                End If
            Next
            sumTCR = sumTCR_1 + sumTCR_2
            retVal(0) = sumTCR_1
            retVal(1) = sumTCR_2
            retVal(2) = sumTCR
            Return retVal

        Catch ex As Exception
            Return {-4, -4, -4}
        End Try
    End Function

    'Function getTCR(dScore As String(), dCredit As Integer()) As Integer
    '    Dim sumTCP As Integer
    '    Try
    '        sumTCP = 0
    '        For i = 0 To dScore.Count - 1
    '            If IsRegisteredScore(toNum(dScore(i))) Then sumTCP = sumTCP + dCredit(i)
    '        Next
    '        Return sumTCP

    '    Catch ex As Exception
    '        Return -4
    '    End Try
    'End Function

    Function CalcGPA(gradePoints As Integer(), credits As Integer(), dlevel As Integer, levelPercentages As Double()) As Double
        Dim tmpGP As Double = 0
        Dim tmpGPA As Double = 0

        Dim tmpCr As Double = 0
        Dim leveGPAs As Double = 0

        '' Dim levelGPAs(9) As Double' todo
        'levelPercentages(0) = 0.05
        'levelPercentages(1) = 0.1
        'levelPercentages(2) = 0.15
        'levelPercentages(3) = 0.2
        'levelPercentages(4) = 0.5

        LastColInSem_1_ForLevel(dlevel)

        For i = COURSE_START_COL To LastColInSem_1_ForLevel(dlevel)
            tmpGP = tmpGP + gradePoints(i)
            tmpCr = tmpCr + credits(i)
        Next
        For i = COURSE_START_COL_2 To LastColInSem_2_ForLevel(dlevel)
            tmpGP = tmpGP + gradePoints(i)
            tmpCr = tmpCr + credits(i)
        Next
        If tmpCr > 0 Then tmpGPA = tmpGP / tmpCr Else tmpGPA = -1
        Return tmpGPA
    End Function
End Class
