<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.Buttonlogin = New System.Windows.Forms.Button()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.TextBoxNama = New System.Windows.Forms.TextBox()
		Me.LabelPassword = New System.Windows.Forms.Label()
		Me.LabelNama = New System.Windows.Forms.Label()
		Me.LabelDatabaseStatus = New System.Windows.Forms.Label()
		Me.LabelDatabase = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ButtonCancel)
		Me.GroupBox1.Controls.Add(Me.Buttonlogin)
		Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
		Me.GroupBox1.Controls.Add(Me.TextBoxNama)
		Me.GroupBox1.Controls.Add(Me.LabelPassword)
		Me.GroupBox1.Controls.Add(Me.LabelNama)
		Me.GroupBox1.Location = New System.Drawing.Point(230, 141)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(303, 186)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Login User"
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(199, 127)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCancel.TabIndex = 5
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'Buttonlogin
		'
		Me.Buttonlogin.Location = New System.Drawing.Point(98, 127)
		Me.Buttonlogin.Name = "Buttonlogin"
		Me.Buttonlogin.Size = New System.Drawing.Size(75, 23)
		Me.Buttonlogin.TabIndex = 4
		Me.Buttonlogin.Text = "Login"
		Me.Buttonlogin.UseVisualStyleBackColor = True
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.Location = New System.Drawing.Point(98, 72)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.Size = New System.Drawing.Size(176, 20)
		Me.TextBoxPassword.TabIndex = 3
		Me.TextBoxPassword.Text = "Masukan Password"
		'
		'TextBoxNama
		'
		Me.TextBoxNama.Location = New System.Drawing.Point(98, 33)
		Me.TextBoxNama.Name = "TextBoxNama"
		Me.TextBoxNama.Size = New System.Drawing.Size(176, 20)
		Me.TextBoxNama.TabIndex = 2
		Me.TextBoxNama.Text = "Masukan Nama"
		'
		'LabelPassword
		'
		Me.LabelPassword.AutoSize = True
		Me.LabelPassword.Location = New System.Drawing.Point(25, 79)
		Me.LabelPassword.Name = "LabelPassword"
		Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
		Me.LabelPassword.TabIndex = 1
		Me.LabelPassword.Text = "Password"
		'
		'LabelNama
		'
		Me.LabelNama.AutoSize = True
		Me.LabelNama.Location = New System.Drawing.Point(25, 36)
		Me.LabelNama.Name = "LabelNama"
		Me.LabelNama.Size = New System.Drawing.Size(35, 13)
		Me.LabelNama.TabIndex = 0
		Me.LabelNama.Text = "Nama"
		'
		'LabelDatabaseStatus
		'
		Me.LabelDatabaseStatus.AutoSize = True
		Me.LabelDatabaseStatus.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelDatabaseStatus.Location = New System.Drawing.Point(342, 344)
		Me.LabelDatabaseStatus.Name = "LabelDatabaseStatus"
		Me.LabelDatabaseStatus.Size = New System.Drawing.Size(90, 9)
		Me.LabelDatabaseStatus.TabIndex = 6
		Me.LabelDatabaseStatus.Text = "Database Status :"
		'
		'LabelDatabase
		'
		Me.LabelDatabase.AutoSize = True
		Me.LabelDatabase.Font = New System.Drawing.Font("Lucida Console", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelDatabase.ForeColor = System.Drawing.SystemColors.Highlight
		Me.LabelDatabase.Location = New System.Drawing.Point(438, 344)
		Me.LabelDatabase.Name = "LabelDatabase"
		Me.LabelDatabase.Size = New System.Drawing.Size(95, 9)
		Me.LabelDatabase.TabIndex = 7
		Me.LabelDatabase.Text = "Database Status"
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.LabelDatabase)
		Me.Controls.Add(Me.LabelDatabaseStatus)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormLogin"
		Me.Text = "Form Login"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents Buttonlogin As Button
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents TextBoxNama As TextBox
	Friend WithEvents LabelPassword As Label
	Friend WithEvents LabelNama As Label
	Friend WithEvents LabelDatabaseStatus As Label
	Friend WithEvents LabelDatabase As Label
End Class
