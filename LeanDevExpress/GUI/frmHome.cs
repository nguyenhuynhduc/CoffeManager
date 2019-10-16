using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
 
namespace LeanDevExpress.GUI
{
    public partial class frmHome : DevExpress.XtraEditors.XtraForm
    {

        BUS.BUS_Table busTable;
        public frmHome()
        {
            InitializeComponent();
            busTable = new BUS.BUS_Table();

            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }


        private void loadTable()
        {
 
        }
        
        


        private void loadTableLayout()
        {
            DataTable dt = busTable.getAlltable();
            BUS.BUS_Oder oder = new BUS.BUS_Oder();
            
            content.Controls.Clear();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Size = new Size(733, 334);

            tableLayoutPanel.AutoScroll = true;

            tableLayoutPanel.ColumnStyles.Clear(); 
            tableLayoutPanel.RowStyles.Clear();

            tableLayoutPanel.ColumnCount = 7;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                tableLayoutPanel.RowCount += 1;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

                Button btn = new Button();
                btn.Text = "Table " + dt.Rows[i]["name"];
                btn.Name = "btn" + i;
                btn.Width = 80;
                btn.Height = 80;

                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btn.AutoSize = false;
                btn.Dock = DockStyle.Fill;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                string idTable = dt.Rows[i]["idTable"].ToString();
                string name = dt.Rows[i]["name"].ToString();
                btn.Click += (se, ev) => button_Click(se, ev, idTable, name);
              
                DTO.DTO_Oder dtoOder = new DTO.DTO_Oder();
                dtoOder.idTable = Convert.ToInt16(dt.Rows[i]["idTable"].ToString());

                DataTable dtOder = oder.getAllOder(dtoOder);

                if (dtOder.Rows.Count > 0)
                {
                    btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\inconCoffeAction.png");

                }
                else
                {
                    btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\inconCoffeEmpty.png");
                }

                tableLayoutPanel.Controls.Add(btn, i, 0); 
            }
            content.Controls.Add(tableLayoutPanel);

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            loadTableLayout();

        }
        protected void button_Click(object sender, EventArgs e,string idTable,string name)
        {
            frmOder Product = new frmOder();
            
            Product.FormClosed += new FormClosedEventHandler(closeForm);
            Product.id = idTable;
            Product.name = name;
            Product.Show();
        }

        private void closeForm(object sender, EventArgs e)
        {
            loadTableLayout();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = busTable.getLastTable();
            DTO.DTO_Table DTO_table = new DTO.DTO_Table();
            DTO_table.name = Convert.ToInt16(dt.Rows[0]["name"]) + 1;
            DTO_table.status = "action";
            if (busTable.insertTable(DTO_table))
            {
                MessageBox.Show("Insert Table Success!!!");
                loadTableLayout();
            }
            else
            {
                MessageBox.Show("ERROR!!!");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = busTable.getLastTable();
            DTO.DTO_Table DTO_table = new DTO.DTO_Table();
            DTO_table.idTable = Convert.ToInt16(dt.Rows[0]["idTable"]);
            if (busTable.deleteTable(DTO_table))
            {
                MessageBox.Show("Delete Table Success!!!");
                loadTableLayout();
            }
            else
            {
                MessageBox.Show("ERROR!!!");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.FormClosed += new FormClosedEventHandler(dongform);
            this.Hide();
            home.Show();
        }

        private void managerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProducts product = new frmAllProducts();
            product.FormClosed += new FormClosedEventHandler(dongform);
            this.Hide();
            product.Show();
        }

        private void billListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatic allBill = new frmStatic();
            allBill.FormClosed += new FormClosedEventHandler(dongform);
            this.Hide();
            allBill.Show();
        }

        private void staticticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductStatic statictical = new frmProductStatic();
            statictical.FormClosed += new FormClosedEventHandler(dongform);
            this.Hide();
            statictical.Show();
        }
        private void dongform(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}