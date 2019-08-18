using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Model = "488-Spider";
        public string DriverName { get ; set ; }

        public Ferrari(string name)
        {
            this.DriverName = name;
        }

        public string PushGas()
        {
            return "Gas!";
        }

        public string UseBreaks()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Model);
            sb.Append("/");
            sb.Append(this.UseBreaks());
            sb.Append("/");
            sb.Append(this.PushGas());
            sb.Append("/");
            sb.AppendLine(this.DriverName);
            return sb.ToString();
        }
    }
}
