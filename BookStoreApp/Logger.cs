using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    class Logger
    {
        
        public static void log(string userActivite)
        {
            string path = Application.StartupPath + @"/Log.txt";
            LoginedUser user = LoginedUser.getInstance();
            string log =user.Customer.Username + "\t\t" + userActivite + " Button\t\t" + DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToLongTimeString(); ;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", "Username", "Activite", "Date", "Time"));
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", user.Customer.Username, userActivite, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", user.Customer.Username, userActivite, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
                }
            }
               
        }
    }
}
