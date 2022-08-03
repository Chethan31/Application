using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Order
    {
        public List<OrderedItem> orderedItems { get; set; } = new List<OrderedItem>();

        public Customer customer { get; set; } = new Customer();
        public int GetOrderAmt()
        {
            int amount = 0;
            foreach(OrderedItem ot in orderedItems)
                amount+=ot.GetAmt();
            return amount;
        }
    }
}
