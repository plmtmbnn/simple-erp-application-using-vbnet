Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Public Class FormUser
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable


    Private Sub load_combo()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select role_name from sdi_db.sdi_tb_role"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim vendor = READER.GetString("role_name")
                ComboBox1.Items.Add(vendor)
            End While

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer

            Select Case ComboBox1.Text
                Case "staff sales"
                    vendorId = 1
                Case "staff gudang"
                    vendorId = 2
                Case "admin"
                    vendorId = 4
                Case "staff finance"
                    vendorId = 3
            End Select


            Query = "insert into sdi_db.sdi_tb_user (user_id,role_id,user_name,email,password) 
            values ('0','" & vendorId & "','" & TextBoxUsername.Text & "','" & TextBoxEmail.Text & "','" & TextBoxPassword.Text & "')"
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
            Dim vendorId As Integer

            Select Case ComboBox1.Text
                Case "staff sales"
                    vendorId = 1
                Case "staff gudang"
                    vendorId = 2
                Case "admin"
                    vendorId = 4
                Case "staff finance"
                    vendorId = 3
            End Select


            Query = "update sdi_db.sdi_tb_user set  
            user_id='" & LabelID.Text & "',role_id='" & vendorId & "',user_name='" & TextBoxUsername.Text & "',email='" & TextBoxEmail.Text & "',password='" & TextBoxPassword.Text & "' where user_id='" & LabelID.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil diupdate!")


            Me.Hide()
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combo()
        ButtonUpdate.Visible = False
    End Sub
End Class