using System;

namespace Delivarable_2_ISM_4300
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15:");
                int length = int.Parse(Console.ReadLine());

                if (length >= 5 && length <= 15)
                {
                    int[] array = Method1(length);
                    Console.WriteLine("The elements of the array are:");
                    DisplayArray(array);

                    int sum = Method2(array);
                    Console.WriteLine("The sum is: " + sum);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static int[] Method1(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51);
            }
            return array;
        }

        static int Method2(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        static void DisplayArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}