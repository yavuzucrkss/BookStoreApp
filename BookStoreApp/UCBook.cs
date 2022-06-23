using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class UCBook : UserControl 
    {

        ItemtoPurchase item;

        public UCBook(Book book)
        {
            InitializeComponent();
            item = new ItemtoPurchase(book,1);
            idbookLbl.Text = book.Id;
            namebookLbl.Text = book.Name;
            authorbookLbl.Text = book.Author;
            ısbnbookLbl.Text = book.Isdb;
            publisherbookLbl.Text = book.Publisher;
            pricebookLbl.Text = book.Price + " TL";
            pictureBox1.Image = Util.stringToImage(book.Image);
            descriptionTextBox.Text = book.Description;
            pagenumberbookLbl.Text = book.Page;
            descriptionTextBox.ReadOnly = true;

        }

      
        private void addtocardButton_Click(object sender, EventArgs e)
        {
           
            ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
            shoppingCart.AddCartItem(item);
            MessageBox.Show("Product Added");
        }

       
    }
}
