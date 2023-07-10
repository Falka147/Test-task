using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_area
{
    internal class Triangle : GeometricFigure
    {
        double firstSide;
        double secondSide;
        double thirdSide;
        bool isRightAngledTriangle;
        double[] array;

        public double FirstSide 
        {
            get { return firstSide; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else
                    firstSide = value;
            }
        }
        public double SecondSide 
        {
            get{ return secondSide; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else
                    secondSide = value;
            }
        }
        public double ThirdSide 
        {
            get { return thirdSide; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else
                    thirdSide = value;
            }
        }
        public double Square 
        { 
            get
            {
                CheckOfAngledTriangle();

                if (isRightAngledTriangle)
                    return array[0] * array[1] / 2;
                else
                {
                    double halfOfPerimeter = (array[0] + array[1] + array[2]) / 2;
                    return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - array[0]) * (halfOfPerimeter - array[1]) * (halfOfPerimeter - array[2]));
                }
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            array = new double[3] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(array);
        }

        private void CheckOfAngledTriangle()
        {
            if (Math.Pow(array[0],2) + Math.Pow(array[1],2) == Math.Pow(array[2],2))
                isRightAngledTriangle = true;
            else
                isRightAngledTriangle = false;
        }

    }
}
