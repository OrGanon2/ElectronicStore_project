using Electron_Store;
using Hyperion_Store.UI;
using System;
using System.Windows.Forms;

namespace Hyperion_Store
{
    public partial class MainMenu : Form
    {
        public static Form MainMain;
        public MainMenu()
        {
            MainMain = this;
            InitializeComponent();
        }
        
        private void phoneButton_Click(object sender, EventArgs e)
        {
            Phones phones= new Phones();
            phones.Parent = containerPanel;
            containerPanel.Controls.Add(phones);
            phones.Dock = DockStyle.Fill;
            phones.BringToFront();
            phones.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ProfileMenu menu = new ProfileMenu();
            menu.Parent = containerPanel;
            containerPanel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
            menu.Show();
            menu.BringToFront();
        }


        private void DesktopPCButton_Click(object sender, EventArgs e)
        {
            Computers computers = new Computers();
            computers.Parent = containerPanel;
            containerPanel.Controls.Add(computers);
            computers.Dock = DockStyle.Fill;
            computers.Show();
            computers.BringToFront();
        }

        private void LaptopsButton_Click(object sender, EventArgs e)
        {
            Laptops laptops = new Laptops();
            laptops.Parent = containerPanel;
            containerPanel.Controls.Add(laptops);
            laptops.Dock = DockStyle.Fill;
            laptops.Show();
            laptops.BringToFront();
        }

        private void MonitorsButton_Click(object sender, EventArgs e)
        {
            Monitors monitor = new Monitors();
            monitor.Parent = containerPanel;
            containerPanel.Controls.Add(monitor);
            monitor.Dock = DockStyle.Fill;
            monitor.Show();
            monitor.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfileMenu profileMenu = new ProfileMenu();
            profileMenu.Parent = containerPanel;
            containerPanel.Controls.Add(profileMenu);
            profileMenu.Dock = DockStyle.Fill;
            profileMenu.Show();
            profileMenu.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            MainMain.Close();
        }

        private  void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginMenu.thisform.Visible = true; 
            MessageBox.Show("Goodbye");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }
    }
}
