using System;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;

            var adding = (a + b);
            var subtracting = (a - b);
            var multiplying = (a * b);
            var quotient = (a / b);
            var remainder = (a % b);

           
            Console.WriteLine($"{adding} {subtracting} {multiplying} {quotient} {remainder}");
            var x = AreaOfCircle(3);
            Console.WriteLine(x);
            Console.WriteLine(AreaOfCircle(3));
            Console.WriteLine("Give me a radius and I will give you the area of the circle");
            var y = int.Parse(Console.ReadLine());
        }

        public static double AreaOfCircle(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    

}
