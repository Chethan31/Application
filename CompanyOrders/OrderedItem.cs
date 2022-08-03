using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class OrderedItem
    {
        public int Qty { get; set; }
        public Item item { get; set; } = new Item();
    }
}
