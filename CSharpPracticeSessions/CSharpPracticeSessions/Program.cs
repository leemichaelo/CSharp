using System;

namespace CSharpPracticeSessions
{
    class Program
    {
        //Multiplication Calculator
        static void Main(string[] args)
        {
            // TODO Switch to using "continue" and "break" 
            // to control the flow of execution through the program.            

            while (true)
            {
                // TODO Update the text "Enter a number: " to 
                // "Enter a number between 1 and 1000: ".
                Console.Write("Enter a number: ");
                var entry = Console.ReadLine();

                // TODO Force the user's provided value for the "entry" variable 
                // to lowercase letters so the user can type the text "quit"
                // in any of the possible formats.
                if (entry.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    try
                    // TODO Add a try/catch statement
                    {
                        // TODO Allow the user to enter a fractional value.
                        double number = double.Parse(entry);

                        // TODO If the user enters a value less than or equal to "0"
                        // then display the message 
                        // "Please enter a number greater than '0'."
                        if (number < 0)
                        {
                            Console.WriteLine("Please enter a number greater than '0'.");
                            continue;
                        }
                        // TODO If the user enters a value greater than "1000"
                        // then display the message 
                        // "Please enter a number less than or equal to '1000'."
                        else if (number > 1000)
                        {
                            Console.WriteLine("Please enter a number less than or equal than '1000'.");
                            continue;
                        }
                        else
                        {
                            double result = number * number;
                            Console.WriteLine(number + " multiplied by itself is equal to " + result + ".");
                        }
                    }
                    // Handle FormatException exceptions by displaying the text 
                    // "'[user's entry value]' is not a number
                    catch (FormatException)
                    {
                        Console.WriteLine(entry + " is not a valid number!");
                    }
                }
            }
            Console.WriteLine("Goodbye!");
        }

        /*Simple Input Output example
        static void Main(string[] args)
        {
            // TODO Declare and assign a "thing" string variable.
            // Example: "movie", "book", "color", etc.
            string thing = "movie";

            // TODO Prompt the user with the text "What is your name?" 
            Console.Write("What is your name? ");
            // and assign their value to a "name" string variable.         
            var name = Console.ReadLine();

            // TODO Prompt the user with the text 
            // "What is your favorite <thing>?" 
            Console.Write("What is your favorite " + thing + "? ");
            // and assign their value to a "favoriteThing" string variable.
            var favoriteThing = Console.ReadLine();

            // TODO Write the user's name and favorite thing to the console.
            // Example: "My name is James and my favorite movie is Toy Story."
            Console.WriteLine("My name is " + name + " and my favorite " + thing + " is " + favoriteThing + ".");
        }
        */
    }
}
