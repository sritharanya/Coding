using System;
using System.Collections.Generic;
using System.Text;

class Day1
{
    public static string FirstNonRepeating(string s)
    {
        Dictionary<char, int> dt = new();
        Queue<char> q = new();
        StringBuilder result = new();

        foreach (char c in s)
        {
            if (dt.ContainsKey(c))
                dt[c]++;
            else
                dt[c] = 1;

            q.Enqueue(c);

            while (q.Count > 0 && dt[q.Peek()] > 1)
                q.Dequeue();

            result.Append(q.Count == 0 ? '#' : q.Peek());
        }

        return result.ToString();
    }
}

/*
We process the string character by character like a stream.

We use a dictionary to store the frequency of each character and a queue to maintain the order in which characters appear.

For every new character, we increment its frequency and push it into the queue.

Then we remove characters from the front of the queue if their frequency is more than one, because they are repeating.

The front of the queue always represents the first non-repeating character at that point.

If the queue becomes empty, we append #; otherwise, we append the front character.

This approach runs in O(n) time and uses O(n) space.
--version
*/