using System;
using System.Collections.Generic;
using System.Text;

namespace OdevDictionary
{
    class MyDictionary <T1, T2>
    {
        {
          T1[] keys;
          T2[] values;

        public  MyDictionary()
        {
            keys = new  T1[0];
            values = new T2[0];
        }

        public void Add(T1 Key, T2 Value)
        {
            T1[] tempArrayKeys = keys;
            T2[] tempArrayValues = Value;

            keys = new  T1[keys.Length + 1];
            values = new T2[keys.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
                values[i] = tempArrayValues[i];
            }

            keys[keys.Length - 1] = Key;
            keys[keys.Length - 1] = Value;
        }
    }
    
}
