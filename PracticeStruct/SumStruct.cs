using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStruct
{
    public struct SumStruct
    {
        public int X;
        public int Y;
        public SumStruct(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }
        public static SumStruct operator +(SumStruct vector1, SumStruct vector2)
        {
            return new(
                vector1.X + vector2.X,
                vector1.Y + vector2.Y
                );
        }
    }
}
