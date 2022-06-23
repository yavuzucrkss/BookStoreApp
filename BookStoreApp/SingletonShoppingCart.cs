using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    class SingletonShoppingCart
    {
        private static ShoppingCart shoppingCard;

        public static ShoppingCart GetShoppingCard()
        {
            if(shoppingCard == null)
            {
                shoppingCard = new ShoppingCart();
            }
            return shoppingCard;
        }

    }
}
