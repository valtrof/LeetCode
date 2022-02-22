class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        A, B = nums1, nums2
        if len(B) < len(A): B, A = A, B
            
        n = len(A)
        m = len(B)
        
        start = 0
        end = n
        realmidinmergedarray = (n + m + 1) // 2

        while (start <= end):
            mid = (start + end) // 2
            leftAsize = mid
            leftBsize = realmidinmergedarray - mid
            
            # checking overflow of indices
            leftA = A[leftAsize - 1] if (leftAsize > 0) else float('-inf')
            leftB = B[leftBsize - 1] if (leftBsize > 0) else float('-inf')
            rightA = A[leftAsize] if (leftAsize < n) else float('inf')
            rightB = B[leftBsize] if (leftBsize < m) else float('inf')

            # if correct partition is done
            if leftA <= rightB and leftB <= rightA:
                if ((m + n) % 2 == 0):
                    return (max(leftA, leftB) + min(rightA, rightB)) / 2.0
                return max(leftA, leftB)

            elif (leftA > rightB):
                end = mid - 1
            else:
                start = mid + 1
