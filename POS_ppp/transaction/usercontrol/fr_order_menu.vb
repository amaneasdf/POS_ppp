Public Class fr_order_menu
    Dim _Order_allowInput As Boolean = False

    Public Async Sub DoLoadForm(ParentControl As Control)
        Me.Dock = DockStyle.Fill
        ParentControl.Controls.Add(Me)
        SetupOrderForm()

        Dim x = Await Task.Run(Function() DoLoadCategory())
        If Not x("result") Then
            MessageBox.Show(x("message"), "Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim _ff = New TouchScroll(fpnl_kateg)
    End Sub

    'LOAD ITEM KATEGORY
    Private Function DoLoadCategory() As Dictionary(Of String, Object)
        Try
            Using x = New MySqlThing("117.53.47.193", "pos_trial", "mamad", "Honocoroko11")
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = "SELECT item_k_koderef, item_k_nama FROM data_item_kateg WHERE item_k_status=1 ORDER BY item_k_order"
                    Dim i As Integer = 0
                    Using rdx = x.ReadCommand(q)
                        While rdx.Read
                            Dim _btkat As New Button With {
                                .Name = rdx.Item("item_k_koderef"),
                                .BackColor = System.Drawing.Color.White,
                                .ForeColor = System.Drawing.Color.SlateGray,
                                .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                                .Font = New System.Drawing.Font("Open Sans", 9.25!, System.Drawing.FontStyle.Bold),
                                .Text = rdx.Item("item_k_nama"),
                                .Size = New System.Drawing.Size(125, 50),
                                .Location = New Point(3, 20),
                                .TabStop = False
                            }
                            _btkat.FlatAppearance.BorderSize = 1
                            _btkat.FlatAppearance.BorderColor = Color.Gainsboro

                            If InvokeRequired Then
                                Invoke(Sub()
                                           fpnl_kateg.Controls.Add(_btkat)
                                       End Sub)
                            Else
                                fpnl_kateg.Controls.Add(_btkat)
                            End If
                            AddHandler _btkat.Click, AddressOf btkategori_click

                            i += 1
                        End While
                    End Using

                    If i > 0 Then
                        Return New Dictionary(Of String, Object) From {{"result", True}}
                    Else
                        Return New Dictionary(Of String, Object) From {{"result", False}, {"message", "Data kategori item tidak ditemukan."}}
                    End If
                Else
                    Return New Dictionary(Of String, Object) From {{"result", False}, {"message", "Tidak dapat terhubung ke database."}}
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            Return New Dictionary(Of String, Object) From {
                {"result", False},
                {"message", "Terjadi kesalahan saat melakukan pengambilan data kategori item." & Environment.NewLine & "Error : " & ex.Message}
            }
        End Try
    End Function

    Private Function DoLoadMenu(IdKateg As String) As Dictionary(Of String, Object)
        Try
            Using x = New MySqlThing("117.53.47.193", "pos_trial", "mamad", "Honocoroko11")
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = "SELECT item_koderef, item_photo, item_nama FROM data_item " _
                                      & "WHERE item_kateg='{0}' AND item_status=1 ORDER BY item_nama"
                    Using rdx = x.ReadCommand(String.Format(q, IdKateg))
                        While rdx.Read
                            Dim _picbox As New PictureBox With {
                                .Name = rdx.Item("item_koderef"),
                                .Width = 150,
                                .Height = 150,
                                .BackColor = Color.White,
                                .BackgroundImageLayout = ImageLayout.Stretch
                            }

                            Dim _urlImg As String = rdx.Item("item_photo")
                            If Not String.IsNullOrWhiteSpace(_urlImg) Then
                                Dim _tempMemStr = New IO.MemoryStream(New Net.WebClient().DownloadData(_urlImg))
                                Dim _tempImage = Bitmap.FromStream(_tempMemStr)
                                _picbox.BackgroundImage = _tempImage
                            End If

                            'VVV STREAM FILE USING FTP
                            'Dim _ftpreq As Net.FtpWebRequest = Net.WebRequest.Create("")
                            '_ftpreq.Credentials = New Net.NetworkCredential("", "")
                            '_ftpreq.Method = Net.WebRequestMethods.Ftp.DownloadFile
                            'Using _sss = _ftpreq.GetResponse.GetResponseStream()
                            '    Dim _tempImage = Bitmap.FromStream(_sss)
                            '    _picbox.BackgroundImage = _tempImage
                            'End Using

                            If InvokeRequired Then
                                Invoke(Sub()
                                           fpnl_main.Controls.Add(_picbox)
                                       End Sub)
                            Else
                                fpnl_main.Controls.Add(_picbox)
                            End If
                            AddHandler _picbox.Click, AddressOf picbox_click

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
                {"message", "Terjadi kesalahan saat melakukan pengambilan daftar item." & Environment.NewLine & "Error : " & ex.Message}
            }
        End Try
    End Function

    'NEW ORDER
    Private Sub SetupOrderForm()
        If dgv_test.RowCount > 0 Then
            Dim _resp = MessageBox.Show("Batalkan order sebelumnya dan buat order baru?", "New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If _resp <> DialogResult.Yes Then Exit Sub
        End If
        dgv_test.Rows.Clear()

        For Each _txt As TextBox In {in_subtot, in_disk, in_tax, in_total, in_table}
            _txt.Clear()
        Next
        Dim _style = dgvstyle_commathousand
        _style.Font = item_total.DefaultCellStyle.Font
        item_total.DefaultCellStyle = _style

        in_table.ReadOnly = True
        ck_eatin.Checked = False
        ck_takeaway.Checked = False

        InputingOrder = False
        bt_proses.Enabled = False
        bt_del.Enabled = False
    End Sub

    'ADD ITEM
    Private Function AddItem(IdItem As String) As Dictionary(Of String, Object)
        Try
            Using x = New MySqlThing("117.53.47.193", "pos_trial", "mamad", "Honocoroko11")
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim _itemdata As New Dictionary(Of String, Object)

                    'GET DATA ITEM
                    Dim q As String = "SELECT item_koderef, item_nama FROM data_item WHERE item_koderef='{0}'"
                    Using rdx = x.ReadCommand(String.Format(q, IdItem))
                        Dim red = rdx.Read
                        If red And rdx.HasRows Then
                            'BUILD DATAITEM DICTIONARY
                            _itemdata.Add("id", IdItem)
                            _itemdata.Add("name", rdx.Item("item_nama"))
                            _itemdata.Add("price", 1000)
                            _itemdata.Add("discount", 0)

                        Else
                            Return New Dictionary(Of String, Object) From {{"result", False}, {"message", "Tidak dapat menemukan data untuk item " & IdItem & "."}}
                        End If
                    End Using

                    'ADD TO DATAGRID
                    AddItem_DGV(_itemdata)
                    InputingOrder = True
                    Return New Dictionary(Of String, Object) From {{"result", True}}
                Else
                    Return New Dictionary(Of String, Object) From {{"result", False}, {"message", "Tidak dapat terhubung ke database."}}
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            Return New Dictionary(Of String, Object) From {
                {"result", False},
                {"message", "Terjadi kesalahan saat menambahkan item." & Environment.NewLine & ex.Message}
            }
        End Try
    End Function

    'DATAGRID
    Private Sub AddItem_DGV(DataItem As Dictionary(Of String, Object))
        If InvokeRequired Then
            Invoke(Sub() AddItem_DGV(DataItem))
        Else
            With dgv_test
                Dim i = .Rows.Add
                .Rows(i).Cells("item_id").Value = DataItem("id")
                .Rows(i).Cells("item_name").Value = DataItem("name")
                .Rows(i).Cells("item_count").Value = 1
                .Rows(i).Cells("item_price").Value = DataItem("price")
                .Rows(i).Cells("item_disk").Value = DataItem("discount")

                Item_CountPrice(i)
                .ClearSelection()
            End With

            bt_proses.Enabled = True
            bt_del.Enabled = True
        End If
    End Sub

    Private Sub Item_CountPrice(RowIndex As Integer)
        If RowIndex > -1 Then
            With dgv_test.Rows(RowIndex)
                Dim _ct = .Cells("item_count").Value
                Dim _price = .Cells("item_price").Value
                Dim _disk = .Cells("item_disk").Value

                .Cells("item_total").Value = _ct * (_price - _disk)
            End With

            Item_CountTotal()
        End If
    End Sub

    Private Sub Item_CountTotal()
        Dim _disk As Decimal = 0
        Dim _value As Decimal = 0

        For Each _r As DataGridViewRow In dgv_test.Rows
            _disk += _r.Cells("item_count").Value * _r.Cells("item_disk").Value
            _value += _r.Cells("item_count").Value * _r.Cells("item_price").Value
        Next

        Dim _tax As Decimal = 0.1 * (_value - _disk)
        Dim _total As Decimal = (_value - _disk) + _tax

        in_subtot.Text = commaThousand(_value)
        in_disk.Text = commaThousand(_disk)
        in_tax.Text = commaThousand(_tax)
        in_total.Text = commaThousand(_total)
    End Sub

    'CREATE ORDER
    Private Sub SaveOrder()
        Try
            Using x = New MySqlThing("117.53.47.193", "pos_trial", "mamad", "Honocoroko11")
                x.Open() : If x.ConnectionState = ConnectionState.Open Then
                    Dim q As String = ""
                    Dim _type As String = If(ck_eatin.Checked, "IN", "TK")
                    Dim _fr = {"order_type='" & 1 & "'",
                               "order_date=CURDATE()",
                               "order_time=NOW()",
                               "order_status=0"
                              }
                Else
                    MessageBox.Show("Tidak dapat terhubung ke database.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            LogError(ex)

        End Try
    End Sub


    'UI : ITEM
    Private Async Sub btkategori_click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor

        'CHANGE STYLE
        For Each _ctr As Control In fpnl_kateg.Controls
            If _ctr.GetType = GetType(Button) Then
                If _ctr.Name = sender.Name Then
                    _ctr.BackColor = System.Drawing.Color.Blue
                    _ctr.ForeColor = System.Drawing.Color.White
                Else
                    _ctr.BackColor = System.Drawing.Color.White
                    _ctr.ForeColor = System.Drawing.Color.SlateGray
                End If
            End If
        Next

        fpnl_kateg.Enabled = False

        'GET MENU
        fpnl_main.Controls.Clear()
        Dim _idKateg = sender.Name
        Dim x = Await Task.Run(Function() DoLoadMenu(_idKateg))
        If Not x("result") Then
            MessageBox.Show(x("message"), "Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim _ss = New TouchScroll(fpnl_main)
        fpnl_kateg.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub bt_proses_Click(sender As Object, e As EventArgs) Handles bt_proses.Click
        If Not ck_eatin.Checked Or Not ck_takeaway.Checked Then ck_eatin.Checked = True
        If dgv_test.RowCount = 0 Then
            MessageBox.Show("Pilih menu terlebih dahulu.")
        End If
    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        SetupOrderForm()
    End Sub

    'UI : PICBOX
    Private Async Sub picbox_click(sender As Object, e As EventArgs)
        Dim x = Await Task.Run(Function() AddItem(sender.Name))
        If Not x("result") Then
            MessageBox.Show(x("message"), "Menu", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'UI : CHECKBOX
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ck_takeaway.CheckedChanged, ck_eatin.CheckedChanged
        If sender.Checked Then
            If sender.Name = ck_takeaway.Name Then
                ck_eatin.Checked = Not sender.Checked
            Else
                ck_takeaway.Checked = Not sender.Checked
            End If
        End If

        in_table.ReadOnly = Not ck_eatin.Checked
        If in_table.ReadOnly Then in_table.Clear()
    End Sub

    Private Sub bt_item_del_Click(sender As Object, e As EventArgs) Handles bt_item_del.Click, bt_item_rem.Click, bt_item_add.Click, Button1.Click
        If dgv_test.SelectedRows.Count > 0 Then
            Dim _idx = dgv_test.SelectedRows(0).Index

            Select Case sender.Name
                Case bt_item_add.Name
                    dgv_test.SelectedRows(0).Cells("item_count").Value += 1
                    Item_CountPrice(_idx)

                Case bt_item_rem.Name
                    If dgv_test.SelectedRows(0).Cells("item_count").Value = 1 Then
                        Dim _resp = MessageBox.Show("Hapus item?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If _resp <> DialogResult.Yes Then Exit Sub
                        bt_item_del.PerformClick() : Exit Sub
                    Else
                        dgv_test.SelectedRows(0).Cells("item_count").Value -= 1
                    End If
                    Item_CountPrice(_idx)

                Case bt_item_del.Name
                    For Each _rows As DataGridViewRow In dgv_test.SelectedRows
                        _idx = _rows.Index
                        dgv_test.Rows.RemoveAt(_idx)
                    Next
                    dgv_test.ClearSelection()
                    Item_CountTotal()
            End Select

        End If
    End Sub
End Class
