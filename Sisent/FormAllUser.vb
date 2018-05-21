Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormAllUser

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Dim id As String

    Private Sub Load_Table()
        dbDataSet.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from sdi_db.sdi_tb_user"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub FormAllUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        ButtonLihat.Text = row.Cells("user_id").Value.ToString
        id = ButtonLihat.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dataView As New DataView(dbDataSet)

        dataView.RowFilter = String.Format("vendor_name like '%{0}%' or vendor_email like '%{1}%' or city like '%{2}%'", TextBox1.Text, TextBox1.Text, TextBox1.Text)
        DataGridView1.DataSource = dataView
    End Sub





    Private Sub ButtonLihat_Click(sender As Object, e As EventArgs) Handles ButtonLihat.Click
        Dim formPelanggan As New FormUser
        formPelanggan.Show()
        formPelanggan.LabelID.Text = id
        formPelanggan.Button2.Visible = False

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from sdi_db.sdi_tb_user where user_id = " & Convert.ToInt32(id)
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                formPelanggan.TextBoxUsername.Text = READER.GetString("user_name")
                formPelanggan.TextBoxEmail.Text = READER.GetString("email")
                formPelanggan.TextBoxPassword.Text = READER.GetString("password")
                formPelanggan.LabelID.Text = READER.GetString("user_id")
                formPelanggan.LabelIdRole.Text = READER.GetString("role_id")
                formPelanggan.ComboBox1.SelectedItem = "staff finance"
                formPelanggan.ButtonUpdate.Visible = True
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Load_Table()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim user As New FormUser
        user.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "delete from sdi_db.sdi_tb_user where user_id='" & ButtonLihat.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil dihapus!")
            Load_Table()
            MySqlConn.Close()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub
End Class