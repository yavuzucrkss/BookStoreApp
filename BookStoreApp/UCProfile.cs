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
    public partial class UCProfile : UserControl
    {
        Data data = SingletonData.GetData();
        LoginedUser user = LoginedUser.getInstance();
        public UCProfile(LoginedUser user)
        {
            InitializeComponent();
            //this.Dock = DockStyle.Fill;
            this.idLbl.Text = user.Customer.Id;
            this.usernameLbl.Text = user.Customer.Username;
            this.NameTextBox.Text = user.Customer.Namesurname;
            this.EmailTextBox.Text = user.Customer.Email;
            this.AdressTextBox.Text = user.Customer.Address;
          
        }

        private void updateInfoButton(object sender, EventArgs e)
        {

            if(NameTextBox.Text == "" || EmailTextBox.Text == "" || AdressTextBox.Text == "")
            {
                MessageBox.Show("Please do not leave information blank.");
            }
            else
            {
            user.Customer.Namesurname = NameTextBox.Text;
            user.Customer.Email = EmailTextBox.Text;
            user.Customer.Address = AdressTextBox.Text;
            data.UpdateCustomerList(user.Customer);
            }
        }

        private void changePasswordButton(object sender, EventArgs e)
        {
            try
            {
                if (passTextBox.Text == replypassTextBox.Text)
                {
                    if (passTextBox.Text != "")
                    {
                        data.UpdateCustomerPass(idLbl.Text, passTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter password");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not same!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
