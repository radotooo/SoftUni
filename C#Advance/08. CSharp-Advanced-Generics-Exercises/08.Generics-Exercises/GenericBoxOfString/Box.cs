using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public static class Box<T>
    {

        

        public static void MyMethod(T data)
        {
            Console.WriteLine($"{data.GetType()}: {data} ");
            
        }

    }
}
