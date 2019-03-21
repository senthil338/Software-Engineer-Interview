using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.DataStructure.HashTable
{
    /// <summary>
    /// Simple hashtable implementation with constant array value,
    /// Key collison not handled as it just for the reference and how Add and FindByKey works
    /// Time Complexity : Avg  Search, Insert , Delete :- O(1) and Worst O(n) when Key collison occure's
    /// </summary>
    public class HashtableImp
    {
        private struct bucket
        {
            public object Key;
            public object Value;
            private int has_coll;
        }
        private const int MAX_SIZE = 20;
        private bucket[] buckets = new bucket[MAX_SIZE];

        public void Add(object key, object value)
        {

            int count = 0;
            while (buckets.Length > count)
            {
                if (buckets[count].Key == key)
                {
                    throw new Exception("Key already present.");
                }
                if (buckets[count].Key == null)
                {
                    buckets[count].Value = value;
                    buckets[count].Key = key;
                    return;
                }
                count++;
            }
        }

        public object FindByKey(object key)
        {
            foreach (bucket _bucket in buckets)
            {
                if (_bucket.Key == key)
                {
                    return _bucket;
                }
            }
            return null;
        }

        public object this[int i]
        {
            get
            {
                return buckets[i];
            }
        }

    }
}
