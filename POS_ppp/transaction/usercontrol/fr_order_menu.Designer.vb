<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_order_menu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_detail = New System.Windows.Forms.Panel()
        Me.pnl_order_content = New System.Windows.Forms.Panel()
        Me.bt_item_del = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_item_rem = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.bt_item_add = New System.Windows.Forms.Button()
        Me.bt_del = New System.Windows.Forms.Button()
        Me.bt_proses = New System.Windows.Forms.Button()
        Me.in_total = New System.Windows.Forms.TextBox()
        Me.in_disk = New System.Windows.Forms.TextBox()
        Me.in_tax = New System.Windows.Forms.TextBox()
        Me.in_table = New System.Windows.Forms.TextBox()
        Me.in_subtot = New System.Windows.Forms.TextBox()
        Me.ck_takeaway = New System.Windows.Forms.CheckBox()
        Me.ck_eatin = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_test = New System.Windows.Forms.DataGridView()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_notes_ck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_disk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_filler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.fpnl_main = New System.Windows.Forms.FlowLayoutPanel()
        Me.fpnl_kateg = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnl_detail.SuspendLayout()
        Me.pnl_order_content.SuspendLayout()
        CType(Me.dgv_test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_detail
        '
        Me.pnl_detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_detail.Controls.Add(Me.pnl_order_content)
        Me.pnl_detail.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_detail.ForeColor = System.Drawing.Color.White
        Me.pnl_detail.Location = New System.Drawing.Point(570, 0)
        Me.pnl_detail.Name = "pnl_detail"
        Me.pnl_detail.Size = New System.Drawing.Size(418, 515)
        Me.pnl_detail.TabIndex = 0
        '
        'pnl_order_content
        '
        Me.pnl_order_content.Controls.Add(Me.bt_item_del)
        Me.pnl_order_content.Controls.Add(Me.Button2)
        Me.pnl_order_content.Controls.Add(Me.Button5)
        Me.pnl_order_content.Controls.Add(Me.Button1)
        Me.pnl_order_content.Controls.Add(Me.bt_item_rem)
        Me.pnl_order_content.Controls.Add(Me.Button4)
        Me.pnl_order_content.Controls.Add(Me.bt_item_add)
        Me.pnl_order_content.Controls.Add(Me.bt_del)
        Me.pnl_order_content.Controls.Add(Me.bt_proses)
        Me.pnl_order_content.Controls.Add(Me.in_total)
        Me.pnl_order_content.Controls.Add(Me.in_disk)
        Me.pnl_order_content.Controls.Add(Me.in_tax)
        Me.pnl_order_content.Controls.Add(Me.in_table)
        Me.pnl_order_content.Controls.Add(Me.in_subtot)
        Me.pnl_order_content.Controls.Add(Me.ck_takeaway)
        Me.pnl_order_content.Controls.Add(Me.ck_eatin)
        Me.pnl_order_content.Controls.Add(Me.Label3)
        Me.pnl_order_content.Controls.Add(Me.Label5)
        Me.pnl_order_content.Controls.Add(Me.Label2)
        Me.pnl_order_content.Controls.Add(Me.Label4)
        Me.pnl_order_content.Controls.Add(Me.Label6)
        Me.pnl_order_content.Controls.Add(Me.Label1)
        Me.pnl_order_content.Controls.Add(Me.dgv_test)
        Me.pnl_order_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_order_content.Location = New System.Drawing.Point(0, 0)
        Me.pnl_order_content.Name = "pnl_order_content"
        Me.pnl_order_content.Size = New System.Drawing.Size(418, 515)
        Me.pnl_order_content.TabIndex = 4
        '
        'bt_item_del
        '
        Me.bt_item_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_item_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.bt_item_del.FlatAppearance.BorderSize = 0
        Me.bt_item_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_item_del.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.bt_item_del.Image = Global.POS_ppp.My.Resources.Resources.close_wh_thin_16x16
        Me.bt_item_del.Location = New System.Drawing.Point(156, 292)
        Me.bt_item_del.Name = "bt_item_del"
        Me.bt_item_del.Size = New System.Drawing.Size(43, 37)
        Me.bt_item_del.TabIndex = 7
        Me.bt_item_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_item_del.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(156, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(110, 335)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 37)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "free"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(110, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bt_item_rem
        '
        Me.bt_item_rem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_item_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.bt_item_rem.FlatAppearance.BorderSize = 0
        Me.bt_item_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_item_rem.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.bt_item_rem.Image = Global.POS_ppp.My.Resources.Resources.minimize_wh_thin_16x16
        Me.bt_item_rem.Location = New System.Drawing.Point(64, 292)
        Me.bt_item_rem.Name = "bt_item_rem"
        Me.bt_item_rem.Size = New System.Drawing.Size(43, 37)
        Me.bt_item_rem.TabIndex = 7
        Me.bt_item_rem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_item_rem.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.POS_ppp.My.Resources.Resources.menu_wh_thin_16x16
        Me.Button4.Location = New System.Drawing.Point(18, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 37)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "  Option"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'bt_item_add
        '
        Me.bt_item_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_item_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.bt_item_add.FlatAppearance.BorderSize = 0
        Me.bt_item_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_item_add.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.bt_item_add.Image = Global.POS_ppp.My.Resources.Resources.add_wh_thin_16x16
        Me.bt_item_add.Location = New System.Drawing.Point(18, 292)
        Me.bt_item_add.Name = "bt_item_add"
        Me.bt_item_add.Size = New System.Drawing.Size(43, 37)
        Me.bt_item_add.TabIndex = 7
        Me.bt_item_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_item_add.UseVisualStyleBackColor = False
        '
        'bt_del
        '
        Me.bt_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_del.BackColor = System.Drawing.Color.Brown
        Me.bt_del.FlatAppearance.BorderSize = 0
        Me.bt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_del.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.bt_del.Location = New System.Drawing.Point(305, 464)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(43, 37)
        Me.bt_del.TabIndex = 7
        Me.bt_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_del.UseVisualStyleBackColor = False
        '
        'bt_proses
        '
        Me.bt_proses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_proses.BackColor = System.Drawing.Color.Blue
        Me.bt_proses.FlatAppearance.BorderSize = 0
        Me.bt_proses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_proses.Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold)
        Me.bt_proses.Location = New System.Drawing.Point(93, 463)
        Me.bt_proses.Name = "bt_proses"
        Me.bt_proses.Size = New System.Drawing.Size(206, 37)
        Me.bt_proses.TabIndex = 0
        Me.bt_proses.Text = "Proses Order"
        Me.bt_proses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_proses.UseVisualStyleBackColor = False
        '
        'in_total
        '
        Me.in_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.in_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.in_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_total.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.in_total.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.in_total.ForeColor = System.Drawing.Color.White
        Me.in_total.Location = New System.Drawing.Point(280, 419)
        Me.in_total.Name = "in_total"
        Me.in_total.ReadOnly = True
        Me.in_total.Size = New System.Drawing.Size(126, 24)
        Me.in_total.TabIndex = 6
        Me.in_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'in_disk
        '
        Me.in_disk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.in_disk.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.in_disk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_disk.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.in_disk.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.in_disk.ForeColor = System.Drawing.Color.White
        Me.in_disk.Location = New System.Drawing.Point(81, 419)
        Me.in_disk.Name = "in_disk"
        Me.in_disk.ReadOnly = True
        Me.in_disk.Size = New System.Drawing.Size(126, 24)
        Me.in_disk.TabIndex = 6
        Me.in_disk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'in_tax
        '
        Me.in_tax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.in_tax.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.in_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_tax.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.in_tax.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.in_tax.ForeColor = System.Drawing.Color.White
        Me.in_tax.Location = New System.Drawing.Point(280, 391)
        Me.in_tax.Name = "in_tax"
        Me.in_tax.ReadOnly = True
        Me.in_tax.Size = New System.Drawing.Size(126, 24)
        Me.in_tax.TabIndex = 6
        Me.in_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'in_table
        '
        Me.in_table.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.in_table.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.in_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_table.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.in_table.ForeColor = System.Drawing.Color.Black
        Me.in_table.Location = New System.Drawing.Point(316, 292)
        Me.in_table.Name = "in_table"
        Me.in_table.Size = New System.Drawing.Size(68, 24)
        Me.in_table.TabIndex = 6
        '
        'in_subtot
        '
        Me.in_subtot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.in_subtot.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.in_subtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_subtot.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.in_subtot.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.in_subtot.ForeColor = System.Drawing.Color.White
        Me.in_subtot.Location = New System.Drawing.Point(81, 391)
        Me.in_subtot.Name = "in_subtot"
        Me.in_subtot.ReadOnly = True
        Me.in_subtot.Size = New System.Drawing.Size(126, 24)
        Me.in_subtot.TabIndex = 6
        Me.in_subtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ck_takeaway
        '
        Me.ck_takeaway.AutoSize = True
        Me.ck_takeaway.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.ck_takeaway.Location = New System.Drawing.Point(184, 10)
        Me.ck_takeaway.Name = "ck_takeaway"
        Me.ck_takeaway.Size = New System.Drawing.Size(87, 21)
        Me.ck_takeaway.TabIndex = 5
        Me.ck_takeaway.Text = "Take Away"
        Me.ck_takeaway.UseVisualStyleBackColor = True
        '
        'ck_eatin
        '
        Me.ck_eatin.AutoSize = True
        Me.ck_eatin.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.ck_eatin.Location = New System.Drawing.Point(93, 10)
        Me.ck_eatin.Name = "ck_eatin"
        Me.ck_eatin.Size = New System.Drawing.Size(58, 21)
        Me.ck_eatin.TabIndex = 5
        Me.ck_eatin.Text = "Eat In"
        Me.ck_eatin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(220, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(21, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diskon"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(220, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PPN"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(21, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subtot."
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(256, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Table"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Order Type"
        '
        'dgv_test
        '
        Me.dgv_test.AllowUserToAddRows = False
        Me.dgv_test.AllowUserToDeleteRows = False
        Me.dgv_test.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_test.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_test.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_test.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_test.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_test.ColumnHeadersVisible = False
        Me.dgv_test.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.item_name, Me.item_notes_ck, Me.item_notes, Me.item_count, Me.item_price, Me.item_disk, Me.item_total, Me.item_filler})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_test.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_test.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_test.Location = New System.Drawing.Point(3, 36)
        Me.dgv_test.Name = "dgv_test"
        Me.dgv_test.ReadOnly = True
        Me.dgv_test.RowHeadersVisible = False
        Me.dgv_test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_test.Size = New System.Drawing.Size(412, 240)
        Me.dgv_test.TabIndex = 3
        '
        'item_id
        '
        Me.item_id.HeaderText = "id"
        Me.item_id.Name = "item_id"
        Me.item_id.ReadOnly = True
        Me.item_id.Visible = False
        '
        'item_name
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.item_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.item_name.HeaderText = "Item"
        Me.item_name.MinimumWidth = 190
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 190
        '
        'item_notes_ck
        '
        Me.item_notes_ck.HeaderText = "O"
        Me.item_notes_ck.MinimumWidth = 25
        Me.item_notes_ck.Name = "item_notes_ck"
        Me.item_notes_ck.ReadOnly = True
        Me.item_notes_ck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item_notes_ck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_notes_ck.Width = 25
        '
        'item_notes
        '
        Me.item_notes.HeaderText = "notes"
        Me.item_notes.Name = "item_notes"
        Me.item_notes.ReadOnly = True
        Me.item_notes.Visible = False
        '
        'item_count
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.item_count.DefaultCellStyle = DataGridViewCellStyle3
        Me.item_count.HeaderText = "Count"
        Me.item_count.MinimumWidth = 50
        Me.item_count.Name = "item_count"
        Me.item_count.ReadOnly = True
        Me.item_count.Width = 50
        '
        'item_price
        '
        Me.item_price.HeaderText = "price"
        Me.item_price.Name = "item_price"
        Me.item_price.ReadOnly = True
        Me.item_price.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_price.Visible = False
        '
        'item_disk
        '
        Me.item_disk.HeaderText = "diskon"
        Me.item_disk.Name = "item_disk"
        Me.item_disk.ReadOnly = True
        Me.item_disk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item_disk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_disk.Visible = False
        '
        'item_total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.item_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.item_total.HeaderText = "Total"
        Me.item_total.Name = "item_total"
        Me.item_total.ReadOnly = True
        '
        'item_filler
        '
        Me.item_filler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.item_filler.HeaderText = ""
        Me.item_filler.Name = "item_filler"
        Me.item_filler.ReadOnly = True
        '
        'pnl_menu
        '
        Me.pnl_menu.Controls.Add(Me.fpnl_main)
        Me.pnl_menu.Controls.Add(Me.fpnl_kateg)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(570, 515)
        Me.pnl_menu.TabIndex = 1
        '
        'fpnl_main
        '
        Me.fpnl_main.AutoScroll = True
        Me.fpnl_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.fpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpnl_main.Location = New System.Drawing.Point(0, 75)
        Me.fpnl_main.Name = "fpnl_main"
        Me.fpnl_main.Size = New System.Drawing.Size(570, 440)
        Me.fpnl_main.TabIndex = 1
        '
        'fpnl_kateg
        '
        Me.fpnl_kateg.AutoScroll = True
        Me.fpnl_kateg.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.fpnl_kateg.Dock = System.Windows.Forms.DockStyle.Top
        Me.fpnl_kateg.Location = New System.Drawing.Point(0, 0)
        Me.fpnl_kateg.Name = "fpnl_kateg"
        Me.fpnl_kateg.Size = New System.Drawing.Size(570, 75)
        Me.fpnl_kateg.TabIndex = 0
        Me.fpnl_kateg.WrapContents = False
        '
        'fr_order_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_menu)
        Me.Controls.Add(Me.pnl_detail)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(988, 515)
        Me.Name = "fr_order_menu"
        Me.Size = New System.Drawing.Size(988, 515)
        Me.pnl_detail.ResumeLayout(False)
        Me.pnl_order_content.ResumeLayout(False)
        Me.pnl_order_content.PerformLayout()
        CType(Me.dgv_test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_detail As System.Windows.Forms.Panel
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents fpnl_main As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents fpnl_kateg As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents bt_proses As System.Windows.Forms.Button
    Friend WithEvents pnl_order_content As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_test As System.Windows.Forms.DataGridView
    Friend WithEvents ck_takeaway As System.Windows.Forms.CheckBox
    Friend WithEvents ck_eatin As System.Windows.Forms.CheckBox
    Friend WithEvents in_disk As System.Windows.Forms.TextBox
    Friend WithEvents in_subtot As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents in_total As System.Windows.Forms.TextBox
    Friend WithEvents in_tax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_del As System.Windows.Forms.Button
    Friend WithEvents bt_item_del As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents bt_item_rem As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents bt_item_add As System.Windows.Forms.Button
    Friend WithEvents item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_notes_ck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_disk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_filler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_table As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
