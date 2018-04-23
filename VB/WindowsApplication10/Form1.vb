Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication10
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private adapter As CubeToTableAdapter
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			adapter = New CubeToTableAdapter(pivotGridControl1)
		End Sub



		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			adapter.RefreshDataSource()
			pivotGridControl1.CollapseAll()
		End Sub
	End Class

End Namespace