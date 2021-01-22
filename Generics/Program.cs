using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Edirne");
            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Edirne");
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("Çanakkale");
            sehirler.Add("Bursa");
            sehirler2.Add("İzmir");

            Console.WriteLine(sehirler2.Count);
        }   
    }
    class MyList<T>
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }

        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
