using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                
                if (commandArgs[0] == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                }

                else if (commandArgs[0] == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    numbers.Insert(index, number);
                }

                else if (commandArgs[0] == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    numbers.RemoveAt(index);
                }

                else if (commandArgs[1] == "left")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstElement = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElement);
                    }
                }

                else if (commandArgs[1] == "right")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int j = 0; j < count; j++)
                    {
                        int lastElement = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElement);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
