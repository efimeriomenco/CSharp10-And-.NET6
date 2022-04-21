using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
    public class Circle : Shape
    {
        public new double Height { get; set; }
        public new double Width { get; set; }
        public new double Area { get; set; }
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Height = radius * 2;
            Width = radius * 2;
            Area = Math.PI * Math.Pow(radius, 2);

        }

    }
}
