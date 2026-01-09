public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        int digit = 0;
        int value = 0;
        int temp = x;
        while(x!=0)
        {
            digit = x%10;
            value = value*10+digit;
            x /= 10;
        }
        if(temp == value)
            return true;
        return false;
    }
}