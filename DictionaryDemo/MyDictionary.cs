using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1, T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempArrayk = keys;
            T2[] tempArrayv = values;
            
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            
            for (int i = 0; i < tempArrayv.Length; i++)
            {
                keys[i] = tempArrayk[i];
                values[i] = tempArrayv[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + "\t   ->\t" + values[i]);
            }

        }
    }
}
