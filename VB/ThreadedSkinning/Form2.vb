Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Namespace ThreadedSkinning
	Partial Public Class Form2
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub MainLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.InvokeRequired Then
				Me.BeginInvoke(New EventHandler(AddressOf MainLookAndFeel_StyleChanged), sender, e)
				Return
			End If

			UserLookAndFeel.Default.Assign(CType(sender, UserLookAndFeel))
		End Sub

	End Class
End Namespace