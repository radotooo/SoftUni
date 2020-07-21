using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //var a = "rado";
            //var b = "rado";
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            var list = new ReversedList<int>();
            var cc = new int[] { 1, 2, 3, 4, 5 };
            var c = new ReversedList<int>(cc);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            Console.WriteLine(string.Join(",", c));
            Console.WriteLine(c.Count());

            Console.WriteLine(c.Capacity());
            Console.WriteLine("----");
            Console.WriteLine(c[0]);
            Console.WriteLine("----");
            c.RemoveAt(0);
            c.RemoveAt(2);

            Console.WriteLine("====after Remove====");
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine(c[2]);
            Console.WriteLine(c[3]);
            Console.WriteLine(c[4]);
            






            // Console.WriteLine(string.Join(",", listR));
        }

    }
}
