<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentConfirm
    Inherits VisualBasicAssignment.MasterWidgetItem

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentConfirm))
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPaymentId = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNote = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTax = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTotalAmount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDelivaryFees = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCustomerPaid = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(31, 78)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1056, 10)
        Me.Guna2Separator1.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(251, 38)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "Payment Complete"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(31, 57)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(23, 17)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "All"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(60, 57)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 17)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "To Pay"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(119, 57)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(92, 17)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "To Deliveried"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(217, 58)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(59, 17)
        Me.LinkLabel4.TabIndex = 8
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Recived"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblPaymentId)
        Me.Panel1.Controls.Add(Me.lblNote)
        Me.Panel1.Controls.Add(Me.dgvDetails)
        Me.Panel1.Location = New System.Drawing.Point(37, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 416)
        Me.Panel1.TabIndex = 9
        '
        'lblDate
        '
        Me.lblDate.AutoSize = False
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblDate.Location = New System.Drawing.Point(493, 44)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(265, 22)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Payment Date: "
        '
        'lblPaymentId
        '
        Me.lblPaymentId.AutoSize = False
        Me.lblPaymentId.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblPaymentId.Location = New System.Drawing.Point(21, 12)
        Me.lblPaymentId.Name = "lblPaymentId"
        Me.lblPaymentId.Size = New System.Drawing.Size(737, 22)
        Me.lblPaymentId.TabIndex = 17
        Me.lblPaymentId.Text = "Payment : Guid "
        '
        'lblNote
        '
        Me.lblNote.AutoSize = False
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(493, 134)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(265, 273)
        Me.lblNote.TabIndex = 1
        Me.lblNote.Text = "Payment note:<br/> Note"
        '
        'dgvDetails
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetails.ColumnHeadersHeight = 50
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetails.EnableHeadersVisualStyles = False
        Me.dgvDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.Location = New System.Drawing.Point(17, 44)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.RowHeadersWidth = 51
        Me.dgvDetails.RowTemplate.Height = 24
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.Size = New System.Drawing.Size(461, 363)
        Me.dgvDetails.TabIndex = 0
        Me.dgvDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDetails.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvDetails.ThemeStyle.ReadOnly = False
        Me.dgvDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDetails.ThemeStyle.RowsStyle.Height = 24
        Me.dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(839, 96)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(198, 38)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Make Payment"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = False
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblSubTotal.Location = New System.Drawing.Point(836, 306)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(200, 22)
        Me.lblSubTotal.TabIndex = 12
        Me.lblSubTotal.Text = "Sub Total: RM 199.00"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = False
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblTax.Location = New System.Drawing.Point(836, 348)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(200, 22)
        Me.lblTax.TabIndex = 13
        Me.lblTax.Text = "Tax Charges: RM 19.90"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = False
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(836, 437)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(200, 22)
        Me.lblTotalAmount.TabIndex = 15
        Me.lblTotalAmount.Text = "Total Fees: RM 221.00"
        '
        'lblDelivaryFees
        '
        Me.lblDelivaryFees.AutoSize = False
        Me.lblDelivaryFees.BackColor = System.Drawing.Color.Transparent
        Me.lblDelivaryFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblDelivaryFees.Location = New System.Drawing.Point(836, 395)
        Me.lblDelivaryFees.Name = "lblDelivaryFees"
        Me.lblDelivaryFees.Size = New System.Drawing.Size(200, 22)
        Me.lblDelivaryFees.TabIndex = 14
        Me.lblDelivaryFees.Text = "Delivary Fees: RM 3.00"
        '
        'lblCustomerPaid
        '
        Me.lblCustomerPaid.AutoSize = False
        Me.lblCustomerPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lblCustomerPaid.Location = New System.Drawing.Point(836, 481)
        Me.lblCustomerPaid.Name = "lblCustomerPaid"
        Me.lblCustomerPaid.Size = New System.Drawing.Size(200, 22)
        Me.lblCustomerPaid.TabIndex = 16
        Me.lblCustomerPaid.Text = "You Pay: RM 221.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(861, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PaymentConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.Controls.Add(Me.lblCustomerPaid)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblDelivaryFees)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Name = "PaymentConfirm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTax As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalAmount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDelivaryFees As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblPaymentId As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNote As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCustomerPaid As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
