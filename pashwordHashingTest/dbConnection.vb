Imports MySql.Data.MySqlClient


Module dbConnection

    Public con As New MySqlConnection

    Public Async Function openCon(cn As MySqlConnection) As Task(Of Boolean)
        Try
            con.ConnectionString = "server=localhost; database=test; Uid=root;Password=;"
            Await con.OpenAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return con.State
    End Function


    Public Sub closeCon()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Module
