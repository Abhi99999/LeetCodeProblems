public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int l1 = nums1.Length, l2 = nums2.Length;
        int total = l1+l2;
        int[] nums3 = new int[total];
        int i = 0 , j = 0,size =0;
        while(i < l1 && j < l2)
        {
            if(nums1[i] < nums2[j])
                nums3[size++] = nums1[i++];
                
            else
                nums3[size++] = nums2[j++];
        }
        while(i < l1)
            nums3[size++] = nums1[i++];
        while(j < l2)
            nums3[size++] = nums2[j++];
        
        // Median calculation
        if (total % 2 == 1)
        {
            return nums3[total / 2];
        }
        else
        {
            int mid = total / 2;
            return (nums3[mid - 1] + nums3[mid]) / 2.0;
        }
    }
}