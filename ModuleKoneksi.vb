Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Ds As DataSet
	Public Da As SqlDataAdapter
	Public Cmd As SqlCommand

	Sub Koneksi()
		Conn = New SqlConnection("Data Source=AERYICE-PC666;Initial Catalog=crudyellow;integrated security=true")
		Conn.Open()
		Try
			MsgBox("Koneksi Berhasil", MsgBoxStyle.Information, "Informasi")
		Catch ex As Exception
			MsgBox(Err.Description, MsgBoxStyle.Critical, "Koneksi Gagal")

		End Try
	End Sub
End Module
