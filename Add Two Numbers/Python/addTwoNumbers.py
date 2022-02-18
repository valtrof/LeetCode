from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    # 79.65, 82.16, first attempt, recursive
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode], carry: int=0) -> Optional[ListNode]:
        if l1 is None and l2 is None: return ListNode(1) if carry == 1 else None
        sum = (0 if l1 is None else l1.val) + (0 if l2 is None else l2.val) + carry
        return ListNode(sum % 10, self.addTwoNumbers(None if l1 is None else l1.next, None if l2 is None else l2.next, sum // 10))


s = Solution()

res = s.addTwoNumbers(
    ListNode(2, ListNode(4, ListNode(3))),
    ListNode(5, ListNode(6, ListNode(4))))
print(",".join([str(x) for x in [res.val, res.next.val, res.next.next.val]]))

res = s.addTwoNumbers(
    ListNode(9, ListNode(9)),
    ListNode(9))
print(",".join([str(x) for x in [res.val, res.next.val, res.next.next.val]]))
