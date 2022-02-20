
using Hyperion_Store;
using Hyperion_Store.DB.DataProduct;
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


namespace Electron_Store
{
    public partial class LoginMenu : Form
    {
        public static  Customer ThisCustomer { get; set; }
        public static Form thisform;
        public LoginMenu()
        {
            InitializeComponent();
            thisform = this;
        }
        public static ProfileMenu _Menu { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Electronic_storeContext())
            {
                var client = db.Customers.Where(c=> c.UserName == UserTextBox.Text && c.Password == PasswordTextBox.Text ).FirstOrDefault();

                if (client == null  )
                {

                    MessageBox.Show("Wrong ID or passwsord");
                }
                else
                {
                    ThisCustomer = client;
                    MessageBox.Show("Welcome");
                    LoginMenu.thisform.Visible = false;
                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();

             
                   
                }
            }
           
          
            




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Thank you for login in to Hyperion!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.ShowDialog();
        }
    }
}
