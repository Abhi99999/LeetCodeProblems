public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length-1;
        int maxArea = 0;
        while(l<r)
        {
           int area = Math.Min(height[l],height[r])*(r-l);
           if(maxArea<area)
            maxArea=area;
           if(height[l]<height[r])
            l++;
           else
            r--;
        }
        return maxArea;
    }
}