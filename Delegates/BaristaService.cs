using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegates
{
    class BaristaService
    {
        public void MakeCoffee(Order ord)
        {
            MessageBox.Show("Preparing your " + ord.Coffee + " coffees...");
        }
    }
}
