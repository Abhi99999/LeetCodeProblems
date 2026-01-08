public class Solution {

    public bool solve(string str, int l, int r){
        if(l >= r)
            return true;
        else if(str[l]==str[r])
            return solve(str,l+1,r-1);
        else
            return false;
    }

    public string LongestPalindrome(string s) {
        int maxLength = int.MinValue;
        int startIndex = 0;
        for(int i = 0; i< s.Length; i++)
        {
            for(int j = i; j< s.Length; j++)
            {
                if(solve(s,i,j))
                {
                    if(maxLength < j-i+1)
                    {
                        maxLength = j-i+1;
                        startIndex = i;
                    }
                }
            }
        }
        return s.Substring(startIndex, maxLength);
    }
}