namespace SerializeToXml_Ex._9._2.Data
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [Serializable]
    public abstract class Shape
    {
        public string Colour { get; set; }
        public abstract double Area { get;  }
    }
}
