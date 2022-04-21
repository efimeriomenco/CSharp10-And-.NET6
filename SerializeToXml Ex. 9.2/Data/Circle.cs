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
        public override string Colour { get; set; }
        
        public override double? Radius { get; set; }

    }
}
