<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_order_simple
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
        Me.in_name.BackColor = System.Drawing.Color.White
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
        'uc_order_simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.in_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uc_order_simple"
        Me.Size = New System.Drawing.Size(250, 100)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents in_name As System.Windows.Forms.TextBox

End Class
