Imports System.Data.SqlClient
Public Class FormSiswa

	Sub Bersihkan()
		TextBoxNIS.Focus()
		TextBoxNIS.Clear()
		TextBoxNamaSiswa.Clear()
		TextBoxPassword.Clear()
		TextBoxAlamat.Clear()
		ComboBoxJenisKelamin.Text = ""
		'ComboBoxJenisKelamin.Items.Add("Laki-Laki")
		'ComboBoxJenisKelamin.Items.Add("Perempuan")
	End Sub

	Sub RefreshDGVSiswa()
		Call Koneksi()
		Da = New SqlDataAdapter("SELECT * FROM siswa", Conn)
		Ds = New DataSet
		Da.Fill(Ds)
		DGVSiswa.DataSource = Ds.Tables(0)
		DGVSiswa.ReadOnly = True


	End Sub
	Private Sub ButtonKeluarBatal_Click(sender As Object, e As EventArgs) Handles ButtonKeluarBatal.Click
		If ButtonKeluarBatal.Text = "Keluar" Then
			If MsgBox("Apakah Anda yakin Keluar?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Me.Close()
				FormLogin.Close()

			End If
		Else
			If MsgBox("BatalKan Operasi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Call Bersihkan()
				TextBoxNIS.Enabled = True
				TextBoxNamaSiswa.Enabled = True
				TextBoxAlamat.Enabled = True
				ComboBoxJenisKelamin.Enabled = True
				TextBoxPassword.Enabled = True
				ButtonKeluarBatal.Text = "Keluar"
			Else
				ButtonKeluarBatal.Text = "Keluar"

			End If
		End If


	End Sub

	Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBoxNIS.Focus()
		Call Bersihkan()
		Call RefreshDGVSiswa()
		ComboBoxJenisKelamin.Items.Add("Laki-Laki")
		ComboBoxJenisKelamin.Items.Add("Perempuan")
		TextBoxNIS.Enabled = False
		TextBoxNamaSiswa.Enabled = False
		TextBoxAlamat.Enabled = False
		ComboBoxJenisKelamin.Enabled = False
		TextBoxPassword.Enabled = False
	End Sub

	Private Sub TextBoxNIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIS.KeyPress
		If e.KeyChar = Chr(13) Then
			TextBoxNamaSiswa.Focus()
			ButtonKeluarBatal.Text = "Batal"
		End If

	End Sub

	Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
		TextBoxNIS.Enabled = True
		TextBoxNamaSiswa.Enabled = True
		TextBoxAlamat.Enabled = True
		ComboBoxJenisKelamin.Enabled = True
		TextBoxPassword.Enabled = True
		If MsgBox("Lanjut Input Data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
			TextBoxNIS.Focus()
			If TextBoxNIS.Text = "" Or TextBoxNamaSiswa.Text = "" Or TextBoxPassword.Text = "" Or TextBoxAlamat.Text = "" Or ComboBoxJenisKelamin.Text = "" Then
				If MsgBox("Data belum lengkap, lengkapi data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
					Me.Show()
				Else
					MsgBox("Operasi di batalkan")
					Call Bersihkan()
					ButtonKeluarBatal.Text = "Keluar"
				End If


			Else
				If MsgBox("Simpan Data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
					Call Koneksi()
					Cmd = New SqlCommand("SELECT * FROM siswa WHERE NIS='" & TextBoxNIS.Text & "' ", Conn)
					Dr = Cmd.ExecuteReader()
					Dr.Read()
					If Dr.HasRows Then
						MsgBox("NIS Sudah ada, Silahkan Ganti")
						TextBoxNIS.Enabled = True
						TextBoxNamaSiswa.Enabled = False
						TextBoxAlamat.Enabled = False
						ComboBoxJenisKelamin.Enabled = False
						TextBoxPassword.Enabled = False
						ButtonKeluarBatal.Text = "Batal"
					Else
						Call Koneksi()
						Dim Simpan As String = "INSERT INTO siswa VALUES ('" & TextBoxNIS.Text & "','" & TextBoxNamaSiswa.Text & "','" & TextBoxAlamat.Text & "','" & ComboBoxJenisKelamin.Text & "','" & TextBoxPassword.Text & "')"
						Cmd = New SqlCommand(Simpan, Conn)
						Cmd.ExecuteNonQuery()
						If MsgBox("Data Sudah Tersimpan, Input Lagi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
							Call Bersihkan()
							Call RefreshDGVSiswa()
							ButtonKeluarBatal.Text = "Batal"
							TextBoxNIS.Enabled = True
							TextBoxNamaSiswa.Enabled = True
							TextBoxAlamat.Enabled = True
							ComboBoxJenisKelamin.Enabled = True
							TextBoxPassword.Enabled = True
						Else
							MsgBox("Data Sudah Tersimpan")
							Call Bersihkan()
							Call RefreshDGVSiswa()
							ButtonKeluarBatal.Text = "Keluar"


						End If

					End If

				Else
					MsgBox("Operasi Dibatalkan")
					Call Bersihkan()
					Call RefreshDGVSiswa()
				End If
			End If
		Else
			Me.Show()
			TextBoxNIS.Enabled = False
			TextBoxNamaSiswa.Enabled = False
			TextBoxAlamat.Enabled = False
			ComboBoxJenisKelamin.Enabled = False
			TextBoxPassword.Enabled = False
		End If



	End Sub
End Class