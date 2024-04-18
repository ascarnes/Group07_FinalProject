using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group07_FinalProject
{
    public class LeetCodeEasy
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic (if needed)
        }

        protected void btnTwoSum_Click(object sender, EventArgs e)
        {
            // Show the description and test case labels
            lblDescription.Visible = true;
            lblTestCase.Visible = true;
        }

        // Other methods (TwoSum, etc.) can go here

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse user input from text boxes
            string[] numStrings = txtNumbers.Text.Split(',');
            long[] nums = Array.ConvertAll(numStrings, long.Parse); // Use long data type
            long target = Convert.ToInt64(txtTarget.Text); // Use long data type

            // Call the TwoSum method
            int[] result = TwoSum(nums, target);

            // Display the result
            lblResult.Text = $"Output: [{result[0]}, {result[1]}]";
        }

        public int[] TwoSum(long[] nums, long target) // Use long data type
        {
            Dictionary<long, int> numToIndex = new Dictionary<long, int>(); // Use long data type

            for (int i = 0; i < nums.Length; i++)
            {
                long complement = target - nums[i];

                if (numToIndex.ContainsKey(complement))
                {
                    return new int[] { numToIndex[complement], i };
                }

                numToIndex[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
