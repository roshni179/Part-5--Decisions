using System;

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

           

            if (angle >= 315 || angle < 45)
                Console.WriteLine("The direction is NORTH");
            else if (angle >= 45 && angle < 135)
                Console.WriteLine("The direction is East");
            else if (angle >= 135 && angle < 225)
                Console.WriteLine("The direction is SOUTH");
            else Console.WriteLine("The direction is WEST");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" PART 2");
            Console.WriteLine("----------------");

            Double hour, minutes, day, charge;
            

            Console.WriteLine("Enter the number of minutes you parked:  ");
            minutes = 
             
                60 minutes == 4.00.

            if (minutes == 60)
                Console.WriteLine("Your charge is $4.00");
            if (minutes > 60)
                Console.WriteLine(" "


         

















        }
    }
}
