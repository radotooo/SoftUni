using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] firstDate = Console.ReadLine().Split();
            {
                int year = int.Parse(firstDate[0]);
                int month = int.Parse(firstDate[1]);
                int day = int.Parse(firstDate[2]);


                DateTime date1 = new DateTime(year, month, day);


                string[] secondDate = Console.ReadLine().Split();
                int year2 = int.Parse(secondDate[0]);
                int month2 = int.Parse(secondDate[1]);
                int day2 = int.Parse(secondDate[2]);


                DateTime date2 = new DateTime(year2, month2, day2);




                //DateTime date1 = new DateTime(year, month, day);
                //DateTime date2 = new DateTime(year, month, day);
                int daysDiff = Math.Abs(((TimeSpan)(date2 - date1)).Days);
                Console.WriteLine(daysDiff);

            }
        }
    }
}
