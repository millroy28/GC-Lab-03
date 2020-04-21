using System;

namespace GC_Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Introduction to user and prompt for name
            Console.WriteLine("Please tell me what you would like to be called: ");
            string userName = Console.ReadLine();

            
            bool userContinue = true;
            while (userContinue)
            {
                // INPUT - prompt user for integer between 1 and 100
                int userNum = 0;
                while (userNum < 1 || userNum > 100)
                {
                    Console.WriteLine($"Hello {userName}, please enter a whole number between 1 and 100: ");
                    string userIn = Console.ReadLine();
                    userNum = int.Parse(userIn);
                }

            
                // Decision tree and Output
                bool isEven = userNum % 2 == 0;
                bool isUnder25 = userNum < 25;
                bool is60OrOver = userNum >= 60;

                if (isEven)
                {
                    if (isUnder25)
                        Console.WriteLine("Even and less than 25.");
                    else if (is60OrOver)
                        Console.WriteLine($"{userNum}, Even.");
                    else
                        Console.WriteLine("Even.");
                }
                else
                    Console.WriteLine($"{userNum}, Odd.");
                

                
                // Prompt user for continue / end

                while (true)
                {
                    Console.WriteLine($"Would you like to enter another number, {userName}? Y/N:");
                    string contInput = Console.ReadLine();

                    if (contInput.ToLower() == "y")
                    {
                        userContinue = true;
                        break;
                    }
                    else if (contInput.ToLower() == "n")
                    {
                        userContinue = false;
                        break;
                    }
                    else
                        continue;
                }
                
            }

            Console.WriteLine($"Thank you, {userName}, I declare that this program is now officially ended.");

        }
    }
}
