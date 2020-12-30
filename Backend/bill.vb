'Bill generation form
Imports System.Data.OleDb
Public Class frm_BillGeneration



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

    
    

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    
    

    Private Sub btn_Thanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thanks.Click
        Me.Close()
    End Sub
End Class
