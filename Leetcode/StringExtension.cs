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
