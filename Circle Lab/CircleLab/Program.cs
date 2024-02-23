
using CircleLab;
using System.Net.NetworkInformation;



Console.WriteLine("Welcome to the Circle Tester");
Console.Write("Enter radius: ");
double radius = double.Parse(Console.ReadLine());
Circle circle = new Circle(radius);
//add validation here for valid radius entered
bool grow = true;

while (grow)
{
    Console.WriteLine($"Diameter: {circle.CalculateDiameter(radius)}");
    Console.WriteLine($"Circumference: {circle.CalculateCircumference(radius)}");
    Console.WriteLine($"Area: {circle.CalculateArea(radius)}");

    Console.WriteLine("Should the circle grow? (y/n)");
    grow = Console.ReadLine().ToLower().Trim() == "y";

    if (grow == true)
    {
        circle.Grow();
        Console.WriteLine("The circle is magically growing!");
        radius = circle.GetRadius();
    }
    else
    {
        grow = false;
        Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}");
    }
}

Console.ReadKey();
//bool validRadius(double radius)
//{
//   try 

//     catch?
//}