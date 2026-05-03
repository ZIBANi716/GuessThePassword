using System;


namespace Угадай_пароль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 3216;

            int attempts = 3;

            Console.WriteLine($"A mini game: guess the four-digit password! You have 3 attempts.");

            while (attempts > 0)
            {
                if(!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("\nYou only need to enter numbers!"); 
                    continue;
                }
                if (input < 1000 || input > 9999)
                {
                    Console.WriteLine("\nEnter a four-digit number!");
                    continue;
                }

                

                if (input == password)
                {
                    Console.WriteLine("\nAccess is allowed!" );
                    break;
                }
                else if (input != password)
                {
                    attempts--;
                    Console.WriteLine("\nWrong,you have more " + attempts + " attempts!");

                }
                
                if (attempts == 0)
                {
                    Console.WriteLine("\nAccess is allowed!");
                }
                
               Console.ReadLine();
            }
        }
    }
}
