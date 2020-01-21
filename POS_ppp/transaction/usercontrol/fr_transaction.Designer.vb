<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_transaction
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
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.bt_cl = New System.Windows.Forms.Button()
        Me.bt_pay = New System.Windows.Forms.Button()
        Me.bt_order = New System.Windows.Forms.Button()
        Me.bt_menu = New System.Windows.Forms.Button()
        Me.pnl_content = New System.Windows.Forms.Panel()
        Me.pnl_top.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.BackColor = System.Drawing.Color.White
        Me.pnl_top.Controls.Add(Me.bt_cl)
        Me.pnl_top.Controls.Add(Me.bt_pay)
        Me.pnl_top.Controls.Add(Me.bt_order)
        Me.pnl_top.Controls.Add(Me.bt_menu)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(988, 60)
        Me.pnl_top.TabIndex = 0
        '
        'bt_cl
        '
        Me.bt_cl.BackColor = System.Drawing.Color.DarkBlue
        Me.bt_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cl.Font = New System.Drawing.Font("Open Sans", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bt_cl.ForeColor = System.Drawing.Color.SlateGray
        Me.bt_cl.Image = Global.POS_ppp.My.Resources.Resources.arrowleft_wh_thin_16x16
        Me.bt_cl.Location = New System.Drawing.Point(0, 10)
        Me.bt_cl.Name = "bt_cl"
        Me.bt_cl.Size = New System.Drawing.Size(47, 41)
        Me.bt_cl.TabIndex = 2
        Me.bt_cl.UseVisualStyleBackColor = False
        '
        'bt_pay
        '
        Me.bt_pay.BackColor = System.Drawing.Color.White
        Me.bt_pay.FlatAppearance.BorderSize = 0
        Me.bt_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pay.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bt_pay.ForeColor = System.Drawing.Color.SlateGray
        Me.bt_pay.Location = New System.Drawing.Point(349, 1)
        Me.bt_pay.Name = "bt_pay"
        Me.bt_pay.Size = New System.Drawing.Size(142, 59)
        Me.bt_pay.TabIndex = 2
        Me.bt_pay.Text = "PAYMENT"
        Me.bt_pay.UseVisualStyleBackColor = False
        '
        'bt_order
        '
        Me.bt_order.BackColor = System.Drawing.Color.White
        Me.bt_order.FlatAppearance.BorderSize = 0
        Me.bt_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_order.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bt_order.ForeColor = System.Drawing.Color.SlateGray
        Me.bt_order.Location = New System.Drawing.Point(201, 1)
        Me.bt_order.Name = "bt_order"
        Me.bt_order.Size = New System.Drawing.Size(142, 59)
        Me.bt_order.TabIndex = 2
        Me.bt_order.Text = "ORDER STATUS"
        Me.bt_order.UseVisualStyleBackColor = False
        '
        'bt_menu
        '
        Me.bt_menu.BackColor = System.Drawing.Color.White
        Me.bt_menu.FlatAppearance.BorderSize = 0
        Me.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_menu.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bt_menu.ForeColor = System.Drawing.Color.SlateGray
        Me.bt_menu.Location = New System.Drawing.Point(53, 1)
        Me.bt_menu.Name = "bt_menu"
        Me.bt_menu.Size = New System.Drawing.Size(142, 59)
        Me.bt_menu.TabIndex = 2
        Me.bt_menu.Text = "MENU"
        Me.bt_menu.UseVisualStyleBackColor = False
        '
        'pnl_content
        '
        Me.pnl_content.AutoScroll = True
        Me.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_content.Location = New System.Drawing.Point(0, 60)
        Me.pnl_content.Name = "pnl_content"
        Me.pnl_content.Size = New System.Drawing.Size(988, 515)
        Me.pnl_content.TabIndex = 1
        '
        'fr_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_content)
        Me.Controls.Add(Me.pnl_top)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fr_transaction"
        Me.Size = New System.Drawing.Size(988, 575)
        Me.pnl_top.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents bt_cl As System.Windows.Forms.Button
    Friend WithEvents bt_pay As System.Windows.Forms.Button
    Friend WithEvents bt_order As System.Windows.Forms.Button
    Friend WithEvents bt_menu As System.Windows.Forms.Button
    Friend WithEvents pnl_content As System.Windows.Forms.Panel

End Class
