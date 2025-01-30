using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
                sum += num;
            return sum;
        }

        public static string RepeatString(this string str, int times)
        {
            return string.Concat(System.Linq.Enumerable.Repeat(str, times));
        }
    }
}

