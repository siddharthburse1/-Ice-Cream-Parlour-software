'Customer Details Form
Imports System.Data.OleDb
Public Class frm_CustomerPurchace

    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False



    Private Sub btn_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu.Click
        Me.Hide()
    End Sub

    Private Sub frm_CustomerPurchace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\customer purchases.accdb")
            conn.Open()

            Dim Query As String = "SELECT*FROM Mst_CustomerPurchases WHERE cust_Id=" & txt_Id.Text & ""

            Dim adp As OleDbDataAdapter = New OleDbDataAdapter(Query, conn)

            Dim dt As DataTable = New DataTable()

            adp.Fill(dt)

            conn.Close()

            txt_FirstName.Text = dt.Rows(0)(1).ToString
            txt_MiddleName.Text = dt.Rows(0)(2).ToString
            txt_LastName.Text = dt.Rows(0)(3).ToString
            txt_CakeType.Text = dt.Rows(0)(4).ToString
            txt_CakeFlavour.Text = dt.Rows(0)(5).ToString
            txt_CakeQuantity.Text = dt.Rows(0)(6).ToString
            txt_CakePrice.Text = dt.Rows(0)(7).ToString
            txt_Total.Text = dt.Rows(0)(8).ToString
            dt_Today.Text = dt.Rows(0)(9).ToString
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\customer purchases.accdb")
            conn.Open()

            Dim Query As String = "DELETE FROM Mst_CustomerPurchases WHERE cust_Id=" & txt_Id.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(Query, conn)

            Dim a As Integer = cmd.ExecuteNonQuery()

            MsgBox(a & "Record Deleted")
            Clean()
        Catch ex As Exception
            MsgBox("Error in Insertion")
        End Try

    End Sub

    Private Sub btn_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        clean()
    End Sub
    Public Sub Clean()
        txt_Id.Text = ""
        txt_FirstName.Text = ""
        txt_MiddleName.Text = ""
        txt_LastName.Text = ""
        txt_CakeType.Text = ""
        txt_CakeFlavour.Text = ""
        txt_CakeQuantity.Text = ""
        txt_CakePrice.Text = ""
        txt_Total.Text = ""
        dt_Today.Text = ""
    End Sub


    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bill.Click
        frm_BillGeneration.Show()
    End Sub

    Private Sub btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Submit.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mini project\database\customer purchases.accdb")
            conn.Open()

            Dim Query As String = "INSERT INTO Mst_CustomerPurchases(cust_Id,cust_FirstName,cust_MiddleName,cust_LastName,cust_CakeType,cust_CakeFlavour,cust_CakeQuantity,cust_CakePrice,cust_Total,cust_Date) VALUES(" & txt_Id.Text & ",'" & txt_FirstName.Text & "','" & txt_MiddleName.Text & "','" & txt_LastName.Text & "','" & txt_CakeType.Text & "','" & txt_CakeFlavour.Text & "','" & txt_CakeQuantity.Text & "','" & txt_CakePrice.Text & "','" & txt_Total.Text & "','" & dt_Today.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(Query, conn)

            Dim a As Integer = cmd.ExecuteNonQuery()

            MsgBox(a & "Record inserted")
            Clean()
        Catch ex As Exception
            MsgBox("Error in Insertion")

        End Try

    End Sub

    Private Sub btn_One_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_One.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "1"
        Else
            txt_Display.Text = "1"
        End If

    End Sub

    Private Sub btn_Two_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Two.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "2"
        Else
            txt_Display.Text = "2"
        End If

    End Sub

    Private Sub btn_Three_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Three.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "3"
        Else
            txt_Display.Text = "3"
        End If

    End Sub

    Private Sub btn_Four_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Four.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "4"
        Else
            txt_Display.Text = "4"
        End If

    End Sub

    Private Sub btn_Five_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Five.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "5"
        Else
            txt_Display.Text = "5"
        End If

    End Sub

    Private Sub btn_Six_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Six.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "6"
        Else
            txt_Display.Text = "6"
        End If

    End Sub

    Private Sub btn_Seven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Seven.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "7"
        Else
            txt_Display.Text = "7"
        End If

    End Sub

    Private Sub btn_Eight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eight.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "8"
        Else
            txt_Display.Text = "8"
        End If

    End Sub

    Private Sub btn_Nine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nine.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "9"
        Else
            txt_Display.Text = "9"
        End If

    End Sub

    Private Sub btn_Zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Zero.Click
        If txt_Display.Text <> "0" Then
            txt_Display.Text += "0"
        End If

    End Sub

    Private Sub btn_Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dot.Click
        If Not (txt_Display.Text.Contains(".")) Then
            txt_Display.Text += "."
        End If

    End Sub

    Private Sub btn_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_C.Click
        txt_Display.Text = "0"
    End Sub

    Private Sub btn_Plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Plus.Click
        FirstNum = txt_Display.Text
        txt_Display.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +

    End Sub

    Private Sub btn_Minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Minus.Click
        FirstNum = txt_Display.Text
        txt_Display.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -

    End Sub

    Private Sub btn_Star_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Star.Click
        FirstNum = txt_Display.Text
        txt_Display.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *

    End Sub

    Private Sub btn_Slash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Slash.Click
        FirstNum = txt_Display.Text
        txt_Display.Text = "0"
        Operator_Selector = True
        Operations = 4 ' /

    End Sub

    Private Sub btn_Equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Equal.Click
        If Operator_Selector = True Then
            SecondNum = txt_Display.Text
            If Operations = 1 Then
                txt_Display.Text = FirstNum + SecondNum
            ElseIf Operations = 2 Then
                txt_Display.Text = FirstNum - SecondNum
            ElseIf Operations = 3 Then
                txt_Display.Text = FirstNum * SecondNum
            Else
                If SecondNum = 0 Then
                    txt_Display.Text = "Error!"
                Else
                    txt_Display.Text = FirstNum / SecondNum
                End If
            End If
            Operator_Selector = False
        End If

    End Sub

    Private Sub txt_Display_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Display.TextChanged

    End Sub

    
End Class