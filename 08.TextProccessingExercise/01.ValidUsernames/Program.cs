using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currUsername in input)
            {
                if (currUsername.Length < 3 || currUsername.Length > 16)
                {
                    continue;
                }

                bool isValid = false;

                foreach (var symbol in currUsername)
                {
                    if (!(char.IsLetterOrDigit(symbol) ||
                        symbol == '-' || symbol =='_'))
                    {
                        isValid = false;
                        break;
                    }
                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine(currUsername);
                }
            }
        }
    }
}
