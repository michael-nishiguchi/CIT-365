using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            string location = "Salt Lake";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");


            DateTime today = DateTime.Today;
            Console.WriteLine("Today is " + today.ToString("MMMM/dd/yyy"));

            DateTime christmas = new DateTime(2020, 12, 25);
            int daysToChristmas = getDays(today, christmas);
            Console.WriteLine($"There are {daysToChristmas} days till Christmas");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nEnter a width");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter a height");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }

        static int getDays(DateTime today, DateTime christmas) {
            if (today == christmas) { return 0; }

            Console.WriteLine(today.AddDays(1));
            int daysToChristmas = 1;
            while(true) {
                if(today.AddDays(daysToChristmas) == christmas) {
                    return daysToChristmas;
                }
                else {
                    daysToChristmas++;
                }
            }
        }
    }
}
