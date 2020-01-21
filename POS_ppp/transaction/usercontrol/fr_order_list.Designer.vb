<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_order_list
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
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.fpnl_onprog = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.fpnl_main = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_top.SuspendLayout()
        Me.fpnl_onprog.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.fpnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_top.Controls.Add(Me.lbl_progress)
        Me.pnl_top.Controls.Add(Me.fpnl_onprog)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(988, 220)
        Me.pnl_top.TabIndex = 2
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = True
        Me.lbl_progress.Font = New System.Drawing.Font("Open Sans", 9.25!)
        Me.lbl_progress.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_progress.Location = New System.Drawing.Point(3, 9)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(81, 18)
        Me.lbl_progress.TabIndex = 2
        Me.lbl_progress.Text = "On Progress"
        '
        'fpnl_onprog
        '
        Me.fpnl_onprog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpnl_onprog.AutoScroll = True
        Me.fpnl_onprog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fpnl_onprog.Controls.Add(Me.Panel2)
        Me.fpnl_onprog.Controls.Add(Me.Panel3)
        Me.fpnl_onprog.Controls.Add(Me.Panel4)
        Me.fpnl_onprog.Controls.Add(Me.Panel5)
        Me.fpnl_onprog.Location = New System.Drawing.Point(10, 30)
        Me.fpnl_onprog.Name = "fpnl_onprog"
        Me.fpnl_onprog.Size = New System.Drawing.Size(968, 184)
        Me.fpnl_onprog.TabIndex = 1
        Me.fpnl_onprog.WrapContents = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 160)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(184, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 160)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(365, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 160)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(546, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(175, 160)
        Me.Panel5.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.fpnl_main)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 295)
        Me.Panel1.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(897, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Riwayat Order"
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
        Me.fpnl_main.Location = New System.Drawing.Point(10, 32)
        Me.fpnl_main.Name = "fpnl_main"
        Me.fpnl_main.Size = New System.Drawing.Size(968, 257)
        Me.fpnl_main.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(175, 160)
        Me.Panel9.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(184, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(175, 160)
        Me.Panel6.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(365, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(175, 160)
        Me.Panel7.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 9.25!)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Completed"
        '
        'fr_order_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_top)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(988, 515)
        Me.Name = "fr_order_list"
        Me.Size = New System.Drawing.Size(988, 515)
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        Me.fpnl_onprog.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.fpnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents lbl_progress As System.Windows.Forms.Label
    Friend WithEvents fpnl_onprog As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fpnl_main As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
