using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public int Weight { get; set; }
        public string  Color { get; set; }
        public Engine Engine { get; set; }

        //public override string ToString()
        //{
        //return $"{Model}:{Environment.NewLine} {Engine.Model}:{Environment.NewLine}" +
        //    $"  Power: {Engine.Power}{Environment.NewLine}  Displacement: {Chek(Engine.Displacement)}{Environment.NewLine}" +
        //    $"  Efficiency: {Engine.Efficiency}{Environment.NewLine} Weight: {Chek(Weight)}{Environment.NewLine} Color: {Color}";


        //}
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Model}:");
            builder.AppendLine($" {Engine.Model}:");
            builder.AppendLine($"  Power: {Engine.Power}");
            builder.AppendLine($"  Displacement: {Chek(Engine.Displacement)}");
            builder.AppendLine($"  Efficiency: {Engine.Efficiency}");
            builder.AppendLine($"  Weight: {Chek(Weight)}");
            builder.Append($"  Color: {Color}");
            return builder.ToString();





        }

        public string Chek (int Weight)
        {
            if(Weight==0)
            {
                return "n/a";
            }
            else
            {
                return Weight.ToString();
            }
            
        }

    }
}
