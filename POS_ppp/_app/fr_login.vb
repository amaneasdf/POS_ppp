Public Class fr_login
    Private _ParentForm As Form
    Private _ParentPanel As Panel
    Private _AplicationExit As Boolean = False

    'LOAD FORM
    Public Sub DoLoadForm(ParentForm As Form)
        _ParentForm = ParentForm : Me.Owner = ParentForm
        DarkenParentForm(True, _ParentForm, _ParentPanel)
        SetupForm()
    End Sub

    'SETUP FORM
    Private Sub SetupForm()
        Try
            Me.Opacity = 0
            If GetConnectionSetting() Then
                Me.Opacity = 100 : Me.Show()
            Else
                _AplicationExit = True : fr_main.isForcedClose = True
                Application.Exit()
            End If
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat membuka jendela login." & Environment.NewLine & ex.Message,
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseForm()
        End Try
    End Sub

    'GET CONECTION SETTING
    Private Function GetConnectionSetting() As Boolean
        Try
            Dim _ConnCfgName As String = ""
            Dim _RespMsg As String = ""

            MainConnData = LoadDataConnection(NetworkSettingName)

            Return True
        Catch ex As Exception
            LogError(ex)
            Return False
        End Try
    End Function

    'CLOSING
    Private Sub CloseForm()
        Me.Opacity = 0
        DarkenParentForm(False, _ParentForm, _ParentPanel)
        _ParentForm.Enabled = True
        Me.Close()
    End Sub

    'UI : BUTTON
    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click

        CloseForm()
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        _AplicationExit = True : fr_main.isForcedClose = True
        Application.Exit()
    End Sub
End Class