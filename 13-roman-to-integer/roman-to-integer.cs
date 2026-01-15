public class Solution {
    public int RomanToInt(string s) 
    {
        Dictionary<string, int> romanMap = new Dictionary<string, int>
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },  //not needed to put
            { "L", 50 },
            { "XL", 40 }, //not needed to put
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };
        int num = 0;
        for(int i = 0; i < s.Length; i++ )
        {
            if(i+1 < s.Length)
            {
                int num1 = romanMap[s[i].ToString()];
                int num2 = romanMap[s[i+1].ToString()];
                if(num1>=num2)
                    num+=num1;
                else
                    num-=num1;
            }
            else
                num+=romanMap[s[i].ToString()];  //for last index of string 
        }
        return num;
    }
}