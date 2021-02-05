using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the end point of first line");    // Taking input from user
            int l2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("l2 = " + l2);                           //Display the input
            Console.WriteLine("Enter the end point of second line");   //Taking input from user
            int b2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("b2 = " + b2);                          //Display the input

            if (l2.CompareTo(b2) == 0)                                   //Compuatation
            {
                Console.WriteLine("First line is equal to second line ");
            }
            else if (l2 > b2)                                           //Computation
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
