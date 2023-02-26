namespace Line_comparison_for_java_object_compared
{
    using System;

    namespace LineAndPoint
    {
        class Point : IComparable<Point>
        {
            private int x;
            private int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public int CompareTo(Point other)
            {
                if (other == null) return 1;

                if (this.x == other.x && this.y == other.y)
                {
                    return 0;
                }
                else if (this.x < other.x || (this.x == other.x && this.y < other.y))
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Point other = (Point)obj;

                return (this.x == other.x && this.y == other.y);
            }

            public override int GetHashCode()
            {
                return x.GetHashCode() ^ y.GetHashCode();
            }
        }

        class Line
        {
            private Point start;
            private Point end;

            public Line(Point start, Point end)
            {
                this.start = start;
                this.end = end;
            }

            public Point Start
            {
                get { return start; }
                set { start = value; }
            }

            public Point End
            {
                get { return end; }
                set { end = value; }
            }

            public double Length
            {
                get { return Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2)); }
            }

            public bool Equals(Line other)
            {
                if (other == null) return false;

                return (this.start.Equals(other.start) && this.end.Equals(other.end)) || (this.start.Equals(other.end) && this.end.Equals(other.start));
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Line other = (Line)obj;

                return Equals(other);
            }

            public override int GetHashCode()
            {
                return start.GetHashCode() ^ end.GetHashCode();
            }

            internal string CompareTo(Line line2)
            {
                throw new NotImplementedException();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(3, 4);

                Line line1 = new Line(p1, p2);
                Line line2 = new Line(p2, p1);

                Console.WriteLine("line1.Length = " + line1.Length);
                Console.WriteLine("line1 == line2: " + line1.Equals(line2));
                Console.WriteLine("line1.CompareTo(line2) = " + line1.CompareTo(line2));
            }
        }
    }

}

