using System;
namespace ProgramsNumbers
{
    internal class DigitOccurance
    {
        /*static void Main(string[] args)
         {
            //From array
            /*int[] nums = { 1,2,4,3,1,4,2};
            Console.WriteLine("Numbers : ");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Repeated Numbers : ");
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = i + 1; j <nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        Console.WriteLine(nums[i]);
                }

            }*/

            //From single number
            /*int num = 102341023;
            Console.WriteLine("Number : "+num);
            string a=num.ToString();
            Console.WriteLine("Enter Number : ");
            string a=Console.ReadLine();
            Console.WriteLine("Repeated digits : ");
            for (int i = 0; i <= a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        Console.WriteLine(a[i]);
                }

            }*/

            //From single number of array
           /* int[] nums = { 121,421,232,155};
            Console.WriteLine("Numbers : ");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                Console.WriteLine(num);
                Console.WriteLine("Repeated digits : ");
                string a = num.ToString();
                for (int j = 0; j <=a.Length; j++)
                {
                    for (int k = j+1; k < a.Length; k++)
                    {
                        if (a[j] == a[k])
                            Console.WriteLine(a[j]);
                    }
                }
                Console.WriteLine();
            }
         }*/
    }
}
