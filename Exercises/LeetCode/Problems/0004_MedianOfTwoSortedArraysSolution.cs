using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MedianOfTwoSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);
            int left = (nums1.Length + nums2.Length + 1) / 2;
            int low = 0;
            int high = nums1.Length;

            while (low <= high)
            {
                int mid1 = (low + high) >> 1;
                int mid2 = left - mid1;

                int l1 = Int32.MinValue;
                int l2 = Int32.MinValue;

                int r1 = Int32.MaxValue;
                int r2 = Int32.MaxValue;

                if (mid1 < nums1.Length)
                    r1 = nums1[mid1];
                if (mid2 < nums2.Length)
                    r2 = nums2[mid2];
                if (mid1 - 1 >= 0)
                    l1 = nums1[mid1 - 1];
                if (mid2 - 1 >= 0)
                    l2 = nums2[mid2 - 1];
                if (l1 <= r2 && l2 <= r1)
                {
                    if ((nums1.Length + nums2.Length) % 2 == 1)
                        return Math.Max(l1, l2);
                    else
                        return ((double)(Math.Max(l1, l2) + Math.Min(r1, r2))) / 2.0;
                }
                else if (l1 > r2)
                    high = mid1 - 1;
                else
                    low = mid1 + 1;
            }
            return 0;
        }
    }
}
