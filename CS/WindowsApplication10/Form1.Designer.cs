namespace WindowsApplication10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategory = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProduct = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSubcategory = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalProductCost = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCalendarYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesTerritoryCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.button1 = new System.Windows.Forms.Button();
            this.fieldSalesAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategory,
            this.fieldProduct,
            this.fieldSubcategory,
            this.fieldTotalProductCost,
            this.fieldCalendarYear,
            this.fieldSalesTerritoryCountry,
            this.fieldSalesAmount});
            pivotGridGroup1.Caption = "Product Categories";
            pivotGridGroup1.Fields.Add(this.fieldCategory);
            pivotGridGroup1.Fields.Add(this.fieldSubcategory);
            pivotGridGroup1.Fields.Add(this.fieldProduct);
            pivotGridGroup1.Hierarchy = "[Product].[Product Categories]";
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=local;initial catalog=\"Adventure Works DW Standard Ed" +
                "ition\";cube name=\"Adventure Works\"";
            this.pivotGridControl1.Size = new System.Drawing.Size(648, 386);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldCategory
            // 
            this.fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory.AreaIndex = 0;
            this.fieldCategory.Caption = "Category";
            this.fieldCategory.FieldName = "[Product].[Product Categories].[Category]";
            this.fieldCategory.Name = "fieldCategory";
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 2;
            this.fieldProduct.Caption = "Product";
            this.fieldProduct.FieldName = "[Product].[Product Categories].[Product]";
            this.fieldProduct.Name = "fieldProduct";
            // 
            // fieldSubcategory
            // 
            this.fieldSubcategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSubcategory.AreaIndex = 1;
            this.fieldSubcategory.Caption = "Subcategory";
            this.fieldSubcategory.FieldName = "[Product].[Product Categories].[Subcategory]";
            this.fieldSubcategory.Name = "fieldSubcategory";
            // 
            // fieldTotalProductCost
            // 
            this.fieldTotalProductCost.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalProductCost.AreaIndex = 0;
            this.fieldTotalProductCost.Caption = "Total Product Cost";
            this.fieldTotalProductCost.CellFormat.FormatString = "c";
            this.fieldTotalProductCost.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTotalProductCost.FieldName = "[Measures].[Total Product Cost]";
            this.fieldTotalProductCost.Name = "fieldTotalProductCost";
            // 
            // fieldCalendarYear
            // 
            this.fieldCalendarYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCalendarYear.AreaIndex = 0;
            this.fieldCalendarYear.Caption = "Calendar Year";
            this.fieldCalendarYear.FieldName = "[Date].[Calendar Year].[Calendar Year]";
            this.fieldCalendarYear.Name = "fieldCalendarYear";
            // 
            // fieldSalesTerritoryCountry
            // 
            this.fieldSalesTerritoryCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesTerritoryCountry.AreaIndex = 1;
            this.fieldSalesTerritoryCountry.Caption = "Sales Territory Country";
            this.fieldSalesTerritoryCountry.FieldName = "[Sales Territory].[Sales Territory Country].[Sales Territory Country]";
            this.fieldSalesTerritoryCountry.Name = "fieldSalesTerritoryCountry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Query Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fieldSalesAmount
            // 
            this.fieldSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSalesAmount.AreaIndex = 1;
            this.fieldSalesAmount.Caption = "Sales Amount";
            this.fieldSalesAmount.CellFormat.FormatString = "c";
            this.fieldSalesAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSalesAmount.FieldName = "[Measures].[Sales Amount]";
            this.fieldSalesAmount.Name = "fieldSalesAmount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProduct;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSubcategory;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalProductCost;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCalendarYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesTerritoryCountry;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesAmount;
    }
}

