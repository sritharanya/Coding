/*
You are given a circular array arr[] of integers, 
find the maximum possible sum of a non-empty subarray. In a circular array,
 the subarray can start at the end and wrap around to the beginning.
  Return the maximum non-empty subarray sum, considering both non-wrapping and wrapping cases.

Input: arr[] = [8, -8, 9, -9, 10, -11, 12]
Output: 22
Explanation: Starting from the last element of the array, i.e, 12, and moving in a circular fashion,
 we have max subarray as 12, 8, -8, 9, -9, 10, which gives maximum sum as 22.

*/

using System;
public class Solution {
    public int maxCircularSum(int[] arr)
    {
        // code here
        int n=arr.Length;
        int maxsub=KadaneMax(arr);
        int minsub=KadaneMin(arr);
        
        if (maxsub<0)
        {
            return maxsub;
        }
        int total=0;
        for (int i=0;i<n;i++)
        {
            total=total+arr[i];
        }
        int circle=total-minsub;
        return Math.Max(maxsub,circle);
        
        
        
        
        
    }
        private int KadaneMax(int[] arr)
        {
            int curr=arr[0];
            int maxs=arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                curr=Math.Max(arr[i],curr+arr[i]);
                maxs=Math.Max(maxs,curr);
            }
            return maxs;
        }
        private int KadaneMin(int[] arr)
        {
            int curr=arr[0];
            int mins=arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                curr=Math.Min(arr[i],curr+arr[i]);
                mins=Math.Min(mins,curr);
            }
            return mins;
        }
   
        

    
}