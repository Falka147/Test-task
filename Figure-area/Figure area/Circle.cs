using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_area
{
    internal class Circle : GeometricFigure
    {
        double radius;
        double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else
                    radius = value;
            }
        }

        public double Square
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public Circle(double radius) 
        {
            Radius = radius;
        }
    }
}
