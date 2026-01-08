public class Solution
{
    int maxLength = int.MinValue;
    int length = 0, startIndex=0;
    public string LongestPalindrome(string s)
    {
        for(int i = 0; i< s.Length; i++)
        {
            palindromeCheck(s,i,i); // for odd pallindrome length
            palindromeCheck(s,i,i+1);  // for even pallindrome length
        }
        return s.Substring(startIndex,maxLength);
    }
    public void palindromeCheck(string s, int l, int r)
    {
        while(l>=0 && r<s.Length && s[l]==s[r])
        {
            length = r-l+1;
            if(maxLength < length)
            {
                maxLength = length;
                startIndex = l;
            }
            l--;
            r++;
        }
    }
}
