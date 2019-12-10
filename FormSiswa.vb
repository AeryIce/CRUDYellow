Imports System.Data.SqlClient
Public Class FormSiswa

	Sub Bersihkan()
		TextBoxNIS.Focus()
		TextBoxNIS.Clear()
		TextBoxNamaSiswa.Clear()
		TextBoxPassword.Clear()
		TextBoxAlamat.Clear()
		ComboBoxJenisKelamin.Items.Clear()
		ComboBoxJenisKelamin.Items.Add("Laki-Laki")
		ComboBoxJenisKelamin.Items.Add("Perempuan")
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
			Else
				ButtonKeluarBatal.Text = "Keluar"

			End If
		End If


	End Sub

	Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBoxNIS.Focus()
		Call Bersihkan()
	End Sub

	Private Sub TextBoxNIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIS.KeyPress
		If e.KeyChar = Chr(13) Then
			TextBoxNamaSiswa.Focus()
			ButtonKeluarBatal.Text = "Batal"
		End If

	End Sub

	Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
		If TextBoxNIS.Text = "" Or TextBoxNamaSiswa.Text = "" Or TextBoxPassword.Text = "" Or TextBoxAlamat.Text = "" Or ComboBoxJenisKelamin.Text = "" Then
			If MsgBox("Data belum lengkap, lengkapi data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Dim Simpan As String = "INSERT INTO siswa VALUES ('" & TextBoxNIS.Text & "','" & TextBoxNamaSiswa.Text & "','" & TextBoxAlamat.Text & "','" & ComboBoxJenisKelamin.Text & "','" & TextBoxPassword.Text & "')"
				Cmd = New SqlCommand(Simpan, Conn)
				Cmd.ExecuteNonQuery()
				Me.Show()
				Call Bersihkan()
			Else
				MsgBox("Operasi di batalkan")
				Call Bersihkan()
				ButtonKeluarBatal.Text = "Keluar"
			End If


		Else
			Call Koneksi()
			Dim Simpan As String = "INSERT INTO siswa VALUES ('" & TextBoxNIS.Text & "','" & TextBoxNamaSiswa.Text & "','" & TextBoxAlamat.Text & "','" & ComboBoxJenisKelamin.Text & "','" & TextBoxPassword.Text & "')"
			Cmd = New SqlCommand(Simpan, Conn)
			Cmd.ExecuteNonQuery()
			If MsgBox("Data Sudah Tersimpan, Input Lagi?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Call Bersihkan()
			Else
				MsgBox("Data Sudah Tersimpan")
				Call Bersihkan()
				ButtonKeluarBatal.Text = "Keluar"

			End If
		End If

	End Sub
End Class