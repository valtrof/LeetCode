var s = new Solution();

var res = s.AddTwoNumbers(
    new ListNode(2, new ListNode(4, new ListNode(3))),
    new ListNode(5, new ListNode(6, new ListNode(4)))
    );
Console.WriteLine("[2,3,4] + [5,6,4] = [" + res.val + "," + res.next.val + "," + res.next.next.val + "]");

res = s.AddTwoNumbers(
    new ListNode(9, new ListNode(9)),
    new ListNode(9)
    );
Console.WriteLine("[9,9] + [9] = [" + res.val + "," + res.next.val + "," + res.next.next.val + "]");

Console.ReadKey();

public class Solution
{
    //// 66.95, 41.68, first attempt
    //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    //{
    //    var res = new ListNode();

    //    var p1 = l1;
    //    var p2 = l2;
    //    var p3 = res;

    //    var carry = 0;

    //    while (p1 != null || p2 != null)
    //    {
    //        p3.val = (p1 == null ? 0 : p1.val) + (p2 == null ? 0 : p2.val) + carry;

    //        if (p3.val >= 10)
    //        {
    //            carry = 1;
    //            p3.val -= 10;
    //        }
    //        else
    //        {
    //            carry = 0;
    //        }

    //        p1 = p1?.next;
    //        p2 = p2?.next;

    //        if (p1 != null || p2 != null)
    //        {
    //            p3.next = new ListNode();
    //            p3 = p3.next;
    //        }
    //        else if (carry == 1)
    //        {
    //            p3.next = new ListNode(1);
    //        }
    //    }

    //    return res;
    //}

    // 56.30, 58.28, recursive
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return NextNode(l1, l2, 0);
    }

    public ListNode NextNode(ListNode l1, ListNode l2, int carry)
    {
        if (l1 == null && l2 == null)
        {
            if (carry == 1) return new ListNode(1);
            else return null;
        }

        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        return new ListNode(sum % 10, NextNode(l1?.next, l2?.next, sum / 10));
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}



