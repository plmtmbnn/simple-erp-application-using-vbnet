<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarProduk
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelSelected = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelRoleID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(361, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'LabelSelected
        '
        Me.LabelSelected.AutoSize = True
        Me.LabelSelected.Location = New System.Drawing.Point(333, 277)
        Me.LabelSelected.Name = "LabelSelected"
        Me.LabelSelected.Size = New System.Drawing.Size(0, 13)
        Me.LabelSelected.TabIndex = 1
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(333, 276)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 2
        Me.LabelID.Text = "ID"
        '
        'LabelRoleID
        '
        Me.LabelRoleID.AutoSize = True
        Me.LabelRoleID.Location = New System.Drawing.Point(12, 276)
        Me.LabelRoleID.Name = "LabelRoleID"
        Me.LabelRoleID.Size = New System.Drawing.Size(29, 13)
        Me.LabelRoleID.TabIndex = 7
        Me.LabelRoleID.Text = "Role"
        Me.LabelRoleID.Visible = False
        '
        'FormDaftarProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 302)
        Me.Controls.Add(Me.LabelRoleID)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelSelected)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormDaftarProduk"
        Me.Text = "FormDaftarProduk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelSelected As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelRoleID As Label
End Class
