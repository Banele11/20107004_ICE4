using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates

//---------- Code Attribution ----------
// Author: Mr E.Adam
// Year: 2021
// URl: https://www.youtube.com/watch?v=MFjlDbn7P8k&list=PL480DYS-b_kfOd8KRx93r92u5UYyzdQ_w&index=6&t=1884s
{
    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order ord);

        public event ProcessOrderDelegate OrderSubmitted;


        public void ProcessOrders(Order ord)
        {
            BaristaService brs = new BaristaService();
            DonutService ds = new DonutService();
            PaymentService ps = new PaymentService();

            OrderSubmitted += brs.MakeCoffee;
            OrderSubmitted += ds.PackDonuts;
            OrderSubmitted += ps.CollectPayment;

            OnOrderSubmitted(ord);
        }

        protected virtual void OnOrderSubmitted(Order ord)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(ord);
            }
        }
    }
}
