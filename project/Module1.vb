Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public bSource As New BindingSource
    Public Property DataGridView1 As Object

    Public Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=dalemoy12345;database=vcustomersdb"
        con.Open()
    End Sub

    Public Sub openCon1()
        con.ConnectionString = "server=localhost;username=root;password=dalemoy12345;database=userdb"
        con.Open()
    End Sub

End Module
