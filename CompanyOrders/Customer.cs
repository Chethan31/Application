using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Customer
    {
        public List<Order> OrderList { get; set; }=new List<Order>();   
        public virtual double GetOrderedAmt()
        {
            double totalAmt = 0;
            foreach (Order o in OrderList)
                totalAmt+=o.GetOrderAmt();
            return totalAmt;
        }

    }
}
