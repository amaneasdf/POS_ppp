<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_order_pay
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.fpnl_main = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.fpnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.fpnl_main)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 515)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.POS_ppp.My.Resources.Resources.search_wh_thin_16x16
        Me.Button1.Location = New System.Drawing.Point(302, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(10, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 26)
        Me.TextBox1.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(862, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Riwayat Pembayaran"
        '
        'fpnl_main
        '
        Me.fpnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpnl_main.AutoScroll = True
        Me.fpnl_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fpnl_main.Controls.Add(Me.Panel9)
        Me.fpnl_main.Controls.Add(Me.Panel6)
        Me.fpnl_main.Controls.Add(Me.Panel7)
        Me.fpnl_main.Location = New System.Drawing.Point(10, 70)
        Me.fpnl_main.Name = "fpnl_main"
        Me.fpnl_main.Size = New System.Drawing.Size(968, 439)
        Me.fpnl_main.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(175, 80)
        Me.Panel9.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(184, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(175, 80)
        Me.Panel6.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(365, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(175, 80)
        Me.Panel7.TabIndex = 0
        '
        'fr_order_pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(988, 515)
        Me.Name = "fr_order_pay"
        Me.Size = New System.Drawing.Size(988, 515)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.fpnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fpnl_main As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
