Imports MySql.Data.MySqlClient

Public Class FrmEnregistrement
    ' Chaîne de connexion demandée par le sujet (Question 1 de la Section 3)
    Dim connString As String = "server=localhost;database=examen;user=candidat;password=bts1"

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO eleves (nom, prenom, classe, annee) VALUES (@nom, @prenom, @classe, 2024)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nom", TxtNom.Text)
                cmd.Parameters.AddWithValue("@prenom", TxtPrenom.Text)
                cmd.Parameters.AddWithValue("@classe", TxtClasse.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Élève enregistré avec succès !")
            Catch ex As Exception
                MsgBox("Erreur : " & ex.Message)
            End Try
        End Using
    End Sub
End Class