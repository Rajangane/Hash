using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class MyMapNode<K, V>
    {
        /// <summary>
        /// variables
        /// </summary>
        private readonly int size; //size of hash table
        private readonly LinkedList<KeyValue<K, V>>[] items; //Passing the Keyvalue object to the Linkedlist
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="size"></param>
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size; //identifying hash code of key
            return Math.Abs(position); //absolute value to identify integer value of key
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position) // position will be the index
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        /// <summary>
        /// adding two parameters and  pushing data into hash table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(K key, V value) 
        {
            int position = GetArrayPosition(key);  
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key); // identifying at what index, key is present
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        /// <summary>
        /// removing key from the hash table
        /// </summary>
        /// <param name="key"></param>
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;

                }
            }
            if (itemFound)
                linkedList.Remove(foundItem);
        }
    }
    

    /// <summary>
    /// class key value
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
