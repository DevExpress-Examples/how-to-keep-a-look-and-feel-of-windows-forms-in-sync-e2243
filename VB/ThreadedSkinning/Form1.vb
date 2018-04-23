Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Namespace ThreadedSkinning
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()

			comboBoxEdit1.EditValue = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
			For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
				comboBoxEdit1.Properties.Items.Add(cnt.SkinName)
			Next cnt
		End Sub
		Private Sub comboBoxEdit1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedValueChanged
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = comboBoxEdit1.Text
		End Sub

		Private Class ShowFormThreadData
			Public mainLookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel
			' TODO add more fields to pass data to a new thread
		End Class

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim thread As New Thread(New ParameterizedThreadStart(AddressOf myThread_OpenForm))
			thread.IsBackground = True
			thread.SetApartmentState(ApartmentState.STA)
			Dim data As New ShowFormThreadData()
			data.mainLookAndFeel = DevExpress.LookAndFeel.UserLookAndFeel.Default
			thread.Start(data)
		End Sub

		Public Shared Sub myThread_OpenForm(ByVal data As Object)
			Dim td As ShowFormThreadData = TryCast(data, ShowFormThreadData)

			' this thread 
			DevExpress.UserSkins.OfficeSkins.Register()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(td.mainLookAndFeel)

			Dim form2 As New Form2()
			AddHandler td.mainLookAndFeel.StyleChanged, AddressOf form2.MainLookAndFeel_StyleChanged
			form2.ShowDialog()
		End Sub
	End Class
End Namespace