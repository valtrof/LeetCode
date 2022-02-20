var s = new Solution();

var res = s.TwoSum(new int[] { 1, 2 }, 3);
Console.WriteLine("[" + String.Join(",", res) + "]");

res = s.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine("[" + String.Join(",", res) + "]");

res = s.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
Console.WriteLine("[" + String.Join(",", res) + "]");

Console.ReadKey();

public class Solution
{
    //// 34.68, 18.21, first attempt
    //public int[] TwoSum(int[] nums, int target)
    //{
    //    var ret = new int[] { 0, 1 };
    //    var h = new Dictionary<int, int>();

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        var need = target - nums[i];

    //        if (h.ContainsKey(need))
    //        {
    //            ret[0] = i;
    //            ret[1] = h[need];
    //            return ret;
    //        }
    //        else
    //        {
    //            h[nums[i]] = i;
    //        }
    //    }

    //    return ret;
    //}

    // 62.18, 20.48, from https://www.c-sharpcorner.com/article/two-sum-leetcodes-solution-in-c-sharp-with-both-on-and-on2-approach/
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> resultDictionary = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (resultDictionary.TryGetValue(target - nums[i], out int index))
            {
                return new[] { index, i };
            }

            resultDictionary[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

