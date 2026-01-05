public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int maxLength = 0, l = 0;
        for(int r = 0; r < s.Length; r++)
        {
            if(!map.ContainsKey(s[r]))
                map.Add(s[r], r);
            else
            {
                if(l <= map[s[r]])
                {
                    l = map[s[r]]+1;
                    map[s[r]] = r;
                }
                else
                    map[s[r]] = r;
            }
            if(maxLength <= r-l+1)
                maxLength = r-l+1;
        }
        return maxLength;
    }
}