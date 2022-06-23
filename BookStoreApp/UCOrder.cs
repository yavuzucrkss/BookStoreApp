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
    public partial class UCOrder : UserControl
    {
            Data data = SingletonData.GetData();
        public UCOrder()
        {
            InitializeComponent();
            data.OrdersList();
            dataGridView1.DataSource = data.OrderTable;
            dataGridView1.ReadOnly = true;
            this.Dock = DockStyle.Fill;
        }

        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idlbl.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            orderAmountLbl.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            orderDate.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idlbl.Text);
                data.DeleteOrder(id);
                data.OrdersList();

                BookStoreForm.ordersButton_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Order Canceled!");
            }
           

        }
    }
}
