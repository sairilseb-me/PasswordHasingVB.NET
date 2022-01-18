
Public Class EncryptionClass
    'Instantiate Random Crypto Provider
    Private Shared cryptoServiceProvider As System.Security.Cryptography.RNGCryptoServiceProvider

    'Create a hash string
    Public Shared Function hashString(str As String) As String
        Return encryptString(str)
    End Function

    'Generate Salt
    Public Shared Function GenerateSalt() As String
        Using cryptoServiceProvider As New System.Security.Cryptography.RNGCryptoServiceProvider
            Dim sb As New System.Text.StringBuilder()
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 6
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next
            Return encryptString(sb.ToString())
        End Using

    End Function

    'Encrypting Function
    Private Shared Function encryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function
End Class
