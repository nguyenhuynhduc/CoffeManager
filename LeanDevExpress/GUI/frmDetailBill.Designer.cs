namespace LeanDevExpress.GUI
{
    partial class frmDetailBill
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
            this.gcvDetailBill = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idDetailBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcvDetailBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcvDetailBill
            // 
            this.gcvDetailBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcvDetailBill.Location = new System.Drawing.Point(0, 40);
            this.gcvDetailBill.MainView = this.gridView1;
            this.gcvDetailBill.Name = "gcvDetailBill";
            this.gcvDetailBill.Size = new System.Drawing.Size(590, 221);
            this.gcvDetailBill.TabIndex = 0;
            this.gcvDetailBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idDetailBill,
            this.idBill,
            this.nameProduct,
            this.price,
            this.Amount,
            this.total});
            this.gridView1.GridControl = this.gcvDetailBill;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // idDetailBill
            // 
            this.idDetailBill.Caption = "ID DETAIL BILL";
            this.idDetailBill.FieldName = "idDetailBill";
            this.idDetailBill.Name = "idDetailBill";
            // 
            // idBill
            // 
            this.idBill.Caption = "ID BILL";
            this.idBill.FieldName = "idBill";
            this.idBill.Name = "idBill";
            // 
            // nameProduct
            // 
            this.nameProduct.Caption = "Product Name";
            this.nameProduct.FieldName = "nameProduct";
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Visible = true;
            this.nameProduct.VisibleIndex = 0;
            // 
            // price
            // 
            this.price.Caption = "Price";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 1;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 2;
            // 
            // total
            // 
            this.total.Caption = "Total";
            this.total.FieldName = "total";
            this.total.Name = "total";
            this.total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "Total={0:0.##}")});
            this.total.Visible = true;
            this.total.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // frmDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcvDetailBill);
            this.Name = "frmDetailBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Bill";
            this.Load += new System.EventHandler(this.frmDetailBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcvDetailBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcvDetailBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idDetailBill;
        private DevExpress.XtraGrid.Columns.GridColumn idBill;
        private DevExpress.XtraGrid.Columns.GridColumn nameProduct;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private System.Windows.Forms.Label label1;

    }
}