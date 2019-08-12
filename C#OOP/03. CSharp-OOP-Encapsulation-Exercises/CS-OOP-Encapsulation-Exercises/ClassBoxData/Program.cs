using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            

            //Console.WriteLine(box.GetSurfaceArea());
            //Console.WriteLine(box.GetLateralSurfaceArea());
            //Console.WriteLine(box.GetVolume());
            try
            {
                var box = new Box(length, width, height);
                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralSurfaceArea());
                Console.WriteLine(box.GetVolume());


            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
