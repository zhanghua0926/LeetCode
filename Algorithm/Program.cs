using Algorithm.AddTwoNumbersAlgorithm;
using Algorithm.LengthOfLongestSubstringAlgorithm;
using Algorithm.SumOfTwoNumAlgorithm;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSumOfTwoNum();
            //GetBreakfastNumber();
            //GetLengthOfLongestSubstring();
            GetAddTwoNumbers();
        }

        private static void GetSumOfTwoNum()
        {
            int[] nums = new int[] { 2, 7, 7, 11, 15 };
            foreach (var item in TwoSumSolution.TwoSum(nums, 22))
            {
                Console.WriteLine(item);
            }
        }

        private static void GetBreakfastNumber()
        {
            int[] num1 = new int[] { 57882, 19027, 10092, 68864, 4793, 79526, 79180 };
            int[] num2 = new int[] { 48972, 4398, 58431, 39850, 18079, 91737, 95744, 2140, 31951, 63025, 49234, 90419, 66653, 37876, 91295, 59338, 17532, 64111 };
            int x = 87979;

            long[] num3 = new long[] { 2, 1, 1 };
            long[] num4 = new long[] { 8, 5, 9, 1 };
            long y = 9;

            int result = new BreakfastNumberAlgorithm.BreakfastNumberSolution().BreakfastNumber(num1, num2, x);
        }

        private static void GetLengthOfLongestSubstring()
        {
            string string1 = "abcabcbb";

            int result = LengthOfLongestSubstringSolution.LengthOfLongestSubstring(string1);
        }

        private static void GetAddTwoNumbers()
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            ListNode l3 = new ListNode(3, new ListNode(7));
            ListNode l4 = new ListNode(9, new ListNode(2));

            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l3, l4);
        }
    }
}
