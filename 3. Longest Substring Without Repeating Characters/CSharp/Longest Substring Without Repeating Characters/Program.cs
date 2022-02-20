var s = new Solution();
Console.WriteLine(s.LengthOfLongestSubstring("dvdf"));

Console.ReadKey();

// https://leetcode.com/problems/longest-substring-without-repeating-characters/
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<int>();
        int l = 0, r = 0, max = 0;

        while (r < s.Length)
        {
            while (set.Contains(s[r])) set.Remove(s[l++]);
            set.Add(s[r++]);
            max = Math.Max(max, r - l);
        }

        return max;
    }
}