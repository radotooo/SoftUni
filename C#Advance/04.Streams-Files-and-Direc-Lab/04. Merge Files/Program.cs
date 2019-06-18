using System;
using System.Collections.Generic;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstText = File.ReadAllLines("FileOne.txt");
            var cesondText = File.ReadAllLines("FileTwo.txt");

            List<string> result = new List<string>();
            for (int i = 0; i < firstText.Length; i++)
            {
               
                    result.Add(firstText[i]);

               
               
                    result.Add(cesondText[i]);
                
                    
            }
            File.WriteAllLines("result.txt", result);
          
        }
    }
}
