// Print odd sum of sequential numbers in an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[8];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter {8 - i} numbers: ");
                arr[i] = Convert.ToInt32(getAnumber());
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (((arr[i] + arr[i + 1]) % 2) != 0)
                {
                    Console.Write("{0},{1}", arr[i], arr[i + 1]);
                    Console.Write("  ");
                }
            }



        }
        static string getAnumber()
        {
            int i;
            string input;
            do
            {
                input = Console.ReadLine();
                for (i = 0; i < input.Length; i++)
                    if (!(input[i] >= 48 && input[i] <= 57))
                    {
                        Console.WriteLine("Try again...");
                        break;
                    }
            } while (i < input.Length);
            return input;

        }
    }
}


