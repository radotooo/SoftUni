using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<Titem1,Titem2,Titem3>
    {

        private Titem1 item1 ;
        private Titem2 item2 ;
        private Titem3 item3;


        public Tuple(Titem1 item1 , Titem2 item2,Titem3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;

        }


        



        public void Print()
        {
            Console.WriteLine($"{item1} -> {item2} -> {item3}");
            
        }

    }
}
