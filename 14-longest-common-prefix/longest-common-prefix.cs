public class Solution {
    public string LongestCommonPrefix(string[] strs) {
    if(strs.Length == 1)
        return strs[0];
     StringBuilder str = new StringBuilder();
     string sampleStr = strs[0];
     int count = 0;
     for(int i = 0; i<sampleStr.Length; i++)
     {
        count = 0;
        char ch = sampleStr[i];
        for(int j = 1; j < strs.Length; j++)
        {
            if(i<strs[j].Length && ch == strs[j][i])
            {
                count++;
                if(count == strs.Length-1)
                    str.Append(strs[j][i]);
            }
            else
                return str.ToString();
        }
     }
     return str.ToString();
    }
}