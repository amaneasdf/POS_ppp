Public Class uc_order_simple
    Private border_width As Integer = 0
    Private border_color As Color = Color.Black
    Private _tooltip As New ToolTip

    Private _DataID As String
    Private _DataName As String
    Private _DataInfo As String

    Public Property BorderWidth() As Integer
        Get
            Return Me.border_width
        End Get
        Set(ByVal value As Integer)
            Me.border_width = Math.Abs(value)
            Me.Refresh()
        End Set
    End Property
    Public Property BorderColor() As Color
        Get
            Return Me.border_color
        End Get
        Set(ByVal value As Color)
            Me.border_color = value
            Me.Refresh()
        End Set
    End Property

    Public Property DataID As String
        Set(value As String)
            lbl_id.Text = If(value.Length > 20, Strings.Left(value, 17) & "...", value)
            If value.Length > 20 Then
                _tooltip.SetToolTip(lbl_id, value)
            Else
                _tooltip.SetToolTip(lbl_id, Nothing)
            End If
            _DataID = value
        End Set
        Get
            Return _DataID
        End Get
    End Property
    Public Property DataName As String
        Set(value As String)
            in_name.Text = value
        End Set
        Get
            Return in_name.Text
        End Get
    End Property

    Public Sub New()
        SetupUserControl()
    End Sub

    Public Sub New(DataID As String)
        SetupUserControl()

        GetData(DataID)
    End Sub

    Private Sub SetupUserControl()
        ' This call is required by the designer.
        InitializeComponent()

        Me.BorderStyle = Windows.Forms.BorderStyle.None

        For Each _ctr As Control In {lbl_id, in_name}
            _ctr.Text = ""
            AddHandler _ctr.Click, AddressOf Label2_Click
            If _ctr.GetType = GetType(TextBox) Then AddHandler _ctr.Enter, AddressOf TextBox1_Enter
        Next
    End Sub

    Public Sub GetData(DataID As String)
        Try
            Me.DataID = DataID

            Using x = New MySqlThing(MainConnData.host, MainConnData.db, MainConnData.uid, MainConnData.pwd)
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = ""

                Else

                End If
            End Using
        Catch ex As Exception
            LogError(ex)

        End Try
    End Sub

    Public Overridable Sub MyPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        If BorderWidth > 0 Then e.Graphics.DrawRectangle(New Pen(Me.border_color, Me.border_width), Me.ClientRectangle)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.OnClick(e)
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs)
        lbl_id.Focus()
        sender.Enabled = False
        sender.Enabled = True
    End Sub
End Class
