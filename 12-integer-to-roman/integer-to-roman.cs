public class Solution {
    public string IntToRoman(int num) {
        int[] values = {
            1000, 900, 500, 400,
            100,  90,  50,  40,
            10,   9,   5,   4,
            1
        };
        string[] symbols = {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV",
            "I"
        };

        StringBuilder roman = new StringBuilder();

        for(int i = 0; i<values.Length; i++)
        {
            if(num == 0)
                break;
            int times = num/values[i];
            for(int j = 0; j<times;j++)
                roman.Append(symbols[i]);
            num = num%values[i];
        }
        return roman.ToString();
    }
}