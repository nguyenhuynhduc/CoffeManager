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
    public partial class frmDetailBill : DevExpress.XtraEditors.XtraForm
    {
        BUS.BUS_DetailBill detailBill;
        public string idBill1 { get; set; }
        public frmDetailBill()
        {
            InitializeComponent();
            detailBill = new BUS.BUS_DetailBill();
        }
        public void loadDeltailBill()
        {
            DTO.DTO_DetailBill dto_detailBill = new DTO.DTO_DetailBill();
            dto_detailBill.idBill = Convert.ToInt16(idBill1);
            DataTable dt = detailBill.getAllDetailBill(dto_detailBill);

            dt.Columns.Add("total", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int price = Convert.ToInt16(dt.Rows[i]["price"].ToString());
                int amount = Convert.ToInt16(dt.Rows[i]["amount"].ToString());
                int total = price * amount;
                dt.Rows[i]["total"] = total + "";
            }
            label1.Text = "Bill: " + idBill1;
            gcvDetailBill.DataSource = dt;

        }
        private void frmDetailBill_Load(object sender, EventArgs e)
        {
            loadDeltailBill();
        }
    }
}