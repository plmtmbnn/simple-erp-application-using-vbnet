Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class FormAddPelanggan

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Dim labels As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "insert into sdi_db.sdi_tb_customer (customer_id,customer_name,customer_email,customer_addres,zip_code,city,phone_number) 
            values ('0','" & TextBoxNama.Text & "','" & TextBoxEmail.Text & "','" & TextBoxAlamat.Text & "','" & TextBoxKodePos.Text & "','" & TextBoxKota.Text & "','" & TextBoxNoTelp.Text & "')"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update sdi_db.sdi_tb_customer set  
            customer_id='" & LabelID.Text & "',customer_name='" & TextBoxNama.Text & "',customer_email='" & TextBoxEmail.Text & "',customer_addres='" & TextBoxAlamat.Text & "',zip_code='" & TextBoxKodePos.Text & "',city='" & TextBoxKota.Text & "',phone_number='" & TextBoxNoTelp.Text & "' where customer_id='" & Label2.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil diupdate! " & TextBoxNama.Text)
            MySqlConn.Close()
            Me.Hide()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class