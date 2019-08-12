using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double  width;
        private double height;




        public double Height    
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public void ValidateSides(double value)
        {
           
            
        }

        public double  Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public Box(double len , double wid , double hei)
        {
            this.Length = len;
            this.Width = wid;
            this.Height = hei;
        }

        public string SurfaceArea()
        {
            double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;

            return $"Surface Area - {surfaceArea:F2}";

        }
        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * length * height + 2 * width * height;

            return $"Lateral Surface Area - {lateralSurfaceArea:F2}";


        }
        public string GetVolume()
        {
            double volume = length * width * height;

            return $"Volume - {volume:F2}";
        }
    }
}
