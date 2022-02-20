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

namespace Hyperion_Store
{
    public partial class ForgotPassword : UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmailMethods sendEmail = new EmailMethods();
            sendEmail.SendCodeThroughEmail(emailBox.Text, "hyperion", $"your password has been reset {userNamebox.Text}");
            CustomerMethods.RestorePassword(userNamebox.Text,passwordBox.Text);
            MessageBox.Show("An email has been sent to you");
        }
    }
}      
