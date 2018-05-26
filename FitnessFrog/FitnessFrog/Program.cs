using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Variables
            var runningTotal = 0.0;

            //Loop until user types quit
            while (true)
            {
                //Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");

                //Accept users minutes
                var entry = Console.ReadLine();

                //Check to see if user typed quit
                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    //Parse users input into double
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a Ninja Warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Now you're just showing off!");
                    }

                    //Add minutes excersised to total
                    runningTotal += minutes;

                    //Display total minutes excersised to screen
                    Console.WriteLine("You've Exercised " + runningTotal + " minutes.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid input");
                    continue;
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
