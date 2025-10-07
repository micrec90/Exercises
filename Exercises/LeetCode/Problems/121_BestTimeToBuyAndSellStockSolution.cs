using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class BestTimeToBuyAndSellStockSolution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = int.MinValue;
            int minimumPrice = int.MaxValue;
            foreach(int price in prices)
            {
                if(price < minimumPrice)
                    minimumPrice = price;

                int profit = price - minimumPrice;
                if(profit > maxProfit)
                    maxProfit = profit;
            }
            return maxProfit;
        }
    }
}
