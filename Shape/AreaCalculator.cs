﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape;

namespace Shape
{
    internal class AreaCalculator
    {
        public double TotaleArea(Form[] arrShapes)
        {
            double area = 0;
           foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
        return area;
        }
    }
}
