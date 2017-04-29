using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Lib
{
    //    You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

    //Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
   public class HouseRoberSln
    {
        //nums = {1, 8, 12 10, 9 }  
        public int Rob(int[] nums)
        {
            int inCur = 0; //偷当前房子能获取的最大钱数
            int noInCur = 0;//不偷当前的房子能收获的最大钱数
            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = nums[i] + noInCur; //偷 ith 房子，上一个房子就不能偷
                noInCur = Math.Max(inCur, noInCur); //如果不偷 ith 房子，则noInCur 等于偷 i-1 房子和不偷 i-1 房子的最大值
                inCur = tmp; //偷当前房子后的获取总钱数
            }
            return Math.Max(inCur, noInCur);
        }
    }
}
