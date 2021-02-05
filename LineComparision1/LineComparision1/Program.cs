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

            Point p = new Point(8, 2);
            Point q = new Point(3, 9);
            Line L = new Line(p, q);

            Console.WriteLine("Length of line L: " + L.LenghtCalculation());

            Point p1 = new Point(8, 2);
            Point q1 = new Point(3, 9);
            Line L2 = new Line(p1, q1);

            Console.WriteLine("Length of line L1: " + L2.LenghtCalculation());
            L.Compare(L2);

            Point p3 = new Point(9, 4);
            Point q3 = new Point(4, 8);
            Line L3 = new Line(p3, q3);

            Console.WriteLine("Length of line L2: " + L3.LenghtCalculation());
            L.compareTo(L3);
        }
    }
}
