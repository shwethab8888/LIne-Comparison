using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comparisons
{
    public class CartesionSystem
    {
        public static void Cartesian_System()
        {

            //co=ordinates
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 3.0;
            double y2 = 4.0;

            //calculate line length
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // print result
            Console.WriteLine("Lenth of line from ({0},{1}) to ({2},{3}) is {4}", x1, y1, x2, y2, length);
        }
    }
}
