Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormVendor
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
            Query = "select * from sdi_db.sdi_tb_vendore"
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

    Private Sub FormVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Load_Table()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        ButtonLihat.Text = row.Cells("vendor_id").Value.ToString
        id = ButtonLihat.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dataView As New DataView(dbDataSet)

        dataView.RowFilter = String.Format("vendor_name like '%{0}%' or vendor_email like '%{1}%' or city like '%{2}%'", TextBox1.Text, TextBox1.Text, TextBox1.Text)
        DataGridView1.DataSource = dataView
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "delete from sdi_db.sdi_tb_vendore where vendor_id='" & ButtonLihat.Text & "'"
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

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim formVendor As New FormAddVendor
        formVendor.Show()
    End Sub

    Private Sub ButtonLihat_Click(sender As Object, e As EventArgs) Handles ButtonLihat.Click
        Dim formPelanggan As New FormAddVendor
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
            Query = "select * from sdi_db.sdi_tb_vendore where vendor_id = " & Convert.ToInt32(id)
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read

                formPelanggan.TextBoxNama.Text = READER.GetString("vendor_name")
                formPelanggan.TextBoxEmail.Text = READER.GetString("vendor_email")
                formPelanggan.TextBoxAlamat.Text = READER.GetString("address")
                formPelanggan.TextBoxNegara.Text = READER.GetString("country")
                formPelanggan.TextBoxKota.Text = READER.GetString("city")
                formPelanggan.TextBoxNoTelp.Text = READER.GetString("phone_number")
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class