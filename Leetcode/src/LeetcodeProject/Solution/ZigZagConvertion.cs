using System;
using System.Linq;
using System.Text;

namespace LeetcodeProject.Solution
{
    /*
    No.6 ZigZag Conversion
    https://leetcode.com/problems/zigzag-conversion/

    Total Accepted: 102432
    Total Submissions: 409953
    Difficulty: Easy

    The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
    (you may want to display this pattern in a fixed font for better legibility)

    P   A   H   N
    A P L S I I G
    Y   I   R
    And then read line by line: "PAHNAPLSIIGYIR"
    Write the code that will take a string and make this conversion given a number of rows:

    string convert(string text, int nRows);
    convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
     */
    public class ZigZagConvertion : IRun
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public string Convert(string s, int numRows)
        {
            var output = SubFormat(s, numRows);
            var outs = output.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            var length = outs.Length;
            foreach (var o in outs)
            {
                var array = o.ToArray();

            }

            return "";
        }

        private string SubFormat(string input, int numRows)
        {
            var sb = new StringBuilder();
            var startIndex = 0;
            var i = 0;
            var length = input.Length;
            while (startIndex < length)
            {
                if (startIndex > length) break;

                bool isOdd = (i % 2 == 0);
                if (isOdd)
                {
                    var restLength = numRows;
                    if (startIndex + restLength > length)
                        restLength = length - startIndex;
                    var sub = input.Substring(startIndex, restLength);
                    sb.AppendFormat("{0}-", sub);
                    if (restLength != numRows) break;
                    startIndex += numRows;
                }
                else
                {
                    var count = numRows / 2;
                    var sub = new StringBuilder();
                    for (int j = 0; j < count; j++)
                    {
                        if (startIndex + 1 > length) break;
                        sub.AppendFormat(" {0}", input.Substring(startIndex, 1));
                        startIndex++;
                    }
                    var s = sub.ToString();
                    if (s.Length < numRows)
                        s += " ";
                    sb.AppendFormat("{0}-", s);
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
