Public Class MDI_AMS

    
    Private Sub nav_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nav_Registration.Click
        frm_EmployeeRegistration.Show()
    End Sub

    Private Sub nav_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nav_Menu.Click
        frm_MenuCard.Show()
    End Sub

    
    Private Sub nav_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nav_Customer.Click
        frm_CustomerPurchace.Show()
    End Sub

    Private Sub nav_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nav_Bill.Click
        frm_BillGeneration.Show()
    End Sub

    Private Sub nav_LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nav_LogOut.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class