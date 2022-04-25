<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDecrypt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPublickey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrivateKey = New System.Windows.Forms.TextBox()
        Me.btnCreateKey = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập dữ liệu vào:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 35)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(472, 48)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "Mã hóa và giải mã RSA - http://laptrinhvb.net"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Chuỗi mã hóa RSA:"
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Location = New System.Drawing.Point(15, 124)
        Me.txtEncrypt.Multiline = True
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(472, 127)
        Me.txtEncrypt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Chuỗi đã giải mã RSA:"
        '
        'txtDecrypt
        '
        Me.txtDecrypt.Location = New System.Drawing.Point(15, 302)
        Me.txtDecrypt.Multiline = True
        Me.txtDecrypt.Name = "txtDecrypt"
        Me.txtDecrypt.Size = New System.Drawing.Size(472, 166)
        Me.txtDecrypt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(541, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Public key:"
        '
        'txtPublickey
        '
        Me.txtPublickey.Location = New System.Drawing.Point(540, 124)
        Me.txtPublickey.Multiline = True
        Me.txtPublickey.Name = "txtPublickey"
        Me.txtPublickey.Size = New System.Drawing.Size(388, 127)
        Me.txtPublickey.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Private key:"
        '
        'txtPrivateKey
        '
        Me.txtPrivateKey.Location = New System.Drawing.Point(540, 302)
        Me.txtPrivateKey.Multiline = True
        Me.txtPrivateKey.Name = "txtPrivateKey"
        Me.txtPrivateKey.Size = New System.Drawing.Size(388, 166)
        Me.txtPrivateKey.TabIndex = 9
        '
        'btnCreateKey
        '
        Me.btnCreateKey.Location = New System.Drawing.Point(709, 85)
        Me.btnCreateKey.Name = "btnCreateKey"
        Me.btnCreateKey.Size = New System.Drawing.Size(219, 23)
        Me.btnCreateKey.TabIndex = 10
        Me.btnCreateKey.Text = "Tạo khóa private và Public"
        Me.btnCreateKey.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(370, 90)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(117, 23)
        Me.btnEncrypt.TabIndex = 11
        Me.btnEncrypt.Text = "Mã hóa RSA"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(361, 264)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(126, 23)
        Me.btnDecrypt.TabIndex = 12
        Me.btnDecrypt.Text = "Giải mã RSA"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RSAEncryptDecrypt_vb.My.Resources.Resources.rsa_thumb
        Me.PictureBox2.Location = New System.Drawing.Point(709, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RSAEncryptDecrypt_vb.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(828, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 476)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.btnCreateKey)
        Me.Controls.Add(Me.txtPrivateKey)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPublickey)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDecrypt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEncrypt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mã hóa và Giải mã RSA - http://laptrinhvb.net"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEncrypt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDecrypt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPublickey As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrivateKey As TextBox
    Friend WithEvents btnCreateKey As Button
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
