﻿using System;
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
    public partial class PaymentReceipt : Form
    {
        public PaymentReceipt()
        {
            InitializeComponent();
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            ShoppingPage shoppingPage = new ShoppingPage();
            shoppingPage.Show();
            this.Hide();
        }
    }
}
