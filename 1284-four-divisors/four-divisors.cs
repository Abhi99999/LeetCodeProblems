public class Solution {
    public int SumFourDivisors(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int factCount = 0;
            int tempSum = 0;
            int num = nums[i];
            int limit = (int)Math.Sqrt(num);
            for (int fact = 1; fact <= limit; fact++ )
            {
                if(num % fact == 0)
                {
                    if(num/fact != fact)
                    {
                        factCount+= 2;
                        tempSum += (fact + (num/fact)); 
                    }
                    else
                    {
                        tempSum += fact;
                        factCount++;
                    }
                }
                if(factCount > 4)
                break;
            }

            if(factCount == 4)
            sum += tempSum;
        }
        return sum;
    }
}