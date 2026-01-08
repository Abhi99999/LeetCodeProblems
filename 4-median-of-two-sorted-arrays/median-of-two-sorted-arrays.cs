public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int m = nums1.Length;
        int n = nums2.Length;

        if(m>n)
            return FindMedianSortedArrays(nums2,nums1);
        
        int low = 0, high= m;
        while(low <= high)
        {
            int px = (low+high)/2;  // mid of smalllest array
            int py = (m+n+1)/2 - px; // mid of other array

            // left side of array
            int x1 = (px==0)? int.MinValue : nums1[px-1];
            int x2 = (py==0)? int.MinValue : nums2[py-1];

            // right side of array
            int x3 = (px==m)? int.MaxValue : nums1[px];
            int x4 = (py==n)? int.MaxValue : nums2[py];

            // now checking x1,x2,x3,x4 
            if(x1<=x4 && x2<=x3)
            {
                if((m+n)%2 == 1)
                    return Math.Max(x1,x2);
                else
                    return ((Math.Max(x1,x2)+Math.Min(x3,x4))/2.0);
            }
            if(x1>x4)
                high = px-1;
            else
                low = px+1;
        }
        return -1;
    }
}