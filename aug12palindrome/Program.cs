using System;

namespace aug12palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            int sum = 0, temp;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n>0)
            {
                r   = n%10;
                sum = (sum*10)+r;
                n   = n/10;

            }
            if (temp==sum)
            {
                Console.WriteLine("Given number is palindrome");
             }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}
