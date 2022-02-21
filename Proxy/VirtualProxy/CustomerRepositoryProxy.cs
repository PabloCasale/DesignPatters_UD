using Proxy.ProxyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.VirtualProxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        private IRepository proxyApp;

        public IList<Customer> Get()
        {
            if (proxyApp == null)
            {
                proxyApp = new CustomerRepository();
            }

            if (Session.CanGetAll)
            {
                return proxyApp.Get();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(Customer customer)
        {
            if (proxyApp == null)
            {
                proxyApp = new CustomerRepository();
            }

            if (Session.CanSave)
            {
                proxyApp.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}