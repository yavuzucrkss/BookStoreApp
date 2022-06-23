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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:yavuzucrks.database.windows.net,1433;Initial Catalog=BookStore;Persist Security Info=False;User ID=yavuzucrkss;Password=oop2_bookstore;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string name = nametxt.Text;
            string price = pricetxt.Text;
            string author = authortxt.Text;
            string publisher = publishertext.Text;
            string page = pagetxt.Text;
            string isdb = isdbtxt.Text;
            string detail = richTextBox1.Text;
            byte[] image = Util.imageToByteArray(pictureBox1.Image);
            try
            {
                
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into BooksTable (BookName,BookPrice,BookImage,BookAuthor,BookPublisher,BookIsdb,BookPageNumber,BookDescription) " +
                    "values (@name,@price,@image,@author,@publisher,@ısbn,@page,@description)", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@ısbn", isdb);
                cmd.Parameters.AddWithValue("@page", page);
                cmd.Parameters.AddWithValue("@description", detail);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Book added.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=tcp:yavuzucrks.database.windows.net,1433;Initial Catalog=BookStore;Persist Security Info=False;User ID=yavuzucrkss;Password=oop2_bookstore;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            byte[] img = Util.imageToByteArray(pictureBox2.Image);
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into MagazinesTable (MagazineName, MagazinePrice,MagazineImage,MagazineType,MagazineIssue,MagazineDetail) " +
                    "values (@name,@price,@image,@type,@issue,@detail)", connection);
                cmd.Parameters.AddWithValue("@name", mnameTxt.Text);
                cmd.Parameters.AddWithValue("@price", mpriceTxt.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.Parameters.AddWithValue("@type", mtypeTxtBox.Text);
                cmd.Parameters.AddWithValue("@issue", issueTxtBox.Text);
                cmd.Parameters.AddWithValue("@detail", richTextBox2.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Magazine added.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:yavuzucrks.database.windows.net,1433;Initial Catalog=BookStore;Persist Security Info=False;User ID=yavuzucrkss;Password=oop2_bookstore;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            byte[] img = Util.imageToByteArray(pictureBox3.Image);
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into MusicsTable (MusicName, MusicPrice,MusicImage,MusicSinger,MusicType,MusicDetail) " +
                    "values (@name,@price,@image,@singer,@type,@detail)", connection);
                cmd.Parameters.AddWithValue("@name", musicnameTextBox.Text);
                cmd.Parameters.AddWithValue("@price", musicproceTextBox.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.Parameters.AddWithValue("@singer", MusicsingerTxtBox.Text);
                cmd.Parameters.AddWithValue("@type", MusicTypeTextBox.Text);
                cmd.Parameters.AddWithValue("@detail", richTextBox3.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Music added.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
