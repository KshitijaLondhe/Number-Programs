/*
1. Two sums
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
*/
using System;

namespace leetcode
{
    public class TwoSums
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nEnter array elements (space-separated) or type 'exit':");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                try
                {
                    string[] parts = input.Split(' ');
                    int[] nums = new int[parts.Length];

                    for (int i = 0; i < parts.Length; i++)
                    {
                        nums[i] = int.Parse(parts[i]);
                    }

                    Console.Write("Enter target: ");
                    int target = int.Parse(Console.ReadLine());

                    int[] result = TwoSum(nums, target);

                    if (result.Length == 0)
                    {
                        Console.WriteLine("No solution found.");
                    }
                    else
                    {
                        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
                        Console.WriteLine($"Values: {nums[result[0]]}, {nums[result[1]]}");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input! Try again.");
                }
            }

            Console.WriteLine("Program exited.");
        }

        // Your original logic
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
    }
}
