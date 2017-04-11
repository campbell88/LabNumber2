using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number between 1 and 100");
                input = int.Parse(Console.ReadLine());

                if (input < 1 || input > 100)
                {
                    Console.WriteLine("Error: Number not between 1 and 100");
                    Console.ReadKey();
                    continue;
                }



                if (input % 2 == 0)
                {
                    Console.WriteLine("even");

                }

                else
                {
                    Console.WriteLine("odd");



                }

                if (input > 2 && input < 25 && input % 2 == 0) //if input is more than 2 and less than 25 and has no remainder aka is an even number
                {
                    Console.WriteLine("Even and Less than 25");



                }

                Console.ReadKey();
            }



            }
        }
    }

