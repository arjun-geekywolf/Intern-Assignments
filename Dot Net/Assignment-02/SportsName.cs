using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class SportsName
    {
        char character;
        public void PrintSportsName()
        {
            Console.WriteLine("\n\n\nInput a character from console and display the sports name corresponding to it\n");

            Console.WriteLine("Enter a character: ");
            if (char.TryParse(Console.ReadLine(), out character))
            {
                switch (character)
                {
                    case 'c':
                        {
                            Console.WriteLine("Cricket");
                            break;
                        }
                    case 'f':
                        {
                            Console.WriteLine("Football");
                            break;
                        }
                    case 'h':
                        {
                            Console.WriteLine("Hockey");
                            break;
                        }
                    case 't':
                        {
                            Console.WriteLine("Tennis");
                            break;
                        }
                    case 'b':
                        {
                            Console.WriteLine("Badminton");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid character");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Enter a valid character");
            }
        }
    }
}
