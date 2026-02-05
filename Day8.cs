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
[1,0,1,0]            zeros = 2   → move left
   [0,1,0]           zeros = 2 
      [1,0]          zeros = 1 
*/