using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodStrings
{
    public class Box<T> : List<T>
        where T: IComparable<T>
    {
        private List<T> MyProperty { get; set; }
       



        public Box()
        {
           List<T> MyProperty = new List<T>();
        }

        //public void Add(T item)
        //{

        //    this.MyProperty.Add(item);
        //}


        public  void MyMethod(List<T> data , T element)
        {
            int count = 0;
            foreach (var item in data)
            {
                int result = item.CompareTo(element);
                if(result==1)
                {
                    count++;
                }
            }
                Console.WriteLine(count);

        }
    }
}
