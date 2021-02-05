using System;

namespace LineComparision
{

    class Point
    {
        // a and b two cordinates intialised
        public int a;
        public int b;
        public Point(int aValue, int bValue)
        {
            a = aValue;
            b = bValue;
        }
    }
    class Line
    {
        //class consist of two ponints p and q
        public Point p;
        public Point q;
        public Line(Point pValue, Point qValue)
        {
            p = pValue;
            q = qValue;
        }

        public double LenghtCalculation()
        {
            return Math.Sqrt(Math.Pow(p.a - q.a, 2) + Math.Pow(p.b - p.b, 2)); 
        }

        public void Compare(Line L2)
        {
            if (L2.LenghtCalculation() == this.LenghtCalculation())
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }

        public void compareTo(Line L2)
        {
            double L1Length = L2.LenghtCalculation();
            double thisLineLength = this.LenghtCalculation();
            if (L1Length == thisLineLength)
                Console.WriteLine("Lines are equal");
            else if (L1Length > thisLineLength)
                Console.WriteLine("This line is smaller than Second Line");
            else
                Console.WriteLine("This line is greater than Second Line");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision computation");

<<<<<<< HEAD
            Point p = new Point(8, 2);
            Point q = new Point(3, 9);
            Line L = new Line(p, q);

            Console.WriteLine("Length of line L: " + L.LenghtCalculation());

            Point p1 = new Point(8, 2);
            Point q1 = new Point(3, 9);
            Line L2 = new Line(p1, q1);

            Console.WriteLine("Length of line L1: " + L2.LenghtCalculation());
            L.Compare(L2);

<<<<<<< HEAD
            Point p3 = new Point(9, 4);
            Point q3 = new Point(4, 8);
            Line L3 = new Line(p3, q3);
=======
            Console.WriteLine("Enter the end point of first line");     //Taking input from user
            int l2 = Convert.ToInt32(Console.ReadLine());               //Convert input in integer format
            Console.WriteLine("l2 = " + l2);                            //Display input 
            Console.WriteLine("Enter the end point of second line");    //Convert input in integer format
            int b2 = Convert.ToInt32(Console.ReadLine());               //Display input
            Console.WriteLine("b2 = " + b2);

            if (l2.Equals(b2))                        //computation
=======
            Console.WriteLine("Enter the end point of first line");    // Taking input from user
            int l2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("l2 = " + l2);                           //Display the input
            Console.WriteLine("Enter the end point of second line");   //Taking input from user
            int b2 = Convert.ToInt32(Console.ReadLine());              //Conversion
            Console.WriteLine("b2 = " + b2);                          //Display the input

            if (l2.CompareTo(b2) == 0)                                   //Compuatation
>>>>>>> UC3_CheckComapreToMethod
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
<<<<<<< HEAD
>>>>>>> UC2_CheckEqualMethod

            Console.WriteLine("Length of line L2: " + L3.LenghtCalculation());
            L.compareTo(L3);
=======
>>>>>>> UC3_CheckComapreToMethod
        }
    }
}
