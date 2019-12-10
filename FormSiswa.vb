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

	'Private Sub TextBoxNIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIS.KeyPress
	'If e.KeyChar = Chr(13) Then
	'	TextBoxNamaSiswa.Focus()
	'	ButtonKeluarBatal.Text = "Batal"
	'End If

	'End Sub

	Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
		If TextBoxNIS.Text = "" Or TextBoxNamaSiswa.Text = "" Or TextBoxPassword.Text = "" Or TextBoxAlamat.Text = "" Or ComboBoxJenisKelamin.Text = "" Then
			If MsgBox("Dalam Belum Lengkap, Lengkapi Data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Me.Show()
			Else
				Call Bersihkan()
				ButtonKeluarBatal.Text = "Keluar"
			End If
		End If
	End Sub
End Class