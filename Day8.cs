/*
Given a binary array arr[] containing only 0s and 1s and an integer k, you are allowed to flip at most k 0s to 1s. Find the maximum number of consecutive 1's that can be obtained in the array after performing the operation at most k times.

Examples:

Input: arr[] = [1, 0, 1], k = 1
Output: 3
Explanation: By flipping the zero at index 1, we get the longest subarray from index 0 to 2 containing all 1’s.
Input: arr[] = [1, 0, 0, 1, 0, 1, 0, 1], k = 2
Output: 5
Explanation: By flipping the zeroes at indices 4 and 6, we get the longest subarray from index 3 to 7 containing all 1’s.
Input: arr[] = [1, 1], k = 2
Output: 2
Explanation: Since the array is already having the max consecutive 1's, hence we dont need to perform any operation. Hence the answer is 2.


aim:to get longer array with all 1s

*/



class Solution {
    public int maxOnes(int[] arr, int k) {
        // code here
       int n=arr.Length;
        int result=0;
        int j=0;
        int i=0;
        int zerocnt=0;
        for (i=0;i<n;i++)
        {
       
        
        if(arr[i]==0)
        {
            zerocnt++;
        }
        
       /* for (int j=i;j<n;j++)
        {
           if(arr[j]==0)
           {
               zerocnt++;
           }
           if (zerocnt>k)
           {
             break;
           }
           */
           while(zerocnt>k)
           {
               if (arr[j]==0)
               {
                   zerocnt--;
               }
               j++;
           }
               int curlength=i-j+1;
        
        result=Math.Max(result,curlength);
/*
result=max(0,0-0+1);given 1 because array starts from 0


*/





        }
        
       return result;
       
       
       
       
       
       
    }
}


/*
arr = [1, 0, 1, 0, 1]
k = 1

Window moves → → →

[1]                  zeros = 0
[1,0]                zeros = 1 
[1,0,1]              zeros = 1 
[1,0,1,0]            zeros = 2   → move left which is greater than k=1 hence while(zerocnt>k)
   [0,1,0]           zeros = 2 -> if you see 0 then if (arr[j]==0)  zerocnt--;
      [1,0]          zeros = 1 
*/

/*
Example 1
j = 0, i = 0
Window: [1]
Length = 0 - 0 + 1 = 1

Example 2
j = 0, i = 2
Window: [1, 0, 1]
Length = 2 - 0 + 1 = 3

Example 3
j = 3, i = 7
Window: [1, 0, 1, 0, 1]
Length = 7 - 3 + 1 = 5


Indexes:

3, 4, 5, 6, 7  → 5 elements
*/
/*


--------------------
Input
arr = [1, 0, 1, 0, 1]
k = 1

Initial
j = 0
zerocnt = 0
result = 0

i = 0
arr[0] = 1
zerocnt = 0
result = max(0, 0-0+1) = 1

i = 1
arr[1] = 0  → zerocnt++
zerocnt = 1
result = max(1, 1-0+1) = 2

i = 2
arr[2] = 1
zerocnt = 1
result = max(2, 2-0+1) = 3

i = 3
arr[3] = 0  → zerocnt++
zerocnt = 2  (> k) → shrink

arr[j] = arr[0] = 1 → zerocnt stays 2 → j = 1
arr[j] = arr[1] = 0 → zerocnt-- → zerocnt = 1 → j = 2

result = max(3, 3-2+1) = 3

i = 4
arr[4] = 1
zerocnt = 1
result = max(3, 4-2+1) = 3

Final Result
3

Final window giving result
[1, 0, 1] → flip 1 zero → [1, 1, 1]
*/