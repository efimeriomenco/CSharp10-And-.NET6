using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeToXml_Ex._9._2.Data
{
    [Serializable]
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area => Math.PI * Math.Pow(Radius, 2);

        // Exemplu
        public override string ToString()
        {
            return $"Type: {nameof(Circle)}, Colour {base.Colour}, Radius: {this.Radius}, Area: {this.Area}";
        }
    }
}
