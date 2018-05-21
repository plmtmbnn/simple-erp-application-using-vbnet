Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class FormDaftarProduk
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

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
            Query = "select * from sdi_db.sdi_tb_product"
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
    Private Sub FormDaftarProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        Console.WriteLine(row.Cells("product_id").Value.ToString())
        LabelSelected.Text = row.Cells("product_id").Value.ToString()
        Me.Hide()

    End Sub
End Class