try
{
    var locationFolder = @"C:\Users\Cristi-PC\Desktop\XmlFiles\";

    //SerializeListToXmlFile(locationFolder);
    DeserializeXmlFileToList(locationFolder);
    
}
catch(Exception e)
{
    WriteLine("Error: " + e.Message);
}
static void SerializeListToXmlFile(string path)
{
    List<Shape> listOfShapes = new ()
    {
        new Circle { Colour = "Red", Radius = 2.5 },
        new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
        new Circle { Colour = "Green", Radius = 2.5 },
        new Circle { Colour = "Purple", Radius = 2.5 },
        new Rectangle { Colour = "Blue", Height = 2.5, Width = 18.0 }
    };
    var xmlSerializer = new XmlSerializer(typeof(List<Shape>));
    using (var writer = new StreamWriter(path+"Shapes.xml"))
    {
        xmlSerializer.Serialize(writer, listOfShapes);
    }
}

static void DeserializeXmlFileToList(string path)
{
    var xmlSerializer = new XmlSerializer(typeof(List<Shape>));
    using (var reader = new StreamReader(path+"Shapes.xml"))
    {
        var members = (List<Shape>)xmlSerializer.Deserialize(reader)!;

        foreach (var member in members)
        {
            WriteLine(member.GetType());
            WriteLine(member.Colour);
            WriteLine(member.Radius);
            WriteLine(member.Width);
            WriteLine(member.Height);
            WriteLine();
        }
    }
}


