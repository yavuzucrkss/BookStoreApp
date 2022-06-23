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
    public partial class UCMusic : UserControl
    {

        ItemtoPurchase item;
        public UCMusic(MusicCD musicCD)
        {
            InitializeComponent();
            item = new ItemtoPurchase(musicCD, 1);
            idbookLbl.Text = musicCD.Id;
            namebookLbl.Text = musicCD.Name;
            pricebookLbl.Text = musicCD.Price + " TL";
            singerLbl.Text = musicCD.Singer;
            descriptionTextBox.Text = musicCD.Description;
            typeLbl.Text = musicCD.Type;
            pictureBox1.Image = Util.stringToImage(musicCD.Image);
            descriptionTextBox.ReadOnly = true;
        }

        private void addtocardButton_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
            shoppingCart.AddCartItem(item);
            MessageBox.Show("Product Added to Cart");
        }
    }
}
