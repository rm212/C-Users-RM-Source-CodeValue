using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    // Lab 8.1: Using Delegates 
    public delegate bool CustomerFilter(Customer _customer);



    public class Customer : IComparable<Customer>, IEquatable<Customer>
    {
    // 2. Create a new class, called Customer with the following properties: Name (string), ID (int), Address (string).
        private string Name;
        private int ID;
        private string Address;
        public Customer()
        {
            Name = null;
            ID = 0;
            Address = null;
        }
        public Customer(string _name, int _id, string _address) 
        {
            Name = _name;
            ID = _id;
            Address = _address;
        }
        public void CustomerDisplay()
        {
            Console.Write("ID:{0,3}, Name: {1},\t", this.ID, Convert.ToString(this.Name));
            Console.WriteLine("Address: {0}", this.Address);
        }

        // Lab 8.1: Using Delegates 
        public string GetName()
        { return (this.Name); }
        public int GetID()
        { return (this.ID); }
        public string GetAddress()
        { return (this.Address); }

        // 3. Implement the interface IComparable<Customer> by using the Name property only in a case insensitive way.
        public int CompareTo(Customer other)
        {
            if (other == null) { return 1; }
            else
            { return ((string.Compare(this.Name.ToLower(), other.Name.ToLower()))); }
        }

        // 4. Implement the interface IEquatable<Customer> by comparing Name and ID of the customers.
        public bool Equals(Customer other)
        {
            if ((other == null)||(other.GetID()==0)) { return false; }
            else
            { return ((string.Compare(this.Name.ToLower(), other.Name.ToLower(), true) == 0) && (this.ID == other.ID) == true); }
        }

        public override bool Equals(object obj)
        { return Equals(obj); }

        public override int GetHashCode()
        { return ID; }
    }
}
