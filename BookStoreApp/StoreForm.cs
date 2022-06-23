using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            UCMagazines uC = new UCMagazines();
            Data data = SingletonData.GetData();
            data.getBooks();
           
        }

        private void booksButton(object sender, EventArgs e)
        {
            Util.FillflowlayoutBooks(containsPanel,Util.FillBooksList());
            //containsPanel.Controls["UCBooks"].BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Util.FillflowlayoutBooks(containsPanel, Util.FillBooksList());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            containsPanel.Controls.Clear();
        }
    }
}
