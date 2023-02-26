using System;
using System.Drawing;

namespace Geometry
{
    public class Line : IComparable<Line>
    {
        private Point _p1;
        private Point _p2;

        public Line(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public double Length
        {
            get { return Math.Sqrt(Math.Pow(_p2.X - _p1.X, 2) + Math.Pow(_p2.Y - _p1.Y, 2)); }
        }

        public int CompareTo(Line other)
        {
            double thisLength = this.Length;
            double otherLength = other.Length;
            if (thisLength == otherLength)
            {
                return 0;
            }
            else if (thisLength < otherLength)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
class Program
    {
        static void Main()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(0, 0);
            Point p4 = new Point(4, 3);

            Line line1 = new Line(p1, p2);
            Line line2 = new Line(p3, p4);

            int result = line1.CompareTo(line2);
            if (result == 0)
            {
                Console.WriteLine("The two lines have equal length.");
            }
            else if (result < 0)
            {
                Console.WriteLine("Line 1 is shorter than line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is longer than line 2.");
            }
        }
    }

}
}
