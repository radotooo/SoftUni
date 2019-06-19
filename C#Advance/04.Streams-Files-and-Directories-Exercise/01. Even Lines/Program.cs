using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("text.txt");
            StringBuilder final = new StringBuilder();
            List<string> hh = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                

                var writer = new StreamWriter("result.txt");
                using (writer)
                {
                    int count = 0;
                    while (line != null)
                    {
                        
                        if (count % 2 == 0)
                        {

                            string[] result = (Regex.Replace(line, "[-,.!?]", "@").ToString()).Split().ToArray(); ;
                            
                            Console.WriteLine(string.Join(" ",result.Reverse()));
                            
                            
                            
                        }
                        line = reader.ReadLine();
                        count++;

                    }
                    


                    
                }



            }
        }
        

    }
}
