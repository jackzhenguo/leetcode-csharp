using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Say you have an array for which the ith element is the price of a given stock on day i.

// Design an algorithm to find the maximum profit. You may complete as many transactions as you like
 // (ie, buy one and sell one share of the stock multiple times). 
// However, you may not engage in multiple transactions at the same time 
// (ie, you must sell the stock before you buy again).
namespace Array.Lib
{
public class BestTime 
{
    public int MaxProfit(int[] prices) {
        int totalProfit = 0;
        for(int i=0;i<prices.Length-1;i++)
        {
            if(prices[i+1]>prices[i])
               totalProfit += prices[i+1] - prices[i];
        }
        return totalProfit;
    }
}
}
