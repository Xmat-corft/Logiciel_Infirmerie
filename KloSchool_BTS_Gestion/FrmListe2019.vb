Imports MySql.Data.MySqlClient

Public Class FrmListe2019
    Dim connString As String = "server=localhost;database=examen;user=root;password="

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        Using conn As New MySqlConnection(connString)
            Dim query As String = "SELECT * FROM eleves WHERE annee = 2019"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvEleves.DataSource = dt
        End Using
    End Sub
End Class