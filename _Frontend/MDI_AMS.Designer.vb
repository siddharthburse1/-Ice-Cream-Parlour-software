<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_AMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_AMS))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.nav_Registration = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.nav_Customer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.nav_Bill = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.nav_AboutUs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.nav_LogOut = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nav_Menu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nav_Registration, Me.ToolStripSeparator1, Me.nav_Menu, Me.ToolStripSeparator2, Me.nav_Customer, Me.ToolStripSeparator3, Me.nav_Bill, Me.ToolStripSeparator4, Me.nav_AboutUs, Me.ToolStripSeparator5, Me.nav_LogOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1924, 48)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'nav_Registration
        '
        Me.nav_Registration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_Registration.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Registration.Image = CType(resources.GetObject("nav_Registration.Image"), System.Drawing.Image)
        Me.nav_Registration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_Registration.Name = "nav_Registration"
        Me.nav_Registration.Size = New System.Drawing.Size(180, 45)
        Me.nav_Registration.Text = "Registration"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'nav_Customer
        '
        Me.nav_Customer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_Customer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Customer.Image = CType(resources.GetObject("nav_Customer.Image"), System.Drawing.Image)
        Me.nav_Customer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_Customer.Name = "nav_Customer"
        Me.nav_Customer.Size = New System.Drawing.Size(248, 45)
        Me.nav_Customer.Text = "Customer Details"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        'nav_Bill
        '
        Me.nav_Bill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_Bill.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Bill.Image = CType(resources.GetObject("nav_Bill.Image"), System.Drawing.Image)
        Me.nav_Bill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_Bill.Name = "nav_Bill"
        Me.nav_Bill.Size = New System.Drawing.Size(157, 45)
        Me.nav_Bill.Text = "Bill Details"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        'nav_AboutUs
        '
        Me.nav_AboutUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_AboutUs.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_AboutUs.Image = CType(resources.GetObject("nav_AboutUs.Image"), System.Drawing.Image)
        Me.nav_AboutUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_AboutUs.Name = "nav_AboutUs"
        Me.nav_AboutUs.Size = New System.Drawing.Size(146, 45)
        Me.nav_AboutUs.Text = "About Us"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 48)
        '
        'nav_LogOut
        '
        Me.nav_LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_LogOut.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_LogOut.Image = CType(resources.GetObject("nav_LogOut.Image"), System.Drawing.Image)
        Me.nav_LogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_LogOut.Name = "nav_LogOut"
        Me.nav_LogOut.Size = New System.Drawing.Size(130, 45)
        Me.nav_LogOut.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HAPPY CAKES CAKE SHOP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Pink
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SBES College of Science,"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(465, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Aurangpura, Aurangabad-431001"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Pink
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 580)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(360, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact : 0240-6542021"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Pink
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(784, 580)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(504, 36)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email-ID : happycakes@gmail.com"
        '
        'nav_Menu
        '
        Me.nav_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.nav_Menu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_Menu.Image = CType(resources.GetObject("nav_Menu.Image"), System.Drawing.Image)
        Me.nav_Menu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nav_Menu.Name = "nav_Menu"
        Me.nav_Menu.Size = New System.Drawing.Size(99, 45)
        Me.nav_Menu.Text = "Menu"
        '
        'MDI_AMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.mini_project.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDI_AMS"
        Me.Text = "MDI_AMS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents nav_Registration As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nav_Customer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nav_Bill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nav_AboutUs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nav_LogOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nav_Menu As System.Windows.Forms.ToolStripButton
End Class
