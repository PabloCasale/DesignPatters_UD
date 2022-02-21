using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyApp
{
    public class CustomerRepository : IRepository
    {
        private IList<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public IList<Customer> Get()
        {
            return customers;
        }

        public void Save(Customer customer)
        {
            customers.Add(customer);
        }
    }
}