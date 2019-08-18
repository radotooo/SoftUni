using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var circle = new Circle(3);
            circle.Draw();
            //var rec = new Rectangle(4, 5);
            //rec.Draw();
        }
    }
}
