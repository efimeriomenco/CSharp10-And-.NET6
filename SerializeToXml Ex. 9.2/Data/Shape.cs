namespace SerializeToXml_Ex._9._2.Data
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [Serializable]
    public abstract class Shape
    {
        public abstract string Colour { get; set; }
       
        public virtual double? Radius { get; set; }
       
        public virtual double? Width { get; set; }
       
        public virtual double? Height { get; set; }


    }
}
