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
    public partial class UCMagazine : UserControl
    {
        ItemtoPurchase item;
        public UCMagazine(Magazine magazine)
        {

            InitializeComponent();
            item = new ItemtoPurchase(magazine, 1);
            idbookLbl.Text = magazine.Id;
            namebookLbl.Text = magazine.Name;
            pricebookLbl.Text = magazine.Price + " TL";
            typeLbl.Text = magazine.Type;
            issueLbl.Text = magazine.Issue;
            descriptionTextBox.Text = magazine.Description;
            pictureBox1.Image = Util.stringToImage(magazine.Image);
            descriptionTextBox.ReadOnly = true;

        }

        private void addtocardButton_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
            shoppingCart.AddCartItem(item);
            MessageBox.Show("Product Added to Cart");
            
        }

        private void UCMagazine_Load(object sender, EventArgs e)
        {

        }
    }
}
