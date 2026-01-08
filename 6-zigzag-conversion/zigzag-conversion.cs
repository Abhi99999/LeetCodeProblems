public class Solution {
    public string Convert(string s, int numRows) 
    {
        StringBuilder[] strBuilder = new  StringBuilder[numRows];
        for(int j=0; j < numRows; j++)
            strBuilder[j] = new StringBuilder();
        int i = 0;
        while(i < s.Length)
        {
            for(int j = 0; j < numRows && i < s.Length; j++ )
            {
                strBuilder[j].Append((char)s[i]);
                i++;
            }
            for(int j = numRows-2; j > 0 && i < s.Length; j--)
            {
                strBuilder[j].Append((char)s[i]);
                i++;
            }  
        }
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in strBuilder)
            result.Append(row);

        return result.ToString();
    }
}