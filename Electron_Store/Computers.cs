using Hyperion_Store.DB.DataProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electron_Store;
using Hyperion_Store.Logic;
using Hyperion_Store.UI;

namespace Hyperion_Store
{
    public partial class Computers : UserControl
    {
        private object form1;

        public Computers()
        {
            InitializeComponent();
        }
        private void Computer_Load(object sender, EventArgs e)
        {
            using (var db = new Electronic_storeContext())
            {
                dataGridView1.DataSource = db.Computers.ToList();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            IOrders ordersManagament = new OrdersMethods();//polimoprhisem דו פרצופיות 
            var order = ordersManagament.CreateOrderInstance(Convert.ToInt32(DesktopText.Text), LoginMenu.ThisCustomer, "computer");
            Cart.Orderlist.Add(order);

        }

        private void DesktopText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//using (var db = new Electronic_storeContext())
//{
//    var id = Convert.ToInt32(addBox.Text);
//    var product = db.Phones.Where(c => c.Id == id).Select(c => c).FirstOrDefault();
//    Order order = new Order()
//    {
//        FirstName = Form1.ThisCustomer.FirstName,
//        LastName = Form1.ThisCustomer.LastName,
//        CustomerId = Form1.ThisCustomer.Id,
//        OrderedProduct = product.SerialNumber.ToString(),



//    };

//    var customer = db.Customers.Where(c => c.Id == Form1.ThisCustomer.Id).Select(c => c).FirstOrDefault();
//    customer.Orders.Add(order);
//    db.Orders.Add(order);
//    db.SaveChanges();
//}