Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New MySqlConnectionStringBuilder
            conexion.Server = "us-cdbr-east-04.cleardb.com"
            conexion.UserID = "bcd2e45ae5722c"
            conexion.Password = "c9507fa2"
            conexion.Database = "heroku_96a597346e8eaba"

            Dim con As New MySqlConnection(conexion.ToString())
            con.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar: " + ex.Message + "")
        End Try
    End Sub
End Class
