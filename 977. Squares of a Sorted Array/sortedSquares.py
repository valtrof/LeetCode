class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        a = [x*x for x in nums if x >= 0]
        b = [x*x for x in nums if x < 0]
        c = [0] * len(nums)
        indA = 0
        indB = len(b) - 1
        for indC in range(len(nums)):
            if indB < 0 or indA < len(a) and a[indA] <= b[indB]:
                c[indC] = a[indA]
                indA += 1
            else:
                c[indC] = b[indB]
                indB -= 1
        return c