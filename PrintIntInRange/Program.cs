using System;

namespace PrintIntInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PrintIntInRange Program --- Robert Aldridge 2020");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            int[] Array0 = { 1, 5, 2, 1, 10 };
            int Above = 0;
            int Below = 0;
            int TestUserInput = GetUserInput();

            foreach (var num in Array0)
            {
                if (num > TestUserInput)
                {
                    Above++;
                }
                else if (num < TestUserInput)
                {
                    Below++;
                }
            }

            Console.WriteLine("There are " + Above + " Number(s) above and " + Below + " below.");
        }       

        static int GetUserInput()
        {
            Console.WriteLine("Please enter a number. The program will tell you how many numbers inside the array above and below your specified number.");

            string ConsoleInput = Console.ReadLine();
            int UserInputInt;

            Console.WriteLine("inut value was " + ConsoleInput);

            if (int.TryParse(ConsoleInput, out UserInputInt))
            {
                return UserInputInt;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again.");

                return GetUserInput();
            }
        }

    }

}
