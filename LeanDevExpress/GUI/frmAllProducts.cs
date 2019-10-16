using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace LeanDevExpress.GUI
{
    public partial class frmAllProducts : DevExpress.XtraEditors.XtraForm
    {
        BUS.BUS_Product busProduct;


        
        public frmAllProducts()
        {
            InitializeComponent();
            busProduct = new BUS.BUS_Product();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void loadProduct()
        {
            DataTable dt = busProduct.getAllProduct();
            gcvProduct.DataSource = dt;
        }
        private void frmAllProducts_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtnameProduct.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtAmount.ReadOnly = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddAmount.Enabled = true;
            lbAddAmount.Visible = false;
            txtAddAmount.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            txtnameProduct.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtAmount.ReadOnly = false;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            txtId.Text = "";
            txtnameProduct.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
            btnAddProduct.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddAmount.Enabled = false;
            lblStatus.Text = "add";
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            txtnameProduct.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtAmount.ReadOnly = true;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddProduct.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddAmount.Enabled = false;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DTO.DTO_Product product = new DTO.DTO_Product();
            product.idProduct= Convert.ToInt32(txtId.Text);

            if (busProduct.deleteProduct(product))
            {
                MessageBox.Show("DELETE success!!!");
            }
            else {
                MessageBox.Show("ERROR!!!");
            }
            loadProduct();
            loadDataFromGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtnameProduct.Text == "")
            {
                MessageBox.Show("Inpunt Product Name Value!!!");

            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Inpunt Price Value!!!");

            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Inpunt Amount Value!!!");
            }
            else {
                        DTO.DTO_Product product = new DTO.DTO_Product();
                        product.price = Convert.ToInt32(txtPrice.Text);
                        product.amount = Convert.ToInt32(txtAmount.Text);
                        product.nameProduct = txtnameProduct.Text;
                        if (txtId.Text != ""&& txtAddAmount.Text=="")
                        {
                            int id = Convert.ToInt32(txtId.Text);
                            product.idProduct = id;
                            if (busProduct.updateProduct(product))
                            {
                                MessageBox.Show("UPDATE SUCCESS!");
                                loadProduct();
                                loadDataFromGridView();
                                cancel();
                            }
                            else
                            {
                                MessageBox.Show("ERROR!");
                            }
                        }
                        else if(txtAddAmount.Text!="")
                        {
                            int id = Convert.ToInt32(txtId.Text);
                            product.idProduct = id;
                            product.amount = Convert.ToInt32(txtAmount.Text)+Convert.ToInt32(txtAddAmount.Text);
                            if (busProduct.updateProduct(product))
                            {
                                MessageBox.Show("Add AMOUNT SUCCESS!");
                                loadProduct();
                                loadDataFromGridView();
                                cancel();
                            }
                            else
                            {
                                MessageBox.Show("ERROR!");
                            }
                        }
                        else
                        {
                            if (busProduct.insertProduct(product))
                            {
                                MessageBox.Show("INSERT SUCCESS!");
                                loadProduct();
                                loadDataFromGridView();
                               
                            }
                            else
                            {
                                MessageBox.Show("ERROR!");
                            }
                        }
            }
            
           
        }


        private void cancel()
        {
            txtnameProduct.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtAmount.ReadOnly = true;
            btnEditProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnAddProduct.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtAmount.ReadOnly = true;
            txtnameProduct.ReadOnly = true;
            txtPrice.ReadOnly = true;
            btnAddAmount.Enabled = true;
            lbAddAmount.Visible = false;
            txtAddAmount.Visible = false;
            txtAddAmount.Text = "";
            lblStatus.Text = "";

            loadDataFromGridView();
            loadDataFromGridView();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel();
        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void gcvAllProduct_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            loadProduct();
        }
        private void loadDataFromGridView()
        {
            if (lblStatus.Text == "")
            {
                txtId.Text = gridView1.GetRowCellValue(index, "idProduct").ToString();
                txtnameProduct.Text = gridView1.GetRowCellValue(index, "nameProduct").ToString();
                txtPrice.Text = gridView1.GetRowCellValue(index, "price").ToString();
                txtAmount.Text = gridView1.GetRowCellValue(index, "amount").ToString();
            }
            

        }
        int index;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
            loadDataFromGridView();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtnameProduct.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtAmount.ReadOnly = true;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddProduct.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddAmount.Enabled = false;
            lbAddAmount.Visible = true;
            txtAddAmount.Visible = true;
        }

        
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txtAddAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
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