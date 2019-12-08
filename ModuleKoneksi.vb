Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Ds As DataSet
	Public Da As SqlDataAdapter
	Public Cmd As SqlCommand

	Sub Koneksi()
		Conn = New SqlConnection("Data Sources=AERYICE-PC666;")

	End Sub
End Module
