using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    public class LoginedUser
    {
        private Customer customer;
        private static LoginedUser logineduser;

        public Customer Customer { get => customer; set => customer = value; }
        
        public static LoginedUser getInstance()
        {
            if(logineduser == null)
            {
                logineduser = new LoginedUser();
            }
            return logineduser;
        }



    }
}
