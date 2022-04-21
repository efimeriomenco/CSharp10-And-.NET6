using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAnInheritanceHierarchy
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public abstract double Area { get; }
    }
}
