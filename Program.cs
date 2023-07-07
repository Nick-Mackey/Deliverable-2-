using System;

namespace Deliverable__2_
{
    internal class Program
    {
        static Random random = new Random();

        static int[] random_array(int array_len)
        {
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int input = 0; // Assign an initial value to input
            bool validInput = false;
            do
            {
                Console.WriteLine("Enter an integer between 5 and 15");
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input >= 5 && input <= 15)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a value between 5 and 15.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!validInput);

            int[] sampleArray = random_array(input);

            Console.WriteLine("The elements in the random array are: ");
            foreach (int element in sampleArray)
            {
                Console.WriteLine(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: " + sum(sampleArray));
        }
    }
}