public class Solution {
    public static bool solve(string s, string p)
{
    if (s.Length == 0)
    {
        if (p.Length == 0)
            return true;
    }
    bool firstCharMatched = false;

    if ((p.Length > 0 && s.Length > 0) && (s[0] == p[0] || p[0] == '.'))
        firstCharMatched = true;

    if (p.Length > 1 && p[1] == '*')
    {
        bool dontTake_astrick = solve(s, p.Substring(2));
        bool take_astrick = firstCharMatched && solve(s.Substring(1), p);
        return dontTake_astrick || take_astrick;
    }
    return firstCharMatched && solve(s.Substring(1), p.Substring(1));
}

    public bool IsMatch(string s, string p) {
        return solve(s,p);
    }
}