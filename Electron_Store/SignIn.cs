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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMethods customer =CustomerMethods.GetInstance();
            customer.CreateAccount(firstNameBox.Text,lastNameBox.Text,emailBox.Text,countryBox.Text,cityBox.Text,addressBox.Text,userNameBox.Text,PasswordBox.Text);
            MessageBox.Show("thank you for signing up!");
            this.Close();

            
        }
    }
}
