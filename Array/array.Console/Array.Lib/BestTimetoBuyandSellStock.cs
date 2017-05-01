/* ==============================================================================
 * 功能描述：ThirdMaximumNumber  
 * 创 建 者：gz
 * 创建日期：2017/5/1 8:25:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Say you have an array for which the ith element is the price of a given stock on day i.

// If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.

// Example 1:
// Input: [7, 1, 5, 3, 6, 4]
// Output: 5

// max. difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be larger than buying price)
// Example 2:
// Input: [7, 6, 4, 3, 1]
// Output: 0

// In this case, no transaction is done, i.e. max profit = 0.
namespace Array.Lib
{
    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// </summary>
    public class BuyAndSellSln
    {
        public int MaxProfit(int[] prices) 
	   {
        int premax = 0;
        int curmax = 0;
        for(int i=1; i<prices.Length; i++)
        {
            int cal = prices[i]-prices[i-1];
            curmax = Math.Max(cal,cal+curmax);
            premax = Math.Max(curmax,premax);
        }
        return premax;
	   }

    }
}
