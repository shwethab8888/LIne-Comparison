//As a fan of geometry, I want to check equality of two lines based on the end points, So that I know when two lines are the equal.
//- Using Java equals method to check equality of 2 Lengths is preferable.

using System.Drawing;
namespace Line_comparison_with_2_lines_r_equal
{

    public class Line
    {
        private Point p1;
        private Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override bool Equals(Object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (!(obj is Line))
            {
                return false;
            }
            Line other = (Line)obj;
            return (this.p1.Equals(other.p1) && this.p2.Equals(other.p2)) ||
                   (this.p1.Equals(other.p2) && this.p2.Equals(other.p1));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(0, 0);

            Line line1 = new Line(p1, p2);
            Line line2 = new Line(p3, p4);

            Console.WriteLine(line1.Equals(line2)); // prints "True"

        }

    }
}