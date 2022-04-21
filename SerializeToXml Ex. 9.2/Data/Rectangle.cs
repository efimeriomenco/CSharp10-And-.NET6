using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeToXml_Ex._9._2.Data
{
    [Serializable]
    public class Rectangle : Shape
    {
        public override string Colour { get; set; }
       
        public override double? Height { get; set; }
     
        public override double? Width { get; set; }

    }
}
