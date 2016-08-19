using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new LongestPalindromicSubstring().Run();
            Test();
        }

        private static void Test()
        {
            var b = "12345".IsMatch(@"\d+");
            var s = "ldp615".Match("[a-zA-Z]");
        }
    }
}
