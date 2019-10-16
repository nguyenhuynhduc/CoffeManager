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
    public partial class frmOder : DevExpress.XtraEditors.XtraForm
    {
       public string id{get;set;}
       public string name { get; set; }
       BUS.BUS_Oder busOder;
       BUS.BUS_Product busProduct;
       BUS.BUS_Bill busBill;
       BUS.BUS_DetailBill busDetailBill;
       int index;
        public frmOder()
        {
            InitializeComponent();
            busOder = new BUS.BUS_Oder();

            busProduct = new BUS.BUS_Product();

            busBill = new BUS.BUS_Bill();
            busDetailBill = new BUS.BUS_DetailBill();
        }

        public void loadOder(string status)
        {
           
            //load gridview
            int total = 0;
            DTO.DTO_Oder oder = new DTO.DTO_Oder();
           
            oder.idTable = Convert.ToInt16(id);
            DataTable dt = busOder.getAllOder(oder);

            dt.Columns.Add("cost", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int price = Convert.ToInt16(dt.Rows[i]["price"].ToString());
                int amount = Convert.ToInt16(dt.Rows[i]["amount"].ToString());
                int cost = price * amount;
                dt.Rows[i]["cost"] = cost + "";
                total += cost;
            }

            gcvOder.DataSource = dt;
            lblTotal.Text = total.ToString();

            //load compobox
            DTO.DTO_Product dtoProduct = new DTO.DTO_Product();

            DataTable dtProduct = busProduct.getAllProduct();

           
            cbbProduct.ValueMember = "idProduct";
            cbbProduct.DisplayMember = "nameProduct";
            cbbProduct.DataSource = dtProduct;
              
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            loadOder("");
        }

        private void frmProduct_Load_1(object sender, EventArgs e)
        {
            label1.Text = "TABLE " + name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        public void changeCompoBox()
        {
            int idProduct = Convert.ToInt16(cbbProduct.SelectedValue.ToString());
        }
        private void cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCompoBox();
        }
        public void loadCompoBox()
        {
            if (txtAmount.Text == "")
                txtAmount.Text = "1";

            int idProduct = Convert.ToInt16(cbbProduct.SelectedValue.ToString());
            DTO.DTO_Product dtoProduct = new DTO.DTO_Product();
            dtoProduct.idProduct = idProduct;
            DataTable dtProduct = busProduct.getProduct(dtoProduct);
            int price = Convert.ToInt16(dtProduct.Rows[0]["price"]);
            int cost = price * Convert.ToInt16(txtAmount.Text);
            lblPrice.Text = cost.ToString();

            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
           
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            loadCompoBox();
        }

        

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = gridView1.GetRowCellValue(index, "idOrder").ToString();
            DTO.DTO_Oder dtoOder = new DTO.DTO_Oder();
            dtoOder.idOrder = Convert.ToInt16(id);


            int idProduct = Convert.ToInt16(cbbProduct.SelectedValue.ToString());
            DTO.DTO_Product dto_product = new DTO.DTO_Product();
            dto_product.idProduct = idProduct;
            DataTable dtProduct = busProduct.getProduct(dto_product);
            int amountProductCheck = Convert.ToInt16(dtProduct.Rows[0]["amount"]);
            int amount = Convert.ToInt16(txtAmount.Text);

            if (busOder.deleteOder(dtoOder))
            {
                int amountProductUpdate = amountProductCheck + amount;
                DTO.DTO_Product dtoProducUpdate = new DTO.DTO_Product();
                dtoProducUpdate.idProduct = idProduct;
                dtoProducUpdate.nameProduct = dtProduct.Rows[0]["nameProduct"].ToString();
                dtoProducUpdate.price = Convert.ToInt16(dtProduct.Rows[0]["price"]);
                dtoProducUpdate.amount = amountProductUpdate;
                busProduct.updateProduct(dtoProducUpdate);

                MessageBox.Show("DELETE Oder success!!!");
                loadOder("");
            }
            else
            {
                MessageBox.Show("ERROR!!!");
            }
        }
        

       
        private void loadDataFromGridView()
        {
            if (index >= 0) {

                cbbProduct.SelectedValue = gridView1.GetRowCellValue(index, "idProduct").ToString();

                txtIdOder.Text = gridView1.GetRowCellValue(index, "idOrder").ToString();

                txtAmount.Text = gridView1.GetRowCellValue(index, "amount").ToString();

                DTO.DTO_Product dtoProduct = new DTO.DTO_Product();
                dtoProduct.idProduct = Convert.ToInt16(gridView1.GetRowCellValue(index, "idProduct").ToString());
                DataTable dtProduct = busProduct.getProduct(dtoProduct);
                int price = Convert.ToInt16(dtProduct.Rows[0]["price"]);
                int cost = price * Convert.ToInt16(txtAmount.Text);
                lblPrice.Text = cost.ToString();
               
            }
           
        }
       
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
            loadDataFromGridView();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt16(cbbProduct.SelectedValue.ToString());
                DTO.DTO_Product dto_product = new DTO.DTO_Product();
                dto_product.idProduct=idProduct;
                DataTable dtProduct= busProduct.getProduct(dto_product);
                int amountProductCheck=Convert.ToInt16(dtProduct.Rows[0]["amount"]);
            int amount = Convert.ToInt16(txtAmount.Text);
            if (amountProductCheck >= amount)
            {
           
                DTO.DTO_Oder dtoOder = new DTO.DTO_Oder();
                dtoOder.idProduct = idProduct;
                dtoOder.idTable = Convert.ToInt16(id);
              
                DataTable dt = busOder.getAllProductOder(dtoOder);

                if (dt.Rows.Count > 0)
                {
                    int amountProduct = Convert.ToInt16(dt.Rows[0]["amount"]);

                    dtoOder.idOrder = Convert.ToInt16(dt.Rows[0]["idOrder"]);
                    dtoOder.amount = amount+amountProduct;

                    if (busOder.updateOder(dtoOder))
                    {
                       int amountProductUpdate=amountProductCheck- amount;
                        DTO.DTO_Product dtoProducUpdate = new DTO.DTO_Product();
                        dtoProducUpdate.idProduct = idProduct;
                        dtoProducUpdate.nameProduct = dtProduct.Rows[0]["nameProduct"].ToString();
                        dtoProducUpdate.price = Convert.ToInt16( dtProduct.Rows[0]["price"]);
                        dtoProducUpdate.amount = amountProductUpdate;
                        busProduct.updateProduct(dtoProducUpdate);

                        MessageBox.Show("Insert Oder success!!!");
                        loadOder("add");
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!!");
                    }
                }
                else
                {
                    dtoOder.amount = amount;
                    if (busOder.insertOder(dtoOder))
                    {
                        int amountProductUpdate = amountProductCheck - amount;
                        DTO.DTO_Product dtoProducUpdate = new DTO.DTO_Product();
                        dtoProducUpdate.idProduct = idProduct;
                        dtoProducUpdate.nameProduct = dtProduct.Rows[0]["nameProduct"].ToString();
                        dtoProducUpdate.price = Convert.ToInt16(dtProduct.Rows[0]["price"]);
                        dtoProducUpdate.amount = amountProductUpdate;
                        busProduct.updateProduct(dtoProducUpdate);

                        MessageBox.Show("Insert Oder success!!!");
                        loadOder("add");
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!!");
                    }
                }
            
            }
            else{
                MessageBox.Show("Amount not Enough!!!!");
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (Convert.ToInt16(txtAmount.Text) - 1).ToString();
            loadCompoBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (Convert.ToInt16(txtAmount.Text) + 1).ToString();
            loadCompoBox();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DTO.DTO_Oder dto_oder = new DTO.DTO_Oder();
            dto_oder.idTable = Convert.ToInt16(id);

            DTO.DTO_Bill dto_bill = new DTO.DTO_Bill();
            dto_bill.cost = Convert.ToInt32(lblTotal.Text);


            string format = "yyyy-MM-dd HH:mm:ss";
             string dateNow= DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            dto_bill.dateTime = Convert.ToDateTime(dateNow);

            
            if (busBill.insertBill(dto_bill))
            {
                MessageBox.Show("Insert Bill Sucess!!!");
                
                DataTable dtBill = busBill.getLastBill();
                int idLastBill = Convert.ToInt16(dtBill.Rows[0]["idBill"]);

                DataTable dtOder = busOder.getAllOder(dto_oder);
                for (int i = 0; i < dtOder.Rows.Count; i++)
                {
                    DTO.DTO_DetailBill dto_detailBill = new DTO.DTO_DetailBill();
                    dto_detailBill.idBill=idLastBill;
                    dto_detailBill.idProduct=Convert.ToInt16(dtOder.Rows[i]["idProduct"]);
                    dto_detailBill.amount= Convert.ToInt16(dtOder.Rows[i]["amount"]);
                    busDetailBill.insertDetailBill(dto_detailBill);

                    DTO.DTO_Oder dto_deleteOder = new DTO.DTO_Oder();
                    dto_deleteOder.idOrder = Convert.ToInt16(dtOder.Rows[i]["idOrder"]);
                    busOder.deleteOder(dto_deleteOder);
                }
                loadOder("");
            }
            else {
                MessageBox.Show("ERROR!!!");
            }

          

        }
      
    }
}