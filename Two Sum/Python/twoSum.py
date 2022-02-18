from typing import List

class Solution:
    # 69.45, 59.12, from https://towardsdatascience.com/leetcode-problem-1-python-ec6cba23c20f
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        values = {}
        for idx, value in enumerate(nums):
            if target - value in values:
                return [values[target - value], idx]
            values[value] = idx

s = Solution()

print(s.twoSum([ 1, 2 ], 3))
print(s.twoSum([ 2, 7, 11, 15 ], 9))
print(s.twoSum([ 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 ], 11))