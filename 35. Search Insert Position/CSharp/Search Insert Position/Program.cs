public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;
        int mid;

        while (l <= r)
        {
            mid = (l + r) / 2;
            if (target == nums[mid]) return mid;
            if (target < nums[mid]) r = mid - 1;
            else l = mid + 1;
        }

        return l;
    }
}