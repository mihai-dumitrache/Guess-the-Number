using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Program obj1 = new Program();
            int random_number = obj1.Generate_number();
            obj1.number_compare(random_number);

        }


        //Generate_number function generates a random number from 1 to 100
        int Generate_number()
        {
            Random rng = new Random();
            int rand_nb = rng.Next(1, 100);
            return rand_nb;
        }

        //number_compare function compares the generated number from "Generate_number" function with another number typed
        //by the user
        void number_compare(int nb_generated)
        {
            int nb_of_tries = 1;

            Console.WriteLine("Type a number:");
            int typed_nr;
            string type_nr = Console.ReadLine();
            typed_nr = int.Parse(type_nr);

            while (typed_nr != nb_generated)

            {

                if (typed_nr > nb_generated)
                {
                    Console.WriteLine("Your number is too high. Please try a lower one!");


                    Console.WriteLine("Type another number:");
                    type_nr = Console.ReadLine();
                    typed_nr = int.Parse(type_nr);

                    nb_of_tries++;
                }
                else
                {
                    Console.WriteLine("Your number is too low. Please try a higher one!");

                    Console.WriteLine("Type another number:");
                    type_nr = Console.ReadLine();
                    typed_nr = int.Parse(type_nr);

                    nb_of_tries++;
                }

            }

            Console.WriteLine("Congratulations! You have guessed the number in {0} tries", nb_of_tries);
        }

    }
}
