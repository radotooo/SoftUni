using System;
using System.IO;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("sliceMe.txt");

            int num = text.Length / 4;
            int startIndex = 0;

            for (int i = 1; i <= 4; i++)
            {
               
               File.WriteAllText($"text{i}.txt", text.Substring(startIndex,num));
                startIndex += num;
            }
            

        }
    }
}
