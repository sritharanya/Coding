using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose Day (1 or 2):");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine(Day1.FirstNonRepeating(input));
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter numbers (example: 2431):");
            string input = Console.ReadLine();

            Queue<int> q = new();
            foreach (char c in input)
                q.Enqueue(c - '0');

            Day2.RearrangeQueue(q);

            Console.Write("Output: ");
            foreach (int x in q)
                Console.Write(x);
        }
    }
}
