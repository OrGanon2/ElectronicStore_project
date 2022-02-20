
using Hyperion_Store.DB.DataProduct;
using Hyperion_Store.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hyperion_Store.UI
{
    public partial class Cart : Form
    {
        public static List<Order> Orderlist { get; set; } = new List<Order>();
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            int? amount = 0;
            var nameList = new List<string>();
            foreach (var item in Orderlist)
            {
                var finalItem = item.OrderedProduct + " Price:\n " + item.Amount.ToString(); 
                nameList.Add(finalItem);
                amount += item.Amount;
            }
            listBox1.DataSource = nameList;

            priceLabel.Text = amount.ToString();
            removeButton.Enabled = true;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = new List<string>();
            priceLabel.Text = "0";
            MessageBox.Show("thank you for buying!");
            Orderlist.Clear();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            IOrders orderMethod = new OrdersMethods();
            orderMethod.RemoveOrdersByID(Cart.Orderlist);
            listBox1.DataSource = new List<string>();
            priceLabel.Text = "0";
            MessageBox.Show("All items have been removed");
            Orderlist.Clear();



        }


    }
}
