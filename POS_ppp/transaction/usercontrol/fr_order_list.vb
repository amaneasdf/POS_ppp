Public Class fr_order_list
    Dim _timer As New Timer With {.Interval = 10000}

    Public Async Sub DoLoadForm(ParentControl As Control)
        Me.Dock = DockStyle.Fill
        ParentControl.Controls.Add(Me)

        Dim _status = 1
        For Each _pnl As FlowLayoutPanel In {fpnl_onprog, fpnl_main}
            Dim _x = Await Task.Run(Function() LoadOrderList(_status))
            If Not _x("result") Then
                MessageBox.Show(_x("message"), "Order List", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            _status += 1
        Next
    End Sub

    Private Function LoadOrderList(OrderStatus As Integer, Optional ParamDict As Dictionary(Of String, Object) = Nothing) As Dictionary(Of String, Object)
        Try
            Using x = New MySqlThing(MainConnData.host, MainConnData.db, MainConnData.uid, MainConnData.pwd)
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = "SELECT order_no FROM data_order WHERE order_status='{0}'"
                    Using rdx = x.ReadCommand(String.Format(q, OrderStatus, LoggedUser.User_Alias))
                        While rdx.Read
                            Select Case OrderStatus
                                Case 1

                                Case 2
                                    AddItem_Completed(rdx.Item("order_no"))
                                Case Else
                                    Throw New Exception("Wrong input value for order status value.")
                            End Select
                        End While
                    End Using

                    Return New Dictionary(Of String, Object) From {{"result", True}}
                Else
                    Return New Dictionary(Of String, Object) From {{"result", False}, {"message", "Tidak dapat terhubung ke database."}}
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            Return New Dictionary(Of String, Object) From {
                {"result", False},
                {"message", "Terjadi kesalahan saat melakukan pengambilan daftar order." & Environment.NewLine & "Error : " & ex.Message}
            }
        End Try
    End Function

    Private Sub AddItem_Completed(DataID As String)
        If InvokeRequired Then
            Invoke(Sub() AddItem_Completed(DataID))
        Else
            For i = 1 To 10
                Dim y = New uc_order_simple
                y.DataID = DataID
                fpnl_main.Controls.Add(y)
            Next
        End If
    End Sub

    Private Sub TouchScrollPanel(OrderStatus As Integer)
        If InvokeRequired Then
            Invoke(Sub() TouchScrollPanel(OrderStatus))
        Else
            Select Case OrderStatus
                Case 1
                    Dim _ff = New TouchScroll(fpnl_onprog)
                Case 2
                    Dim _ff = New TouchScroll(fpnl_main)
            End Select
        End If
    End Sub

    'HANDLE PANEL/USERCONTROL CLICK EVENT
    Private Sub order_Click(sender As Object, e As EventArgs)

    End Sub

    'OPEN ORDER DDETAIL WINDOW
    Private Sub ShowOrderDetail(OrderId As String)
        Try

        Catch ex As Exception
            LogError(ex)
            MessageBox.Show("Terjadi kesalahan saat melakukan pengambilan data order." & Environment.NewLine & "Error : " & ex.Message,
                            "Order List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
