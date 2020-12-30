'Registration form
Imports System.Data.OleDb

Public Class frm_EmployeeRegistration

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Hide()
    End Sub
    'Submit Button
    Private Sub btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Submit.Click


        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\Happy Cakes Cake Shop.accdb")
            conn.Open()

            Dim Query As String = "INSERT INTO Mst_EmployeeRegistration(emp_Id,emp_FirstName,emp_MiddleName,emp_LastName,emp_Gender,emp_ContactNo,emp_Email,emp_Address,emp_Designation,emp_UserName,emp_Password) VALUES(" & txt_ID.Text & ",'" & txt_FirstName.Text & "','" & txt_MiddleName.Text & "','" & txt_LastName.Text & "','" & cmb_Gender.Text & "','" & txt_ContactNo.Text & "','" & txt_Email.Text & "','" & txt_Address.Text & "','" & cmb_Designation.Text & "','" & txt_UserName.Text & "','" & txt_Password.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(Query, conn)

            Dim a As Integer = cmd.ExecuteNonQuery()

            MsgBox(a & "Record inserted")
            Clean()
        Catch ex As Exception
            MsgBox("Error in Insertion")
        End Try
    End Sub
    'Serach Button
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\Happy Cakes Cake Shop.accdb")
            conn.Open()

            Dim Query As String = "SELECT*FROM Mst_EmployeeRegistration WHERE emp_Id=" & txt_ID.Text & ""

            Dim adp As OleDbDataAdapter = New OleDbDataAdapter(Query, conn)

            Dim dt As DataTable = New DataTable()

            adp.Fill(dt)

            conn.Close()

            txt_FirstName.Text = dt.Rows(0)(1).ToString
            txt_MiddleName.Text = dt.Rows(0)(2).ToString
            txt_LastName.Text = dt.Rows(0)(3).ToString
            cmb_Gender.Text = dt.Rows(0)(4).ToString
            txt_ContactNo.Text = dt.Rows(0)(5).ToString
            txt_Email.Text = dt.Rows(0)(6).ToString
            txt_Address.Text = dt.Rows(0)(7).ToString
            cmb_Designation.Text = dt.Rows(0)(8).ToString
            txt_UserName.Text = dt.Rows(0)(9).ToString
            txt_Password.Text = dt.Rows(0)(10).ToString
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    'Update Button
    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\Happy Cakes Cake Shop.accdb")
            conn.Open()

            Dim Query As String = "UPDATE Mst_EmployeeRegistration SET emp_FirstName='" & txt_FirstName.Text & "',emp_MiddleName='" & txt_MiddleName.Text & "',emp_LastName='" & txt_LastName.Text & "',emp_Gender='" & cmb_Gender.Text & "',emp_ContactNo='" & txt_ContactNo.Text & "',emp_Email='" & txt_Email.Text & "',emp_Address='" & txt_Address.Text & "',emp_Designation='" & cmb_Designation.Text & "',emp_UserName='" & txt_UserName.Text & "',emp_Password='" & txt_Password.Text & "'WHERE emp_Id=" & txt_ID.Text & ""

            Dim cmd As OleDbCommand = New OleDbCommand(Query, conn)

            Dim a As Integer = cmd.ExecuteNonQuery()

            MsgBox(a & "Updated")
            Clean()
        Catch ex As Exception
            MsgBox("Error in Updation")
        End Try
    End Sub
    'Delete Button
    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\Happy Cakes Cake Shop.accdb")
            conn.Open()

            Dim Query As String = "DELETE FROM Mst_EmployeeRegistration WHERE emp_Id=" & txt_ID.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(Query, conn)

            Dim a As Integer = cmd.ExecuteNonQuery()

            MsgBox(a & "Record Deleted")
            Clean()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    'Reset Button
    Private Sub btn_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        Clean()
    End Sub
    Public Sub Clean()
        txt_ID.Text = ""
        txt_FirstName.Text = ""
        txt_MiddleName.Text = ""
        txt_LastName.Text = ""
        cmb_Gender.SelectedIndex = -1
        txt_Email.Text = ""
        txt_Address.Text = ""
        txt_ContactNo.Text = ""
        cmb_Designation.Text = ""
        txt_UserName.Text = ""
        txt_Password.Text = ""
    End Sub


    Private Sub frm_EmployeeRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class