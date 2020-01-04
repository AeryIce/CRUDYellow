Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Ds As DataSet
	Public Da As SqlDataAdapter
	Public Cmd As SqlCommand

	Sub Koneksi()
		Try

			Conn = New SqlConnection("Data Source=AERYICE-PC666;Initial Catalog=crudyellow;integrated security=true")
			Conn.Open()

			FormLogin.LabelDatabase.Text = "Connected"
		Catch ex As Exception
			FormLogin.LabelDatabase.Text = "Not Connected"

		End Try
	End Sub
End Module
