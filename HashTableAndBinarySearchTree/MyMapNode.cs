using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValuePair<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K, V>>[size];
        }

        public struct KeyValuePair<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            KeyValuePair<K, V> item = new KeyValuePair<K, V>() { Key = key ,Value = value};
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            bool itemfound = false;
            KeyValuePair<K, V> founditem = default(KeyValuePair<K, V>);
            foreach (KeyValuePair<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    itemfound = true;
                    founditem = item;
                }
            }
            if (itemfound)
            {
                linkedlist.Remove(founditem);
            }
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            foreach(KeyValuePair<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        protected int GetArrayPosition(K key)
        {
            var hashcode = key.GetHashCode();
            int position = hashcode % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValuePair<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public List<KeyValuePair<K, V>> GetAllItems()
        {
            List<KeyValuePair<K, V>> allItems = new List<KeyValuePair<K, V>>();
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var item in linkedList)
                    {
                        allItems.Add(item);
                    }
                }
            }
            return allItems;
        }
    }
}
