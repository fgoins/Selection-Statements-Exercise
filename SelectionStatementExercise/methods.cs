using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class methods
    {
        public static void Game(string[] args) 
        {
            var r = new Random();
            var favnumber = r.Next(1, 20);

            Console.WriteLine("pick a number between 1 and 1000);
            var userinput = int.Parse(Console.ReadLine());

            if (userinput > favnumber)
            {
                Console.WriteLine($"{userinput} too low");
            }
            else if (userinput < favnumber)
            {
                Console.WriteLine($"{userinput} to high");
            }
            else 
            {
                Console.WriteLine("You Guessed it!!!");
            }
        }


    }
}
