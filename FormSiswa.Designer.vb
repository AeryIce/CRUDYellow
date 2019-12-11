<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiswa
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.GroupBoxDataSiswa = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBoxJenisKelamin = New System.Windows.Forms.ComboBox()
		Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
		Me.LabelAlamat = New System.Windows.Forms.Label()
		Me.TextBoxNIS = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.LabelPassword = New System.Windows.Forms.Label()
		Me.TextBoxNamaSiswa = New System.Windows.Forms.TextBox()
		Me.LabelNamaSiswa = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ButtonCari = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.ButtonHapus = New System.Windows.Forms.Button()
		Me.ButtonEdit = New System.Windows.Forms.Button()
		Me.ButtonTambah = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.ButtonKeluarBatal = New System.Windows.Forms.Button()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.DGVSiswa = New System.Windows.Forms.DataGridView()
		Me.TextBoxCariNIS = New System.Windows.Forms.TextBox()
		Me.GroupBoxDataSiswa.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.DGVSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBoxDataSiswa
		'
		Me.GroupBoxDataSiswa.Controls.Add(Me.Label2)
		Me.GroupBoxDataSiswa.Controls.Add(Me.ComboBoxJenisKelamin)
		Me.GroupBoxDataSiswa.Controls.Add(Me.TextBoxAlamat)
		Me.GroupBoxDataSiswa.Controls.Add(Me.LabelAlamat)
		Me.GroupBoxDataSiswa.Controls.Add(Me.TextBoxNIS)
		Me.GroupBoxDataSiswa.Controls.Add(Me.Label1)
		Me.GroupBoxDataSiswa.Controls.Add(Me.TextBoxPassword)
		Me.GroupBoxDataSiswa.Controls.Add(Me.LabelPassword)
		Me.GroupBoxDataSiswa.Controls.Add(Me.TextBoxNamaSiswa)
		Me.GroupBoxDataSiswa.Controls.Add(Me.LabelNamaSiswa)
		Me.GroupBoxDataSiswa.Location = New System.Drawing.Point(12, 12)
		Me.GroupBoxDataSiswa.Name = "GroupBoxDataSiswa"
		Me.GroupBoxDataSiswa.Size = New System.Drawing.Size(334, 206)
		Me.GroupBoxDataSiswa.TabIndex = 0
		Me.GroupBoxDataSiswa.TabStop = False
		Me.GroupBoxDataSiswa.Text = "Data Siswa"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(20, 163)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(92, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Jenis Kelamin      :"
		'
		'ComboBoxJenisKelamin
		'
		Me.ComboBoxJenisKelamin.FormattingEnabled = True
		Me.ComboBoxJenisKelamin.Location = New System.Drawing.Point(118, 160)
		Me.ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
		Me.ComboBoxJenisKelamin.Size = New System.Drawing.Size(184, 21)
		Me.ComboBoxJenisKelamin.TabIndex = 8
		'
		'TextBoxAlamat
		'
		Me.TextBoxAlamat.Location = New System.Drawing.Point(118, 127)
		Me.TextBoxAlamat.Name = "TextBoxAlamat"
		Me.TextBoxAlamat.Size = New System.Drawing.Size(184, 20)
		Me.TextBoxAlamat.TabIndex = 7
		'
		'LabelAlamat
		'
		Me.LabelAlamat.AutoSize = True
		Me.LabelAlamat.Location = New System.Drawing.Point(24, 130)
		Me.LabelAlamat.Name = "LabelAlamat"
		Me.LabelAlamat.Size = New System.Drawing.Size(87, 13)
		Me.LabelAlamat.TabIndex = 6
		Me.LabelAlamat.Text = "Alamat               :"
		'
		'TextBoxNIS
		'
		Me.TextBoxNIS.Location = New System.Drawing.Point(118, 23)
		Me.TextBoxNIS.Name = "TextBoxNIS"
		Me.TextBoxNIS.Size = New System.Drawing.Size(184, 20)
		Me.TextBoxNIS.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(24, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(85, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "NIS                   :"
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.Location = New System.Drawing.Point(118, 97)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.Size = New System.Drawing.Size(184, 20)
		Me.TextBoxPassword.TabIndex = 3
		'
		'LabelPassword
		'
		Me.LabelPassword.AutoSize = True
		Me.LabelPassword.Location = New System.Drawing.Point(24, 100)
		Me.LabelPassword.Name = "LabelPassword"
		Me.LabelPassword.Size = New System.Drawing.Size(86, 13)
		Me.LabelPassword.TabIndex = 2
		Me.LabelPassword.Text = "Password          :"
		'
		'TextBoxNamaSiswa
		'
		Me.TextBoxNamaSiswa.Location = New System.Drawing.Point(118, 62)
		Me.TextBoxNamaSiswa.Name = "TextBoxNamaSiswa"
		Me.TextBoxNamaSiswa.Size = New System.Drawing.Size(184, 20)
		Me.TextBoxNamaSiswa.TabIndex = 1
		'
		'LabelNamaSiswa
		'
		Me.LabelNamaSiswa.AutoSize = True
		Me.LabelNamaSiswa.Location = New System.Drawing.Point(24, 69)
		Me.LabelNamaSiswa.Name = "LabelNamaSiswa"
		Me.LabelNamaSiswa.Size = New System.Drawing.Size(86, 13)
		Me.LabelNamaSiswa.TabIndex = 0
		Me.LabelNamaSiswa.Text = "Nama                :"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBoxCariNIS)
		Me.GroupBox1.Controls.Add(Me.ButtonCari)
		Me.GroupBox1.Location = New System.Drawing.Point(364, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(293, 43)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cari Data"
		'
		'ButtonCari
		'
		Me.ButtonCari.Location = New System.Drawing.Point(143, 17)
		Me.ButtonCari.Name = "ButtonCari"
		Me.ButtonCari.Size = New System.Drawing.Size(144, 20)
		Me.ButtonCari.TabIndex = 0
		Me.ButtonCari.Text = "Cari"
		Me.ButtonCari.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.ButtonHapus)
		Me.GroupBox2.Controls.Add(Me.ButtonEdit)
		Me.GroupBox2.Controls.Add(Me.ButtonTambah)
		Me.GroupBox2.Location = New System.Drawing.Point(358, 68)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(299, 79)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Modif Data"
		'
		'ButtonHapus
		'
		Me.ButtonHapus.Location = New System.Drawing.Point(209, 19)
		Me.ButtonHapus.Name = "ButtonHapus"
		Me.ButtonHapus.Size = New System.Drawing.Size(84, 37)
		Me.ButtonHapus.TabIndex = 3
		Me.ButtonHapus.Text = "Hapus"
		Me.ButtonHapus.UseVisualStyleBackColor = True
		'
		'ButtonEdit
		'
		Me.ButtonEdit.Location = New System.Drawing.Point(110, 19)
		Me.ButtonEdit.Name = "ButtonEdit"
		Me.ButtonEdit.Size = New System.Drawing.Size(81, 37)
		Me.ButtonEdit.TabIndex = 2
		Me.ButtonEdit.Text = "Edit"
		Me.ButtonEdit.UseVisualStyleBackColor = True
		'
		'ButtonTambah
		'
		Me.ButtonTambah.Location = New System.Drawing.Point(6, 19)
		Me.ButtonTambah.Name = "ButtonTambah"
		Me.ButtonTambah.Size = New System.Drawing.Size(81, 38)
		Me.ButtonTambah.TabIndex = 1
		Me.ButtonTambah.Text = "Tambah"
		Me.ButtonTambah.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.ButtonKeluarBatal)
		Me.GroupBox3.Location = New System.Drawing.Point(364, 153)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(293, 65)
		Me.GroupBox3.TabIndex = 3
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Keluar/Batal"
		'
		'ButtonKeluarBatal
		'
		Me.ButtonKeluarBatal.Location = New System.Drawing.Point(95, 17)
		Me.ButtonKeluarBatal.Name = "ButtonKeluarBatal"
		Me.ButtonKeluarBatal.Size = New System.Drawing.Size(103, 42)
		Me.ButtonKeluarBatal.TabIndex = 4
		Me.ButtonKeluarBatal.Text = "Keluar"
		Me.ButtonKeluarBatal.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.DGVSiswa)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 224)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(645, 152)
		Me.GroupBox4.TabIndex = 4
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Data Siswa"
		'
		'DGVSiswa
		'
		Me.DGVSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVSiswa.Location = New System.Drawing.Point(6, 19)
		Me.DGVSiswa.Name = "DGVSiswa"
		Me.DGVSiswa.Size = New System.Drawing.Size(615, 127)
		Me.DGVSiswa.TabIndex = 0
		'
		'TextBoxCariNIS
		'
		Me.TextBoxCariNIS.Location = New System.Drawing.Point(0, 17)
		Me.TextBoxCariNIS.Name = "TextBoxCariNIS"
		Me.TextBoxCariNIS.Size = New System.Drawing.Size(138, 20)
		Me.TextBoxCariNIS.TabIndex = 10
		Me.TextBoxCariNIS.Text = "Masukan Nis yang di cari"
		'
		'FormSiswa
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(685, 450)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBoxDataSiswa)
		Me.Name = "FormSiswa"
		Me.Text = "FormSiswa"
		Me.GroupBoxDataSiswa.ResumeLayout(False)
		Me.GroupBoxDataSiswa.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.DGVSiswa, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBoxDataSiswa As GroupBox
	Friend WithEvents LabelNamaSiswa As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents LabelPassword As Label
	Friend WithEvents TextBoxNamaSiswa As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBoxJenisKelamin As ComboBox
	Friend WithEvents TextBoxAlamat As TextBox
	Friend WithEvents LabelAlamat As Label
	Friend WithEvents TextBoxNIS As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ButtonCari As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ButtonEdit As Button
	Friend WithEvents ButtonTambah As Button
	Friend WithEvents ButtonHapus As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents ButtonKeluarBatal As Button
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents DGVSiswa As DataGridView
	Friend WithEvents TextBoxCariNIS As TextBox
End Class
