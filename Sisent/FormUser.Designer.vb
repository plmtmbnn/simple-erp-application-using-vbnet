<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelIdRole = New System.Windows.Forms.Label()
        Me.LabelRoleID = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(430, 300)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(0, 13)
        Me.LabelID.TabIndex = 12
        Me.LabelID.Visible = False
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(137, 109)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxPassword.TabIndex = 9
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(137, 69)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxEmail.TabIndex = 7
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(137, 25)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxUsername.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(32, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(395, 228)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.LabelID)
        Me.TabPage1.Controls.Add(Me.TextBoxPassword)
        Me.TabPage1.Controls.Add(Me.TextBoxEmail)
        Me.TabPage1.Controls.Add(Me.TextBoxUsername)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(387, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informasi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(234, 307)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 9
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelIdRole
        '
        Me.LabelIdRole.AutoSize = True
        Me.LabelIdRole.Location = New System.Drawing.Point(364, 46)
        Me.LabelIdRole.Name = "LabelIdRole"
        Me.LabelIdRole.Size = New System.Drawing.Size(0, 13)
        Me.LabelIdRole.TabIndex = 10
        Me.LabelIdRole.Visible = False
        '
        'LabelRoleID
        '
        Me.LabelRoleID.AutoSize = True
        Me.LabelRoleID.Location = New System.Drawing.Point(375, 38)
        Me.LabelRoleID.Name = "LabelRoleID"
        Me.LabelRoleID.Size = New System.Drawing.Size(29, 13)
        Me.LabelRoleID.TabIndex = 11
        Me.LabelRoleID.Text = "Role"
        Me.LabelRoleID.Visible = False
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 344)
        Me.Controls.Add(Me.LabelRoleID)
        Me.Controls.Add(Me.LabelIdRole)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents LabelIdRole As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelRoleID As Label
End Class
