using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MathApplication
{
    public class AreaComparer : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Area < y.Area)
                return -1;
            else if (x.Area > y.Area)
                return 1;
            return 0;            
        }
    }
}
