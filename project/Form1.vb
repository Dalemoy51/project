
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        Me.Hide()

        Login.Show()
        AcceptButton = Button1
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox9.Text = ""
        lasttxt.Text = ""
        firsttxt.Text = ""
        addtxt.Text = ""
        contacttxt.Text = ""
        credittxt.Text = ""
        debittxt.Text = ""
        purchasetxt.Text = ""
        returntxt.Text = ""
        gentxt.Text = ""
        agetxt.Text = ""


    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CustomerManagementSystem.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openCon()
        Try
            cmd.Connection = con
            If firsttxt.Text = Nothing Or lasttxt.Text = Nothing Or addtxt.Text = Nothing Or contacttxt.Text = Nothing Or credittxt.Text = Nothing Or debittxt.Text = Nothing Or purchasetxt.Text = Nothing Or returntxt.Text = Nothing Or gentxt.Text = Nothing Or agetxt.Text = Nothing Then
                MessageBox.Show("No details found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf firsttxt.Text = "" Then
                con.Close()
            ElseIf lasttxt.Text = "" Then
                con.Close()
            ElseIf addtxt.Text = "" Then
                con.Close()
            ElseIf contacttxt.Text = "" Then
                con.Close()
            ElseIf credittxt.Text = "" Then
                con.Close()
            ElseIf debittxt.Text = "" Then
                con.Close()
            ElseIf purchasetxt.Text = "" Then
                con.Close()
            ElseIf returntxt.Text = "" Then
                con.Close()
            ElseIf gentxt.Text = "" Then
                con.Close
            ElseIf agetxt.Text = "" Then
                con.Close()
            ElseIf MessageBox.Show("Are you sure you want to update this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                con.Close()
            Else cmd.CommandText = "UPDATE customers SET `Firstname` = '" & firsttxt.Text & "',`Lasname`='" & lasttxt.Text & "',`Address`='" & addtxt.Text & "',`Conctact_no`='" & contacttxt.Text & "',`Credit` = " & credittxt.Text & ",`Debit`= " & debittxt.Text & ",`Product_pruchase`='" & purchasetxt.Text & "',`Product_return`='" & returntxt.Text & "',`Gender` = '" & gentxt.Text & "',`Age` = " & agetxt.Text & " WHERE Firstname ='" & firsttxt.Text & "' "
                MsgBox("Sucessfully Updated!")
                cmd.ExecuteNonQuery()
                CustomerManagementSystem.Show()
                Me.Hide()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openCon()
        Try
            cmd.Connection = con
            If firsttxt.Text = Nothing Or lasttxt.Text = Nothing Or addtxt.Text = Nothing Or contacttxt.Text = Nothing Or credittxt.Text = Nothing Or debittxt.Text = Nothing Or purchasetxt.Text = Nothing Or returntxt.Text = Nothing Or gentxt.Text = Nothing Or agetxt.Text = Nothing Then
                MessageBox.Show("Please Enter details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf firsttxt.Text = "" Then
                con.Close()
            ElseIf lasttxt.Text = "" Then
                con.Close()
            ElseIf addtxt.Text = "" Then
                con.Close()
            ElseIf contacttxt.Text = "" Then
                con.Close()
            ElseIf credittxt.Text = "" Then
                con.Close()
            ElseIf debittxt.Text = "" Then
                con.Close()
            ElseIf purchasetxt.Text = "" Then
                con.Close()
            ElseIf returntxt.Text = "" Then
                con.Close()
            ElseIf gentxt.Text = "" Then
                con.Close()
            ElseIf agetxt.Text = "" Then
                con.Close()
            Else cmd.CommandText = "INSERT INTO customers (`Firstname`,`Lasname`,`Address`,`Conctact_no`,`Credit`,`Debit`,`Product_pruchase`,`Product_return`,`Gender`,`Age`) VALUES('" & firsttxt.Text & "','" & lasttxt.Text & "','" & addtxt.Text & "','" & contacttxt.Text & "'," & credittxt.Text & "," & debittxt.Text & ",'" & purchasetxt.Text & "','" & returntxt.Text & "','" & gentxt.Text & "'," & agetxt.Text & ")"
                MsgBox("Sucessfully added!")
                cmd.ExecuteNonQuery()
                CustomerManagementSystem.Show()
                Me.Hide()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles srchbtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM customers  WHERE Firstname = '" & TextBox9.Text & "'"
            cmd.ExecuteNonQuery()
            adapter.Fill(table)
            If table.Rows.Count = Nothing Then
                MessageBox.Show("No record found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf table.Rows.Count > 0 Then
                firsttxt.Text = table.Rows(0)(4).ToString
                lasttxt.Text = table.Rows(0)(5).ToString
                addtxt.Text = table.Rows(0)(6).ToString
                contacttxt.Text = table.Rows(0)(7).ToString
                credittxt.Text = table.Rows(0)(8).ToString
                debittxt.Text = table.Rows(0)(9).ToString
                purchasetxt.Text = table.Rows(0)(10).ToString
                returntxt.Text = table.Rows(0)(11).ToString
                gentxt.Text = table.Rows(0)(12).ToString
                agetxt.Text = table.Rows(0)(13).ToString
            Else
                firsttxt.Text = ""
                lasttxt.Text = ""
                addtxt.Text = ""
                contacttxt.Text = ""
                credittxt.Text = ""
                debittxt.Text = ""
                purchasetxt.Text = ""
                returntxt.Text = ""
                gentxt.Text = ""
                agetxt.Text = ""
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        openCon()
        Try
            cmd.Connection = con
            If firsttxt.Text = Nothing Or lasttxt.Text = Nothing Or addtxt.Text = Nothing Or contacttxt.Text = Nothing Or credittxt.Text = Nothing Or debittxt.Text = Nothing Or purchasetxt.Text = Nothing Or returntxt.Text = Nothing Or gentxt.Text = Nothing Or agetxt.Text = Nothing Then
                MessageBox.Show("No Details found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf firsttxt.Text = "" Then
                con.Close()
            ElseIf lasttxt.Text = "" Then
                con.Close()
            ElseIf addtxt.Text = "" Then
                con.Close()
            ElseIf contacttxt.Text = "" Then
                con.Close()
            ElseIf credittxt.Text = "" Then
                con.Close()
            ElseIf debittxt.Text = "" Then
                con.Close()
            ElseIf purchasetxt.Text = "" Then
                con.Close()
            ElseIf returntxt.Text = "" Then
                con.Close()
            ElseIf gentxt.Text = "" Then
                con.Close
            ElseIf agetxt.Text = "" Then
                con.Close()
            ElseIf MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                con.Close()

            Else cmd.CommandText = "DELETE FROM customers WHERE Firstname = '" & firsttxt.Text & "'"
                MsgBox("Sucessfully Deleted!")
                cmd.ExecuteNonQuery()
                CustomerManagementSystem.Show()
                Me.Hide()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
