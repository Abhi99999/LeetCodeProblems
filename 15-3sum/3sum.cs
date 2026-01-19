public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {

        IList<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;
        if(n < 3)
            return result;

        Array.Sort(nums);

        for(int i=0; i<n-2; i++)
        {
            if(i>0 && nums[i]==nums[i-1])
                continue;

            int target = nums[i];
            int left = i+1;
            int right = n-1;
            while(left<right)
            {
                int sum = target + nums[left] + nums[right];
                if(sum == 0)
                {
                    result.Add(new List<int> { target, nums[left], nums[right]});
                    while(left<right && nums[left] == nums[left+1])
                        left++;
                    while(left<right && nums[right] == nums[right-1])
                        right--;
                    left++;
                    right--;
                }
                else if(sum>0)
                    right--;
                else
                    left++;
            }
        }
        return result;
    }
}