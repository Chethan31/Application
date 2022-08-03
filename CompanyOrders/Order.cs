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
    }
}
