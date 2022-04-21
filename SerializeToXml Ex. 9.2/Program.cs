using System.Text;

try
{
    var locationFolder = @"C:\Users\Cristi-PC\Desktop\";
    var fileName = "Shapes.xml";
    var path = locationFolder + fileName;
    if (!Directory.Exists(locationFolder))
    {
        Directory.CreateDirectory(locationFolder);
    }

    //SerializeListToXmlFile(path);
    DeserializeXmlFileToList(path);
    
}
catch(Exception e)
{
    WriteLine("Error: " + e.Message);
}
static void SerializeListToXmlFile(string filePath)
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
    using (var writer = new StreamWriter(filePath))
    {
        xmlSerializer.Serialize(writer, listOfShapes);
    }
}

static void DeserializeXmlFileToList(string filePath)
{
    var xmlSerializer = new XmlSerializer(typeof(List<Shape>));
    using (var reader = new StreamReader(filePath))
    {
        var members = (List<Shape>)xmlSerializer.Deserialize(reader)!;
        
        foreach (var member in members)
        {
            var builder = new StringBuilder();
            builder.Append($"Type: {member.GetType().Name}");
            builder.Append($", Colour: {member.Colour}");
            builder.Append($", Area: {member.Area.ToString("F")}");
            builder.Append(System.Environment.NewLine);

            Console.WriteLine(builder.ToString());
        }
    }
}


