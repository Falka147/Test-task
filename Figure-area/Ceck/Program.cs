using Figure_area;

double radius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Figure.Square(radius));

var sides = Console.ReadLine().Split(" ");
Console.WriteLine(Figure.Square(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2])));

Console.ReadKey();