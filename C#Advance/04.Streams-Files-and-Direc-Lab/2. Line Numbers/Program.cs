using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("input.txt");

            using (reader)
            {
                var line = reader.ReadLine();
                var count = 1;

                var writer = new StreamWriter("output.txt");

                using (writer)
                {
                    while(line!=null)
                    {
                        writer.WriteLine($"{count}  {line}");
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
