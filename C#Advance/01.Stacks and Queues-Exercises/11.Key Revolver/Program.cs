using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {

             /// 80/100 !!!!!!!!!!!!!!!!!!!!!!1
            int buletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsCount = new Stack<int>(bullets);
            Queue<int> locksCount = new Queue<int>(locks);

            int buletNum = 0;
            int bulletsUsed = 0;
            
            while (locksCount.Count > 0)
            {
                for (int i = 0; i < gunBarrelSize; i++)
                {
                    if(locksCount.Count==0)
                    {
                        break;
                    }
                    if (bulletsCount.Count == 0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locksCount.Count}");
                        return;
                    }
                    else
                    {
                        buletNum = bulletsCount.Pop();
                        bulletsUsed++;
                    }

                    if(buletNum <= locksCount.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locksCount.Dequeue();
                        
                    }
                    else
                    {
                        
                        Console.WriteLine("Ping!");

                    }
                }
               
                if (bulletsCount.Count > 0 )
                {
                    Console.WriteLine("Reloading!");
                }

            }
            decimal totalSumEarned = intelligenceValue - (bulletsUsed * buletPrice);

            Console.WriteLine($"{bulletsCount.Count} bullets left. Earned ${totalSumEarned}");
            
        }
    }
}

                                    //
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace _01._Key_Revolver
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int pricePerBullet = int.Parse(Console.ReadLine());
//            int barrelSize = int.Parse(Console.ReadLine());
//            int[] bulletsArr = Console.ReadLine()
//                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();
//            Stack<int> bullets = new Stack<int>(bulletsArr);

//            int[] locksArr = Console.ReadLine()
//                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();

//            Queue<int> locks = new Queue<int>(locksArr);

//            int value = int.Parse(Console.ReadLine());
//            int counter = 0;

//            while (locks.Count > 0 && bullets.Count > 0)
//            {
//                var bullet = bullets.Pop();

//                if (bullet <= locks.Peek())
//                {
//                    Console.WriteLine("Bang!");
//                    locks.Dequeue();
//                }
//                else
//                {
//                    Console.WriteLine("Ping!");
//                }

//                counter++;

//                if (counter % barrelSize == 0 && bullets.Count > 0)
//                {
//                    Console.WriteLine("Reloading!");
//                }
//            }

//            if (locks.Count == 0)
//            {
//                int initialBulletsCount = bulletsArr.Length;
//                int spentForBullets = counter * pricePerBullet;
//                int result = value - spentForBullets;
//                Console.WriteLine($"{bullets.Count} bullets left. Earned ${result}");
//            }
//            else
//            {
//                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
//            }
//        }
//    }
//}