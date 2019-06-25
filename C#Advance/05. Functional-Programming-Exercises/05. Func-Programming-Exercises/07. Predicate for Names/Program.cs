using System;
using System.Linq;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            string[] words = Console.ReadLine().Split().ToArray();

            //Predicate<string> filter = x => x.Length <= lenght;

            Func<string, bool> chekLenght = x => x.Length <= lenght;



            words.Where(chekLenght).ToList().ForEach(Console.WriteLine);
           
        }
    }
}
