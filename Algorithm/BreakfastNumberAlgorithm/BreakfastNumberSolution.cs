using System;

namespace Algorithm
{
    public class BreakfastNumberSolution
    {
        #region Solution1 sort+binarysearch
        public int BreakfastNumber(int[] staple, int[] drinks, int x)
        {
            int count = 0;

            Array.Sort(staple);
            Array.Sort(drinks);

            for (int i = 0; i < staple.Length; i++)
            {
                if (staple[i] > x)
                    break;
                else
                {
                    int countItem = this.BinarySearch(drinks, x - staple[i]);
                    // if not, count will overflow 
                    count = (count + countItem) % 1000000007;
                    Console.WriteLine(count);
                }
            }

            return count % 1000000007;
        }

        public int BinarySearch(int[] nums, int target)
        {
            int i = 0;
            int j = nums.Length;

            while (i < j)
            {
                int mid = (i + j) / 2;
                if (nums[mid] > target)
                    j = mid;
                else
                    i = mid + 1;
            }

            return i;
        }
        #endregion


        #region Solution2 sort + twopoint
        public int BreakfastNumber2(int[] staple, int[] drinks, int x)
        {
            Array.Sort(staple);
            Array.Sort(drinks);

            int count = 0;
            int m = staple.Length, n = drinks.Length;
            int i = 0, j = n - 1;
            while (i < m && j >0)
            {
                if (staple[i] + drinks[j] < x)
                {
                    count = (count + j + 1) % 1000000007;
                    i++;
                }
                else
                    j--;
            }

            return count % 1000000007;
        }
        #endregion
    }
}
