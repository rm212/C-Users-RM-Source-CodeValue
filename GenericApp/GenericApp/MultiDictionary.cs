using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class MultiDictionary<K, V> : IMultiDictionary<K, V>, IEnumerable<KeyValuePair<K, V>>
    {
        Dictionary<K, LinkedList<V>> InternalMultiDictionary = new Dictionary<K, LinkedList<V>>();

        //  6. Implement the methods with these guidelines:
        //      a. The Add method should create a new LinkedList instance if the key does not exist,
        //         or add an item with the AddLast instance method. 

        public void Add(K key, V value)
        {
            if (InternalMultiDictionary.ContainsKey(key) == false)
            { InternalMultiDictionary.Add(key, new LinkedList<V>()); }

            if (Contains(key, value) == false)
            { InternalMultiDictionary[key].AddLast(value); }
        }

        //      b.The Remove method with a key only should remove all values with that key(hint: Dictionary can do this).
        //        Remove with a specific value should remove just this value.Both methods return true on success.

        public bool Remove(K key)
        { return InternalMultiDictionary.Remove(key); }



        public bool Remove(K key, V value)
        {
            bool RemoveFlag = false;
            if (ContainsKey(key))
            {
                LinkedList<V> KeyValueList = InternalMultiDictionary[key];
                if (KeyValueList != null)
                { RemoveFlag = KeyValueList.Remove(value); }
            }
            return RemoveFlag;
        }

        //      e. Clear should remove all items from the collection.
        public void Clear()
        { InternalMultiDictionary.Clear(); }

        //      c. The Keys property should return a collection of all keys.
        public bool ContainsKey(K key)
        { return InternalMultiDictionary.ContainsKey(key); }



        public bool Contains(K key, V value)
        {
            LinkedList<V> valuesList = InternalMultiDictionary[key];
            bool ContainsFlag = (valuesList != null && valuesList.Any() && valuesList.Contains(value));

            return ContainsFlag;
        }

        public ICollection<K> Keys
        { get { return InternalMultiDictionary.Keys; } }

        //      d. The Values property should return a collection of all values.
        public ICollection<V> Values
        {
            get
            {
                List<V> ValuesList = new List<V>();
                foreach (var list in InternalMultiDictionary.Values)
                {
                    if (list != null)
                    {ValuesList.AddRange(list);}
                }
                return ValuesList;
            }
        }

        //      f. The Count property should return the total items in the collection. 
        public int Count
        {
            get { return Values.Count(); }
        }

        //  7. Implement the IEnumerable<KeyValuePair<K,V>> interface appropriately. 
        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            try
            {
                List<KeyValuePair<K, V>> KeyValueList = new List<KeyValuePair<K, V>>();
                foreach (var key in InternalMultiDictionary.Keys)
                {
                    foreach (var value in InternalMultiDictionary[key])
                    {
                        KeyValueList.Add(new KeyValuePair<K, V>(key, value));
                    }
                }
                return KeyValueList.GetEnumerator();


            }
            catch { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try { return this.GetEnumerator(); }
            catch { throw new NotImplementedException(); }
            
        }
    }
}

