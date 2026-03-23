using System;

namespace ProgramsNumbers
{
    internal class PalindromeNumber
    {
        //For Number
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rem,revnum=0;
            while (num > 0)
            {
                rem = num % 10;
                revnum = revnum*10+rem;
                num /= 10;
            }
            Console.WriteLine("Actual Number : "+temp);
            Console.WriteLine("Reverse Number : "+revnum);
            if(temp==revnum)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
        }*/

        //For string
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                char a = name[i];
                reverse = reverse + a;
            }
            Console.WriteLine("Reverse string : " + reverse);
            if (name.Equals(reverse))
                Console.WriteLine("Palindrome String");
            else
                Console.WriteLine("Not a Palindrome String");
            
        }*/
    }
}
