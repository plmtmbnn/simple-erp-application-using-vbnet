
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable

Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf


Public Class FormMenu

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dbDataSets As New DataTable

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

    Private Sub Load_Tables()
        dbDataSets.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from sdi_db.sdi_tb_cash"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSets)
            bSource.DataSource = dbDataSets
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataSets)

            MySqlConn.Close()
        Catch ex As Exception
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
        Load_Tables()
        LabelUser.Text = "Welcome!"

        Select Case LabelRoleID.Text
            Case 1
                Button20.Visible = False
                Button19.Visible = False
            Case 2
                Button20.Visible = False
                Button19.Visible = False
            Case 3
                Button20.Visible = False
                Button19.Visible = False
            Case 4
                Button20.Visible = True
                Button19.Visible = True
        End Select
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formIndex = New FormLogin
        formIndex.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectTab(4)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dataView As New DataView(dbDataSet)

        dataView.RowFilter = String.Format("brand_name like '%{0}%' or category_name like '%{1}%' or style_name like '%{2}%'", TextBox1.Text, TextBox1.Text, TextBox1.Text)
        DataGridView1.DataSource = dataView
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "delete from sdi_db.sdi_tb_product where product_id='" & ButtonLihat.Text & "'"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        row = Me.DataGridView1.Rows(e.RowIndex)

        ButtonLihat.Text = row.Cells("product_id").Value.ToString
        id = ButtonLihat.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim formProduct As New FormAddProduct
        formProduct.Show()
        formProduct.Button3.Visible = False

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Load_Table()
    End Sub

    Private Sub ButtonLihat_Click(sender As Object, e As EventArgs) Handles ButtonLihat.Click
        Dim formProduct As New FormAddProduct
        formProduct.Show()
        formProduct.Label2.Text = id
        formProduct.Button1.Visible = False

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost; user id=root; password=; database=sdi_db"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from sdi_db.sdi_tb_product where product_id = " & Convert.ToInt32(id)
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim category_name = READER.GetString("category_name")
                Dim style_name = READER.GetString("style_name")
                Dim sales_unit_price = READER.GetString("sales_unit_price")
                Dim purchase_unit_price = READER.GetString("purchase_unit_price")
                Dim stock = READER.GetString("stock")

                formProduct.TextBox2.Text = category_name
                formProduct.TextBox1.Text = style_name
                formProduct.TextBox5.Text = sales_unit_price
                formProduct.TextBox6.Text = purchase_unit_price
                formProduct.TextBox4.Text = stock
                formProduct.ComboBox1.SelectedItem = READER.GetString("brand_name")
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal!")
        Finally
            MySqlConn.Dispose()
        End Try



    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) 
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4)
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("D:\12S14026_POLMA\Semester 7\SISENT\Document\" + "sample.pdf", FileMode.Create))
            pdfDoc.Open()

            Dim table As New PdfPTable(3)
            Dim cell As New PdfPCell(New Phrase("Haloo"))
            cell.Colspan = 3
            cell.HorizontalAlignment = 1
            table.AddCell(cell)
            table.AddCell("Col 1 row 1")
            table.AddCell("Col 1 row 2")
            table.AddCell("Col 1 row 3")
            table.AddCell("Col 1 row 4")
            table.AddCell("Col 1 row 5")
            table.AddCell("Col 1 row 6")
            pdfDoc.Add(table)
            pdfDoc.Close()

        Catch ex As Exception

        End Try
        '        System.Diagnostics.Process.Start("Acrord32.exe", "D:\12S14026_POLMA\Semester 7\SISENT\Document\\sample.pdf")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectTab(5)
        ButtonVendor.Visible = True
        ButtonPelanggan.Visible = True
    End Sub

    Private Sub ButtonPelanggan_Click(sender As Object, e As EventArgs) Handles ButtonPelanggan.Click
        Dim formPelanggan As New FormPelanggan
        formPelanggan.Show()
    End Sub

    Private Sub ButtonVendor_Click(sender As Object, e As EventArgs) Handles ButtonVendor.Click
        Dim formVendor As New FormVendor
        formVendor.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub ButtonSalesOrder_Click(sender As Object, e As EventArgs) Handles ButtonSalesOrder.Click
        Dim formSalesOders As New FormSalesOrder
        formSalesOders.Show()
        formSalesOders.LabelRoleID.Text = LabelRoleID.Text
        Select Case formSalesOders.LabelRoleID.Text
            Case 1
                formSalesOders.Button2.Visible = True
            Case 2
                formSalesOders.Button2.Visible = False
            Case 3
                formSalesOders.Button2.Visible = False
            Case 4
                formSalesOders.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim formSI As New FormSalesInvoice
        formSI.Show()
        formSI.LabelRoleID.Text = LabelRoleID.Text
        Select Case formSI.LabelRoleID.Text
            Case 1
                formSI.Button2.Visible = False
            Case 2
                formSI.Button2.Visible = False
            Case 3
                formSI.Button2.Visible = True
            Case 4
                formSI.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim formPengiriman As New FormPengiriman
        formPengiriman.Show()
        formPengiriman.LabelRoleID.Text = LabelRoleID.Text
        Select Case formPengiriman.LabelRoleID.Text
            Case 1
                formPengiriman.Button2.Visible = False
            Case 2
                formPengiriman.Button2.Visible = True
            Case 3
                formPengiriman.Button2.Visible = False
            Case 4
                formPengiriman.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim formPO As New FormPurchasesOrder
        formPO.Show()
        formPO.LabelRoleID.Text = LabelRoleID.Text
        Select Case formPO.LabelRoleID.Text
            Case 1
                formPO.Button2.Visible = True
            Case 2
                formPO.Button2.Visible = False
            Case 3
                formPO.Button2.Visible = False
            Case 4
                formPO.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim formCR As New FormCustomerReceipt
        formCR.Show()
        formCR.LabelRoleID.Text = LabelRoleID.Text
        Select Case formCR.LabelRoleID.Text
            Case 1
                formCR.Button2.Visible = False
            Case 2
                formCR.Button2.Visible = False
            Case 3
                formCR.Button2.Visible = True
            Case 4
                formCR.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim formPI As New FormPurchaseInvoice
        formPI.Show()
        formPI.LabelRoleID.Text = LabelRoleID.Text
        Select Case formPI.LabelRoleID.Text
            Case 1
                formPI.Button2.Visible = False
            Case 2
                formPI.Button2.Visible = False
            Case 3
                formPI.Button2.Visible = True
            Case 4
                formPI.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim formPP As New FormPurchasePayment
        formPP.Show()
        formPP.LabelRoleID.Text = LabelRoleID.Text
        Select Case formPP.LabelRoleID.Text
            Case 1
                formPP.Button2.Visible = False
            Case 2
                formPP.Button2.Visible = False
            Case 3
                formPP.Button2.Visible = True
            Case 4
                formPP.Button2.Visible = False
        End Select
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim formAllUSer As New FormAllUser
        formAllUSer.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim formUser As New FormUser
        formUser.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Load_Tables()
    End Sub
End Class