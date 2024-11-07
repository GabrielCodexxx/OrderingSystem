using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class ShoppingPage : Form
    {
        public ShoppingPage()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            CartPage cartPage = new CartPage();
            cartPage.Show();
            this.Hide();
        }
    }
}
