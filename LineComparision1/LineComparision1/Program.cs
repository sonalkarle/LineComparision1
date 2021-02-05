
using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the end point of first line");     //Taking input from user
            int l2 = Convert.ToInt32(Console.ReadLine());               //Convert input in integer format
            Console.WriteLine("l2 = " + l2);                            //Display input 
            Console.WriteLine("Enter the end point of second line");    //Convert input in integer format
            int b2 = Convert.ToInt32(Console.ReadLine());               //Display input
            Console.WriteLine("b2 = " + b2);

            if (l2.Equals(b2))                        //computation
            {
                Console.WriteLine("First line is equal to second line ");
            }
            else
            {
                Console.WriteLine("First line is not equal to second line");
            }

        }
    }
}
