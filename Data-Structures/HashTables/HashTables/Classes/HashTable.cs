using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace HashTables.Classes
{
    public class HashTable
    {
        /// <summary>
        /// The table
        /// </summary>
        LL[] Table = new LL[1024];

        /// <summary>
        /// Adds the specified key and value to the Hash Table.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(string key, string value)
        {
            int index = GetHash(key);
            Node node = new Node(key, value);
            if (Contains(key))
                Table[index].AddBefore(node, Table[index].Head);
            else
                Table[index] = new LL(node);
        }

        /// <summary>
        /// Finds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Returns the key/value pair from the Hash Table</returns>
        public string Find(string key)
        {
            int index = GetHash(key);
            Table[index].Current = Table[index].Head;
            while (Table[index].Current != null)
            {
                if ((string)Table[index].Current.Key == key)
                    return $"{(string)Table[index].Current.Key}: {(string)Table[index].Current.Value}";
                else
                    Table[index].Current = Table[index].Current.Next;
            }
            return null;
        }

        /// <summary>
        /// Determines whether [contains] [the specified key].
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);
            if (Table[index] == null)
                return false;
            Table[index].Current = Table[index].Head;
            while (Table[index].Current != null)
            {
                if ((string)Table[index].Current.Key == key)
                    return true;
                Table[index].Current = Table[index].Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Gets the hash.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Returns the Hash</returns>
        public int GetHash(string key)
        {
            int index = 0;
            foreach (char item in key)
                index += (int)item;
            index = (index * 743) % Table.Length;
            return index;
        }
    }
}
