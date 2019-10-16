namespace LeanDevExpress.GUI
{
    partial class frmStatic
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
            this.gcvBill = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbDay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gcvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDay.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcvBill
            // 
            this.gcvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcvBill.Location = new System.Drawing.Point(0, 81);
            this.gcvBill.MainView = this.gridView1;
            this.gcvBill.Name = "gcvBill";
            this.gcvBill.Size = new System.Drawing.Size(761, 298);
            this.gcvBill.TabIndex = 0;
            this.gcvBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idBill,
            this.total,
            this.dateTime});
            this.gridView1.FooterPanelHeight = 1;
            this.gridView1.GridControl = this.gcvBill;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // idBill
            // 
            this.idBill.Caption = "ID BILL";
            this.idBill.FieldName = "idBill";
            this.idBill.Name = "idBill";
            this.idBill.Visible = true;
            this.idBill.VisibleIndex = 0;
            // 
            // total
            // 
            this.total.Caption = "Total";
            this.total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.total.FieldName = "cost";
            this.total.Name = "total";
            this.total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cost", "Total = {0:0.##}")});
            this.total.Visible = true;
            this.total.VisibleIndex = 1;
            // 
            // dateTime
            // 
            this.dateTime.Caption = "DAY";
            this.dateTime.FieldName = "dateTime";
            this.dateTime.Name = "dateTime";
            this.dateTime.Visible = true;
            this.dateTime.VisibleIndex = 2;
            // 
            // cbbYear
            // 
            this.cbbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbYear.Location = new System.Drawing.Point(193, 3);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.Properties.Appearance.Options.UseFont = true;
            this.cbbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbYear.Size = new System.Drawing.Size(89, 26);
            this.cbbYear.TabIndex = 1;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // cbbMonth
            // 
            this.cbbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMonth.Location = new System.Drawing.Point(383, 3);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonth.Properties.Appearance.Options.UseFont = true;
            this.cbbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMonth.Size = new System.Drawing.Size(89, 26);
            this.cbbMonth.TabIndex = 2;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // cbbDay
            // 
            this.cbbDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDay.Location = new System.Drawing.Point(573, 3);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDay.Properties.Appearance.Options.UseFont = true;
            this.cbbDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDay.Size = new System.Drawing.Size(89, 26);
            this.cbbDay.TabIndex = 3;
            this.cbbDay.SelectedIndexChanged += new System.EventHandler(this.cbbDay_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(146, 7);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(41, 19);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Day";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managerProductToolStripMenuItem,
            this.billListToolStripMenuItem,
            this.staticticalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // managerProductToolStripMenuItem
            // 
            this.managerProductToolStripMenuItem.Name = "managerProductToolStripMenuItem";
            this.managerProductToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.managerProductToolStripMenuItem.Text = "Manager Product";
            this.managerProductToolStripMenuItem.Click += new System.EventHandler(this.managerProductToolStripMenuItem_Click);
            // 
            // billListToolStripMenuItem
            // 
            this.billListToolStripMenuItem.Enabled = false;
            this.billListToolStripMenuItem.Name = "billListToolStripMenuItem";
            this.billListToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.billListToolStripMenuItem.Text = "Bill List";
            this.billListToolStripMenuItem.Click += new System.EventHandler(this.billListToolStripMenuItem_Click);
            // 
            // staticticalToolStripMenuItem
            // 
            this.staticticalToolStripMenuItem.Name = "staticticalToolStripMenuItem";
            this.staticticalToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.staticticalToolStripMenuItem.Text = "Statictical";
            this.staticticalToolStripMenuItem.Click += new System.EventHandler(this.staticticalToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.cbbDay, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Year, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbMonth, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbYear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 34);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // frmStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gcvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDay.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcvBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idBill;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private DevExpress.XtraGrid.Columns.GridColumn dateTime;
        private DevExpress.XtraEditors.ComboBoxEdit cbbYear;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMonth;
        private DevExpress.XtraEditors.ComboBoxEdit cbbDay;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticticalToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}