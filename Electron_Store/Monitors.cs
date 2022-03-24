using Hyperion_Store.DB.DataProduct;
using Electron_Store;
using Hyperion_Store.Logic;
using Hyperion_Store.UI;
using System;
using System.Linq;
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
            if (order == null)
            {
                MessageBox.Show("invalid infromation choose the id from the list");
            }
            else
            {
                Cart.Orderlist.Add(order);
            }
           
        }

     
      
    }
}
