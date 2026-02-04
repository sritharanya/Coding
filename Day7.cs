/*We have a wooden plank of length n units. Some ants are walking on the plank, each ant moves with a speed of 1 unit per second, with some moving left and others right.
When two ants moving in two different directions meet at some point, they change their directions and continue moving again. Assume changing directions does not take any additional time. When an ant reaches one end of the plank at a time t, it falls out of the plank immediately.

Given an integer n and two integer arrays left[] and right[], the positions of the ants moving to the left and the right, return the time when the last ant(s) fall out of the plank.
*/
class Ant_Problem {
    public int getLastMoment(int n, int[] left, int[] right) {
        // code here
      //int initial=0;
      int time=0;
        foreach (int i in left)
        {
             time =Math.Max(time,i);
        }
        foreach(int j in right)
        {
            time=Math.Max(time,n-j);
        }
      return  time;
      
      
      
        
    }
}
/*
Problem: Last Moment Before All Fall Out of a Plank
Objective

Determine the time at which the last object falls off a plank of length n.

Each object moves at a constant speed of 1 unit per second.

Some move left, some move right.

Direction changes on meeting do not affect total time.

Core Insight

When two moving objects meet and reverse directions, the outcome is equivalent to them passing through each other.

Therefore:

Collisions can be ignored.

Individual identities are irrelevant.

Only initial position and direction matter.

Time Calculation Rules

For an object at position x moving left:

Time to fall = x

For an object at position x moving right:

Time to fall = n - x

What Needs to Be Found

The maximum fall time among all objects.

This maximum represents the moment when the last object falls.

Why Only One Variable Must Be Used for Maximum

The problem asks for a single final value.

Splitting maximum calculations across multiple variables:

Loses global comparison

Produces incorrect results

A single variable ensures:

Every candidate time competes fairly

No maximum is discarded or overwritten incorrectly

Algorithm Steps

Initialize one variable to store the maximum time

For each left-moving position:

Compute its fall time

Update the maximum if larger

For each right-moving position:

Compute its fall time

Update the maximum if larger

Return the maximum

Example Walkthrough

Input:

n = 4

left = [3, 0, 2]

right = []

Steps:

Start with result = 0

Compare with 3 → result = 3

Compare with 0 → result = 3

Compare with 2 → result = 3

Final answer = 3

Common Mistake to Avoid

Do not:

Use separate variables for left and right

Combine results at the end

Always:

Update the same maximum variable throughout

Rule to Remember

If a problem asks for:

last moment

maximum time

longest duration

Then:

Use one variable

Update it consistently

Return it directly

*/