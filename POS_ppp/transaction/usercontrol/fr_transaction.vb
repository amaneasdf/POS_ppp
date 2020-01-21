Public Class fr_transaction

    Private _OpenedUserControlName As String = String.Empty
    Private _OpenedUserControl As Object = Nothing

    'LOAD USERCONTROL
    Public Sub LoadControl(ParentControl As Control)
        Me.Dock = DockStyle.Fill
        ParentControl.Controls.Add(Me)
        LoadUserControl("order_home")
    End Sub

    'LOAD USERCONTROL
    Public Sub LoadUserControl(UserControlType As String)
        Try
            If _OpenedUserControlName = UserControlType Then Exit Sub

            'LOAD USER CONTROL
            UnloadUserControl()
            _OpenedUserControlName = UserControlType

            If UserControlType = "order_home" Then
                _OpenedUserControl = Nothing
                _OpenedUserControlName = String.Empty

            ElseIf UserControlType = "order_new" Then
                Dim x = New fr_order_menu
                x.DoLoadForm(pnl_content)
                _OpenedUserControl = x

            ElseIf UserControlType = "order_list" Then
                Dim x = New fr_order_list
                x.DoLoadForm(pnl_content)
                _OpenedUserControl = x

            ElseIf UserControlType = "order_pay" Then
                Dim x = New fr_order_pay
                x.DoLoadForm(pnl_content)
                _OpenedUserControl = x

            Else
                _OpenedUserControlName = String.Empty
            End If

        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat memuat list/dialog." & Environment.NewLine & ex.Message,
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            pnl_content.Controls.Clear()
            _OpenedUserControlName = String.Empty
            _OpenedUserControl = Nothing
        End Try
    End Sub

    'UNLOAD USER CONTROL
    Public Sub UnloadUserControl()
        Try
            pnl_content.Hide()
            pnl_content.Controls.Clear()
            pnl_content.Show()
            _OpenedUserControl = Nothing
            _OpenedUserControlName = String.Empty
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat melakukan penutupan list/dialog." & Environment.NewLine & ex.Message,
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'UI : BUTTON
    Private Sub bt_cl_Click(sender As Object, e As EventArgs) Handles bt_cl.Click
        fr_main.UnloadUserControl()
    End Sub

    Private Sub bt_menu_Click(sender As Object, e As EventArgs) Handles bt_menu.Click, bt_order.Click, bt_pay.Click
        Dim _type As String = ""
        Select Case sender.Name
            Case bt_menu.Name : _type = "order_new"
            Case bt_order.Name : _type = "order_list"
            Case bt_pay.Name : _type = "order_pay"
            Case Else : Exit Sub
        End Select

        LoadUserControl(_type)

        For Each _bt As Button In {bt_menu, bt_order, bt_pay}
            If sender.Name = _bt.Name Then
                _bt.ForeColor = Color.MidnightBlue
            Else
                _bt.ForeColor = Color.SlateGray
            End If
        Next
    End Sub
End Class
