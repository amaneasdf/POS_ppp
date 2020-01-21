<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_main
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
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_pos = New System.Windows.Forms.Button()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.White
        Me.pnl_menu.Controls.Add(Me.Button3)
        Me.pnl_menu.Controls.Add(Me.Button2)
        Me.pnl_menu.Controls.Add(Me.Button1)
        Me.pnl_menu.Controls.Add(Me.bt_pos)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(56, 601)
        Me.pnl_menu.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button3.Location = New System.Drawing.Point(0, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 47)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Other"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button2.Location = New System.Drawing.Point(0, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "RPT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(0, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "MNG"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bt_pos
        '
        Me.bt_pos.BackColor = System.Drawing.Color.White
        Me.bt_pos.FlatAppearance.BorderSize = 0
        Me.bt_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pos.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_pos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.bt_pos.Location = New System.Drawing.Point(0, 7)
        Me.bt_pos.Name = "bt_pos"
        Me.bt_pos.Size = New System.Drawing.Size(47, 47)
        Me.bt_pos.TabIndex = 1
        Me.bt_pos.Text = "POS"
        Me.bt_pos.UseVisualStyleBackColor = False
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.BackColor = System.Drawing.Color.Gainsboro
        Me.pnl_main.Location = New System.Drawing.Point(59, 3)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(1000, 595)
        Me.pnl_main.TabIndex = 1
        '
        'fr_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 601)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_menu)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1080, 640)
        Me.Name = "fr_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents pnl_main As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_pos As System.Windows.Forms.Button

End Class
