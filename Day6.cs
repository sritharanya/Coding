using System;
class Stockprofit {
    public int maxProfit(int[] prices) {
        // code here
     int minPrice=prices[0];
     int profit=0;
     for (int i=0;i<prices.Length;i++)
     {
          minPrice=Math.Min(minPrice,prices[i]);
        
     
   
         profit=Math.Max(profit,prices[i]-minPrice);
     
     }
       return profit;
    }
    
}
/*
buy astocj at minimum price in an array the [5,1,2,4,3,6,2,9,6,3]
find minimun 
then prices[i]-minPrice here find the difference and if that is max profit replace it withe the variable profit do till max profit come then 
at last final max profit is obtained
*/