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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        Data sqlQueries = SingletonData.GetData();
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != repeatpassTextBox.Text && passwordTextBox != null)
            {
                MessageBox.Show("Passwords aren't same.");
            }
            else
            {
                Customer customer = new Customer(namesurnameTextBox.Text,usernameTxtBox.Text,passwordTextBox.Text,emailTextBox.Text,addressTextBox.Text);
                
                sqlQueries.AddCustomerQuery(customer);
              
            }
               
           
        }
    }   
}

