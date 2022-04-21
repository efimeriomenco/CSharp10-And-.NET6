using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
    internal class Square : Shape
    {
        public new int Height { get; set; }
        public new int Width { get; set; }
        public new int Area { get; set; }

        public Square(int v)
        {
            Height = v;
            Width = v;
            Area = Height * Width;
        }

    }
}
