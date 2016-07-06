using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{

    class AnotherCustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if ((y == null) || (x == null)) { return 1; }
            else { return x.GetID().CompareTo(y.GetID()); }
        }
    }
}
    
