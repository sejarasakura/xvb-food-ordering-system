<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewOder
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudQuantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvOrder = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodShopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodShopDataSet = New VisualBasicAssignment.FoodShopDataSet()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.FoodTableAdapter = New VisualBasicAssignment.FoodShopDataSetTableAdapters.FoodTableAdapter()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodShopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.nudQuantity)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txbSearch)
        Me.Panel1.Controls.Add(Me.dgvOrder)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.dgvOrderDetails)
        Me.Panel1.Location = New System.Drawing.Point(21, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 475)
        Me.Panel1.TabIndex = 22
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(581, 87)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(187, 98)
        Me.Guna2HtmlLabel2.TabIndex = 36
        Me.Guna2HtmlLabel2.Text = "Guna2HtmlLabel2"
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(539, 191)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(116, 35)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(661, 18)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(116, 35)
        Me.Guna2Button1.TabIndex = 34
        Me.Guna2Button1.Text = "Search"
        '
        'btnAdd
        '
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(661, 191)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(116, 35)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Quantity"
        '
        'nudQuantity
        '
        Me.nudQuantity.BackColor = System.Drawing.Color.Transparent
        Me.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudQuantity.DisabledState.Parent = Me.nudQuantity
        Me.nudQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudQuantity.FocusedState.Parent = Me.nudQuantity
        Me.nudQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudQuantity.Location = New System.Drawing.Point(455, 87)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.ShadowDecoration.Parent = Me.nudQuantity
        Me.nudQuantity.Size = New System.Drawing.Size(116, 36)
        Me.nudQuantity.TabIndex = 31
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(352, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Search"
        '
        'txbSearch
        '
        Me.txbSearch.AllowDrop = True
        Me.txbSearch.BorderRadius = 10
        Me.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbSearch.DefaultText = ""
        Me.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearch.DisabledState.Parent = Me.txbSearch
        Me.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbSearch.FocusedState.Parent = Me.txbSearch
        Me.txbSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbSearch.HoverState.Parent = Me.txbSearch
        Me.txbSearch.Location = New System.Drawing.Point(455, 19)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSearch.PlaceholderText = ""
        Me.txbSearch.SelectedText = ""
        Me.txbSearch.ShadowDecoration.Parent = Me.txbSearch
        Me.txbSearch.Size = New System.Drawing.Size(200, 36)
        Me.txbSearch.TabIndex = 28
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrder.AutoGenerateColumns = False
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrder.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrder.ColumnHeadersHeight = 30
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ImageDataGridViewImageColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvOrder.DataSource = Me.FoodBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrder.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrder.EnableHeadersVisualStyles = False
        Me.dgvOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOrder.Location = New System.Drawing.Point(3, 3)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.RowHeadersVisible = False
        Me.dgvOrder.RowHeadersWidth = 51
        Me.dgvOrder.RowTemplate.Height = 24
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrder.Size = New System.Drawing.Size(343, 467)
        Me.dgvOrder.TabIndex = 27
        Me.dgvOrder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvOrder.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvOrder.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvOrder.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvOrder.ThemeStyle.ReadOnly = True
        Me.dgvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvOrder.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvOrder.ThemeStyle.RowsStyle.Height = 24
        Me.dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImageDataGridViewImageColumn
        '
        Me.ImageDataGridViewImageColumn.DataPropertyName = "image"
        Me.ImageDataGridViewImageColumn.HeaderText = "image"
        Me.ImageDataGridViewImageColumn.MinimumWidth = 6
        Me.ImageDataGridViewImageColumn.Name = "ImageDataGridViewImageColumn"
        Me.ImageDataGridViewImageColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FoodBindingSource
        '
        Me.FoodBindingSource.DataMember = "Food"
        Me.FoodBindingSource.DataSource = Me.FoodShopDataSetBindingSource
        '
        'FoodShopDataSetBindingSource
        '
        Me.FoodShopDataSetBindingSource.DataSource = Me.FoodShopDataSet
        Me.FoodShopDataSetBindingSource.Position = 0
        '
        'FoodShopDataSet
        '
        Me.FoodShopDataSet.DataSetName = "FoodShopDataSet"
        Me.FoodShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(352, 210)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(97, 22)
        Me.Guna2HtmlLabel7.TabIndex = 26
        Me.Guna2HtmlLabel7.Text = "Order details: "
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToOrderColumns = True
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetails.Location = New System.Drawing.Point(352, 238)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersWidth = 51
        Me.dgvOrderDetails.RowTemplate.Height = 24
        Me.dgvOrderDetails.Size = New System.Drawing.Size(429, 232)
        Me.dgvOrderDetails.TabIndex = 0
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(189, 5)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(59, 17)
        Me.LinkLabel4.TabIndex = 21
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Recived"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(103, 5)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(92, 17)
        Me.LinkLabel3.TabIndex = 20
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "To Deliveried"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(44, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 17)
        Me.LinkLabel2.TabIndex = 19
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "To Pay"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(23, 17)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "All"
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
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(818, 479)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(258, 35)
        Me.Guna2Button2.TabIndex = 36
        Me.Guna2Button2.Text = "Procide Payment"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(815, 47)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(127, 17)
        Me.lblTotal.TabIndex = 37
        Me.lblTotal.Text = "Total Payment: 0.0"
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Location = New System.Drawing.Point(815, 93)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(95, 17)
        Me.lblTotalText.TabIndex = 38
        Me.lblTotalText.Text = "Total Tax: 0.0"
        '
        'NewOder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.Controls.Add(Me.lblTotalText)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Name = "NewOder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodShopDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dgvOrder As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents nudQuantity As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodShopDataSetBindingSource As BindingSource
    Friend WithEvents FoodShopDataSet As FoodShopDataSet
    Friend WithEvents FoodTableAdapter As FoodShopDataSetTableAdapters.FoodTableAdapter
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalText As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
