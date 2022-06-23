using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    class Order
    {
        private string id;
        private string username;
        private string date;
        private string amount;
        private string product;

        public Order(string username, string date, string amount, string product)
        {
            this.username = username;
            this.date = date;
            this.amount = amount;
            this.product = product;
        }

        public Order(string id, string username, string date, string amount, string product)
        {
            this.id = id;
            this.username = username;
            this.date = date;
            this.amount = amount;
            this.product = product;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Date { get => date; set => date = value; }
        public string Amount { get => amount; set => amount = value; }
        public string Product { get => product; set => product = value; }
    }
}
