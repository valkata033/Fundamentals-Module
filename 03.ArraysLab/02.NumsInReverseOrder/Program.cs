using System;

namespace _02.NumsInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    numbers[i] = number;
            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[numbers.Length - 1 - i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
