Imports System.Data.SqlClient

Public Class clsKoneksi
    Protected Cmd As SqlCommand
    Protected Conn As SqlConnection
    Protected Da As SqlDataAdapter

    Protected Ds As DataSet
    Protected Dt As DataTable

    Public Function OpenConn() As Boolean
        Conn = New SqlConnection("Data Source=ALPHA\ITD;" _
                               & "Initial Catalog=DB_AKADEMIK;" _
                               & "Integrated Security=True")
        Conn.Open()
        If Conn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(Conn) Then
            Conn.Close()
            Conn = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal....!", MsgBoxStyle.Critical, " Access Failed")
            Return Nothing
            Exit Function
        End If

        Cmd = New SqlCommand(Query, Conn)
        Da = New SqlDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal...!", MsgBoxStyle.Critical, "Access Failed")
            Exit Sub
        End If

        Cmd = New SqlCommand

        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class
