using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LeanDevExpress.GUI
{
    public partial class frmStatic : DevExpress.XtraEditors.XtraForm
    {
        BUS.BUS_Bill busBill;


        public frmStatic()
        {
            InitializeComponent();
            busBill = new BUS.BUS_Bill();
            
           
        }
        
        private void loadBill()
        {
            DataTable dtBill = busBill.getAllBill();
            gcvBill.DataSource = dtBill;
            
        }
        void loadYear()
        {
            string yearNow = DateTime.Now.Year.ToString();
           
            for (int i = Convert.ToInt16(yearNow); i >=2015 ; i--)
            {
                cbbYear.Properties.Items.Add(i.ToString());  
            }      
        }
        private void frmStatic_Load(object sender, EventArgs e)
        {
            loadBill();
            loadYear();
        }
        int index;
       

      

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            index = e.RowHandle;
            string idBill1 = gridView1.GetRowCellValue(index, "idBill").ToString();
            frmDetailBill detailBill = new frmDetailBill();
            detailBill.idBill1 = idBill1;
            detailBill.Show();


            
        }

       

        private void bmDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(e.Item.Caption + " item clicked");
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMonth.Text = "";
            cbbDay.Text = "";

            int year = Convert.ToInt16(cbbYear.SelectedText);
            loadBillYear(year);

            string monthNow = DateTime.Now.Month.ToString();
            int month = 0;

            cbbMonth.Properties.Items.Clear();
            cbbDay.Properties.Items.Clear();
            if (year + "" == DateTime.Now.Year.ToString())
            {
                 month = Convert.ToInt16(monthNow);
            }
            else {
                 month = 12;
            }
            for (int i = month; i >= 1; i--)
            {
                cbbMonth.Properties.Items.Add(i.ToString());  
            }    
        }
        private void loadBillYear(int year)
        {
            DataTable dtBill = busBill.getBillYear(year);
            gcvBill.DataSource = dtBill;
            cbbYear.SelectedItem = year;
        }
        private void loadBillYearMonth(int year, int month)
        {
            DataTable dtBill = busBill.getBillYearMonth(year,month);
            gcvBill.DataSource = dtBill;
            cbbYear.SelectedItem = year;
            cbbMonth.SelectedItem = month;
        }
        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonth.Text != "")
            {
                cbbDay.Text = "";
                int year = Convert.ToInt16(cbbYear.SelectedText);
                int month = Convert.ToInt16(cbbMonth.SelectedText);
                loadBillYearMonth(year, month);
                int day = 0;
                cbbDay.Properties.Items.Clear();
                if (year + "" == DateTime.Now.Year.ToString() && month + "" == DateTime.Now.Month.ToString())
                {
                    day = Convert.ToInt16(DateTime.Now.Day.ToString());
                }
                else
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        day = 31;
                    }
                    else if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        day = 30;
                    }
                    else
                    {
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))    // nam nhuan
                            day = 29;
                        else
                            day = 28;
                    }
                }
                for (int i = day; i >= 1; i--)
                {
                    cbbDay.Properties.Items.Add(i.ToString());
                }
            }
        }
        private void loadBillYearMonthDay(int year,int month,int day)
        {
            DataTable dtBill = busBill.getBillYearMonthDay(year, month,day);
            gcvBill.DataSource = dtBill;
            cbbYear.SelectedItem = year;
            cbbMonth.SelectedItem = month;
            cbbDay.SelectedItem = day;
        }
        private void cbbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDay.Text != "")
            {
                int year = Convert.ToInt16(cbbYear.SelectedText);
                int month = Convert.ToInt16(cbbMonth.SelectedText);
                int day = Convert.ToInt16(cbbDay.SelectedText);
                loadBillYearMonthDay(year, month, day);
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