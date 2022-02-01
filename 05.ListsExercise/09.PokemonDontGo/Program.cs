using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int index = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                if (index < 0)
                {
                    int current = inputList[0];
                    sum += current;

                    inputList.RemoveAt(inputList[0]);
                    inputList.Insert(inputList[0], inputList[inputList.Count - 1]);

                    Elements(inputList, current);
                }
                else if (index > inputList.Count - 1)
                {
                    int current = inputList[inputList.Count - 1];
                    sum += current;

                    inputList.Insert(inputList.Count - 1, inputList[0]);
                    inputList.RemoveAt(inputList.Count - 2);

                    Elements(inputList, current);
                }
                else
                {
                    sum += inputList[index];

                    int currentNumber = inputList[index];

                    inputList.RemoveAt(index);

                    Elements(inputList, currentNumber);
                }

                if (inputList.Count == 0)
                {
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }

        private static void Elements(List<int> inputList, int currentNumber)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] <= currentNumber)
                {
                    inputList[i] += currentNumber;
                }
                else if (inputList[i] > currentNumber)
                {
                    inputList[i] -= currentNumber;
                }
            }
        }
    }
}
