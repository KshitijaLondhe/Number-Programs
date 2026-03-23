//Automorphic Number
//5 sqr(5)=25 last digit=actual num

using System;
namespace ProgramsNumbers
{
    internal class AutomorphicNumber
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sqr = num * num;
            Console.WriteLine("Square : "+sqr);
            int temp = num;
            int a = 1;
            while (num > 0)
            {
                a = a * 10;
                num = num / 10;

            }
            if (sqr % a == temp)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
        }*/
      /*  static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            int temp = num;

            while (num > 0)
            {
                if (num % 10 == square % 10)
                {
                    Console.WriteLine(temp + " is an Automorphic Number");
                    return;
                }

                num /= 10;
                square /= 10;
            }

            Console.WriteLine(temp + " is not an Automorphic Number");
        }*/
    }
}

