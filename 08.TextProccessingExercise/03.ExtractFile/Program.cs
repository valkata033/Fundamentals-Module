using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();

            int lastSlashIndex = fullPath.LastIndexOf("\\");
            string nameWithExtension = fullPath.Substring(lastSlashIndex + 1);

            int lastPointIndex = nameWithExtension.LastIndexOf(".");
            string extension = nameWithExtension.Substring(lastPointIndex + 1);

            int nameIndex = nameWithExtension.LastIndexOf(".");
            string name = nameWithExtension.Substring(0, nameIndex);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
