using System;
using System.Collections.Generic;


class Attributes
{
    [Obsolete("Use static int Add(List<int> Numbers) function instead")]
    public static int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach (int number in Numbers)
        {
            sum += number;
        }
        return sum;
    }
}

