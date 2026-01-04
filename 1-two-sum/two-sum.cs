public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        // 1st int is difference and 2nd int is index
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int diff = target - num;
            if(map.ContainsKey(diff))
            return new int[] {i, map[diff]};
            else if(!map.ContainsKey(num))
            map.Add(num,i);
        }
         return new int[1];
    }
}