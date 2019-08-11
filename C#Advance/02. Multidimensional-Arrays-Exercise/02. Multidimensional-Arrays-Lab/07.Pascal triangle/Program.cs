using System;
using System.Numerics;

namespace _07.Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger  c = 1;

            BigInteger[][] matrix = new BigInteger[input][];
            matrix[0] = new BigInteger[] { 1 };
           
            for (int i = 0; i < input; i++)
            {
                matrix[i] = new BigInteger[i + 1];
                for (int g = 0; g <= i; g++)
                {
                    
                    if (g == 0 || i == 0)
                    {
                        c = 1;
                        matrix[i][g] = c;
                    }
                    else
                    {
                        c = c * (i - g + 1) / g;
                        matrix[i][g] = c;
                    }
                    
                }
                
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }

    }
}
