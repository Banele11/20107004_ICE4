using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegates
{
    class PaymentService
    {
        public void CollectPayment(Order ord)
        {
            MessageBox.Show(ord.Name + ", your order is ready. The total price is: " + ord.Total);
        }
    }
}
