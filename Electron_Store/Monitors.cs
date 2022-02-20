using Hyperion_Store.DB.DataProduct;
using Electron_Store;
using Hyperion_Store.Logic;
using Hyperion_Store.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hyperion_Store
{
    public partial class Monitors : UserControl
    {
        public Monitors()
        {
            InitializeComponent();
        }
        private void Monitors_Load(object sender, EventArgs e)
        {
            using(var db = new Electronic_storeContext())
            {
                dataGridView1.DataSource = db.Monitors.ToList();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            IOrders ordersManagament = new OrdersMethods();//polimoprhisem דו פרצופיות 
            var order = ordersManagament.CreateOrderInstance(Convert.ToInt32(MontiorText.Text), LoginMenu.ThisCustomer, "monitor");
            Cart.Orderlist.Add(order);
        }

        private void MontiorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
