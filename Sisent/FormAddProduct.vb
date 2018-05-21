Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class FormAddProduct
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
            Query = "select vendor_name from sdi_db.sdi_tb_vendore"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim vendor = READER.GetString("vendor_name")
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
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer

            Select Case ComboBox1.Text
                Case "Adidas"
                    vendorId = 1
                Case "Nike"
                    vendorId = 2
                Case "Converse"
                    vendorId = 3
                Case "Vans"
                    vendorId = 4
                Case "Reebok"
                    vendorId = 5
            End Select


            Query = "insert into sdi_db.sdi_tb_product (product_id,category_name,brand_name,style_name,vendor_id,sales_unit_price,purchase_unit_price,stock) 
            values ('0','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & vendorId & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox4.Text & "')"
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

    Private Sub FormAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combo()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader
        Dim vendorId As Integer

        Select Case ComboBox1.Text
            Case "Adidas"
                vendorId = 1
            Case "Nike"
                vendorId = 2
            Case "Converse"
                vendorId = 3
            Case "Vans"
                vendorId = 4
            Case "Reebok"
                vendorId = 5
        End Select
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update sdi_db.sdi_tb_product set  
            product_id='" & Label2.Text & "',category_name='" & TextBox2.Text & "',brand_name='" & ComboBox1.Text & "',style_name='" & TextBox1.Text & "',vendor_id='" & vendorId & "',sales_unit_price='" & TextBox5.Text & "',purchase_unit_price='" & TextBox6.Text & "',stock='" & TextBox4.Text & "' where product_id='" & Label2.Text & "'"
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

End Class