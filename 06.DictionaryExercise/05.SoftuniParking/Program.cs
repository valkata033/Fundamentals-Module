using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            for (int i = 0; i <= n; i++)
            {
                string[] inputInfo = input.Split();
                string command = inputInfo[0];
                string username = inputInfo[1];
                if (inputInfo[2] != " ")
                {
                    string licensePlate = inputInfo[2];
                }

                string licensePlate = inputInfo[2];

                if (command == "register")
                {
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }

                if (command == "unregister")
                {
                    if (!dict.ContainsKey(username))
                    {
                        dict.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
