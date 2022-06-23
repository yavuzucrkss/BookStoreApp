using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class UCShoppingCart : UserControl
    {
        ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
        public static bool confirmation = false;
        public UCShoppingCart()
        {

            InitializeComponent();
            amountLabel.Text = shoppingCart.TotalAmount.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(shoppingCart.TotalAmount == 0)
            {
                MessageBox.Show("Your Cart is Empty");
            }
            else
            {
            PaymentForm fr = new PaymentForm();
            fr.Show();
            }
        }
    }
}
