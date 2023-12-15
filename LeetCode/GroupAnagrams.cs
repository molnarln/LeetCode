using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class GroupAnagrams
    {
        //Given an array of strings strs, group the anagrams together.You can return the answer in any order.
        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        public static IList<IList<string>> GroupAnagramsFunction(string[] strs)
        {
            bool checkAnagram(string s, string t)
            {
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
            IList<IList<string>> returnList = new List<IList<string>>();

            Dictionary<string, List<string>> dictionary = new();
            foreach (var item in strs)
            {
                var sArray = item.ToCharArray();
                Array.Sort(sArray);
                dictionary.TryAdd(new string(sArray),null);
            }
            foreach (var item in dictionary)
            {
                List<string> group = new();
                foreach (var stringToCheck in strs)
                {
                    if (checkAnagram(stringToCheck, item.Key))
                    {
                        group.Add(stringToCheck);
                    }
                }
                dictionary[item.Key] = group;
            }

            foreach (var item in dictionary)
            {
                returnList.Add(item.Value);
            }
            return returnList;
        }
    }
}
