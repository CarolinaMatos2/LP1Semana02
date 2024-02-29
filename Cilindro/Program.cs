using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the cylinder: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Enter the radius of the cylinder: ");
            float radius = float.Parse(Console.ReadLine());

            float V = Math.PI * Math.Pow(radius, 2) * height;
            float Sa = 2 * Math.PI * radius * (radius + height);

            Console.WriteLine($"The volume of the cylinder {V:F2}");
            
        }
    }
}
