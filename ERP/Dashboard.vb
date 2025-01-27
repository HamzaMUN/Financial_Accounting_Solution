Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration

Public Class Dashboard
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Public Property userNameGot As String
    Public Property fiscalYearIDGot As Integer
    'Access Controls Variables Declaration
    Dim a101 As String
    Dim a102 As String
    Dim a103 As String
    Dim a104 As String
    Dim a105 As String
    Dim a106 As String
    Dim a107 As String
    Dim a108 As String
    Dim a109 As String
    Dim a110 As String
    Dim a111 As String
    Dim a112 As String
    Dim a113 As String
    Dim a201 As String
    Dim a202 As String
    Dim a203 As String
    Dim a204 As String
    Dim a205 As String
    Dim a206 As String
    Dim a207 As String
    Dim a208 As String
    Dim a209 As String
    Dim a210 As String
    Dim a211 As String
    Dim a212 As String
    Dim a213 As String
    Dim a214 As String
    Dim a215 As String
    Dim a216 As String
    Dim a217 As String
    Dim a218 As String
    Dim a219 As String
    Dim a220 As String
    Dim a221 As String
    Dim a222 As String
    Dim a223 As String
    Dim a301 As String
    Dim a302 As String
    Dim a303 As String
    Dim a304 As String
    Dim a305 As String
    Dim a306 As String
    Dim a307 As String
    Dim a308 As String
    Dim a309 As String
    Dim a310 As String
    Dim a311 As String
    Dim a312 As String
    Dim a313 As String
    Dim a401 As String
    Dim a402 As String
    Dim a403 As String
    Dim a404 As String
    Dim a405 As String
    Dim a406 As String
    Dim a501 As String
    Dim a502 As String
    Dim a503 As String
    Dim a504 As String
    Dim a505 As String
    Dim a506 As String
    Dim a507 As String
    Dim a508 As String
    Dim a509 As String
    Dim a510 As String
    Dim a511 As String
    Dim a512 As String
    Dim a513 As String
    Dim a514 As String
    Dim a515 As String
    Dim a516 As String
    Dim a601 As String
    Dim a602 As String
    Dim a603 As String
    Dim a604 As String
    Dim a701 As String
    Dim a702 As String
    Dim a703 As String
    Dim a704 As String
    Dim a705 As String
    Dim a706 As String
    Dim a707 As String
    Dim a708 As String
    Dim a709 As String
    Dim a801 As String
    Dim a802 As String
    Dim a803 As String
    Dim a804 As String
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call userRights()
    End Sub

    Private Sub userRights()
        'Function to load user rights after login
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM accessControls WHERE userName = '" & userNameGot & "'", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                a101 = (reader(2).ToString)
                a102 = (reader(3).ToString)
                a103 = (reader(4).ToString)
                a104 = (reader(5).ToString)
                a105 = (reader(6).ToString)
                a106 = (reader(7).ToString)
                a107 = (reader(8).ToString)
                a108 = (reader(9).ToString)
                a109 = (reader(10).ToString)
                a110 = (reader(11).ToString)
                a111 = (reader(12).ToString)
                a112 = (reader(13).ToString)
                a113 = (reader(14).ToString)
                a201 = (reader(15).ToString)
                a202 = (reader(16).ToString)
                a203 = (reader(17).ToString)
                a204 = (reader(18).ToString)
                a205 = (reader(19).ToString)
                a206 = (reader(20).ToString)
                a207 = (reader(21).ToString)
                a208 = (reader(22).ToString)
                a209 = (reader(23).ToString)
                a210 = (reader(24).ToString)
                a211 = (reader(25).ToString)
                a212 = (reader(26).ToString)
                a213 = (reader(27).ToString)
                a214 = (reader(28).ToString)
                a215 = (reader(29).ToString)
                a216 = (reader(30).ToString)
                a217 = (reader(31).ToString)
                a218 = (reader(32).ToString)
                a219 = (reader(33).ToString)
                a220 = (reader(34).ToString)
                a221 = (reader(35).ToString)
                a222 = (reader(36).ToString)
                a223 = (reader(37).ToString)
                a301 = (reader(38).ToString)
                a302 = (reader(39).ToString)
                a303 = (reader(40).ToString)
                a304 = (reader(41).ToString)
                a305 = (reader(42).ToString)
                a306 = (reader(43).ToString)
                a307 = (reader(44).ToString)
                a308 = (reader(45).ToString)
                a309 = (reader(46).ToString)
                a310 = (reader(47).ToString)
                a311 = (reader(48).ToString)
                a312 = (reader(49).ToString)
                a313 = (reader(50).ToString)
                a401 = (reader(51).ToString)
                a402 = (reader(52).ToString)
                a403 = (reader(53).ToString)
                a404 = (reader(54).ToString)
                a405 = (reader(55).ToString)
                a406 = (reader(56).ToString)
                a501 = (reader(57).ToString)
                a502 = (reader(58).ToString)
                a503 = (reader(59).ToString)
                a504 = (reader(60).ToString)
                a505 = (reader(61).ToString)
                a506 = (reader(62).ToString)
                a507 = (reader(63).ToString)
                a508 = (reader(64).ToString)
                a509 = (reader(65).ToString)
                a510 = (reader(66).ToString)
                a511 = (reader(67).ToString)
                a512 = (reader(68).ToString)
                a513 = (reader(69).ToString)
                a514 = (reader(70).ToString)
                a515 = (reader(71).ToString)
                a516 = (reader(72).ToString)
                a601 = (reader(73).ToString)
                a602 = (reader(74).ToString)
                a603 = (reader(75).ToString)
                a604 = (reader(76).ToString)
                a701 = (reader(77).ToString)
                a702 = (reader(78).ToString)
                a703 = (reader(79).ToString)
                a704 = (reader(80).ToString)
                a705 = (reader(81).ToString)
                a706 = (reader(82).ToString)
                a707 = (reader(83).ToString)
                a708 = (reader(84).ToString)
                a709 = (reader(85).ToString)
                a801 = (reader(86).ToString)
                a802 = (reader(87).ToString)
                a803 = (reader(88).ToString)
                a804 = (reader(89).ToString)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        conn.Close()
    End Sub

    '***Tray Icon Tool Strip***'

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        about.Show()
    End Sub

    Private Sub VisitWebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitWebsiteToolStripMenuItem.Click
        Dim websiteURL As String = "http://www.hexagonsolutionz.com"
        Process.Start(websiteURL)
    End Sub

    Private Sub EmailThehexagonsolutionsgmailcomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailThehexagonsolutionsgmailcomToolStripMenuItem.Click
        Dim mailURL As String = "mailto:hexagonsolutionz@yahoo.com"
        Process.Start(mailURL)
    End Sub

    '***Settings***'

    Private Sub RibbonOrbOptionButton1_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbOptionButton1.Click
        'Log Off Button Click Event
        LoginForm.Show()
        LoginForm.usernameInput.Text = userNameGot
        LoginForm.passwordInput.Focus()
        Me.Hide()
    End Sub

    Private Sub RibbonOrbMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbMenuItem1.Click
        'New User Button Click Event
        If a801 = 1 Then
            newUser.ShowDialog()
        End If
    End Sub

    Private Sub RibbonOrbMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbMenuItem2.Click
        'Change Password Button Click Event
        If a802 = 1 Then
            changePassword.ShowDialog()
        End If
    End Sub

    Private Sub RibbonOrbMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbMenuItem3.Click
        'Access Controls Button Click Event
        If a803 = 1 Then
            accessControls.ShowDialog()
        End If
    End Sub

    Private Sub RibbonOrbMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbMenuItem4.Click
        'Database Backup Button Click Event
        If a804 = 1 Then
            dbBackup.ShowDialog()
        End If
    End Sub

    Private Sub RibbonOrbMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles RibbonOrbMenuItem5.Click
        'About Button Click Event
        about.ShowDialog()
    End Sub

    '***Setup***'

    Private Sub RibbonButton67_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton67.Click
        'Level 1 Group Accounts Creation
        If a101 = 1 Then
            acL1.Show()
        End If
    End Sub

    Private Sub RibbonButton68_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton68.Click
        'Level 2 Control Accounts Creation
        If a102 = 1 Then
            acL2.Show()
        End If
    End Sub

    Private Sub RibbonButton69_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton69.Click
        'Level 3 Chart of Accounts Creation
        If a103 = 1 Then
            acL3.Show()
        End If
    End Sub

    Private Sub RibbonButton70_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton70.Click
        'Subsidiary Accounts Creation
        If a104 = 1 Then
            subCreation.Show()
        End If
    End Sub

    Private Sub RibbonButton71_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton71.Click
        'Cost Centres Creation
        If a105 = 1 Then
            costCentres.Show()
        End If
    End Sub

    Private Sub RibbonButton72_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton72.Click
        'Batch Creation
        If a106 = 1 Then
            batch.userNameGot = userNameGot
            batch.Show()
        End If
    End Sub

    Private Sub RibbonButton73_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton73.Click
        'Accounts Assigning
        If a107 = 1 Then
            acAssign.Show()
        End If
    End Sub

    Private Sub RibbonButton74_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton74.Click
        'Area Creation
        If a108 = 1 Then
            area.Show()
        End If
    End Sub

    Private Sub RibbonButton75_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton75.Click
        'Sub Area Creation
        If a109 = 1 Then
            subArea.Show()
        End If
    End Sub

    Private Sub RibbonButton76_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton76.Click
        'Sales Personnel Creation
        If a110 = 1 Then
            salesPersonnel.Show()
        End If
    End Sub

    Private Sub RibbonButton77_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton77.Click
        'Product Category Creation
        If a111 = 1 Then
            productCategory.Show()
        End If
    End Sub

    Private Sub RibbonButton78_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton78.Click
        'Product Details Creation
        If a112 = 1 Then
            productDetail.Show()
        End If
    End Sub

    Private Sub RibbonButton79_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton79.Click
        'Customers Rate Agreements

    End Sub

    '***Data Entry***'

    Private Sub RibbonButton49_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton49.Click
        'Purchase Request
        'If a201 = 1 Then
        '    purchaseRequest.Show()
        'End If
    End Sub

    Private Sub RibbonButton50_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton50.Click
        'Purchase Order
        'If a202 = 1 Then
        '    purchaseOrder.Show()
        'End If
    End Sub

    Private Sub RibbonButton51_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton51.Click
        'Store Inward / GRN
        'If a203 = 1 Then
        '    grn.userNameGot = userNameGot
        '    grn.fiscalYearIDGot = fiscalYearIDGot
        '    grn.a219 = a219
        '    grn.a220 = a220
        '    grn.a221 = a221
        '    grn.a222 = a222
        '    grn.a223 = a223
        '    grn.Show()
        'End If
    End Sub

    Private Sub RibbonButton52_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton52.Click
        'Purchase Invoice
        'If a204 = 1 Then
        '    purchaseInvoice.userNameGot = userNameGot
        '    purchaseInvoice.fiscalYearIDGot = fiscalYearIDGot
        '    purchaseInvoice.a219 = a219
        '    purchaseInvoice.a220 = a220
        '    purchaseInvoice.a221 = a221
        '    purchaseInvoice.a222 = a222
        '    purchaseInvoice.a223 = a223
        '    purchaseInvoice.Show()
        'End If
    End Sub

    Private Sub RibbonButton53_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton53.Click
        'Store Outward / Purchase Return
        'If a205 = 1 Then
        '    storeOutward.userNameGot = userNameGot
        '    storeOutward.fiscalYearIDGot = fiscalYearIDGot
        '    storeOutward.a219 = a219
        '    storeOutward.a220 = a220
        '    storeOutward.a221 = a221
        '    storeOutward.a222 = a222
        '    storeOutward.a223 = a223
        '    storeOutward.Show()
        'End If
    End Sub

    Private Sub RibbonButton54_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton54.Click
        'Purchase Return Invoice
        'If a206 = 1 Then
        '    purchaseReturnInvoice.userNameGot = userNameGot
        '    purchaseReturnInvoice.fiscalYearIDGot = fiscalYearIDGot
        '    purchaseReturnInvoice.a219 = a219
        '    purchaseReturnInvoice.a220 = a220
        '    purchaseReturnInvoice.a221 = a221
        '    purchaseReturnInvoice.a222 = a222
        '    purchaseReturnInvoice.a223 = a223
        '    purchaseReturnInvoice.Show()
        'End If
    End Sub

    Private Sub RibbonButton55_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton55.Click
        'Inventory Issue Note to Work in Process
        'If a207 = 1 Then
        '    inventoryIssueWIP.Show()
        'End If
    End Sub

    Private Sub RibbonButton56_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton56.Click
        'Stock Transfer / Production
        'If a208 = 1 Then
        '    stockTransferProduction.Show()
        'End If
    End Sub

    Private Sub RibbonButton57_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton57.Click
        'Sales Delivery Challan
        'If a209 = 1 Then
        '    sdc.Show()
        'End If
    End Sub

    Private Sub RibbonButton58_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton58.Click
        'Sales Invoice
        'If a210 = 1 Then
        '    sjv.Show()
        'End If
    End Sub

    Private Sub RibbonButton59_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton59.Click
        'Sales Return Challan
        'If a211 = 1 Then
        '    src.Show()
        'End If
    End Sub

    Private Sub RibbonButton60_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton60.Click
        'Sales Return Invoice
        'If a212 = 1 Then
        '    sri.Show()
        'End If
    End Sub

    Private Sub RibbonButton61_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton61.Click
        'Stock Transfer Note
        'If a213 = 1 Then
        '    stn.Show()
        'End If
    End Sub

    Private Sub RibbonButton62_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton62.Click
        'Journal Voucher
        If a214 = 1 Then
            jv.userNameGot = userNameGot
            jv.fiscalYearIDGot = fiscalYearIDGot
            jv.a219 = a219
            jv.a220 = a220
            jv.a221 = a221
            jv.a222 = a222
            jv.a223 = a223
            jv.Show()
        End If
    End Sub

    Private Sub RibbonButton63_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton63.Click
        'Bank Receipts Voucher
        If a215 = 1 Then
            brv.userNameGot = userNameGot
            brv.fiscalYearIDGot = fiscalYearIDGot
            brv.a219 = a219
            brv.a220 = a220
            brv.a221 = a221
            brv.a222 = a222
            brv.a223 = a223
            brv.Show()
        End If
    End Sub

    Private Sub RibbonButton64_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton64.Click
        'Bank Payment Voucher
        If a216 = 1 Then
            bpv.userNameGot = userNameGot
            bpv.fiscalYearIDGot = fiscalYearIDGot
            bpv.a219 = a219
            bpv.a220 = a220
            bpv.a221 = a221
            bpv.a222 = a222
            bpv.a223 = a223
            bpv.Show()
        End If
    End Sub

    Private Sub RibbonButton65_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton65.Click
        'Cash Receipt Voucher
        If a217 = 1 Then
            crv.userNameGot = userNameGot
            crv.fiscalYearIDGot = fiscalYearIDGot
            crv.a219 = a219
            crv.a220 = a220
            crv.a221 = a221
            crv.a222 = a222
            crv.a223 = a223
            crv.Show()
        End If
    End Sub

    Private Sub RibbonButton66_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton66.Click
        'Cash Payment Voucher
        If a218 = 1 Then
            cpv.userNameGot = userNameGot
            cpv.fiscalYearIDGot = fiscalYearIDGot
            cpv.a219 = a219
            cpv.a220 = a220
            cpv.a221 = a221
            cpv.a222 = a222
            cpv.a223 = a223
            cpv.Show()
        End If
    End Sub

    '***Financial Reports***'

    Private Sub RibbonButton36_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton36.Click
        'Chart of Accounts Report
        If a301 = 1 Then
            coaReport1.fiscalYearIDGot = fiscalYearIDGot
            coaReport1.Show()
        End If
    End Sub

    Private Sub RibbonButton37_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton37.Click
        'Chart of Accounts Ledger
        If a302 = 1 Then
            coaLedger.fiscalYearIDGot = fiscalYearIDGot
            coaLedger.Show()
        End If
    End Sub

    Private Sub RibbonButton38_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton38.Click
        'Trial Balances in Summary
        If a303 = 1 Then
            trialSummary.fiscalYearIDGot = fiscalYearIDGot
            trialSummary.Show()
        End If
    End Sub

    Private Sub RibbonButton39_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton39.Click
        'Trial Balances in Detail
        If a304 = 1 Then
            trialDetails.fiscalYearIDGot = fiscalYearIDGot
            trialDetails.Show()
        End If
    End Sub

    Private Sub RibbonButton40_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton40.Click
        'Subsidiary Activity
        If a305 = 1 Then
            subsidiaryActivity.fiscalYearIDGot = fiscalYearIDGot
            subsidiaryActivity.Show()
        End If
    End Sub

    Private Sub RibbonButton41_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton41.Click
        'Subsidiary Ledgers
        If a306 = 1 Then
            subLedger.fiscalYearIDGot = fiscalYearIDGot
            subLedger.Show()
        End If
    End Sub

    Private Sub RibbonButton42_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton42.Click
        'Area Based Customers Activity
        'If a307 = 1 Then

        'End If
    End Sub

    Private Sub RibbonButton43_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton43.Click
        'Chart of Accounts Ledgers in Range
        If a308 = 1 Then
            coaLedgerRange.fiscalYearIDGot = fiscalYearIDGot
            coaLedgerRange.Show()
        End If
    End Sub

    Private Sub RibbonButton44_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton44.Click
        'Chart of Accounts Wise Subsidiary Ledgers
        If a309 = 1 Then
            coaWSubLedger.fiscalYearIDGot = fiscalYearIDGot
            coaWSubLedger.Show()
        End If
    End Sub

    Private Sub RibbonButton45_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton45.Click
        'Subsidiary Ledgers Wise Chart of Accounts
        If a310 = 1 Then
            subWCoaLedger.fiscalYearIDGot = fiscalYearIDGot
            subWCoaLedger.Show()
        End If
    End Sub

    Private Sub RibbonButton46_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton46.Click
        'Statement of Comprehensive Income
        'If a311 = 1 Then

        'End If
    End Sub

    Private Sub RibbonButton47_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton47.Click
        'Statement of Financial Position
        'If a312 = 1 Then

        'End If
    End Sub

    Private Sub RibbonButton48_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton48.Click
        'Statement of Cash Flows
        'If a313 = 1 Then

        'End If
    End Sub

    '***Stock Reports***'

    Private Sub RibbonButton30_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton30.Click
        'Products Listing

    End Sub

    Private Sub RibbonButton31_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton31.Click
        'Products Stock Ledger

    End Sub

    Private Sub RibbonButton32_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton32.Click
        'Products Current Stock

    End Sub

    Private Sub RibbonButton33_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton33.Click
        'Batch Wise Stock Ledger

    End Sub

    Private Sub RibbonButton34_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton34.Click
        'Batch Wise Current Stock

    End Sub

    Private Sub RibbonButton35_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton35.Click
        'Production Analysis

    End Sub

    '***Other Reports***'

    Private Sub RibbonButton14_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton14.Click
        'Product Wise Purchase Reports

    End Sub

    Private Sub RibbonButton15_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton15.Click
        'Supplier Wise Purchase Reports

    End Sub

    Private Sub RibbonButton16_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton16.Click
        'Products based Sales Reports

    End Sub

    Private Sub RibbonButton17_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton17.Click
        'Area based Sales Reports

    End Sub

    Private Sub RibbonButton18_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton18.Click
        'Sub Area based Sales Reports

    End Sub

    Private Sub RibbonButton19_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton19.Click
        'Area based Customers Wise Sales Reports

    End Sub

    Private Sub RibbonButton20_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton20.Click
        'Salesman based Sales Reports

    End Sub

    Private Sub RibbonButton21_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton21.Click
        'Products based Monthly Sales Comparison Reports

    End Sub

    Private Sub RibbonButton22_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton22.Click
        'Customers Monthly Sales Comparison Reports

    End Sub

    Private Sub RibbonButton23_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton23.Click
        'Area based Monthly Sales Comparison Reports

    End Sub

    Private Sub RibbonButton24_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton24.Click
        'Sub Area based Monthly Sales Comparison Reports

    End Sub

    Private Sub RibbonButton25_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton25.Click
        'Salesman based Monthly Sales Comparison Reports

    End Sub

    Private Sub RibbonButton26_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton26.Click
        'Products based Profitability Reports

    End Sub

    Private Sub RibbonButton27_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton27.Click
        'Area based Profitability Reports
    End Sub

    Private Sub RibbonButton28_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton28.Click
        'Sub Area based Profitability Reports

    End Sub

    Private Sub RibbonButton29_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton29.Click
        'Salesman based Profitability Reports

    End Sub

    '***Vouchers Listing***'

    Private Sub RibbonButton10_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton10.Click
        'Purchase Invoice List

    End Sub

    Private Sub RibbonButton11_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton11.Click
        'Purchase Return Invoice List

    End Sub

    Private Sub RibbonButton12_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton12.Click
        'Sales Invoice List

    End Sub

    Private Sub RibbonButton13_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton13.Click
        'Sales Return Invoice List

    End Sub

    '***Business Registers***'

    Private Sub RibbonButton1_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton1.Click
        'Store Inward Register

    End Sub

    Private Sub RibbonButton2_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton2.Click
        'Purchase Register

    End Sub

    Private Sub RibbonButton3_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton3.Click
        'Purchase Return Register

    End Sub

    Private Sub RibbonButton4_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton4.Click
        'Inventory Issued Register

    End Sub

    Private Sub RibbonButton5_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton5.Click
        'Production Register

    End Sub

    Private Sub RibbonButton7_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton7.Click
        'Delivery Challan Register

    End Sub

    Private Sub RibbonButton8_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton8.Click
        'Sales Invoice Register

    End Sub

    Private Sub RibbonButton9_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton9.Click
        'Sales Return Invoice Register

    End Sub

    Private Sub RibbonButton6_Click(sender As System.Object, e As System.EventArgs) Handles RibbonButton6.Click
        'Customers Rate Agreements Register

    End Sub

End Class