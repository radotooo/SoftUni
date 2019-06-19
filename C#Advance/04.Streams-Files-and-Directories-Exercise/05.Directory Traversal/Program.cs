using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Directory.GetFiles(".", "*.*");

            var info = new Dictionary<string, Dictionary<string, double>>();

            var dirInfo = new DirectoryInfo(".");
            var files = dirInfo.GetFiles();

            foreach (var fileInfo in files)
            {
                double size = fileInfo.Length / 1024d;
                string fileName = fileInfo.Name;
                string extension = fileInfo.Extension;

                if (!info.ContainsKey(extension))
                {
                    info.Add(extension,new Dictionary<string, double>());
                }

                if (!info[extension].ContainsKey(fileName))
                {
                    info[extension].Add(fileName,size);
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";
            var sortedDictionary = info.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (item,value) in sortedDictionary)
            {
                File.AppendAllText(path,item+Environment.NewLine);
                foreach (var d in value.OrderBy(x=>x.Value))
                {
                File.AppendAllText(path,$"--{d.Key} - {Math.Round(d.Value,3)}kb"+Environment.NewLine);

                }
            }

        }
    }
}
