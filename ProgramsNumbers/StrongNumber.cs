//Strong Number or Krishnamurthy number
//145=1!+4!+5!=1+24+120=145

using System;
namespace ProgramsNumbers
{
    internal class StrongNumber
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        
       /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sum = 0;
            
            while (num > 0)
            {
                int digit = num % 10;
                sum += Factorial(digit);
                num /= 10;
            }

            if (sum == temp)
                Console.WriteLine(temp + " is a Strong Number");
            else
                Console.WriteLine(temp + " is not a Strong Number");
        }*/
    }
}

