public class Solution {
    public int Reverse(int x) {
        int num = 0;
        int value = 0;
        while(x != 0)
        {
            num = x%10;
            if(value > int.MaxValue/10 || (value == int.MaxValue/10 && num > 7))
            return 0;
            if(value < int.MinValue/10 ||(value == int.MinValue/10 && num < -8))
            return 0;
            value = value*10 + num;
            x /= 10;
        }
        return value;
    }
}