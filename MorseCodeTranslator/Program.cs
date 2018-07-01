using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(": ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output;

                if (input[0] == '.' || input[0] == '-')
                {
                    output = MorseCodeTranslator.ToText(input);
                }
                else
                {
                    output = MorseCodeTranslator.toMorse(input);
                }

                Console.WriteLine(output);
            }
        }
    }
}
