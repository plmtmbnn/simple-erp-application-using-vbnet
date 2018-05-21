Imports MySql.Data.MySqlClient

Public Class FormLogin



    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    'declare conn as connection and it will now a new connection because 
    'it is equal to Getconnection Function
    Dim con As MySqlConnection = jokenconn()



    Public Function jokenconn() As MySqlConnection
        Return New MySqlConnection("server=localhost; user id=root; password=; database=sdi_db")
    End Function




    Sub login()
        Dim sql As String
        Dim publictable As New DataTable
        Try
            Dim role As String = "0"
            If tbUsername.Text = "" And tbPassword.Text = "" Then
                MessageBox.Show("Username dan Password tidak boleh kosong!")
            Else
                sql = "select * from sdi_tb_user where user_name='" & tbUsername.Text & "' and password='" & tbPassword.Text & "'"
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(publictable)
                If publictable.Rows.Count > 0 Then
                    Dim username, password As String
                    username = publictable.Rows(0).Item(1)
                    password = publictable.Rows(0).Item(3)
                    role = publictable.Rows(0).Item(1)
                End If

                Dim formHome As New FormMenu
                formHome.Location = New Point(0, 0)
                formHome.Show()
                formHome.LabelRoleID.Text = role
                Select Case formHome.LabelRoleID.Text
                    Case 1
                        formHome.Button20.Visible = False
                        formHome.Button19.Visible = False
                    Case 2
                        formHome.Button20.Visible = False
                        formHome.Button19.Visible = False
                    Case 3
                        formHome.Button20.Visible = False
                        formHome.Button19.Visible = False
                    Case 4
                        formHome.Button20.Visible = True
                        formHome.Button19.Visible = True
                End Select

                Me.Hide()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login()
    End Sub


End Class
