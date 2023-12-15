using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
            int[] array1 = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate.ContainsDuplicateFunction(array1));

            //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
            //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
            Console.WriteLine(ValidAnagram.IsAnagram("anagram", "nagaram"));

            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            //You can return the answer in any order.
            var array = new int[] { 3, 3 };

            TwoSum.TwoSumFunction(array, 6).ToList().ForEach(_ => Console.Write(_ + " "));

            //Given an array of strings strs, group the anagrams together. You can return the answer in any order.
            //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
            var array2 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagrams.GroupAnagramsFunction(array2).ToList().ForEach(group =>
            {
                Console.WriteLine();
                group.ToList().ForEach(_ => Console.Write(_ + " "));

            });

            Console.ReadLine();
        }
    }
}
