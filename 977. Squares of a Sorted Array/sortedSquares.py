from typing import List


class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        res = []
        l, r = 0, len(nums) -1
        while l <= r:
            if nums[l]**2 > nums[r]**2:
                res += nums[l]**2
                l += 1
            else:
                res += nums[r]**2
                r -= 1
        return res[::-1] # reverse