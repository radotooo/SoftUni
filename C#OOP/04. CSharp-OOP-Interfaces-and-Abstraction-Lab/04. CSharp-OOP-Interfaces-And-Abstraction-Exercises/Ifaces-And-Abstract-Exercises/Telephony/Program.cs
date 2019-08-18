using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var tele = new Smartphone();
            
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                Console.WriteLine(tele.Call(number)); 
            }
            foreach (var url in urls)
            {
                Console.WriteLine(tele.Browse(url));
             
            }
        }
    }
}
