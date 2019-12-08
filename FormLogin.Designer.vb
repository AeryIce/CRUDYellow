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
		Me.ButtonTestKoneksi = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonTestKoneksi
		'
		Me.ButtonTestKoneksi.Location = New System.Drawing.Point(365, 165)
		Me.ButtonTestKoneksi.Name = "ButtonTestKoneksi"
		Me.ButtonTestKoneksi.Size = New System.Drawing.Size(75, 23)
		Me.ButtonTestKoneksi.TabIndex = 0
		Me.ButtonTestKoneksi.Text = "Tes Koneksi"
		Me.ButtonTestKoneksi.UseVisualStyleBackColor = True
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.ButtonTestKoneksi)
		Me.Name = "FormLogin"
		Me.Text = "Login User"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonTestKoneksi As Button
End Class
