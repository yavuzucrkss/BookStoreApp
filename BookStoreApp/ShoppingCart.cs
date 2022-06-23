using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookStoreApp
{
    public class ShoppingCart
    {
        private List<ItemtoPurchase> itemsList = new List<ItemtoPurchase>();
       // private string CustomerId = LoginedUser.getInstance().Customer.Id;
        private int totalAmount = 0;

       // public string CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public List<ItemtoPurchase> ItemsList { get => itemsList; set => itemsList = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }

        public void AddCartItem(ItemtoPurchase _item)
        {
            try
            {
              
                    foreach (ItemtoPurchase item in itemsList)
                    {
                        if (_item.Product.Name == item.Product.Name)
                        {
                            //item.Quantity += 1;
                            UpdatetotalAmount();
                            return;
                        }
                    }
                    ItemsList.Add(_item);


                Util.FillUCShoppingCard();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        public void RemoveFromCart(ItemtoPurchase ıtemtoPurchase)
        {
            try
            {
                foreach (ItemtoPurchase item in ItemsList)
                {
                    if (ıtemtoPurchase.Product.Name == item.Product.Name)
                    {
                        ItemsList.Remove(item);
                    }
                }
                UpdatetotalAmount();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Product removed!");
            }
           
            
        }

        public void UpdatetoItemQuantity(ItemtoPurchase ıtemtoPurchase, int quantity)
        {
            foreach (ItemtoPurchase item in ItemsList)
            {
                if (ıtemtoPurchase.Product.Name == item.Product.Name)
                {
                    item.Quantity = quantity;
                }

            }
            UpdatetotalAmount();
        }

        public void ClearShoppingCard()
        {
            itemsList.Clear();
            totalAmount = 0;
        }

        public void UpdatetotalAmount()
        {
            totalAmount = 0;
            foreach (ItemtoPurchase item in ItemsList)
            {
                totalAmount += item.calcuAmount();
            }
        }

    }
}
