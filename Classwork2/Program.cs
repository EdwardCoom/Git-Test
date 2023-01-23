using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork2
{
    //-----------------------------------------------------------------
    //   Name:           Zach Coomer
    //   Date:           01/22/2023
    //   Class:          352  
    //   Description:    A number guessing program. 
    //-----------------------------------------------------------------      


    class Program
    {  
    
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            // random number generator
            
            int userGuess = -1;
            int guesses = 0;
            int x;
            int y;

            Console.WriteLine("Select a starting number.");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select a stopping number.");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I am thinking of a number from " + x + " to " + y + ".");

            int num = ranNum.Next(x, y + 1);

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
