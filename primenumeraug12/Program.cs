using System;

namespace primenumeraug12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, temp = 0;
            Console.Write("Enter a number: ");
            n= int.Parse(Console.ReadLine());
            m =n/2;
            for(i=2; i<=m; i++)
            {
                if(n%i==0)
                {
                    Console.Write("Not a Prime number");
                    temp=1;
                    break;
                }
            }
            if (temp==0)
                Console.Write("It is a Prime number.");
        }
    }
}
