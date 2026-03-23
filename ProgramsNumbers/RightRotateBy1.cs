using System;
namespace ProgramsNumbers
{
    internal class RightRotateBy1
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4,5,6};
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            int num = nums[nums.Length - 1];
            for (int i =nums.Length-1;i>0; i--)
            {
              nums[i] = nums[i-1];
            }
            nums[0] = num;
            Console.WriteLine("Right Rotate By 1 Array");
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
