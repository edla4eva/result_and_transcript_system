Imports Microsoft.Reporting.WinForms
Public Class ClassTranscripts
    Public Sub New()

    End Sub

    Public _sn As String
    Public Property sn() As String
        Get
            Return _sn
        End Get
        Set(ByVal value As String)
            _sn = value
        End Set
    End Property
    Public _matno As String
    Public Property matno() As String
        Get
            Return _matno
        End Get
        Set(ByVal value As String)
            _matno = value
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
    Public _score As String
    Public Property score() As String
        Get
            Return _score
        End Get
        Set(ByVal value As String)
            _score = value
        End Set
    End Property
    Public _Session As String
    Public Property Session() As String
        Get
            Return _Session
        End Get
        Set(ByVal value As String)
            _Session = value
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

    Public _status As String

    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
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

    Public _dob As String

    Public Property dob() As String
        Get
            Return _dob
        End Get
        Set(ByVal value As String)
            _dob = value
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

    Public _session_idr As String

    Public Property session_idr() As String
        Get
            Return _session_idr
        End Get
        Set(ByVal value As String)
            _session_idr = value
        End Set
    End Property


End Class
