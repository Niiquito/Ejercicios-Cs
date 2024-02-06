using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCs
{
    public class Bank
    {
        public int CustomerCounter { get;}
        private List<NewCustomer> customers;
        public Bank()
        {
            customers = new();
        }
        public void AddCustomer(NewCustomer customer)
        {
            customers.Add(customer);
        }
        public List<NewCustomer> GetCustomer()
        {
            return customers;
        }
    }
}
