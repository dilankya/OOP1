using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> keys;
        List<TValue> values;
        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public void Key (TKey key)
        {
            try
            {
                Console.WriteLine(values[keys.IndexOf(key)]);
            }
            catch
            {
                Console.WriteLine("Aradığınız kelime yok");
            }
        }
    }
}
