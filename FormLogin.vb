Imports System.Data.SqlClient
Public Class FormLogin
	Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Koneksi()
	End Sub

	Private Sub TextBoxNama_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNama.TextChanged

	End Sub

	Private Sub TextBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNama.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxPassword.Focus()
	End Sub

	Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
		If e.KeyChar = Chr(13) Then Buttonlogin.Focus()
	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		Close()
	End Sub

	Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click
		Call Koneksi()
		Cmd = New SqlCommand("SELECT * FROM SISWA WHERE NamaSiswa='" & TextBoxNama.Text & "' AND Password='" & TextBoxPassword.Text & "' ", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			FormSiswa.Show()
			Me.Visible = False
		Else
			MsgBox("Login Gagal")
			Me.Show()
		End If


	End Sub
End Class
