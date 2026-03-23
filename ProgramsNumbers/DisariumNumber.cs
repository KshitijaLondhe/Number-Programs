//Disarium Number
//one where the sum of its digits raised to their respective positions equals the original number itself
//135 = 1¹ + 3² + 5³ = 1 + 9 + 125 = 135 

using System;
using static System.Math;
namespace ProgramsNumbers
{
    internal class DisariumNumber
    {
        public static int countDigits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                int rem = n % 10;
                count++;
                n /= 10;
            }
            return count;
        }

        public static int isDisariumNum(int n)
        {
             int sum = 0;
            int temp = n;
             int count = countDigits(n);
             while (n > 0)
            {
                int rem = n % 10;
                sum += (int) Pow(rem, count);
                n /= 10;
                count--;
            }
            return sum;
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the  number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = isDisariumNum(num);
            if(res==num)
                Console.WriteLine(num+ " is a Disarium Number");
            else
                Console.WriteLine(num + " is not a Disarium Number");

        }*/
    }
}
