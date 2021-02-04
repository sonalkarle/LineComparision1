using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x1");    // Take x1 value from user
            int x1 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("Enter the value of x2");    // Take x2 value from user
            int x2 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("x2 = " + x2);
            Console.WriteLine("Enter the value of y1");    // Take y1 value from user
            int y1 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("y1 = " + y1);
            Console.WriteLine("Enter the value of y2");    // Take y2 value from user
            int y2 = Convert.ToInt32(Console.ReadLine());  //Convert into integer
            Console.WriteLine("y2 = " + y2);
            int a = (((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            Console.WriteLine("Length of line" + (Math.Sqrt(a)));


        }
    }
}
