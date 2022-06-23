using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp
{
    class SingletonData
    {
        private static Data data;

        public static Data GetData()
        {
            if(data == null)
            {
                data = new Data();  
            }
            return data;
        }
    }
}
