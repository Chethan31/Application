using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Company
    {
        public List<Item> items  { get; set; } = new List<Item>();

        public List<Customer> customers { get; set; } = new List<Customer>();    
        public double GetTotalWorthOfOrdersPlaced()
        {
            double total=0;
            foreach (Customer customer in customers)
            {
                foreach(Order order in customer.OrderList)
                {
                    foreach(OrderedItem orderedItem in order.orderedItems)
                    {
                        total += orderedItem.Qty * orderedItem.item.Rate;
                    }
                }          
                if (customer is RegCustomer)
                {
                    RegCustomer reg = customer as RegCustomer;
                    double totalDiscount = 0;
                    totalDiscount = (reg.Discount * total) / 100;
                    total = total - totalDiscount;
                }
            }

            return total;
        } 
    }
}
