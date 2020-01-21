<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_test_customctr
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
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.in_name = New System.Windows.Forms.TextBox()
        Me.in_info = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_id.Location = New System.Drawing.Point(19, 15)
        Me.lbl_id.MaximumSize = New System.Drawing.Size(207, 17)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(78, 17)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Test-DataID"
        '
        'in_name
        '
        Me.in_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.in_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.in_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.in_name.Font = New System.Drawing.Font("Open Sans", 10.5!, System.Drawing.FontStyle.Bold)
        Me.in_name.ForeColor = System.Drawing.Color.Black
        Me.in_name.Location = New System.Drawing.Point(18, 35)
        Me.in_name.Multiline = True
        Me.in_name.Name = "in_name"
        Me.in_name.ReadOnly = True
        Me.in_name.ShortcutsEnabled = False
        Me.in_name.Size = New System.Drawing.Size(207, 40)
        Me.in_name.TabIndex = 1
        Me.in_name.TabStop = False
        Me.in_name.Text = "Test Data Name, No. 17" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yes"
        '
        'in_info
        '
        Me.in_info.BackColor = System.Drawing.Color.WhiteSmoke
        Me.in_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.in_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.in_info.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.in_info.ForeColor = System.Drawing.Color.Black
        Me.in_info.Location = New System.Drawing.Point(18, 75)
        Me.in_info.Multiline = True
        Me.in_info.Name = "in_info"
        Me.in_info.ReadOnly = True
        Me.in_info.ShortcutsEnabled = False
        Me.in_info.Size = New System.Drawing.Size(207, 52)
        Me.in_info.TabIndex = 2
        Me.in_info.TabStop = False
        Me.in_info.Text = "Test other information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3rd Line"
        '
        'uc_test_customctr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.in_info)
        Me.Controls.Add(Me.in_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uc_test_customctr"
        Me.Size = New System.Drawing.Size(248, 148)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents in_name As System.Windows.Forms.TextBox
    Friend WithEvents in_info As System.Windows.Forms.TextBox

End Class
