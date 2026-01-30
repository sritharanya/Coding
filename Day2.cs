using System;
using System.Collections.Generic;

class Day2
{
    public static void RearrangeQueue(Queue<int> q)
    {
        Queue<int> firstHalf = new();
        int half = q.Count / 2;

        for (int i = 0; i < half; i++)
            firstHalf.Enqueue(q.Dequeue());

        while (firstHalf.Count > 0)
        {
            q.Enqueue(firstHalf.Dequeue());
            q.Enqueue(q.Dequeue());
        }
    }
}
