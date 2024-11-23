using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class IsPalindrome
    {
        public static bool IsValidPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(input[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(input[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(input[left]) != char.ToLower(input[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}
