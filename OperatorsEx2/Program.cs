using System;

namespace OperatorsEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radis of your circle?");
                var radius = double.Parse(Console.ReadLine());
            var AreaCircle = AreaOfCircle (radius);
            Console.WriteLine($"The area of your circle of {radius} is {AreaCircle}");


        }
        public static double AreaOfCircle (double radius)
        {

            return Math.PI * ( radius * radius);
        }
    }
}
