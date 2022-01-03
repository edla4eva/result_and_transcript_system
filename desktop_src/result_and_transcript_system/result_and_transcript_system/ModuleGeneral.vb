

Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports ExcelInterop = Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Core
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Controls
Imports System.Windows.Forms.Control

Module ModuleGeneral


    'Create db objects
    Public mappDB As New ClassDB()
    Public mappDBCloud As New ClassDB() '(cloud)
    Public objResult As New ClassExcelResult()
    Public objBroadsheet As New ClassBroadsheets()
    Public objReports As New ClassReports()
    Public objRTPS As New ClassApp


    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim oadDataGrid As MySqlDataAdapter
    Dim oadDataGridLocal As OleDbDataAdapter
    Dim dtDataGrid As DataTable
    'create Excel objects
    Public myExcelApp As New ClassExcel
    Public objExcelFile As New ClassExcelFile() 'ExcelDataReader object

    'App settings
    Public USER_DIRECTORY As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ResultAndTranscriptSystem"
    Public PROG_DIRECTORY As String = My.Application.Info.DirectoryPath

    'DB defalults
    ' '32 bit Access
    Public STR_connectionString32 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;"
    'passworded
    'Public STR_connectionString32 = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" & "Persist Security Info=True;Jet OLEDB:Database Password={0};", (My.Settings.dbpass))
    '64 bits
    Public STR_connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;"
    'passworded
    'Public STR_connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" & "Persist Security Info=True;JET OLEDB: Database Password={0};", (My.Settings.dbpass))


    Public STR_connectionStringAccessNet As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" & "JET OLEDB: Database Password={0};", (My.Settings.dbpass))

    Public STR_connectionStringCloud As String = "server=localhost;User Id=root;Persist Security Info=True;database=result_and_transript_db"


    'TODO: 'Public STR_connectionString As String = CType(ConfigurationManager.AppSettings("connString").ToString, String)

    'Excel
    Public Const strApplicationName As String = "e-Result"
    Public excelApp As ExcelInterop.Application
    Public excelWS As ExcelInterop.Worksheet
    Public excelWB As ExcelInterop.Workbook

    'Data
    Public dictDepts As New Dictionary(Of String, String)
    Public dictCourses As New Dictionary(Of String, String)
    Public dictCoursesOrderFS As New Dictionary(Of String, String)
    Public dictCoursesOrderSS As New Dictionary(Of String, String)
    Public dictSessions As New Dictionary(Of String, String)
    Public dictAllCourses As New Dictionary(Of String, String)

    ' data broadsheet
    Public dictAllCourseCodeKeyAndCourseUnitVal As New Dictionary(Of String, Integer)
    Public dictAllCourseCodeKeyAndCourseLevelVal As New Dictionary(Of String, Integer)
    Public dictAllCoursesCredtsLevel As New Dictionary(Of String, Integer)

    Public dictAllCourseCodeKeyAndCourseSemesterVal As New Dictionary(Of String, Integer)
    'General constants
    Public dblQuote As String = """"
    'Public intLoanID As Integer = CType(My.Settings.Item("LoanID").ToString, Integer)


    'excel template
    'iNTEROP BASE=1
    Public maxCoursesFS As Integer = 55
    Public maxCoursesSS As Integer = 55
    Public startCol As Integer = 8 'TODO: Depends on template starting letter H = 8 (A=1, B=2, C=3
    Public headRowCourse As Integer = 7
    Public headRowCredit As Integer = 9
    Public startRow As Integer = 10
    Public endCol As Integer = 150 'todo:check
    Public firstSemStartCol As Integer = 8 'todo:check
    Public firstSemEndCol As Integer = 8 + 55 'todo:check
    Public secondSemStartCol As Integer = 8 + 55 + 3 'todo:check
    Public secondSemEndCol As Integer = (8 + 55 + 3) + 55 'todo:check
    Public headerRow As Integer = 8
    Public endRow As Integer = 200
    Public endRowTemplate As Integer = 280
    Public startColLevel As Integer = 20
    Public endColLevel As Integer = 7

    'NPOI BASE=0
    Public NUM_COURSES_PER_LEVEL_1 As Integer = 15
    Public NUM_COURSES_PER_LEVEL_2 As Integer = 15
    Public NUM_LEVELS As Integer = 5
    Public MAX_COURSES_1 As Integer = NUM_COURSES_PER_LEVEL_1 * NUM_LEVELS    '75
    Public MAX_COURSES_2 As Integer = NUM_COURSES_PER_LEVEL_2 * NUM_LEVELS    '75
    Public NUM_COLS_BETWEEN_COURSES_1_AND_COURSES_2 As Integer = 4

    Public ROW_HEADER As Integer = 5
    Public COURSE_CODE_HEADER As Integer = 6
    Public ROW_CREDIT As Integer = 8
    Public ALL_HEADERS_COUNT As Integer = 9

    Public SN_COL As Integer = 0    'ExcelColumns.colA-1
    Public MATNO_COL As Integer = 1
    Public FULLNAME_COL As Integer = 2
    Public OTHER_NAMES_COL = 3 ' Othernmes
    Public SURNAME_COL = 4
    Public REPEATED_ALL_COL As Integer = 5
    Public REPEATED_1_COL As Integer = 6

    Public COURSE_START_COL As Integer = 7
    '...courses
    Public COURSE_END_COL As Integer = COURSE_START_COL + MAX_COURSES_1 - 1 '=7+75-1=81

    Public TCF_1_COL As Integer = COURSE_END_COL + 1
    Public TCP_1_COL As Integer = COURSE_END_COL + 2
    Public TCR_1_COL As Integer = COURSE_END_COL + 3

    Public REPEATED_2_COL As Integer = COURSE_END_COL + 3 + 1
    Public COURSE_START_COL_2 As Integer = COURSE_END_COL + NUM_COLS_BETWEEN_COURSES_1_AND_COURSES_2 + 1    '= 81+4+1=86    'first dont -1 last do -1
    Public COURSE_END_COL_2 As Integer = COURSE_START_COL_2 + MAX_COURSES_2 - 1    '= 86 + 75 - 1  '=160
    Public TCF_2_COL As Integer = COURSE_END_COL_2 + 1
    Public TCP_2_COL As Integer = COURSE_END_COL_2 + 2
    Public TCR_2_COL As Integer = COURSE_END_COL_2 + 3
    Public TCF_COL As Integer = COURSE_END_COL_2 + 4
    Public TCP_COL As Integer = COURSE_END_COL_2 + 5
    Public TCR_COL As Integer = COURSE_END_COL_2 + 6
    Public GPA_COL As Integer = COURSE_END_COL_2 + 7
    Public CLASS_COL As Integer = COURSE_END_COL_2 + 8
    Public STATUS_COL As Integer = COURSE_END_COL_2 + 9
    Public COURSE_FAIL_COL As Integer = COURSE_END_COL_2 + 10
    Public SESSION_COL As Integer = COURSE_END_COL_2 + 11
    Public LAST_COL As Integer = COURSE_END_COL_2 + 11 - 1   '=160 + 11 - 1 '=170


    Public ABS_CODE As Integer = -1
    Public NR_CODE As Integer = -2
    Public NA_CODE As Integer = -3
    Public DEFAULT_CODE As Integer = -4
    Public RESULT_NOT_IN_R_CODE As Integer = -5

    Public ABS_DISP As String = "ABS"
    Public NR_DISP As String = "NR"
    Public NA_DISP As String = "NA"
    Public DEFAULT_DISP As String = ""
    Public RESULT_NOT_IN_R_DISP As String = ""

    'mutiplier
    Public BGW_EXPORT_EXCEL_YR_MILTIPLIER As Integer = -1    'multiplier
    Public BGW_EXPORT_EXCEL_LEVEL_MILTIPLIER As Integer = 1    'multiplier

    'Base constant
    Public BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT As Integer = 100
    Public BGW_EXPORT_EXCEL_TEMPLATE_BASE_CONSTANT As Integer = 1000

    'scores
    Public BGW_EXPORT_EXCEL_1ST_SEM_SCORES As Integer = 1
    Public BGW_EXPORT_EXCEL_2ND_SEM_SCORES As Integer = 2
    Public BGW_EXPORT_EXCEL_ALL_SEM_SCORES As Integer = 3
    'Grades
    Public BGW_EXPORT_EXCEL_1ST_SEM_GRADES As Integer = BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT + BGW_EXPORT_EXCEL_1ST_SEM_SCORES
    Public BGW_EXPORT_EXCEL_2ND_SEM_GRADES As Integer = BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT + BGW_EXPORT_EXCEL_2ND_SEM_SCORES
    Public BGW_EXPORT_EXCEL_ALL_SEM_GRADES As Integer = BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT + BGW_EXPORT_EXCEL_ALL_SEM_SCORES




    'mutiplier
    Public BGW_PROCESS_INTERROP_YR_SCORES As Integer = -1
    Public BGW_PROCESS_BUILTIN_NPOI_LEVEL As Integer = 1

    'Queries
    'FormResult
    'all
    Public STR_SQL_ALL_RESULTS As String = "SELECT * FROM results order by result_id" ' "SELECT `id`, `matno`, `score` FROM `tableResults` WHERE matno='{0}' order by id"
    Public STR_SQL_ALL_RESULTS_SUMMARY As String = "SELECT Results.Session_idr, Results.course_code_idr,Results.result_timestamp, Count(Results.matno) AS NumStudents, Avg(Results.total) AS Average 
                                                    FROM Results
                                                    GROUP BY Results.Session_idr, Results.course_code_idr, Results.result_timestamp;"

    Public STR_SQL_ALL_BROADSHEETS_SUMMARY As String = "SELECT broadsheets_all.Col171,count(broadsheets_all.Col2) AS NumStudents,broadsheets_all.col172, first(broadsheets_all.col173) AS Faculty, broadsheets_all.Col174, first(broadsheets_all.Col175) AS Footers, ColNames
                                                    FROM broadsheets_all
                                                    WHERE Not(Col1='matno')
                                                    GROUP BY ColNames,broadsheets_all.Col171,broadsheets_all.Col172,broadsheets_all.Col174;"   'todo "Col" & LAST_COL
    Public STR_SQL_ALL_BROADSHEETS_WHERE_COLNAMES As String = "SELECT * FROM broadsheets_all 
                                                                WHERE ((Col1='matno') AND (ColNames='{0}'))"

    Public STR_SQL_ALL_REG_SUMMARY As String = "SELECT reg.session_idr, reg.dept_idr, reg.level, count(reg.matno) AS NumStudents
                                                    FROM reg
                                                    GROUP BY reg.session_idr,reg.dept_idr,reg.level;"   'todo "Col" & LAST_COL
    Public STR_SQL_ALL_REG As String = "SELECT reg.session_idr As Session, count(reg.matno) AS NumStudents
                                                    FROM reg
                                                    GROUP BY reg.session_idr;"   'todo "Col" & LAST_COL

    Public STR_SQL_ALL_REG_COUNT As String = "SELECT  count(reg.matno) AS NumStudents
                                                    FROM reg;"   'todo "Col" & LAST_COL

    Public STR_SQL_ALL_STUDENTS_COUNT As String = "SELECT count(matno) AS NumStudents
                                                    FROM Reg;"   'todo "Col" & LAST_COL

    Public STR_SQL_QUERY_RESULT_WHERE_SESSION_AND_COURSE As String = "SELECT results.s_n, Results.matno, Reg.student_firstname, Reg.student_othernames, Reg.student_surname, Results.total,Results.Session_idr, Departments.dept_name, Courses.course_code, Courses.course_unit, Courses.course_title, Courses.course_semester 
                 FROM((Results INNER JOIN Reg ON Results.matno = Reg.matno) INNER JOIN Departments On Reg.student_dept_idr = Departments.dept_id) INNER JOIN Courses On Results.course_code_idr = Courses.course_code 
                 WHERE results.session_idr='{0}' AND results.course_code_idr='{1}';"

    Public STR_SQL_ALL_COURSES As String = "SELECT * FROM courses order by course_code" ' 

    Public STR_SQL_ALL_COURSES_ORDER As String = "SELECT * FROM courses_order_new WHERE (session_idr='{0}' AND dept_idr={1}  AND course_level={2});" ' 
    Public STR_SQL_ALL_COURSES_ORDER_NO_CRITERIA As String = "SELECT * FROM courses_order_new  order by session_idr, dept_idr,course_level" ' 

    Public STR_SQL_ALL_DEPARTMENTS_COMBO As String = "SELECT dept_id, dept_name FROM departments"
    Public STR_SQL_ALL_SESSIONS_COMBO As String = "SELECT session_id FROM sessions" ' 
    Public STR_SQL_ALL_STUDENTS_COMBO As String = "SELECT * FROM Reg" ' 

    'Broadsheets
    Public STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_INSERT_IN_BROADSHEET As String = "SELECT Reg.MatNo, Last(Results.total) AS LastOftotal, Results.course_code_idr, 
                      Results.Session_idr  FROM Reg INNER JOIN Results ON Reg.MatNo = Results.matno GROUP BY Reg.MatNo, Results.course_code_idr,  
                      Results.Session_idr HAVING (((Results.course_code_idr)='{0}') AND ((Results.Session_idr)='{1}'));"
    Public STR_ALL_COURSES_ORDERED As String = "SELECT Courses.course_code, Courses.course_level, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order, Count(Courses.course_order) AS CountOfcourse_order
                  FROM Courses
                 GROUP BY Courses.course_level, Courses.course_code, Courses.course_unit, Courses.course_semester, Courses.course_dept_idr, Courses.course_order
                 HAVING (((Courses.course_semester)>0))
                 ORDER BY Courses.course_level, Courses.course_order;" 'and level
    Public STR_COURSES_ORDER_GENERAL As String = "SELECT * FROM Courses_order WHERE (session_idr='{0}' AND dept_idr={1}) ORDER BY sn;" 'and level
    Public STR_COURSES_ORDER_GENERAL_ALL As String = "SELECT * FROM Courses_order;"

    'Public STR_SQL_REGISTERED_STUDENTS As String = "SELECT Reg.MatNo, Reg.session_idr, Reg.CourseCode_1, Reg.CourseCode_2, Reg.Fees_Status, Reg.level, Reg.dept_idr,   
    '                        students.student_firstname, students.student_surname, students.student_othernames, 
    '                        students.mode_of_entry, students.session_idr_of_entry, students.year_of_entry, 
    '                        students.status
    '                        FROM Reg INNER JOIN students ON Reg.MatNo = students.matno 
    '                        WHERE (((Reg.session_idr)='{0}' AND (Reg.dept_idr)={1} AND (Reg.level)={2}));"
    Public STR_SQL_REGISTERED_STUDENTS As String = "SELECT Reg.MatNo, Reg.session_idr, Reg.CourseCode_1, Reg.CourseCode_2, Reg.Fees_Status, Reg.level, Reg.dept_idr,   
                            Reg.student_firstname, Reg.student_surname, Reg.student_othernames, 
                            Reg.mode_of_entry, Reg.session_idr_of_entry, Reg.year_of_entry, 
                            Reg.status
                            FROM Reg 
                            WHERE (((Reg.session_idr)='{0}' AND (Reg.dept_idr)={1} AND (Reg.level)={2}));"

    'Transcripts
    'Public STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_TRANSCRIPT_BY_MATNO_SESSION As String = "SELECT Students.MatNo, Last(Results.total) AS LastOftotal, Results.course_code_idr, 
    '                  Results.Session_idr  FROM Students INNER JOIN Results ON Students.MatNo = Results.matno GROUP BY Students.MatNo, Results.course_code_idr,  
    '                  Results.Session_idr HAVING (((Students.matno)='{0}') AND ((Results.Session_idr)='{1}'));"

    Public STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_TRANSCRIPT_BY_MATNO_SESSION As String = "SELECT Reg.MatNo, Last(Results.total) AS LastOftotal, Results.course_code_idr, 
                      Results.Session_idr  FROM Reg INNER JOIN Results ON Reg.MatNo = Results.matno GROUP BY Reg.MatNo, Results.course_code_idr,  
                      Results.Session_idr HAVING (((Reg.matno)='{0}') AND ((Results.Session_idr)='{1}'));"

    Public STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_TRANSCRIPT_BY_MATNO As String = "SELECT Reg.MatNo, Last(Results.total) AS Score, Results.course_code_idr, 
                      Results.Session_idr   FROM Reg INNER JOIN Results ON Reg.MatNo = Results.matno GROUP BY Reg.MatNo, Results.course_code_idr,  
                      Results.Session_idr HAVING (((Reg.matno)='{0}'));"
    Public STR_SQL_STUDENTS_FULL_NAME As String = "SELECT * FROM Reg WHERE matno='{0}'"

    'Import reg students from existing Access sofware
    'Note table name is SPD
    Public STR_SQL_ACCESS_IMPORT_REGISTERED_STUDENTS_INPUT_DEPT_LEVEL As String = "SELECT MatNo, year as session_idr, CourseCode_1, CourseCode_2, Fees_Status, SPD.level, year as dept_idr,   
                            othernames as student_firstname, surname as student_surname, othernames as student_othernames, 
                            mode as mode_of_entry, year as session_idr_of_entry, year as year_of_entry, 
                            year as status
                            FROM SPD
                            WHERE (((dept='{0}') AND (SPD.level='{1}')));"

    'search
    Public STR_SQL_SEARCH_STUDENTS_BY_MATNO_PARAM = "SELECT * FROM Reg WHERE matno like @STR)"
    'Dim strParam As New OleDbParameter("@STR", "%" & str & "%")
    Public STR_SQL_SEARCH_STUDENTS_BY_MATNO_SURNAME_FIRSTNAME = "SELECT * FROM Reg WHERE matno like '%{0}%' OR student_surname like '%{1}%' OR student_firstname like '%{2}%'"
    ''TIP: Problem with OLEDB and Access. canot use Like  in query ...''FIXED: use % wildcard instead of *
    Public STR_FILTER_STUDENTS = "matno like '%{0}%' OR student_surname='%{1}%'  OR student_firstname='%{2}%'"
    Public STR_FILTER_RESULTS_BYCOURSECODE = "Course_code_idr like '%{0}%'"
    Public STR_FILTER_RESULTS_BYSESSION = "session_idr like '%{0}%'"
    Public STR_FILTER_REG_BY_MATNO = "matno = '{0}'"
    Public STR_FILTER_GEENERIC = "{0} like '%{1}%'"

    'some
    Public STR_SQL_ALL_RESULTS_WHERE As String = "SELECT matno, coursecode_idr, total FROM results WHERE matno='{0}'" ' "SELECT `id`, `matno`, `score` FROM `tableResults` WHERE matno='{0}' order by id"
    Public SQL_SELECT_RESULTS_WHERE_MATNO As String = " SELECT * FROM results WHERE matno= '{0}'"
    Public SQL_SELECT_ALL_RESULTS As String = "SELECT * FROM results"
    Public STR_SQL_ALL_STUDENTS_IN_DEPT As String = "SELECT * FROM Reg WHERE student_dept_idr={0}" ' 
    Public STR_SQL_ALL_STUDENTS_WHERE_MATNO As String = "SELECT * FROM Reg WHERE matno='{0}'" ' 


    Public STR_SQL_COURSES_WHERE As String = "SELECT * FROM courses WHERE matno='{0}' order by course_code" ' 
    Public STR_SQL_COURSES_REG_WHERE As String = "SELECT * FROM reg WHERE matno='{0}'"
    Public STR_SQL_COURSES_REGS_WHERE As String = "SELECT * FROM regs WHERE matno='{0}'"
    'inserts
    Public STR_SQL_INSERT_RESULTS As String = "INSERT INTO `db`.`results` (`result_id`, `matno`, `score``) VALUES ('', '{0}', '{1}');"
    Public STR_SQL_INSERT_STUDENTS As String = "INSERT INTO Reg (matno, student_firstname, student_surname, student_othernames, student_dept_idr, status, year_of_entry,session_idr_of_entry, mode_of_entry,dob,phone,email,gender,session_idr,CourseCode_1, CourseCode_2, Fees_Status, level, dept_idr) " &
                                                "VALUES ('{0}','{1}','{2}','{3}',{4},'{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}',{17},{18});"

    Public STR_SQL_INSERT_STUDENTS_WITH_PARAMS = "INSERT INTO Reg matno,student_firstname,student_surname,student_othernames,student_dept_idr,status,year_of_entry,session_idr_of_entry,mode_of_entry,dob,phone,email,gender,session_idr,CourseCode_1,CourseCode_2,Fees_Status,level,dept_idr
                                                    VALUES(@matno,@student_firstname,@student_surname,@student_othernames,@student_dept_idr,@status,@year_of_entry,@session_idr_of_entry,@mode_of_entry,@dob,@phone,@email,@gender,@session_idr,@CourseCode_1,@CourseCode_2,@Fees_Status,@level,@dept_idr);"


    'UPDATES
    Public STR_SQL_UPDATESTUDENTS_WITH_PARAMS = "UPDATE Reg SET matno=@matno,student_firstname=@student_firstname,student_surname=@student_surname,student_othernames=@student_othernames,student_dept_idr=@student_dept_idr,status=@status,year_of_entry=@year_of_entry,session_idr_of_entry=@session_idr_of_entry,mode_of_entry=@mode_of_entry,dob=@dob,phone=@phone,email=@email,gender=@gender,session_idr=@session_idr,CourseCode_1=@CourseCode_1,CourseCode_2=@CourseCode_2,Fees_Status=@Fees_Status,level=@level,dept_idr=@dept_idr
                                                WHERE matno=@matno"

    'DELETES
    Public STR_SQL_DELETE_STUDENTS_WITH_PARAMS As String = "DELETE FROM Reg WHERE matno=@matno"
    Public DELETE_FROM_RESULTS_WHERE_SESSION_COURSECODE_TIMESAMP As String = "DELETE * FROM results WHERE session_idr='{0}' AND course_code_idr='{1}' AND result_timestamp='{2}'"
    Public DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL As String = "DELETE * FROM Reg WHERE session_idr='{0}' AND dept_idr={1} AND level={2}"

    Public STR_SQL_COURSE_REG_FIRST_SEMESTER = "SELECT FC.CourseCode, FC.CourseTitle, FC.CourseCredit FROM FC WHERE (((FC.CourseSemester)=1)) ORDER BY FC.CourseCode;"
    Public STR_SQL_COURSE_REG_SECOND_SEMESTER = "SELECT CourseCode,CourseTitle,CourseCredit FROM FC WHERE (((CourseSemester)=2)) ORDER BY CourseCode;"
    'EX SCR Expanded 1 - lookup
    'SELECT reg.MatNo, reg.CourseCode_1.Value AS CourseCode, reg.Dept, DLookUp("CourseTitle","FC_1","CourseCode='" & [CourseCode] & "'") AS Course_Title, DLookUp("CourseCredit","FC_1","CourseCode='" & [CourseCode] & "'") AS Course_Credit, IIf(IsNull([Course_Credit]),0,[Course_Credit]*1) AS CourseCredit, reg.Pix, DLookUp("CourseSemester","FC_1","CourseCode='" & [CourseCode] & "'") AS CourseSemester, reg.Surname, reg.OtherNames, reg.Level, reg.Fees_Status
    'FROM reg
    'WHERE (((reg.CourseCode_1.Value)=[Enter Course Code]) And ((reg.Dept)=[Enter Department]));

    'EX CrossTab - course projection
    'TRANSFORM Count(SCR_Expanded_1.MatNo) As CountOfMatNo
    'Select Case SCR_Expanded_1.CourseCode, FC.CourseTitle, FC.TeachingDept, FC.CourseSemester, Count(SCR_Expanded_1.MatNo) As [Total Of MatNo]
    'FROM SCR_Expanded_1 INNER JOIN FC On SCR_Expanded_1.CourseCode = FC.CourseCode
    'GROUP BY SCR_Expanded_1.CourseCode, FC.CourseTitle, FC.TeachingDept, FC.CourseSemester
    'PIVOT SCR_Expanded_1.Dept;

    'QueryCourses_CPE_1  - only cpe first semester courses
    'Select Case Courses.course_code, Courses.course_unit, Courses.course_title, Courses.course_semester, Courses.course_level, Courses.course_dept_idr, Courses.Teaching_dept
    'FROM Courses
    'WHERE (((Courses.course_semester)=1) And ((Courses.Teaching_dept)="Computer Engineering"));


    'BroadSheets
    Public STR_SQL_ALL_BROADSHEET As String = "SELECT * FROM broadsheets_all" ' WHERE( (session='{0}') And (level={1}));"
    Public STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL As String = "SELECT * FROM broadsheets_all  WHERE( (Col171='{0}') And (Col172='{1}') And (Col174='{2}')  And (ColNames='{3}') And Not(Col1='matno')) ORDER BY Col0,Col1;"
    Public STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL_WITHOUT_TIMESTAMP As String = "SELECT * FROM broadsheets_all  WHERE( (Col171='{0}') And (Col172='{1}') And (Col174='{2}')  And Not(Col1='matno')) ORDER BY Col0,Col1;"

    Public STR_SQL_APPROVED_COURSES = "SELECT approved_courses_300 from sessions WHERE session_id='{0}';"

    'Public STR_SQL_ALL_USERS As String = "SELECT user_id, username, status as STATUS from tblusers order by status"
    'Public STR_SQL_ALL_GUESTS_BILLS_WHERE As String = "SELECT `guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`, `bill_status` FROM `guest_account` WHERE guest_id_ref='{0}' order by date"
    'Public STR_SQL_GET_BOOKING_FOR_BILL As String = "SELECT `booking_id`, `booking_description`, `booking_type`, `deposited_amount`, `total_amount`, `balance_amount`, `booking_date`, `booking_time`, `booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, `start_date`, `end_date`, `guest_id_ref` FROM `bookings` WHERE (guest_id_ref=1 AND (booking_status='occupied' OR booking_status='booked'))"
    'Public STR_SQL_GET_ROOM_FOR_BILL As String = "SELECT `room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`, `room_image` FROM rooms WHERE   room_id = '{0}'"
    'INSERTS
    'Public STR_SQL_INSERT_BILL As String = "INSERT INTO `crimpsof_ehotel`.`guest_account` (`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`) VALUES ('', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"
    'UPDATES
    'Public STR_SQL_EDIT_BOOKING As String = "UPDATE `crimpsof_ehotel`.`bookings` SET `booking_status` = '{0}' WHERE `bookings`.`booking_id` = {1};"
    'Public STR_SQL_EDIT_ROOMS As String = "UPDATE `crimpsof_ehotel`.`rooms` SET `room_status` = '{0}' WHERE `rooms`.`room_id` = {1};"
    'Public SQL_UPDATE_ROOMS As String = "UPDATE rooms set room_status='{0}' where room_id='{1}'"

    Public Function buildConnectionStringFromAccessFile(dfileName As String, Is32bit As Boolean) As String
        ' '32 bit Access
        Dim connectionString32 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};" '& "User ID=admin;" & "Password=" & m_password
        '64 bits
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};" ' "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.mdb"
        connectionString = "Provider = Microsoft.ACE.OLEDB.16.0;Data Source={0};"
        connectionString32 = "Provider = Microsoft.ACE.OLEDB.16.0;Data Source={0};"

        If Is32bit Then
            Return String.Format(connectionString32, dfileName)
        Else
            Return String.Format(connectionString, dfileName)
        End If
    End Function
    Public Function dblQuoted(dStr As String) As String
        Return dblQuote & dStr & dblQuote
    End Function
    Public Enum ExcelColumns
        colA = 1
        colB = 2
        colC = 3
        colD = 4
        colE = 5
        colF = 6
        colG = 7
        colH = 8
        colI = 9
        colJ = 10
        colK = 11
        colL = 12
        colM = 13
        colN = 14
        colO = 15
        colP = 16
        colQ = 17
        colR = 18
        colS = 19
        colT = 20
        colU = 21
        colV = 22
        colW = 23
        colX = 24
        colY = 25
        colZ = 26

        colAA = 27
        colAB = 28
        colAC = 29
        colAD = 30
        colAE = 31
        colAF = 32
        colAG = 33
        colAH = 34
        colAI = 35
        colAJ = 36
        colAK = 37
        colAL = 38
        colAM = 39
        colAN = 40
        colAO = 41
        colAP = 42
    End Enum
    Public numToLetter As String() = {"0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
    "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
    "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP",
    "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF",
    "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV",
    "BW", "BX", "BY", "BZ",
    "CA", "CB", "CC", "CD", "CE", "CF",
    "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV",
    "CW", "CX", "CY", "CZ", "DA", "DB", "DC", "DD", "DE", "DF",
    "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV",
    "DW", "DX", "DY", "DZ", "EA", "EB", "EC", "ED", "EE", "EF",
    "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV",
    "EW", "EX", "EY", "EZ"}

    Public Function LastColInSem_1_ForLevel(dLevel As Integer) As Integer
        Return (COURSE_START_COL + (dLevel / 100) * NUM_COURSES_PER_LEVEL_1) - 1
    End Function
    Public Function LastColInSem_2_ForLevel(dLevel As Integer) As Integer
        Return (COURSE_START_COL_2 + (dLevel / 100) * NUM_COURSES_PER_LEVEL_2) - 1
    End Function
    Sub refreshcolors(frm As Form, cntls As ControlCollection, Optional darkTheme As Boolean = True)

        frm.BackColor = RGBColors.colorBackground
        frm.ForeColor = RGBColors.colorForeground
        'For Each cnt In cntls
        '        If cntls.GetType = Type.GetType("TextBox") Then


        '        ElseIf cntls.GetType = Type.GetType("DataGridView") Then
        '            cnt.BackgroundColor = RGBColors.colorBackground
        '        cnt.RowsDefaultCellStyle.BackColor = RGBColors.colorBackground
        '        cnt.RowsDefaultCellStyle.ForeColor = RGBColors.colorForeground
        '    Else
        '            cnt.backcolor = RGBColors.colorBackground
        '            cnt.backcolor = RGBColors.colorForeground
        '        End If

        '    Next

        If darkTheme Then
            'do some corrections
        End If
    End Sub
    'Public Sub combolist(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, ByVal this_cbo As ComboBox, Optional dConnMode As String = "local")
    '    Try
    '        Dim oad As Object
    '        Dim ds As New DataSet
    '        Dim strtmp As String = this_cbo.Text.ToString : this_cbo.Text = String.Empty
    '        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
    '            Try
    '                xConn.Open()
    '            Catch ex1 As Exception
    '                xConn.ConnectionString = ModuleGeneral.STR_connectionString
    '                xConn.Open()
    '            End Try

    '            If dConnMode = "local" Then
    '                oad = New OleDbDataAdapter(this_sql, xConn)
    '                oad.Fill(ds)
    '            Else
    '                'oad = New MySqlDataAdapter(this_sql, xConn)
    '                'oad.Fill(ds)
    '            End If


    '            With this_cbo
    '                .DataSource = ds.Tables(0)
    '                .ValueMember = this_value
    '                .DisplayMember = this_member
    '            End With

    '            xConn.Close()
    '            this_sql = Nothing
    '            this_value = Nothing
    '            this_member = Nothing
    '            ds = Nothing
    '            oad = Nothing

    '        End Using
    '        'mappDB.close()
    '    Catch ex As Exception
    '        log(ex.ToString)
    '        Throw ex

    '    End Try
    'End Sub

    Function getDeptSessionsIntoDictionaries() As Boolean
        'Todo create an event to auto refresh these when data is added or deleted
        'if recorsHaveChanged
        Try
            dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")
            dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")
            dictAllCourses = combolistDict(STR_SQL_ALL_COURSES, "course_code", "course_code")
            dictCourses = dictAllCourses

            Return True
        Catch ex As Exception
            logError(ex.ToString)
            Return False
        End Try

    End Function
    Public Function getCoursesOrderIntoDictionaries(session_idr, course_dept_idr, dLevel) As Boolean
        Try
            'old
            'dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & dLevel & "L", "FS" & dLevel & "L")
            'dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & dLevel & "L", "SS" & dLevel & "L")
            'new (traspose of old)
            Dim ds As New DataSet
            Dim strColNameFS As String = ""
            Dim strColNameSS As String = ""
            ds = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr, dLevel))

            dictCoursesOrderFS.Clear()
            dictCoursesOrderSS.Clear()

            If ds.Tables(0).Rows.Count = 0 Then Return False



            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To 14
                    strColNameFS = "FS" & (j + 1).ToString("D3")
                    strColNameSS = "SS" & (j + 1).ToString("D3")
                    If IsDBNull(ds.Tables(0).Rows(i).Item(strColNameFS)) Then
                        ds.Tables(0).Rows(i).Item(strColNameFS) = ""
                    Else
                        dictCoursesOrderFS.Add(j + 1, ds.Tables(0).Rows(i).Item(strColNameFS))
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(strColNameSS)) Then
                        ds.Tables(0).Rows(i).Item(strColNameSS) = ""    'dnt add em
                    Else
                        dictCoursesOrderSS.Add(j + 1, ds.Tables(0).Rows(i).Item(strColNameSS))
                    End If

                Next
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function combolistDict(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, Optional dConnMode As String = "local") As Dictionary(Of String, String)
        Try
            Dim oad As Object
            Dim ds As New DataSet
            Dim strtmp As String = String.Empty
            Dim retDict As New Dictionary(Of String, String)
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    Try
                        xConn.ConnectionString = ModuleGeneral.STR_connectionString32
                        xConn.Open()
                    Catch ex As Exception
                        'Todo: Handle shared memory access issues
                        'GC.Collect()
                    End Try

                End Try

                If dConnMode = "local" Then
                    oad = New OleDbDataAdapter(this_sql, xConn)
                    oad.Fill(ds)
                Else
                    'oad = New MySqlDataAdapter(this_sql, xConn)
                    'oad.Fill(ds)
                End If


                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If IsDBNull(ds.Tables(0).Rows(i).Item(this_value)) Then
                        'retDict.Add(i.ToString, "") 
                    Else
                        retDict.Add(ds.Tables(0).Rows(i).Item(this_value), ds.Tables(0).Rows(i).Item(this_member))  'TODO: avoid nulls

                    End If
                Next

                xConn.Close()
                this_sql = Nothing
                this_value = Nothing
                this_member = Nothing
                ds = Nothing
                oad = Nothing
            End Using
            Return retDict
        Catch ex As Exception
            log(ex.ToString)
            Throw ex

        End Try
    End Function
    Public Function combolistDS(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, Optional dConnMode As String = "local") As DataSet
        Try
            Dim oad As Object
            Dim ds As New DataSet
            Dim strtmp As String = String.Empty
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try

                If dConnMode = "local" Then
                    oad = New OleDbDataAdapter(this_sql, xConn)
                    oad.Fill(ds)
                Else
                    'oad = New MySqlDataAdapter(this_sql, xConn)
                    'oad.Fill(ds)
                End If




                xConn.Close()
                this_sql = Nothing
                this_value = Nothing
                this_member = Nothing
                ds = Nothing
                oad = Nothing

            End Using
            Return ds
        Catch ex As Exception
            log(ex.ToString)
            Throw ex

        End Try
    End Function

    Public Sub fillGrid(ByVal _sql As String, ByVal _criteria As String, ByVal _orderBy As String, ByVal _grid As DataGridView, Optional ByVal _readonly As Boolean = False, Optional ByVal _bindingsource As BindingSource = Nothing)
        'TODO
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
                If mappDB.connMode = "local" Or mappDB.connMode = Nothing Then
                    oadDataGridLocal = New OleDbDataAdapter(_sql + _criteria + _orderBy, xConn)
                Else
                    oadDataGrid = New MySqlDataAdapter(_sql + _criteria + _orderBy, mappDB.connRemote)
                End If

                dtDataGrid = New DataTable

                oadDataGrid.Fill(dtDataGrid)

                With _grid

                    .DataSource = Nothing

                    If _bindingsource Is Nothing Then
                        .DataSource = dtDataGrid
                    Else
                        '_bindingsource = New BindingSource
                        _bindingsource.DataSource = dtDataGrid
                        .DataSource = _bindingsource
                    End If
                    'hide column 0 
                    .Columns(0).Visible = False

                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .Cursor = Cursors.Hand

                    If _readonly Then
                        .ReadOnly = True
                        .AllowUserToAddRows = False
                    End If
                End With
                xConn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("query error : " & ex.Message)
        Finally
            _sql = Nothing
            _criteria = Nothing
            _orderBy = Nothing
            _grid = Nothing

            'bdsource = Nothing

            _bindingsource = Nothing
            oadDataGrid = Nothing
            dtDataGrid = Nothing
            mappDB.closeConn(oadDataGridLocal.SelectCommand.Connection)
        End Try
    End Sub
    'Inspired by Hamid (StackOverflow)
    'Ported from C# to VB.NET
    Public Function getMD5HashCode(strPass As String) As String
        Dim dMD5Hsh As String = ""

        Using md5Hash As MD5 = MD5.Create

            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(strPass))
            Dim sBuilder As StringBuilder = New StringBuilder
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next
            dMD5Hsh = sBuilder.ToString
        End Using
        Return dMD5Hsh
    End Function
    Function Array2sTR(s As String()) As String
        Dim tmpStr As String = ""

        For i = 0 To s.Length - 1
            tmpStr = tmpStr & s(i) & ","
        Next
        Return tmpStr
    End Function
    Function str2Array(s As String) As String()
        Dim tmpStr As String() = {""}


        tmpStr = s.Split(",")
        'tmpStr = s.Substring(0, 0)
        Return tmpStr
    End Function
    Public Sub showError(ByVal _msg As String)
        MessageBox.Show("WARNING : " & _msg & Chr(13) & " Click OK to continue.", strApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub log(ByVal _msg As String)
        On Error Resume Next
        Dim fileName As String = My.Application.Info.DirectoryPath & "\reports\log.txt"
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(fileName)
        If fileExists Then
            My.Computer.FileSystem.WriteAllText(fileName, _msg & vbCrLf, True)
        Else
            My.Computer.FileSystem.WriteAllText(fileName, String.Empty, False)
            My.Computer.FileSystem.WriteAllText(fileName, _msg & vbCrLf, True)
        End If
    End Sub

    'store accounts to hastable
    'Structure _accounts
    '    Dim m_table As Hashtable

    '    Public Sub loaddata(ByVal this_sql As String)

    '    End Sub

    '    Public Sub loadtocombobox(ByVal this_cbo As ComboBox)
    '        this_cbo.DataSource = m_table
    '        this_cbo.ValueMember = "Key"
    '        this_cbo.DisplayMember = "Value"
    '    End Sub


    '    Public Sub dispose()
    '        m_table = Nothing
    '    End Sub
    'End Structure
    'Public accounts As New _accounts


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
    Public Sub drawBorder(ByVal _range As String)
        'excelWS.Range(_range).Select()

        'excelWS.Cells.Range(_range).Borders ()

        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeLeft)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeTop)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeBottom)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeRight)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlInsideVertical)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlInsideHorizontal)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
    End Sub
    Public Function FormatMyDate(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Year.ToString("0000") & "-"
        StrDate = StrDate & dtp.Month.ToString("00") & "-"
        StrDate = StrDate & dtp.Day.ToString("00")
        Return StrDate
    End Function
    Public Function FormatMyTime(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Hour.ToString("00")
        StrDate = StrDate & ":" & dtp.Minute.ToString("00")
        StrDate = StrDate & ":" & dtp.Second.ToString("00")
        Return StrDate
    End Function
    Public Function generateCodeGetSetForBroadsheet() As Boolean
        Dim ds As DataSet = mappDB.GetDataWhere("SELECT * FROM broadsheets_all WHERE Col1=''")
        Dim dt As DataTable = ds.Tables(0)
        Dim strDeclaration As String = ""
        Dim strGetandSet As String = ""
        Dim pptyName As String = ""
        Dim pptyPrivateName As String = ""
        For j = 0 To dt.Columns.Count - 1
            pptyName = dt.Columns(j).ColumnName
            pptyPrivateName = "_" & pptyName.ToLower
            strDeclaration = "Public " & pptyPrivateName & " as String"
            strGetandSet = ""
            strGetandSet = strGetandSet & vbCrLf & "Public Property " & pptyName & "() As String"
            strGetandSet = strGetandSet & vbCrLf & "Get"
            strGetandSet = strGetandSet & vbCrLf & "Return " & pptyPrivateName
            strGetandSet = strGetandSet & vbCrLf & "End Get"
            strGetandSet = strGetandSet & vbCrLf & "Set(ByVal value As String)"

            strGetandSet = strGetandSet & vbCrLf & pptyPrivateName & " = value"
            strGetandSet = strGetandSet & vbCrLf & "End Set"
            strGetandSet = strGetandSet & vbCrLf & "End Property" & vbCrLf
            Debug.Print(strDeclaration)
            Debug.Print(strGetandSet)
        Next
        'output it

        Return True
    End Function

    Function generateCodeBindings(dt As DataTable) As String
        Dim strRet As String = ""
        Dim cntName As String = ""
        Dim paramName As String = ""
        Dim fieldName As String = ""
        For j = 0 To dt.Columns.Count - 1
            fieldName = dt.Columns(j).ColumnName
            cntName = "TextBox" & dt.Columns(j).ColumnName
            If j = 0 Then
                strRet = cntName & ".DataBindings.Add(" & dblQuoted("Text") & ", BindingSourceStudents, " & dblQuoted(fieldName) & ")"
            Else
                strRet = strRet & vbCrLf & cntName & ".DataBindings.Add(" & dblQuoted("Text") & ", BindingSourceStudents, " & dblQuoted(fieldName) & ")"
            End If
        Next
        'TextBoxMATNO.DataBindings.Add("Text", BindingSourceStudents, "matno")


        Return strRet
    End Function
    Function generateSQLUpdate(dt As DataTable, tblname As String, dCriteriaField As String) As String
        'UPDATE Reg SET student_firstname=@first,student_othernames=@middle,student_surname=@last WHERE matno=@matno"
        Dim strRet As String = "UPDATE " & tblname & " SET"
        Dim paramName As String = ""
        Dim fieldName As String = ""
        For j = 0 To dt.Columns.Count - 1

            fieldName = dt.Columns(j).ColumnName
            paramName = "@" & fieldName
            If j = 0 Then
                strRet = strRet & fieldName & "=" & paramName
            Else
                strRet = strRet & "," & fieldName & "=" & paramName
            End If

        Next
        strRet = strRet & vbCrLf & "WHERE " & dCriteriaField & "=@" & dCriteriaField

        Return strRet
    End Function
    Function generateSQLInsert(dt As DataTable, tblName As String) As String
        Dim strRet As String = "INSERT INTO " & tblName & " "
        Dim valS As String = " VALUES("
        Dim paramName As String = ""
        Dim fieldName As String = ""
        For j = 0 To dt.Columns.Count - 1

            fieldName = dt.Columns(j).ColumnName
            paramName = "@" & fieldName
            If j = 0 Then
                strRet = strRet & fieldName
                valS = valS & paramName
            Else
                strRet = strRet & "," & fieldName
                valS = valS & "," & paramName
            End If

        Next
        strRet = strRet & vbCrLf & valS & ");"

        Return strRet
    End Function

    Function generateParams(dt As DataTable) As String
        Dim strRet As String = ""
        Dim valS As String = " VALUES("
        Dim paramName As String = ""
        Dim fieldName As String = ""
        For j = 0 To dt.Columns.Count - 1
            paramName = "@" & fieldName
            fieldName = dt.Columns(j).ColumnName
            ' lstupdateParams.Add(New OleDb.OleDbParameter("@matno", OleDb.OleDbType.VarChar, 100, "matno"))
            strRet = strRet & vbCrLf & "lstupdateParams.Add(New OleDb.OleDbParameter(" & dblQuoted(paramName) & ", OleDb.OleDbType.VarChar, 100, " & dblQuoted(fieldName) & "))"
        Next
        Return strRet
    End Function
End Module

