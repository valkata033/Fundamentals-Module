using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02.ChangeList
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

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Delete")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (commandArgs[0] == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);
                    numbers.Insert(position, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
