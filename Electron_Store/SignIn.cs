using Hyperion_Store.DB.DataProduct;
using Hyperion_Store.Logic;
using System;
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
            if (Customer.ValidateName(firstNameBox.Text + " "  + lastNameBox.Text) && Customer.ValidateEmail(emailBox.Text) && Customer.ValidateUserName(userNameBox.Text) &&  Customer.ValidatePassword(PasswordBox.Text))
            {
                CustomerMethods customer = CustomerMethods.GetInstance();
                customer.CreateAccount(firstNameBox.Text, lastNameBox.Text, emailBox.Text, countryBox.Text, cityBox.Text, addressBox.Text, userNameBox.Text, PasswordBox.Text);
                MessageBox.Show("thank you for signing up!");
                this.Close();
            }
            else if(!Customer.ValidateName(firstNameBox.Text + " " + lastNameBox.Text) )
            {
                MessageBox.Show("invalid name or last name");
            }
            else if (!Customer.ValidateEmail(emailBox.Text))
            {
                MessageBox.Show("invalid Email");
            }
            else if (!Customer.ValidateUserName(userNameBox.Text))
            {
                MessageBox.Show("invalid Username");
            }
            else if (!Customer.ValidatePassword(PasswordBox.Text))
            {
                MessageBox.Show("invalid Password");
            }



        }
    }
}
