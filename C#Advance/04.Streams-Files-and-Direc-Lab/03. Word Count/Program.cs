using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new StreamReader("words.txt");

            using (words)
            {
                var wordsInput = words.ReadToEnd();
                List<string> listOfWords = wordsInput.Split().ToList();

                var input = File.ReadAllText("text.txt");

                foreach (var word in listOfWords)
                {
                    string pattern = ($@"\b{word}\b");
                    var matches = Regex.Matches(input.ToLower(), pattern);

                    Console.WriteLine($"{word} - {matches.Count()}");
                }

            }


        }
    }
}












