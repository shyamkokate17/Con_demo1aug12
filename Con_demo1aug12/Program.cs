/*using System;

namespace Con_demo1aug12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
using System;
class Swap2Numbers
{
    static void Main(string[] args)
    {
        int num1, num2, temp;
        Console.Write("\nEnter the First Number : ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("\nEnter the Second Number : ");
        num2 = int.Parse(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : "+num1);
        Console.Write("\nSecond Number : "+num2);
        Console.ReadLine();
    }
}


