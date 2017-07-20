using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class ClassCustomerOrder
    {

        public ClassCustomerOrder(ClassCustomer customers, ClassOrder orders)
        {
            Customers = customers;
            Orders = orders;
        }

        public ClassCustomer Customers { get; set; }
        public ClassOrder Orders { get; set; }

    }
}