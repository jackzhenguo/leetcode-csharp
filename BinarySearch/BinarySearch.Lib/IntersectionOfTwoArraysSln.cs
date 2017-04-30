using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Lib
{
    //    Given two arrays, write a function to compute their intersection.

    //Example:

    //Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].
    //    Note: 
    //Each element in the result should appear as many times as it shows in both arrays. 
    //The result can be in any order. 
    //Follow up:

    //What if the given array is already sorted? How would you optimize your algorithm?
    //What if nums1’s size is small compared to nums2’s size? Which algorithm is better?
    //What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
    public class IntersectionOfTwoArraysSln
    {
        //交集定义，元素可重复
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            nums1 = nums1.OrderBy(r => r).ToArray(); //升序排列
            nums2 = nums2.OrderBy(r => r).ToArray();

            int n = nums1.Length < nums2.Length ? nums1.Length : nums2.Length;
            List<int> rtn = new List<int>();
            if (nums1.Length < nums2.Length)
            {
                rtn = getIntersection(nums1, nums2);
            }
            else
                rtn = getIntersection(nums2, nums1);
            return rtn.ToArray();
        }

        //二分查找插入位置（相等元素，新插入位置靠后）
        //beginIndex：查询的起始位置
        private int searchInsertIndex(int[] sorted, int lo, int e)
        {
            int hi = sorted.Length;
            while (lo < hi)
            {
                int mi = (lo + hi) >> 1;
                if (e < sorted[mi])
                    hi = mi;
                else
                    lo = mi + 1;
            }
            return lo;
        }

        //nums1个数小于后者得到交集
        private List<int> getIntersection(int[] nums1, int[] nums2)
        {
            List<int> rtn = new List<int>();
            int index = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                index = searchInsertIndex(nums2, index, nums1[i]);
                if (index <= 0) //nums2中一定不存在这个元素
                    continue;
                if (nums1[i] == nums2[index - 1])
                {
                    rtn.Add(nums1[i]);
                    int precnt = preSame(nums2, index - 1);
                    int succnt = sucSame(nums1, i);
                    int sml = precnt < succnt ? precnt : succnt;
                    while (sml-- > 0)
                        rtn.Add(nums1[i]);
                    if (succnt > 0)
                        i = i + succnt;
                }
            }
            return rtn;
        }

        //有序数组中向<----后搜索相等元素的个数
        private int preSame(int[] nums, int index)
        {
            int sameCnt = 0;
            for (int i = index; i > 0; i--)
            {
                if (nums[index] == nums[i - 1])
                    sameCnt++;
            }
            return sameCnt;
        }

        //有序数组中向<----前搜索相等元素的个数
        private int sucSame(int[] nums, int index)
        {
            int sameCnt = 0;
            for (int i = index; i < nums.Length - 1; i++)
            {
                if (nums[index] == nums[i + 1])
                    sameCnt++;
            }
            return sameCnt;
        }

    }
}
