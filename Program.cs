using System;
using System.ComponentModel;

namespace Part_5__Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;

            Console.Write("Enter a angle (0 - 360): ");

            while (!double.TryParse(Console.ReadLine(), out angle))
                Console.WriteLine(" Invalid number, please try again");



            if (angle <= 315 && angle < 45)
                Console.WriteLine("The direction is NORTH");
            else if (angle >= 45 && angle < 135)
                Console.WriteLine("The direction is East");
            else if (angle >= 135 && angle < 225)
                Console.WriteLine("The direction is SOUTH");
            else if (angle >= 225 && angle < 315) 
             Console.WriteLine("The direction is WEST");
            else if (angle > 315)
                Console.WriteLine("Invalid input");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" PART 2");
            Console.WriteLine("----------------");

            Double hours, minutes, day, cost;


            Console.WriteLine("Enter the number of minutes you parked:  ");
            while (!double.TryParse(Console.ReadLine(), out minutes) || minutes < 0)
                Console.WriteLine(" Invalid number, please try again");

           hours = Math.Ceiling (minutes / 60);
            

            if (hours == 1)
            {
                cost = 4.0;
            }
            else if (hours >= 10)
            {
                cost = 20.0;
            }
            else
            {
                cost = 4.0 + (hours - 1) * 2.0;
            }

            Console.WriteLine($"You are being charged for {hours} hours.");
            Console.WriteLine($"Total cost: ${cost}");


            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("PART 3: Hurricane");
            int category;


            Console.WriteLine("Enter a number from 1-5 to see the intensity of hurricane: ");

            while (!int.TryParse(Console.ReadLine(), out category))
                Console.WriteLine(" Invalid number, please try again");
            Console.WriteLine();

            switch (category)
            {
                case 1:
                    Console.WriteLine("74 - 95 mph or  64-82kt or 119-153 km/hour");
                    break;
                case 2: Console.WriteLine("92 - 110 mph or 83-95kt or 154-177 km/hour");
                    break;
                case 3: Console.WriteLine("110-130 mph or 96-113kt or 178-209 km/hour");
                    break;
                case 4: Console.WriteLine("131-155 mph or 113-135 kt or 210-249km/hour");
                    break;
                default:
                case 5: Console.WriteLine("greater than 155mph or 135 kt or 249 km/hour");
                    break;
            }
            















        }
    }
}
