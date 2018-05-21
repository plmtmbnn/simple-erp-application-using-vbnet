<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAllUser
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButtonLihat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.LabelRoleID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(227, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Data User "
        '
        'ButtonLihat
        '
        Me.ButtonLihat.Location = New System.Drawing.Point(50, 102)
        Me.ButtonLihat.Name = "ButtonLihat"
        Me.ButtonLihat.Size = New System.Drawing.Size(52, 23)
        Me.ButtonLihat.TabIndex = 22
        Me.ButtonLihat.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(510, 263)
        Me.DataGridView1.TabIndex = 12
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(108, 70)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Hapus"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Lihat"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(300, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cari"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(11, 70)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 23)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Tambah"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(189, 70)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "Refresh"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'LabelRoleID
        '
        Me.LabelRoleID.AutoSize = True
        Me.LabelRoleID.Location = New System.Drawing.Point(490, 23)
        Me.LabelRoleID.Name = "LabelRoleID"
        Me.LabelRoleID.Size = New System.Drawing.Size(29, 13)
        Me.LabelRoleID.TabIndex = 23
        Me.LabelRoleID.Text = "Role"
        Me.LabelRoleID.Visible = False
        '
        'FormAllUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 410)
        Me.Controls.Add(Me.LabelRoleID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ButtonLihat)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button11)
        Me.Name = "FormAllUser"
        Me.Text = "FormAllUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonLihat As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button9 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents LabelRoleID As Label
End Class
