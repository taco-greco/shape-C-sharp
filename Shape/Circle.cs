using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Form
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius *Math.PI;
        }
    }
}
