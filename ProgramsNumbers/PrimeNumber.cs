//Prime Numbers

using System;
namespace ProgramsNumbers
{
    internal class PrimeNumber
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<2)
                Console.WriteLine("Not a Prime Number");
            
            else
            {
                int rem, count = 0;
                if (num > 2)
                {
                    for (int i = 2; i < num / 2; i++)
                    {
                        if (num % i == 0)
                            count++;
                    }
                }
                if(count<1)
                    Console.WriteLine("Prime Number");
            }
        }*/
        /*static void Main(string[] args)
        {
            for (int n = 2; n <= 100; n++)
           {
               bool res = true;
               for(int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                       res = false;
                        break;
                    }
                }
                if (res)
                {
                    Console.WriteLine(n);
                }
            }

        }*/
    }
}
