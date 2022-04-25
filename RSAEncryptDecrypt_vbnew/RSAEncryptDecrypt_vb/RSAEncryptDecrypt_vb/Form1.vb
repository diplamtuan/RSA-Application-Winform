Public Class Form1
    Private Sub btnCreateKey_Click(sender As Object, e As EventArgs) Handles btnCreateKey.Click
        CreateNewKeys()
    End Sub
    Private Sub CreateNewKeys()
        Dim Keys As Encryption.Keypair = Encryption.Keypair.CreateNewKeys
        txtPrivateKey.Text = Keys.Privatekey
        txtPublickey.Text = Keys.Publickey
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Dim EncryptedMessage As Encryption.RSAResult = Encryption.RSA.Encrypt(txtInput.Text, txtPublickey.Text)
        txtEncrypt.Text = EncryptedMessage.AsBase64String
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim EncryptedMessage As Encryption.RSAResult = Encryption.RSA.Encrypt(txtInput.Text, txtPublickey.Text)
        Dim DecryptedMessage As Encryption.RSAResult = Encryption.RSA.Decrypt(EncryptedMessage.AsBytes, txtPrivateKey.Text)
        txtDecrypt.Text = DecryptedMessage.AsString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateNewKeys()
    End Sub
End Class
