﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyApp
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}