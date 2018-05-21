<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddVendor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxNegara = New System.Windows.Forms.TextBox()
        Me.TextBoxKota = New System.Windows.Forms.TextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.TextBoxNoTelp = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelRoleID = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(35, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(486, 375)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelID)
        Me.TabPage2.Controls.Add(Me.TextBoxNegara)
        Me.TabPage2.Controls.Add(Me.TextBoxKota)
        Me.TabPage2.Controls.Add(Me.TextBoxAlamat)
        Me.TabPage2.Controls.Add(Me.TextBoxNoTelp)
        Me.TabPage2.Controls.Add(Me.TextBoxEmail)
        Me.TabPage2.Controls.Add(Me.TextBoxNama)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(478, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informasi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(402, 285)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(0, 13)
        Me.LabelID.TabIndex = 12
        Me.LabelID.Visible = False
        '
        'TextBoxNegara
        '
        Me.TextBoxNegara.Location = New System.Drawing.Point(145, 279)
        Me.TextBoxNegara.Name = "TextBoxNegara"
        Me.TextBoxNegara.Size = New System.Drawing.Size(195, 20)
        Me.TextBoxNegara.TabIndex = 11
        '
        'TextBoxKota
        '
        Me.TextBoxKota.Location = New System.Drawing.Point(145, 243)
        Me.TextBoxKota.Name = "TextBoxKota"
        Me.TextBoxKota.Size = New System.Drawing.Size(195, 20)
        Me.TextBoxKota.TabIndex = 10
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(145, 152)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(283, 74)
        Me.TextBoxAlamat.TabIndex = 9
        '
        'TextBoxNoTelp
        '
        Me.TextBoxNoTelp.Location = New System.Drawing.Point(145, 114)
        Me.TextBoxNoTelp.Name = "TextBoxNoTelp"
        Me.TextBoxNoTelp.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxNoTelp.TabIndex = 8
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(145, 72)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(283, 20)
        Me.TextBoxEmail.TabIndex = 7
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(145, 33)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(283, 20)
        Me.TextBoxNama.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "No. Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(334, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(334, 442)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 4
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelRoleID
        '
        Me.LabelRoleID.AutoSize = True
        Me.LabelRoleID.Location = New System.Drawing.Point(514, 21)
        Me.LabelRoleID.Name = "LabelRoleID"
        Me.LabelRoleID.Size = New System.Drawing.Size(29, 13)
        Me.LabelRoleID.TabIndex = 7
        Me.LabelRoleID.Text = "Role"
        Me.LabelRoleID.Visible = False
        '
        'FormAddVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 500)
        Me.Controls.Add(Me.LabelRoleID)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAddVendor"
        Me.Text = "FormAddVendor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNegara As TextBox
    Friend WithEvents TextBoxKota As TextBox
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents TextBoxNoTelp As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents LabelRoleID As Label
End Class
