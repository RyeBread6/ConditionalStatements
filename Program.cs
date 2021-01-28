using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Predict the grade you'll earn in ISM4300 (enter this value as an integer 0-100) ...");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /* 
                   This variable will be used to store grades
                   after the input variable is parsed to decimal
                 */
                decimal grades = decimal.Parse(input);
                if (grades < 60)
                {
                    Console.WriteLine("Your predicted grade is F");
                }
                else if ((grades >= 60) && (grades <= 61))
                {
                    Console.WriteLine("Your predicted grade is D-");
                }
                else if ((grades >= 62) && (grades <= 67))
                {
                    Console.WriteLine("Your predicted grade is D");
                }
                else if ((grades >= 68) && (grades <= 69))
                {
                    Console.WriteLine("Your predicted grade is D+");
                }
                else if ((grades >= 70) && (grades <= 71))
                {
                    Console.WriteLine("Your predicted grade is C-");
                }
                else if ((grades >= 72) && (grades <= 77))
                {
                    Console.WriteLine("Your predicted grade is C");
                }
                else if ((grades >= 78) && (grades <= 79))
                {
                    Console.WriteLine("Your predicted grade is C+");
                }
                else if ((grades >= 80) && (grades <= 81))
                {
                    Console.WriteLine("Your predicted grade is B-");
                }
                else if ((grades >= 82) && (grades <= 87))
                {
                    Console.WriteLine("Your predicted grade is B");
                }
                else if ((grades >= 88) && (grades <= 89))
                {
                    Console.WriteLine("Your predicted grade is B+");
                }
                else if ((grades >= 90) && (grades <= 91))
                {
                    Console.WriteLine("Your predicted grade is A-");
                }
                else if ((grades >= 92) && (grades <= 97))
                {
                    Console.WriteLine("Your predicted grade is A");
                }
                else if ((grades >= 98) && (grades <= 100))
                {
                    Console.WriteLine("Your predicted grade is A+");
                }
            } // end of try
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}

