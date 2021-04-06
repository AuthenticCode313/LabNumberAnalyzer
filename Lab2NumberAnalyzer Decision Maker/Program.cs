using System;

namespace Lab2NumberAnalyzer_Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            Console.WriteLine("Welcome to the Number Analyzer - Decision Maker");
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            do
            {
                Console.WriteLine(name +" select a number between 1-100: ");
                int num = int.Parse(Console.ReadLine());
                int newNum = num % 2;

                if (newNum != 0 && num <= 100)
                {
                    Console.WriteLine(name + " the number " + num + " is Odd.");
                }
                else if (newNum == 0 && num >= 2 && num <= 25)
                {
                    Console.WriteLine(name + " the number " + num + " is Even and less than 25.");
                }
                else if (newNum == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine(name + " the number is Even.");
                }
                else if (newNum == 0 && num >= 60 && num <= 100)
                {
                    Console.WriteLine(name + " the number " + num + " is Even");
                }
                else if (newNum != 0 || num >= 60 || num < 100)
                {
                    Console.WriteLine(name + " the number " + num + " is odd.");
                }
                else if (newNum > 100)
                {
                    Console.WriteLine("Please provide a number 1-100.");
                }
                else 
                {
                    Console.WriteLine(name + " please enter a valid number.");
                }

                Console.WriteLine(name +" would you like to continue? y/n");

                while (true)
                {
                    string result = Console.ReadLine();
                    if (result == "y")
                    {
                        break;// Continue program
                    }
                    else if (result == "n")
                    {
                        Console.WriteLine(name + " this concludes the Number Analyzer Decision Maker Program.");
                        runProgram = false;
                        break;// End program 
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n");
                    }

                }
    
              } while (runProgram);
        }
    }
}

