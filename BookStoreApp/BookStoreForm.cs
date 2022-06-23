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
    public partial class BookStoreForm : Form
    {
        public BookStoreForm()
        {
            InitializeComponent();
        }

        ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
        static UCOrder uCOrder = new UCOrder();
       

        private void BookStoreForm_Load(object sender, EventArgs e)
        {
            Logger.log("Load to BookStore");
            Data data = SingletonData.GetData();
            LoginedUser loginedUser = LoginedUser.getInstance();
            UCProfile profile = new UCProfile(loginedUser);

           
            containsPanel.Controls.Add(Util.FillDashboardScreen());
            containsPanel.Controls.Add(Util.FillUC_BooksList(data.getBooks()));
            containsPanel.Controls.Add(Util.FillUCMagazinList(data.getMagazines()));
            containsPanel.Controls.Add(Util.FillUCMusicsList(data.getMusics()));
            containsPanel.Controls.Add(uCOrder);
            containsPanel.Controls.Add(profile);
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            Logger.log("Click to BooksButton");
            containsPanel.Controls["UCBooks"].BringToFront();
        }

        private void magazineButton_Click(object sender, EventArgs e)
        {
            Logger.log("Click to MagazineButton");
            containsPanel.Controls["UCMagazines"].BringToFront();
        }

        private void musicsButton_Click(object sender, EventArgs e)
        {
            Logger.log("Click to MusicButton");
            containsPanel.Controls["UCMusics"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Setting");
            containsPanel.Controls["UCProfile"].BringToFront();
        }

        public static void cartButton(object sender, EventArgs e)
        {
            Logger.log("Load to Cart");
            if (containsPanel.Controls["UCShoppingCart"] == null)
            {
                containsPanel.Controls.Add(Util.FillUCShoppingCard());
            }
            else
            {
                containsPanel.Controls.RemoveByKey("UCShoppingCart");
                containsPanel.Controls.Add(Util.FillUCShoppingCard());
            }
            containsPanel.Controls["UCShoppingCart"].BringToFront();
        }

        internal void cartButton()
        {
            throw new NotImplementedException();
        }

        private void dashBoardButton_Click(object sender, EventArgs e)
        {
            Logger.log("Click to DashBoard");
            containsPanel.Controls["UCDashBoard"].BringToFront();
        }

        public static void ordersButton_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Orders");
            Data data = SingletonData.GetData();
            data.OrdersList();
            if (containsPanel.Controls["UCOrder"] == null)
            {
                containsPanel.Controls.Add(uCOrder);
            }
            else
            {
                containsPanel.Controls.RemoveByKey("UCOrder");
                containsPanel.Controls.Add(uCOrder);
            }
            containsPanel.Controls["UCOrder"].BringToFront();
        }

        private void logOutButton(object sender, EventArgs e)
        {
            Logger.log("Click to logOut");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
