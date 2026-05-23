using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseItems
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show(
                    "Successfully Login",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                frmPurchaseDiscountedItem purchaseForm =
                    new frmPurchaseDiscountedItem();

                purchaseForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}