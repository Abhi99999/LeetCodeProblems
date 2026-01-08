public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0, maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            Expand(s, i, i, ref start, ref maxLength);     // Odd length
            Expand(s, i, i + 1, ref start, ref maxLength); // Even length
        }

        return s.Substring(start, maxLength);
    }

    private void Expand(string s, int left, int right,
                        ref int start, ref int maxLength)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            int length = right - left + 1;
            if (length > maxLength)
            {
                maxLength = length;
                start = left;
            }
            left--;
            right++;
        }
    }
}
