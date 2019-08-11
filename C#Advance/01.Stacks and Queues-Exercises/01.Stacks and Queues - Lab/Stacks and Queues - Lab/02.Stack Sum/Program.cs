using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> resul = new Stack<int>();
            for (int i = 0; i < input.Count; i++)
            {
                resul.Push(input[i]);
            }

            while (true)
            {
                if(end)
                {
                    break;
                }
                string[] command = Console.ReadLine().Split().ToArray();

                
                

                string task = command[0].ToLower();

                switch (task)
                {
                    case "end": end = true; break;
                    case "remove":
                        int numsToPop = int.Parse(command[1]);
                        int count = 0;
                        if (numsToPop > resul.Count)
                        {
                            break;
                        }
                        else
                        {
                            while (count < numsToPop)
                            {
                                resul.Pop();
                                count++;
                            }
                            break;
                        }

                    case "add":
                        resul.Push(int.Parse(command[1]));
                        resul.Push(int.Parse(command[2]));
                        break;
                }

            }
            Console.WriteLine($"Sum: {resul.Sum()}");
        }
    }
}





