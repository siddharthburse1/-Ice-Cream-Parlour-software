'LogIn form
Imports System.Data.OleDb
Public Class frm_LogIn
    'Cancel Button
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
    'SignIn Button
    Private Sub btn_SignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SignIn.Click
        'Step 1 : Connection establish

        Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\Happy Cakes Cake Shop.accdb")

        'Step 2 : Open Connection
        conn.Open()

        'Step 3 : Command Execution
        Dim Query As String = "SELECT * FROM Mst_EmployeeRegistration WHERE emp_UserName='" & txt_UserName.Text & "'"

        Dim adp As OleDbDataAdapter = New OleDbDataAdapter(Query, conn)

        Dim dt As DataTable = New DataTable()

        adp.Fill(dt)

        conn.Close()

        Dim UserName As String = txt_UserName.Text
        Dim Password As String = txt_Password.Text
        Dim dtUserName As String = dt.Rows(0)(9).ToString
        Dim dtPassword As String = dt.Rows(0)(10).ToString

        If ((String.Compare(UserName, dtUserName) = 0) And (String.Compare(Password, dtPassword) = 0)) Then
            MsgBox("Log-In Successfull")
            MDI_AMS.Show()
            Me.Hide()
        Else
            MsgBox("Try Again")

        End If
    End Sub
    'Register Now Button
    Private Sub btn_RegisterNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RegisterNow.Click
        frm_EmployeeRegistration.Show()
    End Sub
End Class
