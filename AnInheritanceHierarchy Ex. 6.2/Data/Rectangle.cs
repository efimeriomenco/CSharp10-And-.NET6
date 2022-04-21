using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
   
    public class Rectangle : Shape
    {
        public override double Area => Width * Height;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
