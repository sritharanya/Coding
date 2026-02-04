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


/*
You are given a circular array arr[] of integers, find the maximum possible sum of a non-empty subarray. In a circular array, the subarray can start at the end and wrap around to the beginning. Return the maximum non-empty subarray sum, considering both non-wrapping and wrapping cases.

Examples:

Input: arr[] = [8, -8, 9, -9, 10, -11, 12]
Output: 22
Explanation: Starting from the last element of the array, i.e, 12, and moving in a circular fashion, we have max subarray as 12, 8, -8, 9, -9, 10, which gives maximum sum as 22.
Input: arr[] = [10, -3, -4, 7, 6, 5, -4, -1]
Output: 23
Explanation: Maximum sum of the circular subarray is 23. The subarray is [7, 6, 5, -4, -1, 10].
Input: arr[] = [5, -2, 3, 4]
Output: 12
Explanation: The circular subarray [3, 4, 5] gives the maximum sum of 12.



Problem: Maximum Circular Subarray Sum
Objective

Given a circular array of integers.

Find the maximum possible sum of a non-empty subarray.

Subarray may:

Stay within the array (normal case)

Wrap from the end to the beginning (circular case)

Key Definitions

Subarray:

A contiguous sequence of elements

Circular array:

The last element connects back to the first

Non-empty:

At least one element must be included

Core Insight

Any maximum circular subarray is one of two types:

A normal subarray (does not wrap)

A wrapping subarray (wraps around the ends)

Case 1: Non-Wrapping Subarray

This is the classic Maximum Subarray Sum problem

Solved using Kadane’s Algorithm

Finds the best subarray entirely inside the array

Case 2: Wrapping Subarray

A wrapping subarray includes:

End of the array

Beginning of the array

Equivalent idea:

Remove a minimum-sum subarray from the middle

Keep everything else

Mathematical Explanation

Let:

totalSum = sum of all elements

maxKadane = maximum subarray sum (non-circular)

minKadane = minimum subarray sum

Then:

Wrapping maximum = totalSum - minKadane

Why This Works

A wrapping subarray includes all elements except one continuous block

That excluded block must have the minimum sum

Removing the minimum gives the maximum remaining sum

Important Edge Case

If all elements are negative:

totalSum - minKadane becomes zero

This is invalid because subarray must be non-empty

In this case:

Answer is simply maxKadane

Final Decision Rule

If maxKadane < 0

Return maxKadane

Else

Return max(maxKadane, totalSum - minKadane)

Step-by-Step Algorithm

Initialize:

totalSum = 0

Variables for max and min Kadane

Loop through the array:

Add each element to totalSum

Update maximum subarray sum (Kadane)

Update minimum subarray sum (reverse Kadane)

Apply decision rule

Return final answer



---------------
Example Walkthrough
Input
[5, -2, 3, 4]

Steps

totalSum = 10

maxKadane = 10

minKadane = -2

wrappingSum = 10 - (-2) = 12

Answer = max(10, 12) = 12

Key Rules to Remember

Always compute:

Maximum subarray sum

Minimum subarray sum

Circular maximum = total sum minus minimum subarray

Use one final comparison, never split logic

Handle all-negative arrays separately

Concept Pattern

If a problem says:

circular

wrap around

maximum sum

Then think:

Kadane + reverse Kadane

totalSum - minimum subarray

*/