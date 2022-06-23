using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
   public class ItemtoPurchase
    {
        private Product product;
        private int quantity;
        private int itemAmount;
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int ItemAmount { get => itemAmount; set => itemAmount = value; }

        public ItemtoPurchase(Product _product, int _quantity)
        {
            product = _product;
            quantity = _quantity;
        }

        public int calcuAmount()
        {
            itemAmount = Convert.ToInt32(product.Price) * quantity;
            return itemAmount;
        }

    }
}
