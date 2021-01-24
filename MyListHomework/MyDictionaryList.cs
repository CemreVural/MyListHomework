using System;
using System.Collections.Generic;
using System.Text;

namespace MyListHomework
{
    class MyDictionaryList<Titem,Tprice>
    {
        Titem[] keys;
        Tprice[] values;
        public MyDictionaryList()
        {
            keys = new Titem[0];
            values = new Tprice[0];
        }
        public void Add(Titem key, Tprice value)
        {
            Titem[] tempKeys = keys;
            Tprice[] tempValues = values;

            keys = new Titem[keys.Length + 1];
            values = new Tprice[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get
            {
                return keys.Length;
            }
        }
        public Titem[] Keys
        {
            get
            {
                return keys;
            }
        }
        public Tprice[] Values
        {
            get
            {
                return values;
            }
        }

    }
}
