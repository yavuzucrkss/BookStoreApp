using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
     public abstract class Product
    {
        private string id;
        private string name;
        private string price;
        private byte[] image;
        private string description;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public byte[] Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }

        public abstract string printProductDetail();
       
    }
}
