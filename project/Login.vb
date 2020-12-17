Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon1()
        con.Close()
        AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon1()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM `users` WHERE `Username` = '" & TextBox1.Text & "' AND `Password` = '" & TextBox2.Text & "' "
            adapter.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                MessageBox.Show("Welcome admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                CustomerManagementSystem.Show()
                Me.Hide()

            Else

                MessageBox.Show("User not registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub


End Class