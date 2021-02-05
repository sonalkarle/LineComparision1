using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of l1");    // Take l1 value from user
            int l1 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("l1 = " + l1);
            Console.WriteLine("Enter the value of l2");    // Take l2 value from user
            int l2 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("l2 = " + l2);
            Console.WriteLine("Enter the value of b1");    // Take b1 value from user
            int b1 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("Enter the value of b2");    // Take b2 value from user
            int b2 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("b2 = " + b2);
            int a = (((l2 - l1) ^ 2) + ((b2 - b1) ^ 2));
            Console.WriteLine("Length of line" + (Math.Sqrt(a)));


        }
    }
}
