using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LeanDevExpress
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        BUS.BUS_User busUser;
        public frmLogin()
        {
            InitializeComponent();
            busUser = new BUS.BUS_User();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }
        private void login()
        {
            DTO.DTO_User user = new DTO.DTO_User();
            user.username = txtUserName.Text;
            user.password = txtPassword.Text;
            if (busUser.getLogin(user) == 1)
            {
               MessageBox.Show("Login Success","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);

               GUI.frmHome main = new GUI.frmHome();
                  main.FormClosed += new FormClosedEventHandler(dongform);
                  this.Hide();
                  main.Show();
            }
            else if (busUser.getLogin(user) == 2)
            {
                MessageBox.Show("Login Is not Ok!");
            }
            else
            {
                MessageBox.Show("Connect ERROR!");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            login();
        }

        

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
        private void dongform(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
       

        
    }
}