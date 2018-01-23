using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName, UserEntry;
            int UserNumber;
            string DoAgain;
            bool Exit = false;

            Console.WriteLine("Hello there! What should I call you?");
            UserName = (Console.ReadLine());

            while (!Exit)
            {
                Console.WriteLine($"Thank you, {UserName}. Please enter a positive integer between 1 and 100.");
                UserEntry = (Console.ReadLine());

                if (int.TryParse(UserEntry, out int Result) == true)
                {
                    UserNumber = int.Parse(UserEntry);
                    if (UserNumber > 0 && UserNumber <= 100)
                    {
                        if (UserNumber % 2 != 0 && UserNumber > 60)
                        {
                            Console.WriteLine($"{UserNumber} is Odd.");
                        }
                        else if (UserNumber % 2 != 0 && UserNumber <= 60)
                        {
                            Console.WriteLine($"{UserNumber} is Odd.");
                        }
                        else if (UserNumber % 2 == 0 && UserNumber < 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else if (UserNumber % 2 == 0 && UserNumber >= 26 && UserNumber <= 60)
                        {
                            Console.WriteLine("Even.");
                        }
                        else
                        {
                            Console.WriteLine($"{UserNumber} is Even.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("You did not enter a positive integer between 1 and 100. Please try again.");
                        Main(args);
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter an integer value. Please enter a whole number between 1 and 100. Do not use a decimal.");
                    Main(args);
                }

                Console.WriteLine($"Would you like to run this program again, {UserName}? (Y or N)");
                DoAgain = (Console.ReadLine());

                if (DoAgain == "Y" || DoAgain == "y")
                {
                    Exit = false;
                }
                else if (DoAgain == "N" || DoAgain == "n")
                {
                    Exit = true;
                    Console.WriteLine($"Thanks for using this program, {UserName}. Goodbye!");
                    Console.Read();
                }
                else
                {
                    Exit = true;
                    Console.WriteLine($"You did not enter Y or N, {UserName}. Thanks for using this program. Goodbye!");
                    Console.Read();
                }
            }
        }
    }
}
