public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        int n = nums.Length;
        int minDistance = int.MaxValue;

        if (n == 3)
            return nums[0]+nums[1]+nums[2];

        Array.Sort(nums);

        for (int i=0; i<n-2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = n - 1;

            while(left<right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if(Math.Abs(minDistance - target)> Math.Abs(sum - target))
                    minDistance = sum;
                if (sum < target) 
                    left++;
                else if (sum > target) 
                    right--;
                else 
                    return sum; // exact match
            }
        }
        return minDistance;
    }
}