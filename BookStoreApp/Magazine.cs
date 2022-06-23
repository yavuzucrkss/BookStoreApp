using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class Magazine : Product
    {
        private string type;
        private string issue;

        public Magazine(string id, string name, string price, byte[] image, string description, string type, string issue)
        {
            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
            base.Description = description;
            this.type = type;
            this.Issue = issue;
        }

        public Magazine(string id, string name, string price, byte[] image)
        {
            base.Id = id;
            base.Name = name;
            base.Price = price;
            base.Image = image;
        }

        public string Type { get => type; set => type = value; }
        public string Issue { get => issue; set => issue = value; }

        public override string printProductDetail()
        {
            return "fsdş";
        }

    }
}
