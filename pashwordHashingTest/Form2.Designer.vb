<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtSubmitPassword = New System.Windows.Forms.TextBox()
        Me.txtSubmitUsername = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.txtFetchPassword = New System.Windows.Forms.TextBox()
        Me.txtFetchUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.txtSubmitPassword)
        Me.Panel1.Controls.Add(Me.txtSubmitUsername)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 513)
        Me.Panel1.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(156, 274)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(123, 42)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtSubmitPassword
        '
        Me.txtSubmitPassword.Location = New System.Drawing.Point(93, 215)
        Me.txtSubmitPassword.Name = "txtSubmitPassword"
        Me.txtSubmitPassword.Size = New System.Drawing.Size(266, 27)
        Me.txtSubmitPassword.TabIndex = 1
        '
        'txtSubmitUsername
        '
        Me.txtSubmitUsername.Location = New System.Drawing.Point(93, 166)
        Me.txtSubmitUsername.Name = "txtSubmitUsername"
        Me.txtSubmitUsername.Size = New System.Drawing.Size(266, 27)
        Me.txtSubmitUsername.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnFetch)
        Me.Panel2.Controls.Add(Me.txtFetchPassword)
        Me.Panel2.Controls.Add(Me.txtFetchUsername)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(497, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 513)
        Me.Panel2.TabIndex = 1
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(151, 274)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(123, 42)
        Me.btnFetch.TabIndex = 5
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'txtFetchPassword
        '
        Me.txtFetchPassword.Location = New System.Drawing.Point(72, 215)
        Me.txtFetchPassword.Name = "txtFetchPassword"
        Me.txtFetchPassword.Size = New System.Drawing.Size(266, 27)
        Me.txtFetchPassword.TabIndex = 4
        '
        'txtFetchUsername
        '
        Me.txtFetchUsername.Location = New System.Drawing.Point(72, 166)
        Me.txtFetchUsername.Name = "txtFetchUsername"
        Me.txtFetchUsername.Size = New System.Drawing.Size(266, 27)
        Me.txtFetchUsername.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Creating Users"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Verifying Users"
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(880, 513)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtSubmitPassword As TextBox
    Friend WithEvents txtSubmitUsername As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFetch As Button
    Friend WithEvents txtFetchPassword As TextBox
    Friend WithEvents txtFetchUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
