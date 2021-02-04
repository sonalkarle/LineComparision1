using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the end point of first line");    // Taking input from user
            int x2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("x2 = " + x2);                           //Display the input
            Console.WriteLine("Enter the end point of second line");   //Taking input from user
            int y2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("y2 = " + y2);                          //Display the input

            if (x2.CompareTo(y2) == 0)                                   //Compuatation
            {
                Console.WriteLine("First line is equal to second line ");
            }
            else if (x2 > y2)                                           //Computation
            {
                Console.WriteLine("First line is greater than second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than first line");
            }
        }
    }
}
