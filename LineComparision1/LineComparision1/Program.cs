
using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the end point of first line");     //Taking input from user
            int x2 = Convert.ToInt32(Console.ReadLine());               //Convert input in integer format
            Console.WriteLine("x2 = " + x2);                            //Display input 
            Console.WriteLine("Enter the end point of second line");    //Convert input in integer format
            int y2 = Convert.ToInt32(Console.ReadLine());               //Display input
            Console.WriteLine("y2 = " + y2);

            if (x2.Equals(y2))                        //computation
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
