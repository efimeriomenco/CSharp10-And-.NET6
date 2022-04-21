WriteLine("Getting Connection ...");

var datasource = "DESKTOP-J32FIV4\\SQLEXPRESS";//your server
var database = "Northwind"; //your database name

string connString = $"Data Source={datasource};Database={database};Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";


try
{
    WriteLine("Openning Connection ...");
    WriteLine("Connection successful!");

    string selectFromProducts = "SELECT ProductId,ProductName FROM Products Order By ProductId";

    Dictionary<int, string> persons;
    //create instanace of database connection
    await using (var con = new SqlConnection(connString))
    {
        persons = await SqlCommandString(selectFromProducts, con);
    }

    //serialize to JSON
    WriteLine(SerializeObjectToJson(persons));
        
}
catch (Exception e)
{
    WriteLine("Error: " + e.Message);
}
Read();

async Task<Dictionary<int, string>> SqlCommandString(string sqlcommand, SqlConnection conn)
{
    var result = new Dictionary<int, string>();

    await conn.OpenAsync();
    await using SqlCommand command = new SqlCommand(sqlcommand, conn);
    await using (SqlDataReader reader = command.ExecuteReader())
    {
        while (await reader.ReadAsync())
        {
            result.Add(reader.GetInt32(0), reader.GetString(1));
        }
    }
    await conn.CloseAsync();
    return result;
}

string SerializeObjectToJson(Dictionary<int, string> objects)
{
   string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
   return json;
}
