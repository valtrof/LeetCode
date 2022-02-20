var s = new Solution();

for (int i = 1; i <= 10000; i++)
{
    var c1 = s.CountEven(i);
    var c2 = s.CountEven3(i);
    Console.WriteLine(i + ": " + c1 + ", " + c2);
    if (c1 != c2) break;
}

Console.ReadKey();

public class Solution
{
    // O(n) solution
    public int CountEven(int num)
    {
        int counter = 0;
        for (int i = 1; i <= num; i++)
        {
            var x = i;
            var digitSum = 0;
            while (x > 0)
            {
                var digit = x % 10;
                digitSum += digit;
                x /= 10;
            }
            if (digitSum % 2 == 0) counter++;
        }
        return counter;
    }

    // O(1) solution, works for num < 10000
    public int CountEven2(int num)
    {
        bool toDecrement = false;
        if (num / 10 % 2 == 1) toDecrement = !toDecrement;
        if (num / 100 % 2 == 1) toDecrement = !toDecrement;
        if (num / 1000 % 2 == 1) toDecrement = !toDecrement;
        if (toDecrement) num--;
        return num / 2;
    }

    // O(1) solution, works for all numbers
    public int CountEven3(int num)
    {
        int digitSum = 0;
        int x = num;
        while (x > 0)
        {
            int digit = x % 10;
            digitSum += digit;
            x /= 10;
        }
        if (digitSum % 2 == 1) num--;
        return num / 2;
    }
}

