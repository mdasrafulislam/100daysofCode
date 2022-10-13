using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static bool IsHappy(int n)
        {
            char[] digits = n.ToString().ToArray();

            bool check = true;
            int sum = 0;

            while (check)
            {
                int i = 0;
                for (i = 0; i < digits.Length; i++)
                {
                    sum += (int)char.GetNumericValue(digits[i]) * (int)char.GetNumericValue(digits[i]);
                }

                if (sum == 1)
                    return true;

                digits = sum.ToString().ToArray();
            }

            return false;
        }

        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length - 1; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > max)
                        max = profit;
                }
            }

            return max;
        }

        public static int LongestPalindrome(string s)
        {
            int[] chars = new int[52];

            for (int i = 0; i < chars.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    chars[c - 'a']++;
                }
                else
                {
                    chars[c - 'A' + 26]++;
                }
            }

            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                count += chars[i] / 2;
            }
            count = count * 2;
            return count + 1;
        }

        public static int MaximumUniqueSubarray(int[] nums)
        {
            int sum = 0;
            HashSet<int> arrs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!arrs.Contains(nums[i]))
                {
                    arrs.Add(nums[i]);
                    sum += arrs.ElementAt(i);
                }                         

            }          

            return sum;
        }

        public static bool IsPalindrome(int x)
        {
           
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }
                        
            return x == revertedNumber || x == revertedNumber / 10;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                {

                }
                else
                {
                    numbers.Add(nums[i]);
                }
            }

            return numbers.Count;
        }


        public static int[] PlusOne(int[] digits)
        {
            int count = digits.Length;

            for (int i = count - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }


            int[] newNumber = new int[count + 1];
            newNumber[0] = 1;
            return newNumber;
        }

        public static bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            int m = 1;

            while (n > 0)
            {
                n = n / 3;
                m = n % 3;
                if (n == 1 && m == 0) return true;
            }

            return false;

        }
        
        public static void rotate(int[] ar, int n)
        {
            int lastElement = ar[n-1];
            int l = n - 2;

            for(int i=l;l>=0;l--)
            {
                ar[l + 1] = ar[l];               
            }

            ar[0] = lastElement;            
        }

        public static int singleNumber(int[] digits)
        {
            int result = 0;
            foreach(int num in digits)
            {
                result ^= num;
            }

            return result;

        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            double median = 0;

            int i = 0, j = 0, k = 0;

            int[] nums3 = new int[n1 + n2];

            while (i < n1 && j < n2)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3[k] = nums1[i];
                    i++;
                }
                else
                {
                    nums3[k] = nums2[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                nums3[k] = nums1[i++];
                i++;
                k++;
            }

            while (j < n2)
            {
                nums3[k] = nums2[j];
                j++;
                k++;
            }


            if (n1 + n2 % 2 == 0)
            {
                int m = (n1 + n2) / 2;
                median = (nums3[m] + nums3[m - 1]) / 2;
                return median;
            }
            else
            {
                int m = (n1 + n2) / 2;
                return nums3[m];
            }



        }

        public static int AddDigits(int num)
        {
            if (num == 0) return 0;
            if (num < 10)
                return num;

            string digits = num.ToString();
            int i = digits.Length;
            int sum = 0;

            while (i > 0)
            {
                foreach(char c in digits.ToCharArray())
                {
                    sum += Int32.Parse(c.ToString());
                }

                if (sum > 9)
                {
                    i = sum.ToString().Length;
                    digits = sum.ToString();
                    sum = 0;
                }
                else
                    return sum;

            }

            return sum;


        }

        public static void ReverseString(char[] s)
        {
            int end = s.Length - 1;
            int i = 0;
            while (true)
            {
                char temp = s[i];
                s[i] = s[end];
                s[end] = temp;

                if (i <= end)
                    break;

                i++;
                end--;
            }

        }

        public static int MaxSubArray(int[] nums)
        {
            int l = nums.Length;
            int maxSum = nums[0];
            int res = nums[0];

            for (int i = 0; i < l; i++)
            {
                int num = nums[i];
                maxSum = Math.Max(maxSum + num, num);
                res = Math.Max(res, maxSum);
            }

            return res;
        }


        static void Main(string[] args)
        {
            int[] arr1 = new int[] {1,2,4,5,6,3,5,0};
            int t = BinarySearch(arr1, 1);

            Console.ReadLine();
            Console.ReadLine();

         

        }

        public static int BinarySearch(int[] a,int target)
        {
            Array.Sort(a);
            int start = 0;
            int end = a.Length - 1;
            
            while(start<=end)
            {
                int mid = (start + end) / 2;
                if (target == a[mid])
                    return mid + 1;
                else if(target>a[mid])
                {
                    start = mid+1;
                }
                else
                {
                    end = mid-1;
                }
            }

            return -1;

        }
    }
}

//added to azure function app


