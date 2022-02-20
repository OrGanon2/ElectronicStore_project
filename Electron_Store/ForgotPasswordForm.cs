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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            ForgotPassword Forgot = new ForgotPassword();
            Forgot.Parent = panel1;
            panel1.Controls.Add(Forgot);
            Forgot.Show();
            Forgot.BringToFront();
            Forgot.Dock = DockStyle.Fill;
        }
    }
}
