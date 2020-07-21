using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var input =  Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = new List<int>();
            var currentList = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int h = i; h < input.Length; h++)
                {
                   
                }
            }
        }
       
    }
}
