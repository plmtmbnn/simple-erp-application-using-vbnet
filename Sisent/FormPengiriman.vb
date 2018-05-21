Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Public Class FormPengiriman
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dbDataSetCreate As New DataTable
    Dim id As Integer = 0

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
            Query = "select * from sdi_db.sdi_tb_shipping"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Public Shared Function get_product(id As Integer) As ArrayList
        Dim MySqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        Dim productList As New ArrayList
        Dim product_id
        Dim product_desc
        Dim product_price

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select * from sdi_db.sdi_tb_product where product_id =" & id
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                product_id = READER.GetString("product_id")
                product_desc = READER.GetString("brand_name") & " " & READER.GetString("category_name") & " " & READER.GetString("style_name")
                product_price = READER.GetString("sales_unit_price")
                productList.Add(product_id)
                productList.Add(product_desc)
                productList.Add(product_price)
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
        Return productList
    End Function



    Private Sub load_combo_so(id As Integer)
        ComboBoxSO.Items.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select * from sdi_db.sdi_tb_sales_invoice where customer_id ='" & id & "' and status='1'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim idSO As Integer = -1
            While READER.Read
                Dim vendor = READER.GetString("id_sales_invoice")
                If (idSO < 0) Then
                    ComboBoxSO.Items.Add(vendor)
                    idSO += 1
                Else
                    If (vendor = Convert.ToUInt32(ComboBoxSO.Items.Item(idSO).ToString)) Then
                    Else
                        ComboBoxSO.Items.Add(vendor)
                        idSO += 1
                    End If
                End If
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub


    Private Sub update_so_status(id As Integer)
        ComboBoxSO.Items.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "update sdi_db.sdi_tb_sales_invoice set status='2' where id_sales_invoice =" & id
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Hehehe!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub load_combo()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select customer_name from sdi_db.sdi_tb_customer"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim vendor = READER.GetString("customer_name")
                ComboBox1.Items.Add(vendor)
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub load_id()
        TextBoxIDSO.Text = 0
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select * from sdi_db.sdi_tb_sales_invoice"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim vendor = READER.GetString("id_sales_invoice")
                vendor += 1
                TextBoxIDSO.Text = vendor
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub FormPengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_combo()
        load_id()
        Load_Table()
        Console.WriteLine(get_product(1).Item(1))
        dbDataSetCreate.Columns.Add("Item", Type.GetType("System.Int32"))
        dbDataSetCreate.Columns.Add("Item Deskripsi", Type.GetType("System.String"))
        dbDataSetCreate.Columns.Add("Kuantitas", Type.GetType("System.Int32"))
        dbDataSetCreate.Columns.Add("Harga Unit", Type.GetType("System.Int32"))
        dbDataSetCreate.Columns.Add("Total Pembayaran", Type.GetType("System.Int32"))

        DataGridView1.DataSource = dbDataSetCreate
        DateTimePicker1.CustomFormat = "yyy-MM-dd"
        DateTimePicker1.Value = Date.Today


    End Sub



    Private Sub ButtonProduks_Click(sender As Object, e As EventArgs) 
        Dim listProduk = New FormDaftarProduk()
        listProduk.Show()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select * from sdi_db.sdi_tb_customer where customer_name = '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim id = READER.GetString("customer_id")
                TextBox1.Text = id
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try

        load_combo_so(Convert.ToInt32(TextBox1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "insert into sdi_db.sdi_tb_shipping (shipping_id,sales_invoice_id,customer_id,shipping_date,status) 
            values ('0','" & Convert.ToInt32(ComboBoxSO.Text) & "','" & Convert.ToInt32(TextBox1.Text) & "','" & DateTimePicker1.Value.Date.ToString("yyyyMMdd") & "','" & "0" & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data berhasil ditambahkan!")
            update_so_status(Convert.ToInt32(ComboBoxSO.Text))
            Me.Hide()
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal! " & ex.ToString)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Load_Table()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView2.Rows(e.RowIndex)
        LabelID.Text = row.Cells("id").Value.ToString
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "delete from sdi_db.sdi_tb_sales_invoice where id='" & Convert.ToUInt32(LabelID.Text) & "'"
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

    Private Sub ComboBoxSO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSO.SelectedIndexChanged

        dbDataSetCreate.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from sdi_db.sdi_tb_sales_invoice where id_sales_invoice = " & Convert.ToInt32(ComboBoxSO.Text)
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim id = get_product(Convert.ToInt32(READER.GetString("product_id"))).Item(0)
                Dim id_deskripsi = get_product(Convert.ToInt32(READER.GetString("product_id"))).Item(1)
                Dim kuantitas = Convert.ToInt32(READER.GetString("quantity"))
                Dim unitprice = get_product(Convert.ToInt32(READER.GetString("product_id"))).Item(2)
                Dim total = Convert.ToInt32(READER.GetString("total_payment"))
                dbDataSetCreate.Rows.Add(id, id_deskripsi, kuantitas, unitprice, total)
                DataGridView1.DataSource = dbDataSetCreate

            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

End Class