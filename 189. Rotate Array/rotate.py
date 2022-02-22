from typing import List


class Solution:
    # 31.72, 8.86, firt attempt
    # def rotate(self, nums: List[int], k: int) -> None:
    #     n = len(nums)
    #     if n < 2: return
    #     cur, next = 0, 0
    #     temp = nums[0]
    #     processed = set()
    #     for i in range(n):
    #         while cur in processed:
    #             cur = (cur + 1) % n  
    #             temp = nums[cur]
    #         processed.add(cur)
    #         next = (cur + k) % n
    #         nums[next], temp = temp, nums[next]
    #         cur = next

    # 59.65, 56.05, https://www.youtube.com/watch?v=BHr381Guz3Y 
    def rotate(self, nums: List[int], k: int) -> None:
        k = k % len(nums)
        def reverse(nums: List[int], l: int, r:int) -> None:
            while l < r:
                nums[l], nums[r] = nums[r], nums[l]
                l, r = l + 1, r - 1
        reverse(nums, 0, len(nums) - 1)
        reverse(nums, 0, k - 1)
        reverse(nums, k, len(nums) - 1)


l = [0]
Solution().rotate(l, 0)
print(l == [0])

l = [0, 1]
Solution().rotate(l, 1)
print(l == [1, 0])

l = [0, 1, 2]
Solution().rotate(l, 1)
print(l == [2, 0, 1])

l = [0, 1, 2]
Solution().rotate(l, 2)
print(l == [1, 2, 0])

l = [-1,-100,3,99]
Solution().rotate(l, 2)
print(l == [3, 99, -1, -100])
