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
                total += customer.GetOrderedAmt();
            }
            return total;
        } 
    }
}
