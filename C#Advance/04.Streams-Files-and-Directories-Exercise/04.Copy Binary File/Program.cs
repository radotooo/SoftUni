using System;
using System.IO;

namespace _04.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "copyMe.png";
            string copy = "copyMe-copy.png";
            FileStream chek = new FileStream(path,FileMode.Open);

            using (chek)
            {

                using (FileStream streamWriter = new FileStream(copy , FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = chek.Read(byteArray, 0, byteArray.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray,0,size);
                    }
                   

                }

            }
        }
    }
}
