/* ==============================================================================
 * 功能描述：RotateArraySln  
 * 创 建 者：gz
 * 创建日期：2017/5/3 16:03:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    /// <summary>
    /// RotateArraySln
    /// </summary>
    public class RotateArraySln
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            if (n == 0 || n == 1) return;
            if ((double)k / n > 1)
                k = k % n;
            if (k == 0) return;
            System.Array.Reverse(nums, 0, n - k); //index, length
            System.Array.Reverse(nums, n - k, k);
            System.Array.Reverse(nums);
        }

        public void Rotate2(int[] nums, int k)
        {
            int n = nums.Length;
            if (n == 0 || n == 1) return;
            if ((double)k / n > 1)
                k = k % n;
            if (k == 0) return;
            Reverse(nums, 0, n - k); //index, length
            Reverse(nums, n - k, k);
            Reverse(nums, 0, n);
        }

        private void Reverse(int[] nums, int index, int length)
        {
            int i = 0;
            int loop = length/2;
            while (i < loop)
            {
                swap(ref nums[index + i], ref nums[length + index - i - 1]);
                i++;
            }
        }

        private void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

    }
}
