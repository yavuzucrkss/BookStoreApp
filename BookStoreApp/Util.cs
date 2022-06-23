using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    class Util
    {

     

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Bitmap stringToImage(byte[] inputString)
        {
            byte[] imageBytes = inputString;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }

        public static UCDashBoard FillDashboardScreen()
        {
            List<List<Product>> productList = new List<List<Product>>();
            productList.Add(Util.FillBooksList());
            productList.Add(Util.FillMusicList());
            productList.Add(Util.FillMagazineList());

            UCDashBoard ucD = new UCDashBoard();
            ProductSeperator UCPF = new ProductSeperator();
            
            for (int i = 0; i < 6; i++)
            {
                   
                ucD.flowLayoutPanel1.Controls.Add(UCPF.CreateUC_Product
                    (productList[0][i]));
                ucD.flowLayoutPanel1.Controls.Add(UCPF.CreateUC_Product
                    (productList[1][i]));
                ucD.flowLayoutPanel1.Controls.Add(UCPF.CreateUC_Product
                    (productList[2][i]));

            }
            ucD.Dock = DockStyle.Fill;
            return ucD;
        }

        public static void FillflowlayoutBooks(FlowLayoutPanel panel, List<Product> BookList) //
        {
            panel.Controls.Clear();
            foreach (Book _book in BookList)
            {
                panel.Controls.Add(new UCBook(_book));

            }
            panel.Dock = DockStyle.Fill;

        }

        public static UCBooks FillUC_BooksList(List<Product> BookList)
        {
            UCBooks ucB = new UCBooks();
            foreach (Book _book in BookList)
            {
                ucB.flowLayoutBooks.Controls.Add(new UCBook(_book));
            }
            ucB.Dock = DockStyle.Fill;
            return ucB;
        }

        public static List<Product> FillBooksList()
        {
            Data data = SingletonData.GetData();
            data.BookList();
            return data.getBooks();
        }

        public static List<Product> FillMagazineList()
        {
            Data data = SingletonData.GetData();
            data.MagazinList();
            return data.getMagazines();
        }

        public static UCMagazines FillUCMagazinList(List<Product> magazineList)
        {
            UCMagazines magazines = new UCMagazines();
            foreach (Magazine item in magazineList)
            {
                magazines.flowLayoutPanel1.Controls.Add(new UCMagazine(item));
            }
            magazines.Dock = DockStyle.Fill;
            return magazines;
        }

        public static List<Product> FillMusicList()
        {
            Data data = SingletonData.GetData();
            data.MusicList();
            return data.getMusics();
        }

        public static UCMusics FillUCMusicsList(List<Product> musicList)
        {
            UCMusics musics = new UCMusics();
            foreach (MusicCD item in musicList)
            {
                musics.flowLayoutPanel1.Controls.Add(new UCMusic(item));
            }
            musics.Dock = DockStyle.Fill;
            return musics;
        }

        public static UCShoppingCart FillUCShoppingCard()
        {
            UCShoppingCart uCShopping = new UCShoppingCart();
            ShoppingCart shoppingCart = SingletonShoppingCart.GetShoppingCard();
            foreach (ItemtoPurchase item in shoppingCart.ItemsList)
            {
                uCShopping.flowLayoutPanel1.Controls.Add(new UCItemofCart(item));

            }
            shoppingCart.UpdatetotalAmount();
            uCShopping.amountLabel.Text = shoppingCart.TotalAmount.ToString() + " TL";
            uCShopping.Dock = DockStyle.Fill;
            return uCShopping;
        }


    }
}
