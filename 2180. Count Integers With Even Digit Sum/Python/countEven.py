class Solution:
    # https://leetcode.com/problems/count-integers-with-even-digit-sum/
    def countEven(self, num: int) -> int:
        return (num - sum([int(k) for k in str(num)]) % 2) // 2