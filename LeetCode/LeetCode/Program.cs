using System;

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


            Console.ReadLine();
        }
    }
}
