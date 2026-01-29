// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System; 
using System.Collections.Generic; 
using System.Text; 
class Solution
{ 
    public static string firstNonRepeating(string s)
     {
         Dictionary<char,int> Dt=new Dictionary<char,int>(); 
         Queue<char> q=new Queue<char>();
          StringBuilder result=new StringBuilder(); 
          foreach(char c in s) 
          {
             if(Dt.ContainsKey(c)) 
             { 
                Dt[c]++;
                 } 
                 else 
                 Dt[c]=1;
                  q.Enqueue(c);
                   while(q.Count>0 && Dt[q.Peek()]>1) 
                   { 
                    q.Dequeue();
                   }
                      if(q.Count==0)
                       {
                         result.Append('#');
                       } 
                     else
                       result.Append(q.Peek()); 
           } 
                           return result.ToString();
     } 

     static void Main()
    {
        Console.WriteLine("Enter a String:");
        string input=Console.ReadLine();

        
        Console.WriteLine(firstNonRepeating(input)) ;
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
dotnet --version
dotnet run
*/
