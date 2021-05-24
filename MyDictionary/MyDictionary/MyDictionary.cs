using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] key;
        V[] value;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }
        public void add(K keys, V values)
        {
            K[] temporaryKey = key;
            V[] temporaryValue = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < temporaryKey.Length; i++)
            {
                key[i] = temporaryKey[i];
            }
            key[key.Length - 1] = keys;
            for (int i = 0; i < temporaryValue.Length; i++)
            {
                value[i] = temporaryValue[i];
            }
            value[value.Length - 1] = values;
        }
        public V[] Values
        {
            get { return value; }
        }
        public K[] Keys
        {
            get { return key; }
        }
    }
}

