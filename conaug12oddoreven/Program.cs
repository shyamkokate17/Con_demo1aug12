using System;

namespace conaug12oddoreven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, rem;
            Console.Write("Enter a number: ");
            num1= Convert.ToInt32(Console.ReadLine());
            rem= num1 % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an Even number.\n", num1);
            else
                Console.WriteLine("{0} is an Odd number.\n", num1);

        }
    }
}
