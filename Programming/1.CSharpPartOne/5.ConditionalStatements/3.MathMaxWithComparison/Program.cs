using System;

class Program
{
    static void Main()
    {
        int[] n = { 0, 2, 1 };
        int max;

        if (n[0] < n[1])
            if (n[1] < n[2]) max = n[2]; // 012
            else max = n[1]; // 021 || 120
        else
            if (n[0] < n[2]) max = n[2]; // 102
            else max = n[0]; // 210 || 201
    }
}
