using System; 

namespace LeetcodeProject
{
    /*
    No. 1
    Total Accepted: 272598
    Total Submissions: 1069617
    Difficulty: Easy

    Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].

    UPDATE (2016/2/13):
    The return format had been changed to zero-based indices. Please read the above updated description carefully.   
    */
    class TwoSumSolution : IRun
    {
        public void Run()
        {
            var givenNums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = TwoSum(givenNums, target);
            if(result.Length == 2)
            {
                string arrayStr = string.Format("[{0}, {1}]", result[0], result[1]);
                Console.WriteLine(arrayStr);            
            }
            else
            {
                Console.WriteLine("can't find it.");
            }
        }

        int[] TwoSum(int[] nums, int target)
        {
            var length = nums.Length;
            for(int i = 0; i < length; i++)
            {
                if(nums[i] >= target)
                    continue;
                for(int j = 0; j < length; j++)
                {
                    if(nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }
    }
}