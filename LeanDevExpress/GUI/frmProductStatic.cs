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
    public partial class frmProductStatic : DevExpress.XtraEditors.XtraForm
    {
        BUS.BUS_DetailBill bus_detailBill;
        public frmProductStatic()
        {
            InitializeComponent();
            bus_detailBill = new BUS.BUS_DetailBill();
        }


        private void loadAll()
        {
            DataTable dt_allDetailBill = bus_detailBill.getDetailBill();
            loadSort(dt_allDetailBill);
        }
        private void loadSort(DataTable dt_allDetailBill)
        {
          
            DataTable dt_load = new DataTable();

            if (dt_allDetailBill.Rows.Count > 0)
            {
               
                dt_load.Columns.Add("nameProduct", typeof(string));
                dt_load.Columns.Add("amount", typeof(string));
                dt_load.Columns.Add("dateTime", typeof(string));
                dt_load.Columns.Add("idProduct", typeof(string));

                dt_load.Rows.Add();
                dt_load.Rows[0]["nameProduct"] = dt_allDetailBill.Rows[0]["nameProduct"];
                dt_load.Rows[0]["amount"] = dt_allDetailBill.Rows[0]["amount"];
                dt_load.Rows[0]["dateTime"] = dt_allDetailBill.Rows[0]["dateTime"];
                dt_load.Rows[0]["idProduct"] = dt_allDetailBill.Rows[0]["idProduct"];

                for (int i = 1; i < dt_allDetailBill.Rows.Count; i++)
                {
                    int check = 0;
                    for (int j = 0; j < dt_load.Rows.Count; j++)
                    {
                        string idProductDetailBill = dt_allDetailBill.Rows[i]["idProduct"].ToString();
                        string idProductLoad = dt_load.Rows[j]["idProduct"].ToString();
                        if (idProductDetailBill == idProductLoad)
                        {
                            int amountProduct = Convert.ToInt16(dt_allDetailBill.Rows[i]["amount"]) + Convert.ToInt16(dt_load.Rows[j]["amount"]);
                            dt_load.Rows[j]["amount"] = amountProduct;
                            check = 1;
                            break;
                        }

                    }

                    if (check != 1)
                    {
                        DataRow _ravi = dt_load.NewRow();
                        _ravi["nameProduct"] = dt_allDetailBill.Rows[i]["nameProduct"];
                        _ravi["amount"] = dt_allDetailBill.Rows[i]["amount"];
                        _ravi["dateTime"] = dt_allDetailBill.Rows[i]["dateTime"];
                        _ravi["idProduct"] = dt_allDetailBill.Rows[i]["idProduct"];
                        dt_load.Rows.Add(_ravi);
                    }

                }
               
            }
            gcvBill.DataSource = dt_load;
        }

        private void loadSortYear()
        {
            
        }
        void loadYear()
        {
            string yearNow = DateTime.Now.Year.ToString();

            for (int i = Convert.ToInt16(yearNow); i >= 2015; i--)
            {
                cbbYear.Properties.Items.Add(i.ToString());
            }
        }
        private void frmProductStatic_Load(object sender, EventArgs e)
        {
            loadAll();
            loadYear();     
        }
        private void loadSortYear(int year)
        {
            DataTable dt_allDetailBill = bus_detailBill.getDetailBillYear(year);
            loadSort(dt_allDetailBill);
        }
        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMonth.Text = "";
            cbbDay.Text = "";

            int year = Convert.ToInt16(cbbYear.SelectedText);
            loadSortYear(year);

            string monthNow = DateTime.Now.Month.ToString();
            int month = 0;

            cbbMonth.Properties.Items.Clear();
            cbbDay.Properties.Items.Clear();
            if (year + "" == DateTime.Now.Year.ToString())
            {
                month = Convert.ToInt16(monthNow);
            }
            else
            {
                month = 12;
            }
            for (int i = month; i >= 1; i--)
            {
                cbbMonth.Properties.Items.Add(i.ToString());
            }    
        }

        private void loadSortYearMonth(int year,int month)
        {
            DataTable dt_allDetailBill = bus_detailBill.getDetailBillYearMonth(year,month);
            loadSort(dt_allDetailBill);


        }


        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonth.Text != "")
            {
                cbbDay.Text = "";
                int year = Convert.ToInt16(cbbYear.SelectedText);
                int month = Convert.ToInt16(cbbMonth.SelectedText);
                loadSortYearMonth(year, month);
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
        private void loadSortYearMonthDay(int year, int month,int day)
        {
            DataTable dt_allDetailBill = bus_detailBill.getDetailBillYearMonthDay(year, month,day);
            loadSort(dt_allDetailBill);
        }

        private void cbbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDay.Text != "")
            {
                int year = Convert.ToInt16(cbbYear.SelectedText);
                int month = Convert.ToInt16(cbbMonth.SelectedText);
                int day = Convert.ToInt16(cbbDay.SelectedText);
                loadSortYearMonthDay(year, month, day);
            }
        }

        private void Year_Click(object sender, EventArgs e)
        {

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