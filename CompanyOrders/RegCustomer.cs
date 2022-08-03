using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class RegCustomer:Customer
    {
        public double Discount { get; set; }
        public override double GetOrderedAmt()
        {
            double totAmt = base.GetOrderedAmt();
            double totDisc = totAmt * Discount / 100;
            return totAmt - totDisc;
        }
    }
}
