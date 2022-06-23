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
    public partial class UCItemofCart : UserControl 
    {

        ItemtoPurchase item;
        ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
        public UCItemofCart(ItemtoPurchase _item)
        {
            InitializeComponent();
            item = _item;
            idbookLbl.Text = _item.Product.Id;
            namebookLbl.Text = _item.Product.Name;
            priceLbl.Text = _item.Product.Price + " TL";
            pictureBox1.Image = Util.stringToImage(_item.Product.Image);
            quantityLbl.Text = _item.Quantity.ToString();
            itemamountLbl.Text = _item.calcuAmount().ToString() + " TL";
            
        }

        private void addQuantity(object sender, EventArgs e)
        {
          
            item.Quantity += 1;
            quantityLbl.Text = item.Quantity.ToString();
            itemamountLbl.Text = item.calcuAmount().ToString();
            
            Util.FillUCShoppingCard();
            BookStoreForm.cartButton(sender, e);
        }

        private void substrctQantity(object sender, EventArgs e)
        {
            if(item.Quantity == 0)
            {
                MessageBox.Show("Quantity cannot be negative");
            }
            else
            {
                item.Quantity -= 1;
                quantityLbl.Text = item.Quantity.ToString();
                itemamountLbl.Text = item.calcuAmount().ToString();
                Util.FillUCShoppingCard();
                BookStoreForm.cartButton(sender, e);
            }
           
          
        }

        private void removeFromCard(object sender, EventArgs e)
        {

            shoppingCart.RemoveFromCart(item);
            Util.FillUCShoppingCard();
            BookStoreForm.cartButton(sender, e);



        }
    }
}
