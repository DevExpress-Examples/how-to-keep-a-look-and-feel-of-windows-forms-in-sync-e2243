Imports Microsoft.VisualBasic
Imports System
Namespace ThreadedSkinning
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 98)
			Me.simpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(317, 28)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Open a new form in a separate thread"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(125, 13)
			Me.comboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEdit1.Size = New System.Drawing.Size(198, 22)
			Me.comboBoxEdit1.TabIndex = 1
'			Me.comboBoxEdit1.SelectedValueChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 16)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(66, 16)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "Select skin:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(341, 195)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Name = "Form1"
			Me.Text = "XtraForm1"
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

