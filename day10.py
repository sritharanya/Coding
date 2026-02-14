class Solution:
    def minTime (self, arr, k):
        # code here
     def is_feasible(mid):
      painters=1
      curr_sum=0
      for board in arr:
        if curr_sum+board<=mid:
         curr_sum=curr_sum+board
        else:
         painters=painters+1
         curr_sum=board
         if painters>k:
          return False
      return True
        
     low=max(arr)
     high=sum(arr)
    
     while low<high:
      mid=(low+high)//2
      if is_feasible(mid):
       high=mid
      else:
       low=mid+1
     return low
    '''To solve the Painter’s Partition Problem, we use Binary Search on 
    Answer to find the minimum possible "maximum time" required to complete the job.
      We define our search range between the largest single board length
        (the minimum time any painter must work) and the sum of all boards (the time if only one painter was
          available). For each midpoint in this range, we run a greedy check to see if we can finish the 
          boards using $k$ or fewer painters without any individual painter exceeding that midpoint's time limit.
            If the check passes, we know a smaller time might be possible and move our "high" boundary down; 
            if it fails, the time limit is too tight, and we raise our "low" boundary. This process repeats until 
            the boundaries converge on the smallest possible time that satisfies the constraint, ensuring an 
            efficient $O(N \log(\text{sum}))$ solution.Would you like to try a 
    similar problem involving "Allocating Books" or "Splitting Arrays" to see if you can apply this logic again?'''
    '''
    Let's use the first example you gave: $arr = [5, 10, 30, 20, 15]$ and $k = 3$.
    Your MissionTry to find the minimum possible time by testing a few values. 
    Remember the rules:You have 3 painters maximum.Boards must be contiguous (no jumping around).
    Every board must be painted.Step 1: Define the Search RangeLow ($L$): 
    What is the absolute minimum time any single painter must take? 
    (Hint: Look at the largest board).High ($R$): If you only had 1 painter, how long would it take?
      (Hint: Sum of all boards).Step 2: Test a ValueLet’s pick a middle value to start.
        Suppose we try Time = 40.Can you fit these boards into 3 painters if no one can work more than 40 units?
        Painter 1: $5 + 10 = 15$. (Can they take the next board, $30$? $15 + 30 = 45$. No, that's over $40$).
        Painter 1 Total: 15Painter 2: $30$. (Can they take the next board, $20$? $30 + 20 = 50$. No).
        Painter 2 Total: 30Painter 3: $20 + 15 = 35$.Painter 3 Total: 35
        Result: It worked! We used exactly 3 painters. 
        Since 40 worked, we now know the answer is 40 or less.
        Step 3: Your Turn!Now, try to see if Time = 30 is possible.Start assigning boards to Painter
      1. Stop before they exceed 30.Move to Painter  
      2. Stop before they exceed 30.Move to Painter 3.
    
    
    '''