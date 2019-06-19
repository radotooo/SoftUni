using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "text.txt";
            var text = File.ReadAllLines(path);

            int count = 1;
            string outputPath = "result.txt";

            var result = new List<string>();

            foreach (var lines in text)
            {
                char[] a = lines.ToCharArray();
                result.Add($"Line {count}:{lines}({a.Where(x => char.IsLetter(x)).Count()})({a.Where(x => char.IsPunctuation(x)).Count()})");
                count++;
            }
            File.WriteAllLines(outputPath,result);
        }
    }
}
               
            

               
                


          
