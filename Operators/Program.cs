using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine("First Problem:");
                Console.WriteLine("17 / 4 and the calculated remainder");
                Console.WriteLine($"{a}/{quotient} is {b} remainder {remainder}  ");
                Console.WriteLine("------------");
            }

            Console.WriteLine("Second Problem:");
            Console.WriteLine("Let me calculate the area of your circle");
                Console.WriteLine("But first enter the radius of yor circle ");
                var userInput = Console.ReadLine();

                var radius = double.Parse(userInput);

                AreaOfCircle(radius);
                                                       
            static double AreaOfCircle(double radius)
            {
                var area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"The area of your circle is: {area}");

                return area;
            }
        }
       
    }
}
