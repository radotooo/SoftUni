using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> result = new Stack<int>();
            
            int indexOfLastOpeningBracket = 0;
           

            for (int i = 0; i < input.Length; i++)
            {
                if( input[i] == '(' )
                {
                    indexOfLastOpeningBracket = i;
                    result.Push(indexOfLastOpeningBracket);
                }
                else if (input[i] == ')')
                {
                    int indexOf = i;
                    int gg = result.Pop();
                    string toBePRinted = input.Substring(gg, indexOf - gg+1);
                    Console.WriteLine(toBePRinted);
                }
            }
        }
    }
}
