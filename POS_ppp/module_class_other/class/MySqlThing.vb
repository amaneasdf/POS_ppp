Imports MySql.Data.MySqlClient

Public Class MySqlThing : Implements IDisposable
    Private Const connstring As String = "Server={0};Database={1};Uid={2};Pwd={3};Allow User Variables=TRUE;"
    Private Const connstring2 As String = "Server={0};Port={1};Database={2};Uid={3};Pwd={4};Allow User Variables=TRUE;"
    Private _host As String
    Private _port As Integer
    Private _db As String
    Private _Uid As String
    Private _pass As String
    Private conn As MySqlConnection
    Protected disposed As Boolean = False

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        If Not Me.disposed Then
            If disposing Then
                conn.Dispose()
            End If
            For Each x As String In {_host, _db, _Uid, _pass}
                x = String.Empty
            Next
            ' Insert code to free unmanaged resources.  
        End If
        Me.disposed = True
    End Sub

    Public Property ConnectionString As String
        Get
            Return conn.ConnectionString
            'Return String.Format(connstring, _host, _db, _Uid, _pass)
        End Get
        Set(value As String)
            Dim x = New MySqlConnectionStringBuilder(value)
            _host = x.Server
            _db = x.Database
            _Uid = x.UserID
            _pass = x.Password

            If conn Is Nothing Then
                conn = New MySqlConnection(String.Format(value))
            Else
                conn.ConnectionString = value
            End If
        End Set
    End Property

    Public ReadOnly Property ConnectionState As ConnectionState
        Get
            Return conn.State
        End Get
    End Property

    Public Property Host As String
        Get
            Return _host
        End Get
        Set(value As String)
            _host = value
        End Set
    End Property

    Public Property Port As Integer
        Get
            Return _port
        End Get
        Set(value As Integer)
            _port = value
        End Set
    End Property

    Public Property Database As String
        Get
            Return _db
        End Get
        Set(value As String)
            _db = value
        End Set
    End Property

    Public WriteOnly Property UId As String
        Set(value As String)
            _Uid = value
        End Set
    End Property

    Public WriteOnly Property Password As String
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public ReadOnly Property Connection As MySqlConnection
        Get
            Return conn
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ConnectionString As String)
        conn = New MySqlConnection(ConnectionString)
    End Sub

    Public Sub New(server As String, db As String, uid As String, pass As String)
        conn = New MySqlConnection(String.Format(connstring, server, db, uid, pass))
        _host = server : _db = db : _Uid = uid : _pass = pass
    End Sub

    Public Sub New(server As String, port As Integer, db As String, uid As String, pass As String)
        conn = New MySqlConnection(String.Format(connstring2, server, port, db, uid, pass))
        _host = server : _port = port : _db = db : _Uid = uid : _pass = pass
    End Sub

    Public Sub Open()
        If Not conn.State = ConnectionState.Open Then
            Try
                conn.Open()
            Catch ex As Exception
                LogError(ex)
            End Try
        End If
    End Sub

    'Public Function OpenAsync() As Task
    '    Dim x As New TaskCompletionSource(Of Object)
    '    If Not conn.State = ConnectionState.Open Then
    '        Try
    '            conn.OpenAsync()
    '            x.SetResult(Nothing)
    '        Catch ex As Exception
    '            x.SetException(ex)
    '        End Try
    '    Else
    '        x.SetResult("Already Open")
    '    End If
    '    Return x.Task
    'End Function

    Public Function ExecCommand(query As String) As Integer
        Me.Open()
        Return New MySqlCommand(query, conn) With {.CommandTimeout = 0}.ExecuteNonQuery
    End Function

    Public Function ExecScalar(query As String) As Object
        Me.Open()
        Return New MySqlCommand(query, conn) With {.CommandTimeout = 0}.ExecuteScalar()
    End Function

    Public Function ReadCommand(query As String, Optional behavior As System.Data.CommandBehavior = CommandBehavior.Default) As MySqlDataReader
        Me.Open()
        Return New MySqlCommand(query, conn) With {.CommandTimeout = 0}.ExecuteReader(behavior)
    End Function

    Public Function TransactCommand(QueryList As List(Of String)) As Boolean
        If conn Is Nothing Then
            Throw New NullReferenceException("Connection is empty")
        End If

        Dim _ckSw As Boolean = False
        Open()
        If ConnectionState <> Data.ConnectionState.Open Then
            _ckSw = False
        Else
            Using x = conn.BeginTransaction()
                Using _cmd As New MySqlCommand
                    _cmd.Connection = conn : _cmd.Transaction = x
                    For Each q As String In QueryList
                        Try
                            _cmd.CommandText = q
                            _cmd.ExecuteNonQuery()
                            _ckSw = True
                        Catch ex As Exception
                            LogError(ex)
                            _ckSw = False : Exit For
                        End Try
                    Next

                    If _ckSw Then : Try : x.Commit() : Catch ex As Exception : LogError(ex) : _ckSw = False : End Try : End If

                    If Not _ckSw Then : Try : x.Rollback() : _ckSw = False : Catch ex As Exception : LogError(ex) : _ckSw = False : End Try : End If
                End Using
            End Using
        End If

        Return _ckSw
    End Function

    Public Function GetDataTable(query As String) As DataTable
        If conn Is Nothing Then
            Throw New NullReferenceException("Connection is empty")
        End If
        Dim dtable As New DataTable
        Using _cmd As New MySqlCommand(query, conn)
            _cmd.CommandTimeout = 3600
            Me.Open()

            Using data_adpt As New MySqlDataAdapter(_cmd) : data_adpt.Fill(dtable) : End Using
        End Using
        Return dtable
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
