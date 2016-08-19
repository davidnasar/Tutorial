using System.Collections.Generic;

namespace LeetcodeProject
{
    /*
    No.5 Longest Palindromic Substring
    https://leetcode.com/problems/longest-palindromic-substring/

    Total Accepted: 124395
    Total Submissions: 524342
    Difficulty: Medium

    Given a string S, find the longest palindromic substring in S. 
    You may assume that the maximum length of S is 1000, 
    and there exists one unique longest palindromic substring.
    eg: abccbadf => abc
     */
    public class LongestPalindromicSubstring : IRun
    {
        public void Run()
        {
            var result2 = LongestPalindrome("eabccbadf");
            var result3 = LongestPalindrome("bbbbbbb");
            var result1 = LongestPalindrome("abccbadf");
            var result4 = LongestPalindrome("eabccbadfeabccbadf");
        }

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;

            var array = s.FindRepeatChar();
            var dics = new Dictionary<int, char>();
            foreach (var ar in array)
            {
                var indexs = s.AllIndexOf(ar);
                for (var i = 0; i < indexs.Count; i++)
                {
                    if (i + 1 < indexs.Count)
                    {
                        if (indexs[i] + 1 == indexs[i + 1])
                            dics.Add(indexs[i], ar);
                    }
                }
            }
            var longestSingleLength = 1;
            var longestString = "";
            var palindrome = new List<TargetPalindrome>();
            foreach (var pair in dics)
            {
                var singleLength = 0;
                var target = "";// pair.Value.ToString();
                //for (var i = 1; i < pair.Key; i++)
                for (var i = 0; i <= pair.Key; i++)
                {
                    if (pair.Key - i >= 0 && pair.Key + 1 + i < s.Length)
                    {
                        var head = s.Substring(pair.Key - i, 1);
                        var trailer = s.Substring(pair.Key + 1 + i, 1);
                        if (head.Equals(trailer) && !head.Equals(target))
                        {
                            target = string.Format("{1}{0}", target, head);
                            singleLength++;
                        }
                        else
                            break;
                    }
                }
                palindrome.Add(new TargetPalindrome { Target = target, Length = singleLength, LastCharIndex = pair.Key });
                if (singleLength >= longestSingleLength)
                {
                    longestSingleLength = singleLength;
                    longestString = target;
                }
            }
            return longestString;
        }

        public class TargetPalindrome
        {
            public string Target { get; set; }
            public int Length { get; set; }
            public int LastCharIndex { get; set; }
        }
    }
}
