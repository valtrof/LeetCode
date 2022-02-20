var s = new Solution();
var res = s.FirstBadVersion(2126753390);

public class VersionControl
{
    public bool IsBadVersion(int version)
    {
        return version >= 1702766719;
    }
}
public class Solution : VersionControl
{
    // 39.07, 83.26, https://leetcode.com/problems/first-bad-version/
    public int FirstBadVersion(int n)
    {
        int l = 1;
        int r = n;
        int mid;
        int minBad = n;

        while (l <= r)
        {
            mid = (int)(((long)l + (long)r) / 2);
            if (IsBadVersion(mid))
            {
                minBad = mid;
                r = mid - 1;
            }
            else l = mid + 1;
        }

        return minBad;
    }
}