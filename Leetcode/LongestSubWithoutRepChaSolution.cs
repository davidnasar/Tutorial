namespace LeetcodeProject
{
    /*
    No.3 Longest Substring Without Repeating Characters
    https://leetcode.com/problems/longest-substring-without-repeating-characters/

    Total Accepted: 174542
    Total Submissions: 761330
    Difficulty: Medium

    Given a string, find the length of the longest substring without repeating characters.

    Examples:

    Given "abcabcbb", the answer is "abc", which the length is 3.

    Given "bbbbb", the answer is "b", with the length of 1.

    Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
     */
    public class LongestSubWithoutRepChaSolution:IRun
    {
        public void Run()
        {
            var result1 = LengthOfLongestSubstring("abcabcbb");
            var result2 = LengthOfLongestSubstring("bbbbb");
            var result3 = LengthOfLongestSubstring("pwwkew");
        }

        public int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;
            var max = 1;
            for (var currentLength = length; currentLength > 1; currentLength--)
            {
                for (var index = 0; index < length - currentLength; index++)
                {
                    var self = s.Substring(index, currentLength);
                    //check self repeat
                    bool existed = self.WithRepeat();
                    if (existed) continue;
                    //check the rest has same characters, record the max length
                    var rest = s.Replace(self, "");
                    if (rest.Length + self.Length == length)
                        return self.Length;
                }
            }
            return max;
        }
    }
}
