using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public T data { get; set; }

        public Box(T data)
        {
            this.data = data;
        }

        public static void MyMethod(List<Box<int>> data,int num1 , int num2)
        {
            var curentData = data[num1];

            data[num1] = data[num2];
            data[num2] = curentData;

            
        }

    }
}
