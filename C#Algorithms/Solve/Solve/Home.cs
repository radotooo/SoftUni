using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solve
{
    public abstract  class Home

    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Home()
        {


        }
        public void MyMethod()
        {

            throw new NotImplementedException();
        }
        internal static void Print()
        {
            var a = 10;
            Console.WriteLine(a);
        }
        public Home SetName(string name)
        {
            this.Name = name;
            return this;
        }
        public Home SetAge(int age)
        {
            this.Age = age;
            return this;

        }
        public abstract int Rado();
       
    }
}
