<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Receipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_PrintReceipt = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Id = New System.Windows.Forms.TextBox
        Me.txt_FirstName = New System.Windows.Forms.TextBox
        Me.txt_MiddleName = New System.Windows.Forms.TextBox
        Me.txt_LastName = New System.Windows.Forms.TextBox
        Me.txt_CakeType = New System.Windows.Forms.TextBox
        Me.txt_CakeFlavour = New System.Windows.Forms.TextBox
        Me.txt_CakeQuantity = New System.Windows.Forms.TextBox
        Me.txt_Total = New System.Windows.Forms.TextBox
        Me.btn_Thanks = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_CakePrice = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn_PrintReceipt
        '
        Me.btn_PrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PrintReceipt.Location = New System.Drawing.Point(3, 3)
        Me.btn_PrintReceipt.Name = "btn_PrintReceipt"
        Me.btn_PrintReceipt.Size = New System.Drawing.Size(108, 28)
        Me.btn_PrintReceipt.TabIndex = 0
        Me.btn_PrintReceipt.Text = "Print Receipt"
        Me.btn_PrintReceipt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cake Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cake Flavour"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cake Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(308, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total"
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(177, 38)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(59, 20)
        Me.txt_Id.TabIndex = 10
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Location = New System.Drawing.Point(177, 62)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(115, 20)
        Me.txt_FirstName.TabIndex = 11
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.Location = New System.Drawing.Point(177, 89)
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(115, 20)
        Me.txt_MiddleName.TabIndex = 12
        '
        'txt_LastName
        '
        Me.txt_LastName.Location = New System.Drawing.Point(177, 116)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(115, 20)
        Me.txt_LastName.TabIndex = 13
        '
        'txt_CakeType
        '
        Me.txt_CakeType.Location = New System.Drawing.Point(177, 142)
        Me.txt_CakeType.Name = "txt_CakeType"
        Me.txt_CakeType.Size = New System.Drawing.Size(115, 20)
        Me.txt_CakeType.TabIndex = 14
        '
        'txt_CakeFlavour
        '
        Me.txt_CakeFlavour.Location = New System.Drawing.Point(177, 169)
        Me.txt_CakeFlavour.Name = "txt_CakeFlavour"
        Me.txt_CakeFlavour.Size = New System.Drawing.Size(115, 20)
        Me.txt_CakeFlavour.TabIndex = 15
        '
        'txt_CakeQuantity
        '
        Me.txt_CakeQuantity.Location = New System.Drawing.Point(177, 197)
        Me.txt_CakeQuantity.Name = "txt_CakeQuantity"
        Me.txt_CakeQuantity.Size = New System.Drawing.Size(115, 20)
        Me.txt_CakeQuantity.TabIndex = 16
        '
        'txt_Total
        '
        Me.txt_Total.Location = New System.Drawing.Point(352, 227)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(115, 20)
        Me.txt_Total.TabIndex = 18
        '
        'btn_Thanks
        '
        Me.btn_Thanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thanks.Location = New System.Drawing.Point(380, 262)
        Me.btn_Thanks.Name = "btn_Thanks"
        Me.btn_Thanks.Size = New System.Drawing.Size(87, 23)
        Me.btn_Thanks.TabIndex = 19
        Me.btn_Thanks.Text = "Thank You"
        Me.btn_Thanks.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gold
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(220, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Receipt"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Cake Price"
        '
        'txt_CakePrice
        '
        Me.txt_CakePrice.Location = New System.Drawing.Point(177, 227)
        Me.txt_CakePrice.Name = "txt_CakePrice"
        Me.txt_CakePrice.Size = New System.Drawing.Size(115, 20)
        Me.txt_CakePrice.TabIndex = 22
        '
        'frm_Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 297)
        Me.Controls.Add(Me.txt_CakePrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Thanks)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt_CakeQuantity)
        Me.Controls.Add(Me.txt_CakeFlavour)
        Me.Controls.Add(Me.txt_CakeType)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_PrintReceipt)
        Me.Name = "frm_Receipt"
        Me.Text = "receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_PrintReceipt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_LastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_CakeType As System.Windows.Forms.TextBox
    Friend WithEvents txt_CakeFlavour As System.Windows.Forms.TextBox
    Friend WithEvents txt_CakeQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents btn_Thanks As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_CakePrice As System.Windows.Forms.TextBox
End Class
