using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeProject
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
            var r1 = Convert("PAYPALISHIRING", 3);
            var r2 = Convert("PAYPALISHIRING", 4);
            var r3 = Convert("PAYPALISHIRING", 5);
        }

        public string Convert(string s, int numRows)
        {
            var output = SubFormat(s, numRows);
            var outs = output.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            var length = outs.Length;
            var list = new List<char[]>();
            foreach (var o in outs)
            {
                var detail = FillLength(o, numRows);
                var array = detail.ToArray();
                list.Add(array);
            }
            var sb = new StringBuilder();
            for (var i = 0; i < numRows; i++)
            {
                foreach(var l in list)
                {
                    var singleStr = l[i].ToString();
                    var str = DealWith(singleStr);
                    sb.Append(str);
                }
            }
            return sb.ToString();
        }

        private string FillLength(string detail, int numRows)
        {
            var length = detail.Length;
            if (length == numRows) return detail;

            var longEmptyStr = "                    ";  //20-length
            var restLength = numRows - detail.Length;
            string emptyStr = longEmptyStr.Substring(0, restLength);
            return detail + emptyStr;
        }

        private string DealWith(string detail)
        {
            if (string.IsNullOrWhiteSpace(detail.Trim())) return "";
            return detail;
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
