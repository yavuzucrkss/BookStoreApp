using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
            InitializeComponent();
            amountLabel.Text = shoppingCart.TotalAmount.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
                Data data = SingletonData.GetData();
                DateTime dateTime = DateTime.Now;
                if (creditCardTextBox.MaskFull == false || maskedTextBox2.MaskFull == false || maskedTextBox3.MaskFull == false)
                {
                    MessageBox.Show("Please fill in the fields");
                }
                else
                {
                    string products = " ";
                    string username = LoginedUser.getInstance().Customer.Username;
                    string amount = shoppingCart.TotalAmount.ToString() + "TL";
                    string date = dateTime.ToString();

                    foreach (ItemtoPurchase item in shoppingCart.ItemsList)
                    {
                        products += item.Product.Name + " ---> Product Unit Price: " + item.Product.Price + " TL --> Quantity: " + item.Quantity.ToString() + " \n";
                    }

                    Order order = new Order(username, date, amount, products);
                    data.AddOrder(order);
                    data.OrdersList();
                    shoppingCart.ClearShoppingCard();
                    BookStoreForm.cartButton(sender, e);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           
           

            
        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
