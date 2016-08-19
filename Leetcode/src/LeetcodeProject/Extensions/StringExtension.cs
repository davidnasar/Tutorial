using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetcodeProject
{
    public static class StringExtension
    {
        /*
        int[] ints = { 18, 45, 15, 39, 21, 26 };
        var result = ints.OrderBy(g => g);
        */

        public static List<int> AllIndexOf(this string input, char target)
        {
            var result = new List<int>();
            if (string.IsNullOrWhiteSpace(input) ||
                target == null ||
                string.IsNullOrWhiteSpace(target.ToString()))
                return result;

            var array = input.ToArray();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    result.Add(i);
            }
            return result;
        }

        public static char[] FindRepeatChar(this string input)
        {
            var result = input.ToArray()
                .GroupBy(l => l)
                .Where(g => g.Count() > 1)
                .Select(t => t.Key)
                .ToArray();
            return result;
        }

        public static string Reverse(this string input)
        {
            var arary = input.ToArray().Reverse().ToArray();
            var result = new string(arary);
            return result;
        }

        public static bool WithRepeat(this string input)
        {
            var result = input.ToCharArray()
                .GroupBy(l => l)
                .Where(g => g.Count() > 1)
                .Count() > 0;
            return result;
        }

        public static bool IsMatch(this string input, string pattern)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return Regex.IsMatch(input, pattern);
        }

        public static string Match(this string input, string pattern)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            return Regex.Match(input, pattern).Value;
        }
    }
}
