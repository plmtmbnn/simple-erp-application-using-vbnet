<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddPelanggan
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxNoTelp = New System.Windows.Forms.TextBox()
        Me.TextBoxKota = New System.Windows.Forms.TextBox()
        Me.TextBoxKodePos = New System.Windows.Forms.TextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelRoleID = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pelanggan"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelID)
        Me.TabPage1.Controls.Add(Me.TextBoxNoTelp)
        Me.TabPage1.Controls.Add(Me.TextBoxKota)
        Me.TabPage1.Controls.Add(Me.TextBoxKodePos)
        Me.TabPage1.Controls.Add(Me.TextBoxAlamat)
        Me.TabPage1.Controls.Add(Me.TextBoxEmail)
        Me.TabPage1.Controls.Add(Me.TextBoxNama)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(506, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informasi"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'TextBoxNoTelp
        '
        Me.TextBoxNoTelp.Location = New System.Drawing.Point(137, 294)
        Me.TextBoxNoTelp.Name = "TextBoxNoTelp"
        Me.TextBoxNoTelp.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxNoTelp.TabIndex = 11
        '
        'TextBoxKota
        '
        Me.TextBoxKota.Location = New System.Drawing.Point(137, 247)
        Me.TextBoxKota.Name = "TextBoxKota"
        Me.TextBoxKota.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxKota.TabIndex = 10
        '
        'TextBoxKodePos
        '
        Me.TextBoxKodePos.Location = New System.Drawing.Point(137, 204)
        Me.TextBoxKodePos.Name = "TextBoxKodePos"
        Me.TextBoxKodePos.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxKodePos.TabIndex = 9
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(137, 110)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(323, 76)
        Me.TextBoxAlamat.TabIndex = 8
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(137, 69)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(323, 20)
        Me.TextBoxEmail.TabIndex = 7
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(137, 25)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(323, 20)
        Me.TextBoxNama.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "No. Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Kota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Kode Pos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alamat"
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
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(29, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(514, 365)
        Me.TabControl1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(375, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(375, 451)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 4
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelRoleID
        '
        Me.LabelRoleID.AutoSize = True
        Me.LabelRoleID.Location = New System.Drawing.Point(514, 54)
        Me.LabelRoleID.Name = "LabelRoleID"
        Me.LabelRoleID.Size = New System.Drawing.Size(29, 13)
        Me.LabelRoleID.TabIndex = 7
        Me.LabelRoleID.Text = "Role"
        Me.LabelRoleID.Visible = False
        '
        'FormAddPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 508)
        Me.Controls.Add(Me.LabelRoleID)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAddPelanggan"
        Me.Text = "FormAddPelanggan"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNoTelp As TextBox
    Friend WithEvents TextBoxKota As TextBox
    Friend WithEvents TextBoxKodePos As TextBox
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelRoleID As Label
End Class
