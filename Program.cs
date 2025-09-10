using System;

namespace DensityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Density Calculator ===");

            // Ask for mass
            Console.Write("Enter the mass of the object (in kilograms): ");
            double mass = Convert.ToDouble(Console.ReadLine());

            // Ask for volume
            Console.Write("Enter the volume of the object (in cubic meters): ");
            double volume = Convert.ToDouble(Console.ReadLine());

            // Calculate density
            if (volume == 0)
            {
                Console.WriteLine("Error: Volume cannot be zero.");
            }
            else
            {
                double density = mass / volume;
                Console.WriteLine($"The density of the object is {density} kg/m³");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
