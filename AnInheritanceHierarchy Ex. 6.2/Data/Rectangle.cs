using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
   
    public class Rectangle : Shape
    {
        public new int Height { get; set; }
        public new double Width { get; set; }
        public new double Area { get; set; }

        public Rectangle(int height, double width)
        {
            Height = height;
            Width = width;
            Area = Height * Width;
        }

    }
}
