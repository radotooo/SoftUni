using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get;  set; }
        public string Color { get ; set ; }

        public Seat(string name, string color)
        {
            this.Model = name;
            this.Color = color;
            
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} Seat {this.Model}");
            sb.AppendLine(this.Start());
            sb.Append(this.Stop());
            return sb.ToString();
        }
    }
}
