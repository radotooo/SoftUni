using System;
using System.IO;
using System.Linq;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo chek = new DirectoryInfo("TestFolder");
            FileInfo[] getFiles = chek.GetFiles();

           

            double totalByteSize = getFiles.Sum(f => f.Length);
           totalByteSize = (totalByteSize / 1024) / 1024;
            Console.WriteLine(totalByteSize);
            File.WriteAllText("ResultInMb.txt", totalByteSize.ToString());

        }
    }
}
