using System;
using System.Linq;

namespace _04.ReverseArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();

            Console.WriteLine(String.Join(" ", strings));


        }
    }
}
