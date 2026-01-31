/*
n=4
k=2
q=8
q[][]
1 5 0
1 3 0
1 1 1
2 0
1 4 1
1 1 0
3 1
4
*/
/*
You made k queues using an array of Queue<int>.
n is the maximum total elements allowed.
size keeps track of how many elements are currently stored across all queues.
enqueue(x, i) adds x to queue i only if size < n.
dequeue(i) removes and returns the front element from queue i, or -1 if empty.
isEmpty(i) checks if a specific queue is empty.
isFull() checks if total elements equal n.
*/
/*
using System;
using System.Collections.Generic;

class KQueues {
    readonly int n;
    private readonly int k;
    readonly Queue<int>[] q;
int size=0;
    public KQueues(int n, int k) {
        // Initialize your data members
        this.n=n;
        this.k=k;
      
       
      q=new Queue<int>[k];
        for (int i=0;i<k;i++)
        {
      q[i]=new Queue<int>();
       
        }
        
    }

    public bool Enqueue(int x, int i) {
        // Enqueue element x into queue number i
        if (size==n)
        {
        return false;
        }
        else
        {
        q[i].Enqueue(x);
        size++;
        return true;
        }
        
        
    }

    public int Dequeue(int i) {
        // Dequeue element from queue number i
        if(q[i].Count>0)
        {
        size--;
      return  q[i].Dequeue();
        }
        else
        {
        return -1;
        }
    }

    public bool IsEmpty(int i) {
        // Check if queue i is empty
    
    return q[i].Count==0;
    }

    public bool IsFull() {
        // Check if array is full
        return size==n;
        
    }
}
*/
using System;
using System.Collections.Generic;

class KQueues
{
    readonly int n;
    readonly int k;
    readonly Queue<int>[] q;
    int size = 0;

    public KQueues(int n, int k)
    {
        this.n = n;
        this.k = k;

        q = new Queue<int>[k];
        for (int i = 0; i < k; i++)
        {
            q[i] = new Queue<int>();
        }
    }

    public bool Enqueue(int x, int i)
    {
        if (size == n)
            return false;

        q[i].Enqueue(x);
        size++;
        return true;
    }

    public int Dequeue(int i)
    {
        if (q[i].Count == 0)
            return -1;

        size--;
        return q[i].Dequeue();
    }

    public bool IsEmpty(int i)
    {
        return q[i].Count == 0;
    }

    public bool IsFull()
    {
        return size == n;
    }

    public void DisplayQueues()
{
    for (int i = 0; i < k; i++)
    {
        Console.Write($"Queue {i}: ");
        if (q[i].Count == 0)
        {
            Console.WriteLine("Empty");
        }
        else
        {
            foreach (var item in q[i])
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine($"Total size: {size}/{n}\n");
}

}

/*
Choose Day (1 or 2 or 3):
3
Enter total capacity (n): 3
Enter number of queues (k): 3

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
1
Enter value: 2
Enter queue index: 1
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
3
Enter queue index: 1
False

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: Empty
Queue 1: 2
Queue 2: Empty
Total size: 1/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
1
Enter value: 3
Enter queue index: 1
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: Empty
Queue 1: 2 3
Queue 2: Empty
Total size: 2/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
1
Enter value: 9
Enter queue index: 0
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: 9 
Queue 1: 2 3
Queue 2: Empty
Total size: 3/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
1
Enter value: 6
Enter queue index: 2
False

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: 9 
Queue 1: 2 3
Queue 2: Empty
Total size: 3/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
4
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
2
Enter queue index: 2
-1

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: 9 
Queue 1: 2 3
Queue 2: Empty
Total size: 3/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
2
Enter queue index: 1
2

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: 9 
Queue 1: 3
Queue 2: Empty
Total size: 2/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
1
Enter value: 2
Enter queue index: 2
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
6
Queue 0: 9 
Queue 1: 3
Queue 2: 2
Total size: 3/3


Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
4
True

Choose an operation:
1. Enqueue
2. Dequeue
3. IsEmpty
4. IsFull
5. Exit
6. Display all queues
*/