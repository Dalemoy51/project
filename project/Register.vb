Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon1()
        Try
            cmd.Connection = con
            If TextBox1.Text = Nothing Or registertxt.Text = Nothing Or passtxt.Text = Nothing Or reenterpasstxt.Text = Nothing Then
                MessageBox.Show("Please enter details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf passtxt.Text > reenterpasstxt.Text Then
                MessageBox.Show("Please enter same password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                reenterpasstxt.Text = passtxt.Text
                cmd.CommandText = "INSERT INTO users (`Username`, `Password`) VALUES('" & registertxt.Text & "', '" & passtxt.Text & "')"
                MsgBox("Succesfully registered!")
                cmd.ExecuteNonQuery()
                Login.Show()
                Me.Hide()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = Button1
    End Sub
End Class