WriteLine("Getting Connection ...");

var datasource = "DESKTOP-J32FIV4\\SQLEXPRESS";//your server
var database = "Northwind"; //your database name

string connString = $"Data Source="+datasource+";Database="+database+";Trusted_Connection=True;MultipleActiveResultSets=true";

Dictionary<int, string> persons = new Dictionary<int, string>();

try
{
    WriteLine("Openning Connection ...");
    WriteLine("Connection successful!");

    string selectFromProducts = "SELECT ProductId,ProductName FROM Products Order By ProductId";

    //create instanace of database connection
    using (var con = new SqlConnection(connString)) 
        SqlCommandString(selectFromProducts, connString ,persons);

    //serialize to JSON
    WriteLine(SerializeObjectToJson(persons));
        
}
catch (Exception e)
{
    WriteLine("Error: " + e.Message);
}
Read();

void SqlCommandString(string sqlcommand, string connString, Dictionary<int, string> objects)
{ 
    var conn = new SqlConnection(connString);
   using (SqlCommand command = new SqlCommand(sqlcommand, conn))
   {
       //open connection
       conn.Open();
      using (SqlDataReader reader = command.ExecuteReader())
      {
          while (reader.Read())
            {
                objects.Add(reader.GetInt32(0), reader.GetString(1));
            }
      }
      conn.Close();
   }
}

string SerializeObjectToJson(Dictionary<int, string> objects)
{
   string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
   return json;
}
