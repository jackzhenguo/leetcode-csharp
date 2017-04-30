using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Lib
{
    //    Given two arrays, write a function to compute their intersection.

    //Example:

    //Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

    //Note:

    //Each element in the result must be unique.
    //The result can be in any order.
    public class IntersectionOfTwoArraysISln
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            return nums1.Intersect(nums2).ToArray();
        }
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            HashSet<int> set1 = new HashSet<int>();
            foreach (var item in nums1)
            {
                if (!set1.Contains(item))
                    set1.Add(item);
            }

            HashSet<int> set2 = new HashSet<int>();
            foreach (var item in nums2)
            {
                if (!set2.Contains(item))
                    set2.Add(item);
            }
            return set1.Intersect(set2).ToArray();
        }
    }
}
