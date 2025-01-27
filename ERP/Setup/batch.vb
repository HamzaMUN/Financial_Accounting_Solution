Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class batch
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim conn2 As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim saveType As String
    Dim codeGot As Integer
    Dim inputVal1 As Integer
    Dim productIDGot1 As Integer
    Dim productNameGot1 As String
    Public Property userNameGot As String
    Dim batchStatusGen1 As Char
    Dim batchCodeGen1 As Integer

    Private Sub batch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Default onLoad Function
        Call loadRecordsAll()
    End Sub

    Private Sub loadRecordsAll()
        'Load Records from Database
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM batch ORDER BY batchID ASC", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(2).ToString)
                listShowAll.SubItems.Add(reader(3).ToString)
                productIDGot1 = (reader(3).ToString) ' Product id from batch table

                'Load Product Name from Products Table
                Try
                    conn2 = New SqlConnection(constr)
                    conn2.Open()
                    comm2 = New SqlCommand("SELECT * FROM ProductDetail WHERE productID = '" & productIDGot1 & "' ", conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True
                        productNameGot1 = (reader2(2).ToString)
                    Loop
                    conn2.Close()
                    listShowAll.SubItems.Add(productNameGot1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                ' Manufacturing Date
                Dim manufacturingDateGot1 As Date = (reader(4).ToString)
                Dim manufacturingDateGot2 As String = String.Format("{0:dd-MMMM-yyyy}", manufacturingDateGot1)
                listShowAll.SubItems.Add(manufacturingDateGot2)

                'Expiry Date
                Dim expiryDateGot1 As Date = (reader(5).ToString)
                Dim expiryDateGot2 As String = String.Format("{0:dd-MMMM-yyyy}", expiryDateGot1)
                listShowAll.SubItems.Add(expiryDateGot2)

                listShowAll.SubItems.Add(reader(6).ToString)
                listShowAll.SubItems.Add(reader(7).ToString)
                listShowAll.SubItems.Add(reader(8).ToString)
                listShowAll.SubItems.Add(reader(9).ToString)
                listShowAll.SubItems.Add(reader(10).ToString)
                listShowAll.SubItems.Add(reader(11).ToString)

                'Batch Status Load
                Dim batchStatusGot1 As String
                batchStatusGot1 = (reader(13).ToString)
                If batchStatusGot1 = "A" Then
                    listShowAll.SubItems.Add("ACTIVE")
                ElseIf batchStatusGot1 = "I" Then
                    listShowAll.SubItems.Add("INACTIVE")
                End If
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub clearInputsAll()
        'Clear All Input Fields
        batchNoInput.Text = Nothing
        productIDInput.Text = Nothing
        theoreticalYieldInput.Text = Nothing
        practcalYieldInput.Text = Nothing
        yieldPercentageInput.Text = Nothing
        qcInchargeInput.Text = Nothing
        productionInchargeInput.Text = Nothing
        productionSupervisorInput.Text = Nothing
        statusInput.Text = Nothing
        codeGot = Nothing
        batchCodeGen1 = Nothing
        batchStatusGen1 = Nothing
    End Sub

    Private Sub lockInputsAll()
        'Make all input fields read only
        batchNoInput.ReadOnly = True
        productIDInput.ReadOnly = True
        theoreticalYieldInput.ReadOnly = True
        practcalYieldInput.ReadOnly = True
        yieldPercentageInput.ReadOnly = True
        qcInchargeInput.ReadOnly = True
        productionInchargeInput.ReadOnly = True
        productionSupervisorInput.ReadOnly = True
    End Sub
    Private Sub unLockInputsAll()
        'Make all input fields read only to false
        batchNoInput.ReadOnly = False
        productIDInput.ReadOnly = False
        theoreticalYieldInput.ReadOnly = False
        practcalYieldInput.ReadOnly = False
        yieldPercentageInput.ReadOnly = False
        qcInchargeInput.ReadOnly = False
        productionInchargeInput.ReadOnly = False
        productionSupervisorInput.ReadOnly = False
        statusInput.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit Menu Strip
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Save Menu Strip
        If batchNoInput.Text = "" Then
            MsgBox("Please Enter a Valid Batch No.")
            batchNoInput.Focus()
        ElseIf statusInput.Text = "" Then
            MsgBox("Please Select Batch Status")
            statusInput.Focus()
        ElseIf productIDInput.Text = "" Then
            MsgBox("Please Select a Product")
            productIDInput.Focus()
        ElseIf productIDInput.Text < 100001 Or productIDInput.Text > 999999 Then
            MsgBox("Please Enter a Valid Code (100001 to 999999)")
            productIDInput.Focus()
        ElseIf theoreticalYieldInput.Text = "" Then
            MsgBox("Please Enter a Valid Theoretical Yield")
            theoreticalYieldInput.Focus()
        ElseIf practcalYieldInput.Text = "" Then
            MsgBox("Please Enter a Valid Practical Yield")
            practcalYieldInput.Focus()
        ElseIf yieldPercentageInput.Text = "" Or yieldPercentageInput.Text < 0 Or yieldPercentageInput.Text > 100 Then
            MsgBox("Please Enter a Valid Yield (%)")
            yieldPercentageInput.Focus()
        ElseIf qcInchargeInput.Text = "" Then
            MsgBox("Please Enter a Valid QC In-Charge")
            qcInchargeInput.Focus()
        ElseIf productionInchargeInput.Text = "" Then
            MsgBox("Please Enter a Valid Production In-Charge")
            productionInchargeInput.Focus()
        ElseIf productionSupervisorInput.Text = "" Then
            MsgBox("Please Enter a Valid Production Supervisor")
            productionSupervisorInput.Focus()
        Else
            Try
                'converting batch status value
                If statusInput.Text = "ACTIVE" Then
                    batchStatusGen1 = "A"
                ElseIf statusInput.Text = "INACTIVE" Then
                    batchStatusGen1 = "I"
                End If
                If saveType = "new" Then
                    'generating batch no. for backend
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        'SQL Validation for duplicate record
                        Dim valcommand2 As New SqlCommand("SELECT * FROM batch", conn)
                        Dim valadapter2 As New SqlDataAdapter(valcommand2)
                        Dim valtable2 As New DataTable()
                        valadapter2.Fill(valtable2)
                        Dim tempBatchCode As Integer = 0
                        If valtable2.Rows.Count() > 0 Then
                            conn = New SqlConnection(constr)
                            conn.Open()
                            comm = New SqlCommand("SELECT TOP 1 batchCode FROM batch ORDER BY batchCode DESC", conn)
                            reader = comm.ExecuteReader
                            Do While reader.Read = True 'Loop to load data realtime
                                tempBatchCode = (reader(0).ToString)
                            Loop
                            conn.Close()
                        Else
                            tempBatchCode = 100000
                        End If
                        conn.Close()
                        batchCodeGen1 = tempBatchCode + 1
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM batch WHERE batchName = @input1got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = batchNoInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO batch(batchCode, batchName, productID, manufacturingDate, expiryDate, theoreticalYield, practicalYield, yieldPercentage, qcIncharge, productionIncharge, productionSupervisor, postedBy, status) VALUES ('" & batchCodeGen1 & "' , '" & batchNoInput.Text & "' , '" & productIDInput.Text & "', '" & manufacturingDateInput.Text & "', '" & expiryDateInput.Text & "', '" & theoreticalYieldInput.Text & "', '" & practcalYieldInput.Text & "', '" & yieldPercentageInput.Text & "', '" & qcInchargeInput.Text & "', '" & productionInchargeInput.Text & "', '" & productionSupervisorInput.Text & "', '" & userNameGot & "', '" & batchStatusGen1 & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call clearInputsAll()
                        Call lockInputsAll()
                        'Reload records on new entry
                        Call loadRecordsAll()
                    Else
                        MsgBox("Record already exist!")
                    End If
                    conn.Close()
                ElseIf saveType = "update" Then
                    'Update existing record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("UPDATE batch SET batchName = '" & batchNoInput.Text & "', productID = '" & productIDInput.Text & "', manufacturingDate = '" & manufacturingDateInput.Text & "', expiryDate = '" & expiryDateInput.Text & "', theoreticalYield = '" & theoreticalYieldInput.Text & "', practicalYield = '" & practcalYieldInput.Text & "', yieldPercentage = '" & yieldPercentageInput.Text & "', qcIncharge = '" & qcInchargeInput.Text & "', productionIncharge = '" & productionInchargeInput.Text & "', productionSupervisor = '" & productionSupervisorInput.Text & "', postedBy = '" & userNameGot & "', status = '" & batchStatusGen1 & "' WHERE batchID = '" & codeGot & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    Call clearInputsAll()
                    Call loadRecordsAll()
                    saveType = ""
                    Call lockInputsAll()
                Else
                    MsgBox("Please Click New or Select Edit an Existing Record")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'New Menu Strip
        Call clearInputsAll()
        Call unLockInputsAll()
        saveType = "new"
        batchNoInput.Focus()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        'Edit Menu Strip
        If ListView1.SelectedItems.Count > 0 Then
            codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
            batchNoInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            Call unLockInputsAll()
            batchNoInput.Focus()
            productIDInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
            productNameInput.Text = ListView1.FocusedItem.SubItems.Item(3).Text
            manufacturingDateInput.Value = ListView1.FocusedItem.SubItems.Item(4).Text
            expiryDateInput.Value = ListView1.FocusedItem.SubItems.Item(5).Text
            theoreticalYieldInput.Text = ListView1.FocusedItem.SubItems.Item(6).Text
            practcalYieldInput.Text = ListView1.FocusedItem.SubItems.Item(7).Text
            yieldPercentageInput.Text = ListView1.FocusedItem.SubItems.Item(8).Text
            qcInchargeInput.Text = ListView1.FocusedItem.SubItems.Item(9).Text
            productionInchargeInput.Text = ListView1.FocusedItem.SubItems.Item(10).Text
            productionSupervisorInput.Text = ListView1.FocusedItem.SubItems.Item(11).Text

            'Status for Batch
            Dim statusBatchGot2 As Char
            statusBatchGot2 = ListView1.FocusedItem.SubItems.Item(12).Text
            If statusBatchGot2 = "A" Then
                statusInput.Text = "ACTIVE"
            ElseIf statusBatchGot2 = "I" Then
                statusInput.Text = "INACTIVE"
            End If
            saveType = "update"
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'Delete Menu Strip
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Validation for child records in Level 3
        'Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
        'Dim valadapter1 As New SqlDataAdapter(valcommand1)
        'Dim valtable1 As New DataTable()
        'valadapter1.Fill(valtable1)
        'If valtable1.Rows.Count() <= 0 Then
        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
        If delresponse = MsgBoxResult.Yes Then
            comm = New SqlCommand("DELETE FROM batch WHERE batchID = '" & codeGot & "' ", conn)
            affector = comm.ExecuteNonQuery
            Call clearInputsAll()
            Call lockInputsAll()
            MessageBox.Show("Record Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            saveType = ""
            'Reload records on new entry
            Call loadRecordsAll()
        Else
            Call loadRecordsAll()
        End If
        'Else
        '    MsgBox("Access Denied! Please Delete Linked Records First.")
        'End If
        conn.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Perform Save Menu Strip Function on Save Button Click
        SaveToolStripMenuItem.PerformClick()
    End Sub

    'Search Products Function on Enter Key Down Event
    Private Sub productIDInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles productIDInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If productIDInput.ReadOnly = False Then
                Call searchQ1()
            End If
        End If
    End Sub

    Private Sub searchQ1()
        searchProduct.searchKeywordGot = productIDInput.Text
        searchProduct.parentFormGot = "batch"
        searchProduct.Show()
    End Sub

End Class