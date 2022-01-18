Imports MySql.Data.MySqlClient

Public Class Form2

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Encrypt the Password
        Dim password = EncryptionClass.hashString(txtSubmitPassword.Text.Trim)
        'Create a Salt 
        Dim salt = EncryptionClass.GenerateSalt()
        'Add the Encrypt Password and Salt
        Dim hashedAndSalted = EncryptionClass.hashString(String.Format($"{password}{salt}"))

        Try
            Await openCon(con)
            Dim checkUser As String
            checkUser = "Select userName from testtable Where userName = @user"
            Dim sqlcommand As MySqlCommand = New MySqlCommand(checkUser, con)
            'Checks if there is a duplicate username
            sqlcommand.Parameters.AddWithValue("@user", txtSubmitUsername.Text.Trim)
            Dim sqlRD As MySqlDataReader = sqlcommand.ExecuteReader

            If sqlRD.Read Then
                'Error, there is a duplicate
                MessageBox.Show("There is already a user with that user name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Insert username and hashed and salted password
                Try
                    Dim insertUser As String
                    insertUser = "Insert into testtable (userName, userPass, insertS) values (@userName, @userPass, @insertS)"
                    Dim sqlcommand0 As MySqlCommand = New MySqlCommand(insertUser, con)
                    'Insert username, hashed and salted password and inset salt
                    sqlcommand0.Parameters.AddWithValue("@userName", txtSubmitUsername.Text.Trim)
                    sqlcommand0.Parameters.AddWithValue("@userPass", hashedAndSalted)
                    sqlcommand0.Parameters.AddWithValue("@insertS", salt)
                    sqlRD.Close()
                    sqlcommand0.ExecuteNonQuery()
                    sqlcommand0.Dispose()
                    MessageBox.Show("Successfully added a user.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            sqlcommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeCon()
        End Try


    End Sub

    Private Async Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Try
            Await openCon(con)
            Dim sqlRD As MySqlDataReader

            Dim checkHash As String

            'get the salt from database
            checkHash = "Select insertS from testtable Where userName = @user"
            Dim sqlcommand As MySqlCommand = New MySqlCommand(checkHash, con)
            sqlcommand.Parameters.AddWithValue("@user", txtFetchUsername.Text.Trim)
            sqlRD = sqlcommand.ExecuteReader
            If sqlRD.Read Then
                Dim salt As String
                salt = sqlRD("insertS").ToString
                sqlRD.Close()
                'Encrypt the password
                Dim password = EncryptionClass.hashString(txtFetchPassword.Text.Trim)
                'Combone Hashed Password with Salt
                Dim hashedAndSalted = EncryptionClass.hashString(String.Format($"{password}{salt}"))

                'Checks if there is a data from DB with the same hashed and salted password
                Dim checkString As String
                checkString = "Select userName from testtable Where userName = @user and userPass = @pass"
                Dim sqlcommand0 As MySqlCommand = New MySqlCommand(checkString, con)
                sqlcommand0.Parameters.AddWithValue("@user", txtFetchUsername.Text.Trim)
                sqlcommand0.Parameters.AddWithValue("@pass", hashedAndSalted)

                sqlRD = sqlcommand0.ExecuteReader
                Try
                    If sqlRD.Read Then
                        MessageBox.Show($"Login Successful!! Welcome, {sqlRD("userName").ToString}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        sqlRD.Close()
                        sqlcommand0.Dispose()
                    Else
                        MsgBox("Error!")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MsgBox("No User of that name.", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeCon()
        End Try
    End Sub
End Class