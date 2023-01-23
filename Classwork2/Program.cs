using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork2
{
    
    


    class Program
    {  
    
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            int userGuess = -1;
            int guesses = 0;

            Console.WriteLine("I am thinking of a number between 0 and 100.");

            int num = ranNum.Next(0, 101);

            while(userGuess != num)
            {
                Console.WriteLine("Try a guess.");
                userGuess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if(userGuess > num)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (userGuess < num)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("That is correct!");
                }
            }

            Console.WriteLine("It took you " + guesses + " guesses to guess the number.");
            
            Console.ReadKey();



        }
    }
}
