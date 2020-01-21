Public Class fr_order_list
    Dim _timer As New Timer With {.Interval = 10000}

    Public Sub DoLoadForm(ParentControl As Control)
        Me.Dock = DockStyle.Fill
        ParentControl.Controls.Add(Me)

        For _status = 1 To 2

        Next
    End Sub

    Private Function LoadOrderList(OrderStatus As Integer) As Dictionary(Of String, Object)
        Try
            Using x = New MySqlThing("117.53.47.193", "pos_trial", "mamad", "Honocoroko11")
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = "SELECT order_kode FROM data_order WHERE order_status='{0}'"
                    Using rdx = x.ReadCommand(String.Format(q, OrderStatus, LoggedUser.User_Alias))
                        While rdx.Read

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
End Class
