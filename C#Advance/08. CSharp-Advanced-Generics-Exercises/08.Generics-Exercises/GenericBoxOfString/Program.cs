using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int command = int.Parse(Console.ReadLine());
                
                 Box<int>.MyMethod(command);


            }
        }
    }
}
