using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> stacks = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> buffer = new Stack<int>();
            foreach (var item in stacks)
            {
                buffer.Push(item);
            }
            int count = 0;
            int total = 0;


            for (int i = 0; i < stacks.Count; i++)
            {
                int currentNum = buffer.Peek();
                total += currentNum;

                if(total>capacity)
                {
                    count++;
                    i--;
                    total = 0;
                    continue;
                }
                if(total==capacity)
                {
                    if(buffer.Count>0)
                    {
                        count++;
                        buffer.Pop();
                        total = 0;
                        continue;
                    }
                }
                if(i == stacks.Count-1 && total < 16)
                {
                    count++;
                }
                buffer.Pop();
            }
            Console.WriteLine(count);
        }
    }
}
