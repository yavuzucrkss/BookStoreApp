using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class Customer
    {
        private string id;
        private string namesurname;
        private string username;
        private string password;
        private string email;
        private string address;

        public Customer(string namesurname, string username, string password, string email, string address)
        {
            
            this.namesurname = namesurname;
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
        }

        public Customer(string id, string namesurname, string username, string password, string email, string address)
        {
            this.id = id;
            this.namesurname = namesurname;
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Namesurname { get => namesurname; set => namesurname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
       

        public string printCustomerInfo()
        {
            string info = "Id:" + this.id + " " +
                          "Name & Surname: " + this.namesurname + " " +
                          "Username: " + this.username + " " +
                          "Password: " + this.password + " " +
                          "Email: " + this.email + " " +
                          "Address: " + this.address + " \n";
            return info;
        }

        public bool isValid(string usname, string pass)
        {
            return this.username.Equals(username) && this.password.Equals(pass);
        }
    }
}
