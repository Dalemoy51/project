Public Class CustomerManagementSystem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to sign-out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then

        Else
            Application.Exit()
        End If

    End Sub


    Private Sub CustomerManagementSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        loadtable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

        Form1.Show()
        Me.Hide()
        Login.Hide()
        Form1.Button1.Enabled = False

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form1.Show()
        Me.Hide()
        Login.Hide()
        Form1.TextBox9.Hide()
        Form1.Label12.Hide()
        Form1.srchbtn.Hide()
        Form1.Label10.Hide()
        Form1.Label13.Hide()
        Form1.Button4.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Panel2.Hide()


    End Sub
    Sub loadtable()
        Dim table1 As New DataTable
        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT `customer_id`, `Firstname`, `Lasname`,`Address`,`Conctact_no`,`Credit`,`Debit`,`Product_pruchase`,`Product_return`,`Gender`,`Age` FROM customers"
            table.Clear()
            adapter.SelectCommand = cmd
            adapter.Fill(table1)
            DataGridView1.DataSource = table1
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        loadtable()
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim table2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT  `customer_id`, `Firstname`,`Lasname`,`Address`,`Conctact_no`,`Credit`,`Debit`,`Product_pruchase`,`Product_return`,`Gender`,`Age` FROM customers WHERE Firstname LIKE '%" & TextBox1.Text & "'"
            cmd.ExecuteNonQuery()
            table.Clear()
            adapter.SelectCommand = cmd
            adapter.Fill(table2)
            DataGridView1.DataSource = table2
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CustomerManagementSystem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub
End Class