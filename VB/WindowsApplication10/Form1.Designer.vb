Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication10
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
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategory = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSubcategory = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldTotalProductCost = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCalendarYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesTerritoryCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.button1 = New System.Windows.Forms.Button()
			Me.fieldSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategory, Me.fieldProduct, Me.fieldSubcategory, Me.fieldTotalProductCost, Me.fieldCalendarYear, Me.fieldSalesTerritoryCountry, Me.fieldSalesAmount})
			pivotGridGroup1.Caption = "Product Categories"
			pivotGridGroup1.Fields.Add(Me.fieldCategory)
			pivotGridGroup1.Fields.Add(Me.fieldSubcategory)
			pivotGridGroup1.Fields.Add(Me.fieldProduct)
			pivotGridGroup1.Hierarchy = "[Product].[Product Categories]"
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=local;initial catalog=""Adventure Works DW Standard Ed" & "ition"";cube name=""Adventure Works"""
			Me.pivotGridControl1.Size = New System.Drawing.Size(648, 386)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldCategory
			' 
			Me.fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategory.AreaIndex = 0
			Me.fieldCategory.Caption = "Category"
			Me.fieldCategory.FieldName = "[Product].[Product Categories].[Category]"
			Me.fieldCategory.Name = "fieldCategory"
			' 
			' fieldProduct
			' 
			Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProduct.AreaIndex = 2
			Me.fieldProduct.Caption = "Product"
			Me.fieldProduct.FieldName = "[Product].[Product Categories].[Product]"
			Me.fieldProduct.Name = "fieldProduct"
			' 
			' fieldSubcategory
			' 
			Me.fieldSubcategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSubcategory.AreaIndex = 1
			Me.fieldSubcategory.Caption = "Subcategory"
			Me.fieldSubcategory.FieldName = "[Product].[Product Categories].[Subcategory]"
			Me.fieldSubcategory.Name = "fieldSubcategory"
			' 
			' fieldTotalProductCost
			' 
			Me.fieldTotalProductCost.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldTotalProductCost.AreaIndex = 0
			Me.fieldTotalProductCost.Caption = "Total Product Cost"
			Me.fieldTotalProductCost.CellFormat.FormatString = "c"
			Me.fieldTotalProductCost.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldTotalProductCost.FieldName = "[Measures].[Total Product Cost]"
			Me.fieldTotalProductCost.Name = "fieldTotalProductCost"
			' 
			' fieldCalendarYear
			' 
			Me.fieldCalendarYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCalendarYear.AreaIndex = 0
			Me.fieldCalendarYear.Caption = "Calendar Year"
			Me.fieldCalendarYear.FieldName = "[Date].[Calendar Year].[Calendar Year]"
			Me.fieldCalendarYear.Name = "fieldCalendarYear"
			' 
			' fieldSalesTerritoryCountry
			' 
			Me.fieldSalesTerritoryCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesTerritoryCountry.AreaIndex = 1
			Me.fieldSalesTerritoryCountry.Caption = "Sales Territory Country"
			Me.fieldSalesTerritoryCountry.FieldName = "[Sales Territory].[Sales Territory Country].[Sales Territory Country]"
			Me.fieldSalesTerritoryCountry.Name = "fieldSalesTerritoryCountry"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(536, 0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(112, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Query Server"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' fieldSalesAmount
			' 
			Me.fieldSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldSalesAmount.AreaIndex = 1
			Me.fieldSalesAmount.Caption = "Sales Amount"
			Me.fieldSalesAmount.CellFormat.FormatString = "c"
			Me.fieldSalesAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldSalesAmount.FieldName = "[Measures].[Sales Amount]"
			Me.fieldSalesAmount.Name = "fieldSalesAmount"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(648, 386)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCategory As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSubcategory As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldTotalProductCost As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCalendarYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesTerritoryCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents button1 As System.Windows.Forms.Button
		Private fieldSalesAmount As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

