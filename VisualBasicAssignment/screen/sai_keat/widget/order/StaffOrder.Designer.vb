<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffOrder
    Inherits VisualBasicAssignment.MasterWidgetItem

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lnkPaymentReport = New System.Windows.Forms.LinkLabel()
        Me.linkSalesReport = New System.Windows.Forms.LinkLabel()
        Me.lnkNewOrder = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, -40)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(126, 38)
        Me.Guna2HtmlLabel1.TabIndex = 17
        Me.Guna2HtmlLabel1.Text = "My Order"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(15, 26)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1056, 10)
        Me.Guna2Separator1.TabIndex = 16
        '
        'lnkPaymentReport
        '
        Me.lnkPaymentReport.AutoSize = True
        Me.lnkPaymentReport.Location = New System.Drawing.Point(183, 8)
        Me.lnkPaymentReport.Name = "lnkPaymentReport"
        Me.lnkPaymentReport.Size = New System.Drawing.Size(110, 17)
        Me.lnkPaymentReport.TabIndex = 43
        Me.lnkPaymentReport.TabStop = True
        Me.lnkPaymentReport.Text = "Payment Report"
        '
        'linkSalesReport
        '
        Me.linkSalesReport.AutoSize = True
        Me.linkSalesReport.Location = New System.Drawing.Point(89, 7)
        Me.linkSalesReport.Name = "linkSalesReport"
        Me.linkSalesReport.Size = New System.Drawing.Size(90, 17)
        Me.linkSalesReport.TabIndex = 42
        Me.linkSalesReport.TabStop = True
        Me.linkSalesReport.Text = "Sales Report"
        '
        'lnkNewOrder
        '
        Me.lnkNewOrder.AutoSize = True
        Me.lnkNewOrder.Location = New System.Drawing.Point(14, 7)
        Me.lnkNewOrder.Name = "lnkNewOrder"
        Me.lnkNewOrder.Size = New System.Drawing.Size(76, 17)
        Me.lnkNewOrder.TabIndex = 40
        Me.lnkNewOrder.TabStop = True
        Me.lnkNewOrder.Text = "New Order"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 493)
        Me.Panel1.TabIndex = 44
        '
        'StaffOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lnkPaymentReport)
        Me.Controls.Add(Me.linkSalesReport)
        Me.Controls.Add(Me.lnkNewOrder)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Name = "StaffOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lnkPaymentReport As LinkLabel
    Friend WithEvents linkSalesReport As LinkLabel
    Friend WithEvents lnkNewOrder As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
