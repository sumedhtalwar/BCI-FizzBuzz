using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzApp.Helper;
using System.Diagnostics;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {

            char again = 'y';


            try
            {
                while (again == 'y' || again == 'Y')
                {
                    Console.Write(" Enter a Number:");
                    string input = Console.ReadLine();

                    if (input.ValidateInputFizzBuzz())
                        Console.WriteLine("Computing fizzbuzz: {0}", new FizzBuzzLogic().DoFizzBuzz(Convert.ToInt32(input)));
                    else

                        Console.WriteLine("Invalid Input");


                    Console.Write(" Do you wish to continue? Y/N ");
                    again = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

}
