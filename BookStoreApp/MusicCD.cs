using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class MusicCD : Product
    {

        private string singer;
        private string type;

        public MusicCD(string id , string name , string price ,byte[] image,string description,string singer, string type)
        {

            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
            base.Description = description;
            this.Singer = singer;
            this.Type = type;
        }
        public MusicCD(string id, string name, string price, byte[] image)
        {
            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
        }
        public string Singer { get => singer; set => singer = value; }
        public string Type { get => type; set => type = value; }

        public override string printProductDetail()
        {
            return "kl0;00";
        }
    }
}
