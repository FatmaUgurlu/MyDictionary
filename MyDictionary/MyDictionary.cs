using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] number;
        V[] name;
        K[] tempNumber;
        V[] tempName;

        public MyDictionary()         //constructor
        {
            number = new K[0];
            name = new V[0];
        }

        public void Add(K items1, V items2)
        {
            tempNumber = number;
            tempName = name;
            number = new K[number.Length + 1];
            name = new V[name.Length + 1];

            for (int i = 0; i < tempNumber.Length; i++)
            {
                number[i] = tempNumber[i];
            }

            number[number.Length - 1] = items1;

            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }

            name[name.Length - 1] = items2;
        }

        public K[] items1
        {
            get { return number; }
        }
        public V[] items2
        {
            get { return name; }
        }
    }
}
