Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Public Class FormAddVendor

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Dim labels As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "insert into sdi_db.sdi_tb_vendore (vendor_id,vendor_name,vendor_email,address,country,city,phone_number) 
            values ('0','" & TextBoxNama.Text & "','" & TextBoxEmail.Text & "','" & TextBoxAlamat.Text & "','" & TextBoxNegara.Text & "','" & TextBoxKota.Text & "','" & TextBoxNoTelp.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil ditambahkan!")
            Me.Hide()
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update sdi_db.sdi_tb_vendore set  
            vendor_id='" & LabelID.Text & "',vendor_name='" & TextBoxNama.Text & "',vendor_email='" & TextBoxEmail.Text & "',address='" & TextBoxAlamat.Text & "',country='" & TextBoxNegara.Text & "',city='" & TextBoxKota.Text & "',phone_number='" & TextBoxNoTelp.Text & "' where vendor_id='" & Label2.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil diupdate!")
            MySqlConn.Close()
            Me.Hide()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub FormAddVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class