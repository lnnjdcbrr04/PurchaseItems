using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurchaseItems;

namespace PurchaseItems
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);

            txtTotalAmount.Text =
                item.getTotalPrice().ToString("0.00");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);
            double payment = Convert.ToDouble(txtPayment.Text);

            DiscountedItem item = new DiscountedItem(
                itemName,
                price,
                quantity,
                discount
            );

            item.getTotalPrice();
            item.setPayment(payment);
            txtChange.Text =
                item.getChange().ToString("0.00");

        }
    }
}
