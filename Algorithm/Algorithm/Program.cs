using Algorithm.SumOfTwoNumAlgorithm;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            GetSumOfTwoNum();
        }

        private static void GetSumOfTwoNum()
        {
            int[] nums = new int[] { 2, 7, 7, 11, 15 };
            foreach (var item in TwoSumSolution.TwoSum(nums, 22))
            {
                Console.WriteLine(item);
            }
        }
    }
}
