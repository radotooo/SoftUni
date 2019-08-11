using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Func<string, bool> cheker = w => char.IsUpper(w[0]);

            var result = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(cheker).ToArray();
            foreach (var words in result)
            {
                Console.WriteLine(words);
            }
            //Func<string,string> cheker = n => n[0]
        }
    }
}
