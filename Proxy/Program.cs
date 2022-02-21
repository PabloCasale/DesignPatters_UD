using Proxy.ProxyApp;
using Proxy.VirtualProxy;
using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern");

            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanSave = true;
                Session.CanGetAll = true;

                Customer a = new Customer("Customer 1");
                Customer b = new Customer("Customer 2");

                repo.Save(a);
                repo.Save(b);

                foreach (var customer in repo.Get())
                {
                    Console.WriteLine($"Saved: {customer.Name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}