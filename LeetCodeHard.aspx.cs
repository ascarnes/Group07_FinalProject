using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group07_FinalProject
{
    public class LeetCodeHard
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic (if needed)
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse input arrays from textboxes
            int[] nums1 = txtNums1.Text.Split(',').Select(int.Parse).ToArray();
            int[] nums2 = txtNums2.Text.Split(',').Select(int.Parse).ToArray();

            // Call the FindMedianSortedArrays method (from your provided C# code)
            double median = FindMedianSortedArrays(nums1, nums2);

            // Display the result
            lblResult.Text = $"Median: {median:F2}";
        }

        // Your provided C# code (FindMedianSortedArrays method)
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, r = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    result[r++] = nums1[i++];
                }
                else if (nums2[j] < nums1[i])
                {
                    result[r++] = nums2[j++];
                }
                else
                {
                    result[r++] = nums1[i++];
                    result[r++] = nums2[j++];
                }
            }
            for (; i < nums1.Length; i++) result[r++] = nums1[i];
            for (; j < nums2.Length; j++) result[r++] = nums2[j];

            var m = result.Length / 2;
            if (result.Length % 2 == 1) return result[m];

            return (result[m - 1] + result[m]) / 2.0;
        }
    }
}