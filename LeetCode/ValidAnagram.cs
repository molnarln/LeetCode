using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ValidAnagram
    {
        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        public static bool IsAnagram(string s, string t)
        {
            //Solution 1 - runs too long:

            //char[] sCharArray = s.ToCharArray();
            //char[] tCharArray = t.ToCharArray();
            //bool valueToReturn = true;

            //if (s.ToCharArray().Length != t.ToCharArray().Length) return false;

            //foreach (char characterToCheck in sCharArray)
            //{
            //    int numberOfOccurrenceS = 0;
            //    for (int i = 0; i < sCharArray.Length; i++)
            //    {
            //        if (sCharArray[i] == characterToCheck)
            //        {
            //            numberOfOccurrenceS++;
            //        }
            //    }
            //    int numberOfOccurrenceT = 0;
            //    for (int j = 0; j < tCharArray.Length; j++)
            //    {
            //        if (characterToCheck == tCharArray[j])
            //        {
            //            numberOfOccurrenceT++;
            //        }
            //    }
            //    if (numberOfOccurrenceS != numberOfOccurrenceT)
            //    {
            //        valueToReturn = false;
            //        break;
            //    }

            //}
            //return valueToReturn;

            //Solution2:
            //Dictionary<char, int> sd = new Dictionary<char, int>();
            //Dictionary<char, int> st = new Dictionary<char, int>();
            //foreach (var item in s.ToCharArray())
            //{
            //    if (sd.ContainsKey(item))
            //    {
            //        sd[item] += 1;
            //    }
            //    else
            //    {
            //        sd.TryAdd(item, 1);
            //    }
            //}
            //foreach (var item in t.ToCharArray())
            //{
            //    if (st.ContainsKey(item))
            //    {
            //        st[item] += 1;
            //    }
            //    else
            //    {
            //        st.TryAdd(item, 1);
            //    }
            //}
            //if (sd.Count != st.Count)
            //{
            //    return false;
            //}
            //if(sd.Keys.ToHashSet().SetEquals(st.Keys.ToHashSet()) == false) return false;
            //foreach (var item in sd.Keys)
            //{
            //    if (st[item] != sd[item])
            //    {
            //        return false;
            //    }
            //}
            //return true;


            //Solution 3 - accepted:

            if (s.Length != t.Length) return false;
            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            bool returnvalue = true;
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                {
                    returnvalue = false;
                    break;
                }
            }
            return returnvalue;
        }
    }
}
