<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_login
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
        Me.pnl_content = New System.Windows.Forms.Panel()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bt_login = New System.Windows.Forms.Button()
        Me.pnl_content.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_content
        '
        Me.pnl_content.BackColor = System.Drawing.Color.SteelBlue
        Me.pnl_content.Controls.Add(Me.bt_close)
        Me.pnl_content.Controls.Add(Me.bt_login)
        Me.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_content.Location = New System.Drawing.Point(0, 0)
        Me.pnl_content.Name = "pnl_content"
        Me.pnl_content.Size = New System.Drawing.Size(437, 225)
        Me.pnl_content.TabIndex = 0
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.White
        Me.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_close.FlatAppearance.BorderSize = 0
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bt_close.ForeColor = System.Drawing.Color.Black
        Me.bt_close.Location = New System.Drawing.Point(308, 174)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(117, 39)
        Me.bt_close.TabIndex = 5
        Me.bt_close.Text = "Keluar"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt_login
        '
        Me.bt_login.BackColor = System.Drawing.Color.White
        Me.bt_login.FlatAppearance.BorderSize = 0
        Me.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_login.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bt_login.ForeColor = System.Drawing.Color.Black
        Me.bt_login.Location = New System.Drawing.Point(169, 174)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(133, 39)
        Me.bt_login.TabIndex = 4
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = False
        '
        'fr_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 225)
        Me.Controls.Add(Me.pnl_content)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fr_login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_login"
        Me.pnl_content.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_content As System.Windows.Forms.Panel
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents bt_login As System.Windows.Forms.Button
End Class
