using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookStoreApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm fr = new SignUpForm();
            fr.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try  
            {
                Data data = SingletonData.GetData();
                data.CustomerList();
                foreach (Customer item in data.GetCustomers())
                {
                    if (item.isValid(usernameTxtBox.Text, passwordTextBox.Text))
                    {
                        LoginedUser.getInstance().Customer = item;
                        BookStoreForm storeForm = new BookStoreForm();
                        storeForm.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Invalid username or password!");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
          

        }
    }
}
