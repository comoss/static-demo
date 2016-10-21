using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q" )
            {
                Console.WriteLine("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit to quit");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temperature: ");
                        fahrenheit = Tempurature.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        celsius = Tempurature.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;
                    case "q":
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }

            }

        }
    }
}
