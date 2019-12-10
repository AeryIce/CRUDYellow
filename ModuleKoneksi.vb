Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Ds As DataSet
	Public Da As SqlDataAdapter
	Public Cmd As SqlCommand

	Sub Koneksi()
		Conn = New SqlConnection("Data Source=DESKTOP-5A499D7\MSSQLSERVER01;Initial Catalog=crudyellow;integrated security=true")
		Conn.Open()
		Try
			FormLogin.LabelDatabase.Text = "Connected"
		Catch ex As Exception
			FormLogin.LabelDatabase.Text = "Not Connected"

		End Try
	End Sub
End Module
