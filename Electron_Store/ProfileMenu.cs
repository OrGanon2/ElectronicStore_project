using Hyperion_Store.DB.DataProduct;
using Electron_Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hyperion_Store.Logic;

namespace Hyperion_Store
{
    public partial class ProfileMenu : UserControl
    {
        public static ProfileMenu _Menu { get; set; } = new ProfileMenu();
        public bool IsHide { get; set; } = false;

        public ProfileMenu()
        {
            InitializeComponent();
            label2.Text = LoginMenu.ThisCustomer.FirstName;
            label3.Text = LoginMenu.ThisCustomer.LastName;
            label4.Text = LoginMenu.ThisCustomer.Email;
            label5.Text = LoginMenu.ThisCustomer.Country;
            label6.Text = LoginMenu.ThisCustomer.City;
            label7.Text = LoginMenu.ThisCustomer.Adress;



        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginMenu form1 = new LoginMenu();
            form1.Controls.Add(this);
        }

        private void PhoneButton_Click(object sender, EventArgs e)
        {
            Phones phone = new Phones();
            phone.Show();
            phone.BringToFront();
            containerPanel.Controls.Add(phone);
            containerPanel.BringToFront();
            phone.Dock = DockStyle.Fill;


        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ProfileMenu_Load(object sender, EventArgs e)
        {
            IOrders orders = new OrdersMethods();
            dataGridView1.DataSource = orders.GetThisCustomerOrders(LoginMenu.ThisCustomer);
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
