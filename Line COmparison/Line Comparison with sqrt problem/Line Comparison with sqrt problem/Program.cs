// As a fan of geometry, I want to model a line based on a point consisting of (x,y) co-ordinates using the Cartesian system,So that I can calculate its length.
// -- A Length as 2 poits(x1,y1) and (x2,y2)
// -- Length of a Line = sqrt(x2-x1)^2 + (y2-y1)^2)


namespace Line_Comparison_with_sqrt_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //co=ordinates
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 3.0;
            double y2 = 4.0;

            //calculate line length
            double length=Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2-y1,2));
            // print result
            Console.WriteLine("Lenth of line from ({0},{1}) to ({2},{3}) is {4}",x1,y1,x2,y2,length);
        }
    }
}