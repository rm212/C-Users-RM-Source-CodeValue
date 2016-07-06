using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{


    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<int, string> Pairs = new MultiDictionary<int, string>();

            Console.WriteLine("Numbers of pairs before initiating the pairs in the dictionary:\t{0}",Pairs.Count);
            string ListOfpairs = "{1,“one”}, {2,“two”}, {3,“three”}, {1,“ich”}, {2,“nee”}, {3,“sun”}";
            Console.WriteLine("\nStep1:\tInitiating the MultiDictionary:");
            Console.WriteLine("\tThe following pairs were inserted:\n\t{0}", ListOfpairs);

            //  { 1, "one" }, { 2, "two" }, { 3, "three" }, { 1, "ich" }, { 2, "nee" }, { 3, "sun" }
            Pairs.Add(1, "one");
            Pairs.Add(2, "two");
            Pairs.Add(3, "three");
            Pairs.Add(1, "ich");
            Pairs.Add(2, "nee");
            Pairs.Add(3, "sun");

            Console.WriteLine("\nNumbers of pairs after initiating the pairs:\t{0}", Pairs.Count);
            // 
            Console.WriteLine("\nStep 2:\tTrying to insert duplications:");
            string ListOfpairs2 = "{1,“one”}, {2,“two”}, {3,“sun”}";
            Console.WriteLine("\tThe following pairs were re-inserted:\n\t{0}", ListOfpairs2);
            Pairs.Add(1, "one");
            Pairs.Add(2, "two");
            Pairs.Add(3, "sun");
            Console.WriteLine("\nNumbers of pairs after trying to insert duplications:\t{0}", Pairs.Count);

            string ListOfpairs3 = "{4,“sun”}, {2,“sun”}, {1,“two”}";
            Console.WriteLine("\nStep3:\tThe following \"mixed\" pairs were inserted:\n\t{0}", ListOfpairs3);
            Pairs.Add(4, "sun");
            Pairs.Add(2, "sun");
            Pairs.Add(1, "two");
            Console.WriteLine("\nNumbers of pairs after trying to insert \"mixed\" pairs:\t{0}", Pairs.Count);

            Console.WriteLine("\nStep4:\tTesting the remove method on the \"mixed\" pairs that were inserted:\n\t{0}", ListOfpairs3);
            Pairs.Remove(4);
            Pairs.Remove(2, "sun");
            Pairs.Remove(1, "two");
            Console.WriteLine("\nNumbers of pairs after removing the \"mixed\" pairs:\t{0}", Pairs.Count);

            Console.WriteLine("\nOthers:");


            Console.WriteLine("* Finale list of elements:");
            foreach (var PairsKey in Pairs.Keys)
            {
                Console.Write("\t");
                Console.Write("( {0}:\t",PairsKey);
                foreach (var PairsValue in Pairs.Values)
                {
                    if (Pairs.Contains(PairsKey, PairsValue))
                    { Console.Write(PairsValue + " \t "); }
                }
                Console.WriteLine(")");
            }

            Console.WriteLine();

            Console.Write("* Finale list of elements:\t");
            foreach (var KeyValue in Pairs)
            { Console.Write(KeyValue + " ; "); }
            Console.WriteLine();

            Console.Write("* Finale list of keys:\t\t");
            foreach (var KeyValue in Pairs.Keys)
            { Console.Write(KeyValue + " ; "); }
            Console.WriteLine();

            Console.Write("* Finale list of values:\t");
            foreach (var KeyValue in Pairs.Values)
            { Console.Write(KeyValue + " ; "); }
            Console.WriteLine();

            Console.WriteLine("\nStep5:\tTesting the clear method");
            Pairs.Clear();
            Console.WriteLine("Numbers of pairs after using the clear method:\t{0}", Pairs.Count);
            Console.ReadLine();
        }
    }
}
