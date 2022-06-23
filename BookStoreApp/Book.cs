using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class Book : Product
    {
       
        private string author;
        private string publisher;
        private string isdb;
        private string page;
        

        public Book(string id ,string name ,string price, byte[] image, string description,string author, string publisher, string isdb, string page)
        {
            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
            base.Description = description;
            this.author = author;
            this.publisher = publisher;
            this.isdb = isdb;
            this.page = page;
        }

        public Book(string id , string name , string price, byte[] image)
        {
            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
        }

        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Isdb { get => isdb; set => isdb = value; }
        public string Page { get => page; set => page = value; }
       

        public override string printProductDetail()
        {
            return "sda";
        }
    }
}
