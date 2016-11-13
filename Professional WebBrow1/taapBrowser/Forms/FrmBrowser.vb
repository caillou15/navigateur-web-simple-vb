Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports WeifenLuo.WinFormsUI.Docking

Namespace taapBrowser.Forms
	Partial Public Class FrmBrowser
		Inherits DockContent

		Public Sub New()
			InitializeComponent()

		End Sub
        Public Shared WithEvents tbSeachBox As Container
        Private Sub tbSearchBox_Click(sender As Object, e As EventArgs) Handles tbSearchBox.Click
            Dim Recherche As Integer
            Recherche = AddressBar
        End Sub
    End Class
End Namespace
