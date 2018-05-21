Imports MaterialSkin

Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class FormSalesInvoice
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
            Query = "select * from sdi_db.sdi_tb_sales_invoice"
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
            Query = "select * from sdi_db.sdi_tb_sales_order where customer_id ='" & id & "' and status='0'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim idSO As Integer = -1
            While READER.Read
                Dim vendor = READER.GetString("sales_order_id")
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
            MessageBox.Show("Uhh! " & ex.ToString)
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
            Query = "update sdi_db.sdi_tb_sales_order set status='1' where sales_order_id =" & id
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
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
                vendor = vendor + 1
                TextBoxIDSO.Text = vendor
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub FormSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DateTimePicker1.CustomFormat = "yyy-MM-dd"
        DateTimePicker1.Value = Date.Today
        TextBoxTotal.Text = 0
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)
        row.Cells("Total Pembayaran").Value = Convert.ToInt32(row.Cells("Kuantitas").Value) * Convert.ToInt32(row.Cells("Harga Unit").Value)
    End Sub

    Private Sub ButtonProduks_Click(sender As Object, e As EventArgs) Handles ButtonProduks.Click
        Dim listProduk = New FormDaftarProduk()
        listProduk.Show()
    End Sub
    Private Sub ButtonTambahkan_Click(sender As Object, e As EventArgs) Handles ButtonTambahkan.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Dim vendorId As Integer = 1
            Query = "select * from sdi_db.sdi_tb_product where product_id = " & Convert.ToInt32(TextBoxID.Text)
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim id = READER.GetString("product_id")
                Dim id_deskripsi = READER.GetString("brand_name") & " " & READER.GetString("category_name") & " " & READER.GetString("style_name")
                Dim kuantitas = 1
                Dim unitprice = READER.GetString("sales_unit_price")
                Dim total = kuantitas * unitprice
                dbDataSetCreate.Rows.Add(id, id_deskripsi, kuantitas, unitprice, total)
                DataGridView1.DataSource = dbDataSetCreate
                TextBoxTotal.Text = Convert.ToUInt32(TextBoxTotal.Text) + total
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try

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

            Dim Query As String
            Dim product_idz As Integer
            Dim kuantitasz As Integer
            Dim totalz As Integer



            For Each row As DataGridViewRow In DataGridView1.Rows

                product_idz = row.Cells(0).Value
                kuantitasz = row.Cells(2).Value
                totalz = row.Cells(4).Value

                If (kuantitasz = 0) Then
                    Exit For
                Else
                    MySqlConn.Open()
                    Console.WriteLine(Date.Today)
                    Query = "insert into sdi_db.sdi_tb_sales_invoice (id,id_sales_invoice,date_sales_invoice,customer_id,product_id,quantity,total_payment,status) 
            values ('0','" & Convert.ToInt32(TextBoxIDSO.Text) & "','" & DateTimePicker1.Value.Date.ToString("yyyyMMdd") & "','" & Convert.ToInt32(TextBox1.Text) & "','" & Convert.ToInt32(product_idz) & "','" & Convert.ToInt32(kuantitasz) & "','" & Convert.ToInt32(totalz) & "','" & "0" & "')"
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader
                    MySqlConn.Close()
                End If
            Next


            MessageBox.Show("Data berhasil ditambahkan!")
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
        generate_pdf()
        update_so_status(Convert.ToInt32(ComboBoxSO.Text))


    End Sub



    Public Sub generate_pdf()
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4)
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("D:\12S14026_POLMA\Semester 7\SISENT\Document\Penjualan\" + "SalesInvoice_" + TextBoxIDSO.Text + "_" + ComboBox1.Text + ".pdf", FileMode.Create))
            pdfDoc.Open()

            Dim font As New Font(FontFactory.GetFont("Helvetica", 16, font.Bold, BaseColor.BLACK))

            pdfDoc.Add(New Paragraph("---------------------------------Sales Invoice----------------------------", font))

            Dim phrase1 As New Phrase("==========================================================================")
            pdfDoc.Add(phrase1)
            pdfDoc.Add(Chunk.NEWLINE)

            Dim phrase2 As New Phrase("SI Number    : " + TextBoxIDSO.Text)
            pdfDoc.Add(phrase2)
            pdfDoc.Add(Chunk.NEWLINE)

            Dim phrase3 As New Phrase("SI date      : " + DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"))
            pdfDoc.Add(phrase3)
            pdfDoc.Add(Chunk.NEWLINE)

            Dim phrase4 As New Phrase("Dipesan oleh : " + ComboBox1.Text)
            pdfDoc.Add(phrase4)
            pdfDoc.Add(Chunk.NEWLINE)
            pdfDoc.Add(Chunk.NEWLINE)

            Dim table As New PdfPTable(5)
            Dim cell As New PdfPCell()

            cell.Colspan = 10
            cell.HorizontalAlignment = 1
            table.AddCell(cell)
            table.AddCell("Item")
            table.AddCell("Item Deskripsi")
            table.AddCell("Kuantitas")
            table.AddCell("Harga Unit")
            table.AddCell("Total Pembayaran")

            Dim a As Integer
            Dim b As String
            Dim c As Integer
            Dim d As Integer
            Dim f As Integer

            For Each row As DataGridViewRow In DataGridView1.Rows
                a = row.Cells(0).Value
                b = row.Cells(1).Value
                c = row.Cells(2).Value
                d = row.Cells(3).Value
                f = row.Cells(4).Value
                If (c = 0) Then
                    Exit For
                Else
                    table.AddCell(a)
                    table.AddCell(b)
                    table.AddCell(c)
                    table.AddCell("Rp " & d & "000")
                    table.AddCell("Rp " & f & "000")
                End If
            Next
            pdfDoc.Add(table)
            pdfDoc.Add(Chunk.NEWLINE)
            Dim phrase5 As New Phrase("Total : Rp " + TextBoxTotal.Text & "000")
            pdfDoc.Add(phrase5)
            pdfDoc.Add(Chunk.NEWLINE)
            pdfDoc.Add(Chunk.NEWLINE)

            Dim phrase6 As New Phrase("Disetujui oleh: ")
            pdfDoc.Add(phrase6)
            pdfDoc.Add(Chunk.NEWLINE)
            pdfDoc.Add(Chunk.NEWLINE)
            pdfDoc.Add(Chunk.NEWLINE)
            pdfDoc.Add(Chunk.NEWLINE)
            Dim phrase7 As New Phrase("---------------- ")
            pdfDoc.Add(phrase7)

            pdfDoc.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) 
        Load_Table()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView2.Rows(e.RowIndex)
        'LabelID.Text = row.Cells("id").Value.ToString
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) 
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            '       Query = "delete from sdi_db.sdi_tb_sales_order where id='" & Convert.ToUInt32(LabelID.Text) & "'"
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

            Query = "select * from sdi_db.sdi_tb_sales_order where sales_order_id = " & Convert.ToInt32(ComboBoxSO.Text)
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
                TextBoxTotal.Text = Convert.ToUInt32(TextBoxTotal.Text) + total
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

End Class