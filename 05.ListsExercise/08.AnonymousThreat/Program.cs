using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace _08AnonymousThrea
{
    class Program

    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandFirts = commandArr[0];

                if (commandFirts == "merge")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > text.Count - 1)
                    {
                        endIndex = text.Count - 1;
                    }
                    if (startIndex >= text.Count - 1 || endIndex <= 0)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    MergeParts(startIndex, endIndex, text);

                }
                else if (commandFirts == "divide")
                {
                    int index = int.Parse(commandArr[1]);
                    int parts = int.Parse(commandArr[2]);
                    string textToDivide = text[index];
                    text.RemoveAt(index);
                    if (textToDivide.Length % parts == 0)
                    {
                        int dividenum = textToDivide.Length / parts;

                        int count = 0;
                        int curr = 0;
                        while (count != parts)
                        {
                            string kind = textToDivide.Substring(curr, dividenum);
                            curr += dividenum;
                            text.Insert(index + count, kind);
                            count++;

                        }
                    }
                    else if (textToDivide.Length % parts != 0)
                    {
                        int dividenum = textToDivide.Length / parts;

                        int count = 0;
                        int curr = 0;
                        while (count != parts)
                        {
                            string kind = textToDivide.Substring(curr, dividenum);
                            curr += dividenum;
                            text.Insert(index + count, kind);
                            count++;
                            if (count == parts - 1)
                            {
                                kind = textToDivide.Substring(curr, textToDivide.Length - curr);
                                text.Insert(index + count, kind);
                                count++;
                            }

                        }

                    }

                }

                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", text));
        }

        private static void MergeParts(int start, int end, List<string> isManipulate)
        {
            int count = start;
            while (count != end)
            {
                isManipulate[start] += isManipulate[start + 1];
                isManipulate.RemoveAt(start + 1);
                count++;

            }

        }
    }
}