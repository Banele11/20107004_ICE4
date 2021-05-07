using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegates
{
    class DonutService
    {
        public void PackDonuts(Order ord)
        {
            MessageBox.Show("Preparing your " + ord.Donuts + " donunts...");
        }
    }
}
