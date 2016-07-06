using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    // 1. Create a new console application named CustomersApp. 
    class Program
    {
        // 5. Create a Customer array, display it, then use Array.Sort to sort the array and display the sorted results.
        // 7. Test the comparer by passing it to Array.Sort call. 
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 7.1: Generic Interface Implementation");
            Console.WriteLine("\nSections 1-4: Implementation of \"IComparable<Customer>\" and \"IEquatable<Customer>\":");

            Console.WriteLine("* The following list of customers is includding 100 different customers (Uniq ID)");
            Console.WriteLine("* The names are with Cycle of 10 (each name repeat every 10 customers, some with capital letters and some not)");
            Console.WriteLine("* The addresses are with Cycle of 5 (each address repeat every 10 customers)");

            string[] NamesList = { "David", "Anthony", "Jeff", "Jason", "Steven", "Lisa", "Sandra", "Jennifer", "Sharon", "Ruth",
                                   "DAVID", "ANTHONY", "JEFF", "JASON", "STEVEN", "LISA", "SANDRA", "JENNIFER", "SHARON", "RUTH"};
            string[] AddressesList =  { "10250 Santa Monica Blvd, Los Angeles, CA 90067",
                                        "55 East 52nd Street 21st Floor New York, NY 10022 United States",
                                        "405 East 42nd Street, New York, NY, 10017, USA",
                                        "Calle de la Princesa, 58, 28008 Madrid",
                                        "79-83 Brompton Rd, London SW3 1DB" };

            Customer[] CustomerList = new Customer[100];
            for (int i = 0; i < CustomerList.Length; i++)
            {
                String CustNname = NamesList[i%20];
                String CustAddress = AddressesList[i % 5];
                CustomerList[i] = new Customer(CustNname,(100-i), CustAddress);
            }

            Console.WriteLine("\nTable 1.1:\tChecking the \"CompareTo\" method:");
            Console.WriteLine("* Every 10th element got the same Name, therefor every 10th element is '0'");
            Console.WriteLine("* Half of the names are with capital letters, but there is no influence");
            for (int i = 0; i < CustomerList.Length; i++)
            {
                Console.Write("({0,3}, {1})", CustomerList[i].GetID(), CustomerList[0].CompareTo(CustomerList[i]));
                if (i % 10 == 9) { Console.WriteLine(); }
                else { Console.Write(", "); }
            }

            Console.WriteLine("\nTable 1.2:\tChecking the \"Equals\" method:");
            Console.WriteLine("* Only the First element is \"true\", since the ID is uniq");
            for (int i = 0; i < CustomerList.Length; i++)
            {
                Console.Write("({0,3},{1,5})", CustomerList[i].GetID(), CustomerList[0].Equals(CustomerList[i]));
                if (i % 10 == 9) { Console.WriteLine(); }
                else { Console.Write(","); }
            }

            // 5:
            Console.WriteLine("\n\nSections 5: Customers Array:    \n");
            Console.WriteLine("Table 2.1:\tDispaying the customers array (only the first 20 customers...):    \n");
            for (int i = 0; i < 20; i++) { CustomerList[i].CustomerDisplay(); }

            Array.Sort(CustomerList);
            Console.WriteLine("\nTable 2.2:\tDispaying the sorted customers array (only the first 20 customers...):");
            Console.WriteLine("(* the elements in the array are sorted by the address)    \n");
            for (int i = 0; i < 20; i++) { CustomerList[i].CustomerDisplay(); }


            // 7:
            Console.WriteLine("\n\nSections 7: AnotherCustomerComparer:");
            Array.Sort(CustomerList, new AnotherCustomerComparer());

            Console.WriteLine("\nTable 3.1:\tDispaying the sorted customers array (only the first 20 customers...):");
            Console.WriteLine("(* the elements in the array are sorted by the ID)    \n");
            for (int i = 0; i < 20; i++) { CustomerList[i].CustomerDisplay(); }



            // Lab 8.1: Using Delegates 
            // A to K List:
            Console.WriteLine("\n\nLab 8.1: Using Delegates");
            Console.WriteLine(" 5.b-c Return a Customer if its name starts with the letters A-K:");
            var FromAToKList = GetCustomers(CustomerList, AToKCustomerFilter);
            PrintList(FromAToKList);

            // L to Z List:
            Console.WriteLine("\n 5.d-e Return a Customer if its name starts with the letters L-Z:");
            var FromLToZList = GetCustomers(CustomerList, delegate (Customer _customer)
            {
                if ((_customer == null) || (string.IsNullOrEmpty(_customer.GetName()))) { return false; }
                else
                {
                    char FirstLetter = Convert.ToChar(_customer.GetName().Substring(0, 1));
                    return ((((FirstLetter >= 'L') && (FirstLetter <= 'Z')) || ((FirstLetter >= 'l') && (FirstLetter <= 'z'))));
                }
            });
            PrintList(FromLToZList);

            // ID is  less than 100
            Console.WriteLine("\n 5.f-g Return  all customers whose ID is less than 100:");
            var IDFilterCustomersList = GetCustomers(CustomerList, _customer => (_customer!=null&& _customer.GetID()<100));
            PrintList(IDFilterCustomersList);

            Console.ReadLine();
        }



        // Lab 8.1: Using Delegates 
        // 8.1 3. Add a static method to the Program class named GetCustomers that 
        //        accepts a collection of customers
        //        and an instance of the CustomFilter delegate
        //        and returns a collection of Customers. 
        
        static List<Customer> GetCustomers(Customer[] customers, CustomerFilter filter) // returns a collection of Customers (ArrayList).
        {
            var filteredCustomers = new List<Customer>();
            foreach (var customer in customers)
            {
                if (filter(customer))
                {
                    filteredCustomers.Add(customer);
                }
            }
            return filteredCustomers;
        }


        static bool AToKCustomerFilter (Customer customer) // Return true if the first letter is from a to k, else, return false
        {
            if ((customer == null) || (string.IsNullOrEmpty(customer.GetName()))) { return false; }
            else
            {
                char FirstLetter = Convert.ToChar(customer.GetName().Substring(0, 1));
                return (((FirstLetter >= 'A') && (FirstLetter <= 'K')) || ((FirstLetter >= 'a') && (FirstLetter <= 'k')));
            }
        }



        static public void PrintList(List<Customer> customersList) // Printint the Customers ArrayList 
        {
            if (customersList.Count == 0) { Console.WriteLine("There are no customers in the given list"); }
            else
            {
                Console.WriteLine();
                for (int i = 0; i < customersList.Count; i++)
                {
                    Console.Write("{0,3}: {1,9}", ((Customer)customersList[i]).GetID(), ((Customer)customersList[i]).GetName());
                    if (i % 5 == 4) { Console.WriteLine(); }
                    else { Console.Write(";\t"); }
                }

                Console.WriteLine("\nList length is: {0,3}", (customersList.Count));
            }

        }


    }

}
