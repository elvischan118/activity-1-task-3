using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // Create an array to store 5 numbers

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    // Add 3 to each number in the array
                    numbers[i] += 3;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement the loop counter to re-enter the current number
                }
            }

            Console.WriteLine("Result after adding 3 to each number:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
