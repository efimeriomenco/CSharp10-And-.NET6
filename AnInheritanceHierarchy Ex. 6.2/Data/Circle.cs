using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
    public class Circle : Shape
    {
        public override double Area => Math.PI * Math.Pow(Radius, 2);
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Height = radius * 2;
            Width = radius * 2;
        }
    }
}
