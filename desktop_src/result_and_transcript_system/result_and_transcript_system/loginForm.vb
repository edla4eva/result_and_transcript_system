
Imports MySql.Data.MySqlClient
Public Class loginForm
    Public adminStatus As Boolean = False

    Private Sub okButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton2.Click

        If CheckBoxDemo.Checked = True Then
            mappDB.UserName = TextBoxusername.Text
            mappDB.Password = TextBoxpassword.Text
            mappDB.Dept = comboDepartments.Text
            mappDB.StaffID = 1
            mappDB.GuestID = 1
            Me.adminStatus = True
            Me.Hide()
            MdiParent.Show()
            Exit Sub
        End If
        Try
            Dim cn As String = "select * from tblusers WHERE username='"
            cn = cn & TextBoxusername.Text & "' AND password='"
            cn = cn & TextBoxpassword.Text & "' AND dept_id="
            cn = cn & CInt(comboDepartments.SelectedValue) & ";"
            Dim cmd As New MySqlCommand(cn, mappDB.conn)
            Dim rd As MySqlDataReader
            rd = cmd.ExecuteReader

            If rd.Read() Then
                If rd.GetString(4) <> "" Then
                    mappDB.UserName = TextBoxusername.Text
                    mappDB.Password = TextBoxpassword.Text
                    mappDB.Dept = comboDepartments.Text
                    mappDB.StaffID = rd.GetInt16(0)
                    mappDB.GuestID = 1
                    If TextBoxAdminPassword.Text = "2015TrussNetAdmin" Then Me.adminStatus = True
                    MsgBox("Login successful for the user name: '" & rd.GetString(4) & "'")
                    MDIParentMain.Show()
                    Me.Hide()
                End If
                rd.Close()
                rd = Nothing
            Else
                'mappdb.conn.State=ConnectionState.Open

                rd.Close()
                rd = Nothing
                MsgBox("Login NOT successful! please try again")

            End If

        Catch ex As Exception

            Call showError(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        'Me.Hide()
        If MessageBox.Show("Do you really want to quit now?", strApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub loginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = strApplicationName & " Login"
        TextBoxpassword.Text = String.Empty

        'todo remove when launch
        TextBoxusername.Text = "admin"
        TextBoxpassword.Text = "admin"
        'TextBoxAdminPassword= String.Empty

    End Sub

    Private Sub ButtonExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExpand.Click
        If ButtonExpand.Text = ">>" Then
            Me.TextBoxAdminPassword.Visible = True
            ButtonExpand.Text = "<<"
        Else
            Me.TextBoxAdminPassword.Visible = False
            ButtonExpand.Text = ">>"
        End If


    End Sub
    Function checkIfDatabaseIsAccessable() As Boolean

        '-----Populate combo box with data-------------------------
        Dim cn As String = "select * from tbldept"
        combolist(cn, "dept_id", "dept_name", comboDepartments)
        Return True
    End Function

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Try

            If txtMySQLUserName.Text = "" Or CheckBoxAuto.Checked Then
                If MsgBox("Use Auto settings?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    mappDB.connectToMySQLServer(, True)
                    'ElseIf MsgBox("Use default values?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    mappDB.connectToMySQLServer(, False)
                End If

            Else
                'user supplied login credentials
                mappDB.connectToMySQLServer(, False, txtIP.Text, txtMySQLUserName.Text, txtMySQLPassword.Text)

            End If
            MsgBox("Connected to Database Server")
            Call checkIfDatabaseIsAccessable()            ''
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class