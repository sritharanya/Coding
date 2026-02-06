


class Besttriplets {
    public int[] smallestDiff(int[] a, int[] b, int[] c) {
        // code here
      Array.Sort(a);
      Array.Sort(b);
      Array.Sort(c);
      //of the same size 
      int n=a.Length;
      int i=0,j=0,k=0;
      int[] result=new int[3];
      int big_n=int.MaxValue;
      int sum_n=int.MaxValue;
        
   // return a;//sorting happens
   while(i<n&&j<n&&k<n)
   {
      int x=a[i];
      int y=b[j];
      int z=c[k];
     // int[] result=new int[3];
      
      int currmax=Math.Max(x,Math.Max(y,z));
      int currmin=Math.Min(x,Math.Min(y,z));
      int diff=currmax-currmin;
     /*
     Note: If there are 2 or more smallest difference triplets,
     then the one with the smallest sum of=> its elements <= should be displayed.
If diff is better  update

If diff same check sum
     */
      int sum=x+y+z;
      if (diff<big_n || (diff==big_n&&sum<sum_n))
      {
         big_n=diff;
         sum_n=sum;
         result[0]=x;result[1]=y;result[2]=z;/////important part
      }
      
      if (currmin==x)
      {
          i++;
      }
      else if(currmin==y)
      {
          j++;
      }
      else k++;
      
      Array.Sort(result);
      Array.Reverse(result);
     // return result;
      
      
      


      
   }
    
    return result;
    }
}



/*
You are given three arrays a[], b[], c[] of the same size . Find a triplet such that (maximum-minimum) in that triplet is the minimum of all the triplets. A triplet should be selected so that it should have one number from each of the three given arrays. This triplet is the happiest among all the possible triplets. Print the triplet in decreasing order.

Note: If there are 2 or more smallest difference triplets, then the one with the smallest sum of its elements should be displayed.

Examples:

Input: a[] = [5, 2, 8] , b[] = [10, 7, 12] , c[] = [9, 14, 6]
Output: [7, 6, 5]
Explanation: The triplet [5, 7, 6]  has difference (maximum - minimum)= (7 - 5) = 2 which is minimum of all triplets.  
Input: a[] = [15, 12, 18, 9] , b[] = [10, 17, 13, 8] , c[] = [14, 16, 11, 5]
Output: [11, 10, 9]
Explanation: Multiple triplets have the same minimum difference, and among them [11, 10, 9] has the smallest sum, so it is chosen.
Constraints:
1 ≤ a.size(), b.size() ,c.size() ≤ 105
1 ≤ a[i], b[i], c[i] ≤ 105

Expected Complexities
Time Complexity: O(n log n)
Auxiliary Space: O(1)
--------------------------------------------------
Here is the explanation in a clean, formal documentation style that you can remember permanently.

This problem requires selecting one element from each of three arrays such that the difference between the maximum and minimum elements of the selected triplet is minimized. This is the primary objective. However, the problem also specifies a secondary condition: if multiple triplets produce the same minimum difference, then the triplet with the smallest total sum must be chosen.

Because there are two levels of comparison, we must track two separate values while iterating through possible triplets. The first variable, bestDiff, stores the smallest difference found so far between the maximum and minimum values of any valid triplet. The second variable, bestSum, stores the smallest sum among the triplets that share that same minimum difference.

During iteration, each new triplet is evaluated. If its difference is smaller than the currently stored best difference, both bestDiff and bestSum are updated. If its difference is equal to the current best difference, then the sum is compared. Only if the new sum is smaller do we update the stored values. This ensures the solution always respects the problem’s priority rules: minimize difference first, and only use sum as a tie-breaker.

Both variables are initialized to the maximum possible integer value so that the first valid triplet encountered will always replace the initial values. This is a common pattern when solving minimization problems.

In summary, two variables are required because the problem defines a two-stage optimization process. One variable tracks the primary condition, and the other supports the secondary tie-breaking condition. Without storing both values, it would not be possible to correctly determine the optimal triplet according to the problem’s requirements.



-----------------------------------------------------------------------------
Step 1: Imagine a 3D Matrix

If:

a = [2, 5, 8]
b = [7, 10, 12]
c = [6, 9, 14]

All possible triplets form a 3D grid.

Think of it like layers.

Layer for c = 6:

(2,7,6) (5,7,6) (8,7,6)
(2,10,6) (5,10,6) (8,10,6)
(2,12,6) (5,12,6) (8,12,6)

Layer for c = 9:

(2,7,9) (5,7,9) (8,7,9)
(2,10,9) (5,10,9) (8,10,9)
(2,12,9) (5,12,9) (8,12,9)

Layer for c = 14:

(2,7,14) (5,7,14) (8,7,14)
(2,10,14) (5,10,14) (8,10,14)
(2,12,14) (5,12,14) (8,12,14)

That is 27 combinations.

Brute force checks everything.

Step 2: What Our Algorithm Does

We DO NOT scan the whole matrix.

Instead, we start at the “corner”:

(2, 7, 6)

Then we move only one direction at a time.

The movement rule is:

Move the pointer of the smallest element.

Step 3: Walk Through Like a Path

Start:

(2, 7, 6)
Minimum is 2 → move in array a

Now:

(5, 7, 6)
Minimum is 5 → move in array a

Now:

(8, 7, 6)
Minimum is 6 → move in array c

Now:

(8, 7, 9)
Minimum is 7 → move in array b

Now:

(8, 10, 9)
Minimum is 8 → move in array a

Stop when one array ends.










*/