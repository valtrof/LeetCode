from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    # 95.31, 82.16, first attempt, recursive
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode], carry: int = 0) -> Optional[ListNode]:
        if not l1 and not l2: return ListNode(1) if carry == 1 else None
        sum = (0 if not l1 else l1.val) + (0 if not l2 else l2.val) + carry
        return ListNode(sum % 10, self.addTwoNumbers(None if not l1 else l1.next, None if not l2 else l2.next, sum // 10))


if __name__ == '__main__':
    a, a.next, a.next.next = ListNode(2), ListNode(4), ListNode(3)
    b, b.next, b.next.next = ListNode(5), ListNode(6), ListNode(4)
    res = Solution().addTwoNumbers(a, b)
    print(f"[{res.val},{res.next.val},{res.next.next.val}]")

    a, a.next = ListNode(9), ListNode(9)
    b = ListNode(9)
    res = Solution().addTwoNumbers(a, b)
    print(f"[{res.val},{res.next.val},{res.next.next.val}]")