using System;
using System.Collections.Generic;

namespace _08.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<string> queue = new Queue<string>();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }
            //if (input.Length < 2)
            //{
            //    Console.WriteLine("NO");
            //    return;
            //}
            foreach (char c in input)
            {
                if (c == '{' || c == '(' || c == '[' )
                {
                    stack.Push(c);
                }
                else if ((c == ')' || c == '}' || c == ']' ) && stack.Count > 0)
                {
                    if (stack.Peek() == '(' && c == ')' || stack.Peek() == '{' && c == '}' || stack.Peek() == '[' && c == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                break;
            }

            Console.WriteLine("YES");

            // for (int i = 0; i < input.Length; i++)
            // {
            //     if(input[i] == )
            //}

            // for (int i = 0; i < input.Length; i++)
            // {
            //     string symbol = queue.Peek();
            //     string symbol2 = stack.Peek();


            // if (symbol == "{" && symbol2 != "}")
            // {
            //     Console.WriteLine("NO");
            //     return;
            // }
            //else if (symbol == "(" && symbol2 != ")")
            // {
            //     Console.WriteLine("NO");
            //     return;
            // }
            // else if (symbol == "[" && symbol2 != "]")
            // {
            //     Console.WriteLine("NO");
            //     return;
            // }
            // else if (symbol == " " && symbol2 != " ")
            // {
            //     Console.WriteLine("NO");
            //     return;
            // }
            // queue.Dequeue();
            // stack.Pop();

        }

    }
}

