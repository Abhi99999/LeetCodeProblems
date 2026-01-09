public class Solution {
    public int MyAtoi(string s) 
    {
        s = s.Trim();
        if(string.IsNullOrEmpty(s))
            return 0;
        int i = 0, sign = 1, num=0, digit=0;
        if(s[i] == '-')
        {
            sign = -1;
            i++;
        }
        else if(s[i] == '+')
        {
            sign = 1;
            i++;
        }
        while(i < s.Length && char.IsDigit(s[i]))
        {
                digit = s[i] - '0';
                if(num > int.MaxValue/10 || (num == int.MaxValue/10 && digit > 7))
                    return sign == 1 ? int.MaxValue : int.MinValue;
                num = num*10 + digit;
                i++;
        }
        return num*sign;
    }
}