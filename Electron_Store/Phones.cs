using Hyperion_Store.DB.DataProduct;
using Electron_Store;
using System;
using System.Linq;
using System.Windows.Forms;
using Hyperion_Store.Logic;
using Hyperion_Store.UI;

namespace Hyperion_Store
{
    public partial class Phones : UserControl
    {
        public Phones()
        {
            InitializeComponent();
        }

        private void Phones_Load(object sender, EventArgs e)
        {
            using(var db = new Electronic_storeContext())
            {
                dataGridView1.DataSource = db.Phones.ToList();
               
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
  
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            IOrders ordersManagament = new OrdersMethods();
            var order = ordersManagament.CreateOrderInstance(Convert.ToInt32(addBox.Text), LoginMenu.ThisCustomer, "phone");
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
