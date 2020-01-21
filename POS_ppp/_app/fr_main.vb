Public Class fr_main
    Public MainMenu As New MenuStrip
    Public isForcedClose As Boolean = False
    Public KodeMenu As New List(Of String)

    Private _OpenedUserControlName As String = String.Empty
    Private _OpenedUserControl As Object = Nothing

    'FIRST LOAD
    Private Sub fr_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _login As New fr_login With {.Owner = Me}

        'CHECK FONT
        For Each _font As String In {"Open Sans", "Source Sans Pro"}
            If Not IsFontInstalled(_font) Then
                Dim _idx As Integer = 0
                Select Case _font
                    Case "Open Sans"
                        _idx = 1 : OpenSans_Self = True
                    Case "Source Sans Pro"
                        _idx = 2 : SourceSans_Self = True
                    Case Else : GoTo NextFont
                End Select

                For Each _file As String In IO.Directory.GetFiles(AppDir_SystemDir & "font\" & _idx & "\")
                    If _file.Split(".").Last = "ttf" Then AddFontResource(_file)
                Next
            End If
NextFont:
        Next

        Me.Cursor = Cursors.AppStarting
        _login.DoLoadForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    'MENU HANDLE
    Public Sub MenuItemClicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim mnName As String = DirectCast(sender, ToolStripItem).Name
        Dim mnLabel As String = DirectCast(sender, ToolStripItem).Text
        Dim mnChld As Boolean = DirectCast(sender, ToolStripMenuItem).HasDropDownItems

        Me.Cursor = Cursors.WaitCursor

        Select Case mnName

            Case Else
                If Not mnChld Then
                    MessageBox.Show("Maaf fungsi ini masih dalam perbaikan/maintenance atau belum tersedia.", mnLabel, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
        End Select

        Me.Cursor = Cursors.Default
    End Sub

    'LOAD USER CONTROL
    Public Sub LoadUserControl(UserControlType As String)
        Try
            If _OpenedUserControlName = UserControlType Then Exit Sub

            'LOAD USER CONTROL
            UnloadUserControl()
            _OpenedUserControlName = UserControlType
            If UserControlType = "pos" Then
                Dim x = New fr_transaction
                x.LoadControl(pnl_main)
                _OpenedUserControl = x

            Else
                _OpenedUserControlName = String.Empty
            End If

        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat memuat list/dialog." & Environment.NewLine & ex.Message,
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            pnl_main.Controls.Clear()
            _OpenedUserControlName = String.Empty
            _OpenedUserControl = Nothing
        End Try
    End Sub

    'UNLOAD USER CONTROL
    Public Sub UnloadUserControl()
        Try
            pnl_main.Hide()
            pnl_main.Controls.Clear()
            pnl_main.Show()
            _OpenedUserControl = Nothing
            _OpenedUserControlName = String.Empty
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat melakukan penutupan list/dialog." & Environment.NewLine & ex.Message,
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'REFRESH USER CONTROL
    Public Sub RefreshUserControl(Optional ReferredUserControl As String = "")
        Try
            If Not String.IsNullOrWhiteSpace(ReferredUserControl) Then
                If ReferredUserControl <> _OpenedUserControlName Then Exit Sub
            End If
            If Not String.IsNullOrWhiteSpace(_OpenedUserControlName) Then _OpenedUserControl.PerformRefresh()
        Catch missingmember As MissingMemberException
            LogError(missingmember)
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat melakukan refresh list/dialog." & Environment.NewLine & ex.Message,
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'CLOSING APPLICATION
    Private Sub main_closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isForcedClose = False Then
            Dim msg = MessageBox.Show("Tutup Aplikasi?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                Try
                    If Not LoggedUser.IsEmpty Then LogOut(False)
                Catch ex As Exception
                    LogError(ex)
                End Try
            End If
        End If
    End Sub

    'LOGING OUT
    Private Sub LogOut(Optional ShowLogin As Boolean = True)
        'UPDATE LOGIN DATA
        'Using x = MainConnection
        '    x.Open() : If x.ConnectionState = ConnectionState.Open Then
        '        Dim q = "UPDATE pefindo_log_login SET log_status=2, log_end=NOW() WHERE log_sess='{0}'"
        '        x.ExecCommand(String.Format(q, LoggedUser.User_Session))
        '    End If
        'End Using
        LoggedUser = New UserData

        If ShowLogin Then
            Dim _login As New fr_login
            Me.Opacity = 0 : Me.Visible = False

            'CLEAR/RESET ALL USER BASED CONTROL
            MainMenu.Items.Clear()
            If Me.Controls.Contains(MainMenu) Then Me.Controls.Remove(MainMenu)
            UnloadUserControl()

            _login.DoLoadForm(Me)
        End If
    End Sub

    'UI : BUTTON
    Private Sub bt_pos_Click(sender As Object, e As EventArgs) Handles bt_pos.Click
        LoadUserControl("pos")
    End Sub
End Class
