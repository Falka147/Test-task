namespace Figure_area
{
    public static class Figure
    {
        public static double Square(double radius)
        {
            GeometricFigure figure = new Circle(radius);
            return figure.Square;
        }

        public static double Square(double firstSide, double secondSide, double thirdSide) 
        {
            GeometricFigure figure = new Triangle(firstSide, secondSide, thirdSide);
            return figure.Square;
        }
    }
}