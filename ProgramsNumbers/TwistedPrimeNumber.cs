//Twisted Prime Number in C#
//A Twisted Prime Number is a number that is prime, and its reverse is also a prime number.
//13 31

using System;
namespace ProgramsNumbers
{
    internal class TwistedPrimeNumber
    {
        static bool IsPrime(int n)
        {
            if (n < 2) 
                return false;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

       /*public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;
            while (temp > 0)
            {
                int rem = temp % 10;
                rev = rev * 10 + rem;
                temp /= 10;
            }
            Console.WriteLine("reverse Number : "+rev);
             if(IsPrime(num) && IsPrime(rev))
                Console.WriteLine("Twisted Prime Numbers");
             else
                Console.WriteLine("Not Twisted Prime Numbers");


        }*/
    }
}
