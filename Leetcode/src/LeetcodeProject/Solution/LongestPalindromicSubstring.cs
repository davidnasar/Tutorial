using System;
using System.Collections.Generic;
using System.Linq;

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
    public class LongestPalindromicSubstring:IRun
    {
        public void Run()
        {
            var result = LongestPalindrome("abccbadf");
        }

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;

            var array = s.ToArray();
            var length = array.Length;
            

            return null;
        }

    }
}
