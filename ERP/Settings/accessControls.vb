Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class accessControls
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim saveType As String
    Private Sub accessControls_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub clearAll()
        CheckBox101.CheckState = 0
        CheckBox102.CheckState = 0
        CheckBox103.CheckState = 0
        CheckBox104.CheckState = 0
        CheckBox105.CheckState = 0
        CheckBox106.CheckState = 0
        CheckBox107.CheckState = 0
        CheckBox108.CheckState = 0
        CheckBox109.CheckState = 0
        CheckBox110.CheckState = 0
        CheckBox111.CheckState = 0
        CheckBox112.CheckState = 0
        CheckBox113.CheckState = 0
        CheckBox201.CheckState = 0
        CheckBox202.CheckState = 0
        CheckBox203.CheckState = 0
        CheckBox204.CheckState = 0
        CheckBox205.CheckState = 0
        CheckBox206.CheckState = 0
        CheckBox207.CheckState = 0
        CheckBox208.CheckState = 0
        CheckBox209.CheckState = 0
        CheckBox210.CheckState = 0
        CheckBox211.CheckState = 0
        CheckBox212.CheckState = 0
        CheckBox213.CheckState = 0
        CheckBox214.CheckState = 0
        CheckBox215.CheckState = 0
        CheckBox216.CheckState = 0
        CheckBox217.CheckState = 0
        CheckBox218.CheckState = 0
        CheckBox219.CheckState = 0
        CheckBox220.CheckState = 0
        CheckBox221.CheckState = 0
        CheckBox222.CheckState = 0
        CheckBox223.CheckState = 0
        CheckBox301.CheckState = 0
        CheckBox302.CheckState = 0
        CheckBox303.CheckState = 0
        CheckBox304.CheckState = 0
        CheckBox305.CheckState = 0
        CheckBox306.CheckState = 0
        CheckBox307.CheckState = 0
        CheckBox308.CheckState = 0
        CheckBox309.CheckState = 0
        CheckBox310.CheckState = 0
        CheckBox311.CheckState = 0
        CheckBox312.CheckState = 0
        CheckBox313.CheckState = 0
        CheckBox401.CheckState = 0
        CheckBox402.CheckState = 0
        CheckBox403.CheckState = 0
        CheckBox404.CheckState = 0
        CheckBox405.CheckState = 0
        CheckBox406.CheckState = 0
        CheckBox501.CheckState = 0
        CheckBox502.CheckState = 0
        CheckBox503.CheckState = 0
        CheckBox504.CheckState = 0
        CheckBox505.CheckState = 0
        CheckBox506.CheckState = 0
        CheckBox507.CheckState = 0
        CheckBox508.CheckState = 0
        CheckBox509.CheckState = 0
        CheckBox510.CheckState = 0
        CheckBox511.CheckState = 0
        CheckBox512.CheckState = 0
        CheckBox513.CheckState = 0
        CheckBox514.CheckState = 0
        CheckBox515.CheckState = 0
        CheckBox516.CheckState = 0
        CheckBox601.CheckState = 0
        CheckBox602.CheckState = 0
        CheckBox603.CheckState = 0
        CheckBox604.CheckState = 0
        CheckBox701.CheckState = 0
        CheckBox702.CheckState = 0
        CheckBox703.CheckState = 0
        CheckBox704.CheckState = 0
        CheckBox705.CheckState = 0
        CheckBox706.CheckState = 0
        CheckBox707.CheckState = 0
        CheckBox708.CheckState = 0
        CheckBox709.CheckState = 0
        CheckBox801.CheckState = 0
        CheckBox802.CheckState = 0
        CheckBox803.CheckState = 0
        CheckBox804.CheckState = 0
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If userNameInput.Text = "" Then
            MsgBox("Please Enter a Valid User Name")
            userNameInput.Focus()
        Else
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                'SQL Validation for User Name
                Dim valcommand1 As New SqlCommand("SELECT * FROM userAuth WHERE userName = @input1got", conn)
                valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = userNameInput.Text
                Dim valadapter1 As New SqlDataAdapter(valcommand1)
                Dim valtable1 As New DataTable()
                valadapter1.Fill(valtable1)
                If valtable1.Rows.Count() > 0 Then
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        'SQL Loading Existing Record
                        Dim valcommand2 As New SqlCommand("SELECT * FROM accessControls WHERE userName = @input1got", conn)
                        valcommand2.Parameters.Add("@input1got", SqlDbType.VarChar).Value = userNameInput.Text
                        Dim valadapter2 As New SqlDataAdapter(valcommand2)
                        Dim valtable2 As New DataTable()
                        valadapter2.Fill(valtable2)
                        If valtable2.Rows.Count() > 0 Then
                            MsgBox("Edit and Click Save to Update Access Controls")
                            saveType = "update"
                            Try
                                conn = New SqlConnection(constr)
                                conn.Open()
                                comm = New SqlCommand("SELECT * FROM accessControls WHERE userName = '" & userNameInput.Text & "'", conn)
                                reader = comm.ExecuteReader
                                Do While reader.Read = True 'Loop to load data realtime
                                    CheckBox101.CheckState = (reader(2).ToString)
                                    CheckBox102.CheckState = (reader(3).ToString)
                                    CheckBox103.CheckState = (reader(4).ToString)
                                    CheckBox104.CheckState = (reader(5).ToString)
                                    CheckBox105.CheckState = (reader(6).ToString)
                                    CheckBox106.CheckState = (reader(7).ToString)
                                    CheckBox107.CheckState = (reader(8).ToString)
                                    CheckBox108.CheckState = (reader(9).ToString)
                                    CheckBox109.CheckState = (reader(10).ToString)
                                    CheckBox110.CheckState = (reader(11).ToString)
                                    CheckBox111.CheckState = (reader(12).ToString)
                                    CheckBox112.CheckState = (reader(13).ToString)
                                    CheckBox113.CheckState = (reader(14).ToString)
                                    CheckBox201.CheckState = (reader(15).ToString)
                                    CheckBox202.CheckState = (reader(16).ToString)
                                    CheckBox203.CheckState = (reader(17).ToString)
                                    CheckBox204.CheckState = (reader(18).ToString)
                                    CheckBox205.CheckState = (reader(19).ToString)
                                    CheckBox206.CheckState = (reader(20).ToString)
                                    CheckBox207.CheckState = (reader(21).ToString)
                                    CheckBox208.CheckState = (reader(22).ToString)
                                    CheckBox209.CheckState = (reader(23).ToString)
                                    CheckBox210.CheckState = (reader(24).ToString)
                                    CheckBox211.CheckState = (reader(25).ToString)
                                    CheckBox212.CheckState = (reader(26).ToString)
                                    CheckBox213.CheckState = (reader(27).ToString)
                                    CheckBox214.CheckState = (reader(28).ToString)
                                    CheckBox215.CheckState = (reader(29).ToString)
                                    CheckBox216.CheckState = (reader(30).ToString)
                                    CheckBox217.CheckState = (reader(31).ToString)
                                    CheckBox218.CheckState = (reader(32).ToString)
                                    CheckBox219.CheckState = (reader(33).ToString)
                                    CheckBox220.CheckState = (reader(34).ToString)
                                    CheckBox221.CheckState = (reader(35).ToString)
                                    CheckBox222.CheckState = (reader(36).ToString)
                                    CheckBox223.CheckState = (reader(37).ToString)
                                    CheckBox301.CheckState = (reader(38).ToString)
                                    CheckBox302.CheckState = (reader(39).ToString)
                                    CheckBox303.CheckState = (reader(40).ToString)
                                    CheckBox304.CheckState = (reader(41).ToString)
                                    CheckBox305.CheckState = (reader(42).ToString)
                                    CheckBox306.CheckState = (reader(43).ToString)
                                    CheckBox307.CheckState = (reader(44).ToString)
                                    CheckBox308.CheckState = (reader(45).ToString)
                                    CheckBox309.CheckState = (reader(46).ToString)
                                    CheckBox310.CheckState = (reader(47).ToString)
                                    CheckBox311.CheckState = (reader(48).ToString)
                                    CheckBox312.CheckState = (reader(49).ToString)
                                    CheckBox313.CheckState = (reader(50).ToString)
                                    CheckBox401.CheckState = (reader(51).ToString)
                                    CheckBox402.CheckState = (reader(52).ToString)
                                    CheckBox403.CheckState = (reader(53).ToString)
                                    CheckBox404.CheckState = (reader(54).ToString)
                                    CheckBox405.CheckState = (reader(55).ToString)
                                    CheckBox406.CheckState = (reader(56).ToString)
                                    CheckBox501.CheckState = (reader(57).ToString)
                                    CheckBox502.CheckState = (reader(58).ToString)
                                    CheckBox503.CheckState = (reader(59).ToString)
                                    CheckBox504.CheckState = (reader(60).ToString)
                                    CheckBox505.CheckState = (reader(61).ToString)
                                    CheckBox506.CheckState = (reader(62).ToString)
                                    CheckBox507.CheckState = (reader(63).ToString)
                                    CheckBox508.CheckState = (reader(64).ToString)
                                    CheckBox509.CheckState = (reader(65).ToString)
                                    CheckBox510.CheckState = (reader(66).ToString)
                                    CheckBox511.CheckState = (reader(67).ToString)
                                    CheckBox512.CheckState = (reader(68).ToString)
                                    CheckBox513.CheckState = (reader(69).ToString)
                                    CheckBox514.CheckState = (reader(70).ToString)
                                    CheckBox515.CheckState = (reader(71).ToString)
                                    CheckBox516.CheckState = (reader(72).ToString)
                                    CheckBox601.CheckState = (reader(73).ToString)
                                    CheckBox602.CheckState = (reader(74).ToString)
                                    CheckBox603.CheckState = (reader(75).ToString)
                                    CheckBox604.CheckState = (reader(76).ToString)
                                    CheckBox701.CheckState = (reader(77).ToString)
                                    CheckBox702.CheckState = (reader(78).ToString)
                                    CheckBox703.CheckState = (reader(79).ToString)
                                    CheckBox704.CheckState = (reader(80).ToString)
                                    CheckBox705.CheckState = (reader(81).ToString)
                                    CheckBox706.CheckState = (reader(82).ToString)
                                    CheckBox707.CheckState = (reader(83).ToString)
                                    CheckBox708.CheckState = (reader(84).ToString)
                                    CheckBox709.CheckState = (reader(85).ToString)
                                    CheckBox801.CheckState = (reader(86).ToString)
                                    CheckBox802.CheckState = (reader(87).ToString)
                                    CheckBox803.CheckState = (reader(88).ToString)
                                    CheckBox804.CheckState = (reader(89).ToString)
                                Loop
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Try
                            conn.Close()
                        Else
                            MsgBox("Edit and Click Save to Update Access Controls")
                            saveType = "new"
                            Call clearAll()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Else
                    MsgBox("Please Check Your User Name")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If saveType = "new" Then
            If userNameInput.Text = "" Then
                MsgBox("Please Choose a Username")
            Else
                'Save New Record
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("INSERT INTO accessControls(userName, a101, a102, a103, a104, a105, a106, a107, a108, a109, a110, a111, a112, a113, a201, a202, a203, a204, a205, a206, a207, a208, a209, a210, a211, a212, a213, a214, a215, a216, a217, a218, a219, a220, a221, a222, a223, a301, a302, a303, a304, a305, a306, a307, a308, a309, a310, a311, a312, a313, a401, a402, a403, a404, a405, a406, a501, a502, a503, a504, a505, a506, a507, a508, a509, a510, a511, a512, a513, a514, a515, a516, a601, a602, a603, a604, a701, a702, a703, a704, a705, a706, a707, a708, a709, a801, a802, a803, a804) VALUES ('" & userNameInput.Text & "' , '" & CheckBox101.CheckState & "' , '" & CheckBox102.CheckState & "' , '" & CheckBox103.CheckState & "' , '" & CheckBox104.CheckState & "' , '" & CheckBox105.CheckState & "' , '" & CheckBox106.CheckState & "' , '" & CheckBox107.CheckState & "' , '" & CheckBox108.CheckState & "' , '" & CheckBox109.CheckState & "' , '" & CheckBox110.CheckState & "' , '" & CheckBox111.CheckState & "' , '" & CheckBox112.CheckState & "' , '" & CheckBox113.CheckState & "' , '" & CheckBox201.CheckState & "' , '" & CheckBox202.CheckState & "' , '" & CheckBox203.CheckState & "' , '" & CheckBox204.CheckState & "' , '" & CheckBox205.CheckState & "' , '" & CheckBox206.CheckState & "' , '" & CheckBox207.CheckState & "' , '" & CheckBox208.CheckState & "' , '" & CheckBox209.CheckState & "' , '" & CheckBox210.CheckState & "' , '" & CheckBox211.CheckState & "' , '" & CheckBox212.CheckState & "' , '" & CheckBox213.CheckState & "' , '" & CheckBox214.CheckState & "' , '" & CheckBox215.CheckState & "' , '" & CheckBox216.CheckState & "' , '" & CheckBox217.CheckState & "' , '" & CheckBox218.CheckState & "' , '" & CheckBox219.CheckState & "' , '" & CheckBox220.CheckState & "' , '" & CheckBox221.CheckState & "' , '" & CheckBox222.CheckState & "' , '" & CheckBox223.CheckState & "' , '" & CheckBox301.CheckState & "' , '" & CheckBox302.CheckState & "' , '" & CheckBox303.CheckState & "' , '" & CheckBox304.CheckState & "' , '" & CheckBox305.CheckState & "' , '" & CheckBox306.CheckState & "' , '" & CheckBox307.CheckState & "' , '" & CheckBox308.CheckState & "' , '" & CheckBox309.CheckState & "' , '" & CheckBox310.CheckState & "' , '" & CheckBox311.CheckState & "' , '" & CheckBox312.CheckState & "' , '" & CheckBox313.CheckState & "' , '" & CheckBox401.CheckState & "' , '" & CheckBox402.CheckState & "' , '" & CheckBox403.CheckState & "' , '" & CheckBox404.CheckState & "' , '" & CheckBox405.CheckState & "' , '" & CheckBox406.CheckState & "' , '" & CheckBox501.CheckState & "' , '" & CheckBox502.CheckState & "' , '" & CheckBox503.CheckState & "' , '" & CheckBox504.CheckState & "' , '" & CheckBox505.CheckState & "' , '" & CheckBox506.CheckState & "' , '" & CheckBox507.CheckState & "' , '" & CheckBox508.CheckState & "' , '" & CheckBox509.CheckState & "' , '" & CheckBox510.CheckState & "' , '" & CheckBox511.CheckState & "' , '" & CheckBox512.CheckState & "' , '" & CheckBox513.CheckState & "' , '" & CheckBox514.CheckState & "' , '" & CheckBox515.CheckState & "' , '" & CheckBox516.CheckState & "' , '" & CheckBox601.CheckState & "' , '" & CheckBox602.CheckState & "' , '" & CheckBox603.CheckState & "' , '" & CheckBox604.CheckState & "' , '" & CheckBox701.CheckState & "' , '" & CheckBox702.CheckState & "' , '" & CheckBox703.CheckState & "' , '" & CheckBox704.CheckState & "' , '" & CheckBox705.CheckState & "' , '" & CheckBox706.CheckState & "' , '" & CheckBox707.CheckState & "' , '" & CheckBox708.CheckState & "' , '" & CheckBox709.CheckState & "' , '" & CheckBox801.CheckState & "' , '" & CheckBox802.CheckState & "' , '" & CheckBox803.CheckState & "' , '" & CheckBox804.CheckState & "')", conn)
                affector = comm.ExecuteNonQuery
                MessageBox.Show("Access Controls have been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call clearAll()
                saveType = ""
                userNameInput.Text = ""
                conn.Close()
            End If
        ElseIf saveType = "update" Then
            If userNameInput.Text = "" Then
                MsgBox("Please Choose a Username")
            Else
                'Save New Record
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("UPDATE accessControls SET a101 = '" & CheckBox101.CheckState & "', a102 = '" & CheckBox102.CheckState & "', a103 = '" & CheckBox103.CheckState & "', a104 = '" & CheckBox104.CheckState & "', a105 = '" & CheckBox105.CheckState & "', a106 = '" & CheckBox106.CheckState & "', a107 = '" & CheckBox107.CheckState & "', a108 = '" & CheckBox108.CheckState & "', a109 = '" & CheckBox109.CheckState & "', a110 = '" & CheckBox110.CheckState & "', a111 = '" & CheckBox111.CheckState & "', a112 = '" & CheckBox112.CheckState & "', a113 = '" & CheckBox113.CheckState & "' , a201 = '" & CheckBox201.CheckState & "', a202 = '" & CheckBox202.CheckState & "', a203 = '" & CheckBox203.CheckState & "', a204 = '" & CheckBox204.CheckState & "', a205 = '" & CheckBox205.CheckState & "', a206 = '" & CheckBox206.CheckState & "', a207 = '" & CheckBox207.CheckState & "', a208 = '" & CheckBox208.CheckState & "', a209 = '" & CheckBox209.CheckState & "', a210 = '" & CheckBox210.CheckState & "', a211 = '" & CheckBox211.CheckState & "', a212 = '" & CheckBox212.CheckState & "', a213 = '" & CheckBox213.CheckState & "', a214 = '" & CheckBox214.CheckState & "', a215 = '" & CheckBox215.CheckState & "', a216 = '" & CheckBox216.CheckState & "', a217 = '" & CheckBox217.CheckState & "', a218 = '" & CheckBox218.CheckState & "', a219 = '" & CheckBox219.CheckState & "', a220 = '" & CheckBox220.CheckState & "', a221 = '" & CheckBox221.CheckState & "', a222 = '" & CheckBox222.CheckState & "', a223 = '" & CheckBox223.CheckState & "', a301 = '" & CheckBox301.CheckState & "', a302 = '" & CheckBox302.CheckState & "', a303 = '" & CheckBox303.CheckState & "', a304 = '" & CheckBox304.CheckState & "', a305 = '" & CheckBox305.CheckState & "', a306 = '" & CheckBox306.CheckState & "', a307 = '" & CheckBox307.CheckState & "', a308 = '" & CheckBox308.CheckState & "', a309 = '" & CheckBox309.CheckState & "', a310 = '" & CheckBox310.CheckState & "', a311 = '" & CheckBox311.CheckState & "', a312 = '" & CheckBox312.CheckState & "', a313 = '" & CheckBox313.CheckState & "', a401 = '" & CheckBox401.CheckState & "', a402 = '" & CheckBox402.CheckState & "', a403 = '" & CheckBox403.CheckState & "', a404 = '" & CheckBox404.CheckState & "', a405 = '" & CheckBox405.CheckState & "', a406 = '" & CheckBox406.CheckState & "', a501 = '" & CheckBox501.CheckState & "', a502 = '" & CheckBox502.CheckState & "', a503 = '" & CheckBox503.CheckState & "', a504 = '" & CheckBox504.CheckState & "', a505 = '" & CheckBox505.CheckState & "', a506 = '" & CheckBox506.CheckState & "', a507 = '" & CheckBox507.CheckState & "', a508 = '" & CheckBox508.CheckState & "', a509 = '" & CheckBox509.CheckState & "', a510 = '" & CheckBox510.CheckState & "', a511 = '" & CheckBox511.CheckState & "', a512 = '" & CheckBox512.CheckState & "', a513 = '" & CheckBox513.CheckState & "', a514 = '" & CheckBox514.CheckState & "', a515 = '" & CheckBox515.CheckState & "', a516 = '" & CheckBox516.CheckState & "', a601 = '" & CheckBox601.CheckState & "', a602 = '" & CheckBox602.CheckState & "', a603 = '" & CheckBox603.CheckState & "', a604 = '" & CheckBox604.CheckState & "', a701 = '" & CheckBox701.CheckState & "', a702 = '" & CheckBox702.CheckState & "', a703 = '" & CheckBox703.CheckState & "', a704 = '" & CheckBox704.CheckState & "', a705 = '" & CheckBox705.CheckState & "', a706 = '" & CheckBox706.CheckState & "', a707 = '" & CheckBox707.CheckState & "', a708 = '" & CheckBox708.CheckState & "', a709 = '" & CheckBox709.CheckState & "', a801 = '" & CheckBox801.CheckState & "', a802 = '" & CheckBox802.CheckState & "', a803 = '" & CheckBox803.CheckState & "', a804 = '" & CheckBox804.CheckState & "' WHERE userName = '" & userNameInput.Text & "' ", conn)
                affector = comm.ExecuteNonQuery
                MessageBox.Show("Access Controls have been updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call clearAll()
                saveType = ""
                userNameInput.Text = ""
                conn.Close()
            End If
        Else
            MsgBox("Please Choose a User Name")
        End If
    End Sub
End Class