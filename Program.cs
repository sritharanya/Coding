using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose Day (1 or 2 or 3):");
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
        else if (choice==3)
        {
          

    
        Console.Write("Enter total capacity (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of queues (k): ");
        int k = int.Parse(Console.ReadLine());

        KQueues obj = new KQueues(n, k);

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. IsEmpty");
            Console.WriteLine("4. IsFull");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Display all queues");


            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                Console.Write("Enter value: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter queue index: ");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine(obj.Enqueue(x, i));
            }
            else if (opt == 2)
            {
                Console.Write("Enter queue index: ");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine(obj.Dequeue(i));
            }
            else if (opt == 3)
            {
                Console.Write("Enter queue index: ");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine(obj.IsEmpty(i));
            }
            else if (opt == 4)
            {
                Console.WriteLine(obj.IsFull());
            }
            else if (opt == 5)
            {
                break;
            }
            else if (opt == 6)
{
    obj.DisplayQueues();
}

        }
    
        }
     }
    }

