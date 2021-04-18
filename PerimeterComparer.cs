using System;
using System.Collections.Generic;
using System.Text;

namespace MathApplication
{
    public class PerimeterComparer : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Perimeter < y.Perimeter)
                return -1;
            else if (x.Perimeter > y.Perimeter)
                return 1;
            return 0;
        }
    }

}
