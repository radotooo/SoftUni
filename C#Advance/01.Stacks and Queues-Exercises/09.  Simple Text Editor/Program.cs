using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _09.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int blabla = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            int count = 0;

            for (int i = 0; i < blabla; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                int order = int.Parse(commands[0]);
                if (order == 1)
                {
                    text.Push(sb.ToString());
                    sb.Append(commands[1]);
                    
                }
                else if (order == 2)
                {
                    text.Push(sb.ToString());
                    int lettersToRemove = int.Parse(commands[1]);
                    sb.Remove(sb.Length - lettersToRemove , lettersToRemove);
                    
                }
                else if (order == 3)
                {
                    int lettersToRemove = int.Parse(commands[1]);
                    for (int h = 0; h < sb.Length; h++)
                    {
                        if (h == lettersToRemove - 1)
                        {
                            Console.WriteLine(sb[h]);
                            continue;
                        }
                    }
                }
                else if (order == 4)
                {
                    //count++;
                    //if (count > 1)
                    //{
                        string thisy = text.Pop();
                        sb.Clear();
                        sb.Append(thisy);
                        continue;
                    //}
                    //else
                    //{
                    //    text.Pop();
                    //    string thisy = text.Pop();
                    //    sb.Clear();
                    //    sb.Append(thisy);
                    //    continue;
                    //}


                }
                count = 0;


            }


        }
    }
}
