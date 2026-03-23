//Kaprekar Number
//Number whose square can be split into two parts and the sum of those parts equals the original number.
//45^2=2025
//Split → 20 and 25
//Add → 20 + 25 = 45   

using System;
namespace ProgramsNumbers
{
    internal class KaprekarNumber
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the  number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sqr = num * num;
            Console.WriteLine("Square : "+sqr);
            string str = sqr.ToString();
            int len = str.Length;
            int mid = len / 2;

            int part1 = Convert.ToInt32(str.Substring(0, mid));
            int part2 = Convert.ToInt32(str.Substring(mid));

            if (part1 + part2 == num)
                Console.WriteLine(num + " is a Kaprekar Number");
            else
                Console.WriteLine(num + " is not a Kaprekar Number");
        }*/
    }
}
