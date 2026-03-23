//Fibonacci Series
// i/p : 0 1 2 3 4 5 6 7 8 9 10
//o/p : 0 1 1 2 3 5 8 13 21 34 55

using System;
namespace ProgramsNumbers
{
    internal class FibonacciSeries
    {
        /*static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write(n1+" "+n2+" ");
            for (int i = 2; i <= 10; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }*/

        /*static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, num;
            Console.WriteLine("Enter the number of terms : ");
            num = int.Parse(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series");
            if (num < 2)
                Console.WriteLine("Enter number greater than 2");
            else 
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);

                for (int i = 2; i < num; i++)
                {
                    n3 = n1 + n2;
                    Console.WriteLine(n3);
                    n1 = n2;
                    n2 = n3;
                }
            }
        }*/
    }
}
