using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
    internal class Square : Shape
    {
        public override double Area => Height * Width;

        public Square(int length)
        {
            Height = length;
            Width = length;
        }

    }
}
