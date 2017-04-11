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
            Console.WriteLine("Please enter a number between 1 and 100");
            input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("even");

            }

            else
            {
                Console.WriteLine("odd");



            }





            }
        }
    }

