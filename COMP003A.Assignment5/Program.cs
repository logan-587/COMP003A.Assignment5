#nullable disable
/* 
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 5 Assignment
 * 
 */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************************
            // Triangle Section
            PrintSeparator("Triangle Section");

            Console.Write("Enter a single character: ");
            string charGuy = Convert.ToString(Console.ReadLine());
            Console.Write("Enter an integer number: ");
            int nummyGuy = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nRandom Mode? (1 = yes, 2 = no): ");
            int randomDude = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nYour triangle:");

            if(randomDude == 1)
            {
                IsoscelesTriangleBuilder(charGuy, nummyGuy, randomDude);
            }
            else if(randomDude == 2)
            {
                IsoscelesTriangleBuilder(charGuy, nummyGuy);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bruh");
                Console.ForegroundColor = ConsoleColor.White;
                IsoscelesTriangleBuilder(" :( ", 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you don't get a nice triangle");
                Console.ForegroundColor = ConsoleColor.White;
            }


            //*********************************************************************
            //CharacterInfo Section
            PrintSeparator("Character Info Section");

            Console.Write("\nDid you know? ");
            CharacterInfo("Phil Coulson", 1964);

            Console.WriteLine("You try it now!");
            for(int j = 0; j < 4; j++)
            {
                Console.Write("\nInput a character: ");
                string yourDude = Console.ReadLine();
                Console.Write("Input their birth year: ");
                int dudeAge = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                CharacterInfo(yourDude, dudeAge);
                Console.ForegroundColor = ConsoleColor.White;
            }

            //*********************************************************************
            //End
            PrintSeparator("Goodbye!");

        }




        /// <summary>
        /// Method for outputting nicely formatted sections
        /// </summary>
        /// <param name="message">String input</param>
        static void PrintSeparator(string message)
        {
            Console.WriteLine("\n\n".PadRight(100, '*'));
            Console.WriteLine($"\t{message}");
            Console.WriteLine("".PadRight(100, '*'));
        }


        /// <summary>
        /// Method for making an isosceles triangle of an inputted character
        /// </summary>
        /// <param name="tryGuy">Character</param>
        /// <param name="countyGuy">Counter</param>
        static void IsoscelesTriangleBuilder(string tryGuy, int countyGuy)
        {
            string spare = Convert.ToString(tryGuy);
            for(int i = 1; i <= countyGuy; i++)
            {
                Console.WriteLine($"{tryGuy}");
                tryGuy += spare;
            }
            for (int i = (countyGuy - 1); i > 0; i--)
            {
                Console.WriteLine($"{tryGuy.Substring(countyGuy - (i-1))}");
            }
        }

        /// <summary>
        /// Method for making an isosceles triangle of an inputted character (random version)
        /// </summary>
        /// <param name="tryGuy">Character</param>
        /// <param name="countyGuy">Counter</param>
        /// <param name="funDude">Randomizer</param>
        static void IsoscelesTriangleBuilder(string tryGuy, int countyGuy, int funDude)
        {
            Random randy = new Random();
            string x = "!@#$%^&*()_+-=Ä/ôBô~XW|‼åN≡v☺φ¿○☼◙WE<«♣Ž";

            char spare = Convert.ToChar(tryGuy);
            for (int i = 1; i <= countyGuy; i++)
            {
                Console.WriteLine($"{tryGuy}");
                tryGuy += x[randy.Next(1,41)];
            }
            for (int i = (countyGuy - 1); i > 0; i--)
            {
                Console.WriteLine($"{tryGuy.Substring(countyGuy - (i - 1))}");
            }
        }


        /// <summary>
        /// Calculates Age
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Age</returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Writes how old a favorite character is.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            Console.WriteLine($"{name} turns {AgeCalculator(birthYear)} this year!");
        }


    }
}