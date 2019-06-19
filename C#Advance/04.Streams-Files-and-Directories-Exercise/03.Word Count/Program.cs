using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllLines("words.txt");
            var text = File.ReadAllText("text.txt");

            var result = new Dictionary<string,int>();

            foreach (var word in words)
            {
                var gg = Regex.Matches(text.ToLower(), $@"\b{word}\b");

                result[word]=gg.Count();

                
            }

            foreach (var i in result)
            {
                File.AppendAllText("actualResults.txt", $"{i.Key} - {i.Value}{Environment.NewLine}");
            }


            foreach (var i in result.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText("expectedResult.txt", $"{i.Key} - {i.Value}{Environment.NewLine}");
            }
        }
    }
}
