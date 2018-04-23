Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
			gridView1.Columns("Category").GroupIndex = 0
			gridView1.ExpandAllGroups()
			gridView1.GroupSummary.Add(SummaryItemType.Count, "Product Name", Nothing)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			gridView1.GroupFormat = "[{0}: {1}] [Image: [#image]] [Summary: {2}]"
		End Sub
	End Class
End Namespace