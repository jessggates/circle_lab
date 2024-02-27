
using CircleLab;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to the Circle Tester");

double radius = 0;
bool validRadius = false;

do
{
    Console.Write("Enter radius: ");
    string input = Console.ReadLine();
    validRadius = TryParse(input, out radius);
    if (validRadius == false)
    {
        Console.WriteLine("That is not a valid radius, please enter a number.");
    }
    else
    {
        Circle circle = new Circle(radius);
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
    }
} while (validRadius == false);


static bool TryParse(string stringToParse, out double result)
{
    return double.TryParse(stringToParse, out result);
}

Console.ReadKey();
