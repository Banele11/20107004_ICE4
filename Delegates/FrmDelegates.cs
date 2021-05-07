using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Delegates
{
    public partial class FrmDelegates : Form
    {
        public FrmDelegates()
        {
            InitializeComponent();
        }

        private void Order_Click(object sender, EventArgs e)
        {

            try
            {
                string name = txbName.Text;
                int coffee = Convert.ToInt32(txbCoffee.Text);
                int donuts = Convert.ToInt32(txbDonuts.Text);
                Order ord = new Order(name, coffee, donuts);
                ProcessOrder po = new ProcessOrder();
                po.ProcessOrders(ord);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
