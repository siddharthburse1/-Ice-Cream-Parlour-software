Imports System.Data.OleDb
Public Class frm_Receipt

    Private Sub frm_Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Thanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thanks.Click
        Me.Close()
    End Sub

    Private Sub btn_PrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PrintReceipt.Click
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Visual Studio 2008\Projects\mini project\database\customer purchases.accdb")
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

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class