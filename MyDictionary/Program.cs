using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new MyDictionary<int, string>();
            users.Add(0, "Utku");
            users.Add(1, "Arzu");
            //users.Add(2, "Fuat");
            //users.Add(3, "Mürvet");
            Console.WriteLine(users.Count);

            
        }
    }


    
}
