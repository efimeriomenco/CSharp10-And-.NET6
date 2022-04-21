
var validInput = false;
ConsoleKeyInfo cki = default;
// loop until you have valid input
while (!validInput)
{
    // get the input
    WriteLine("The default regular expression checks for at least one digit.");
    WriteLine("Enter a regular expression (or press ENTER to use the default): ^[a-z]+$");
    Write("Enter some input: ");
    var input = ReadLine();
    if (IsAlpha(input))
    {
        WriteLine($"{input} matches ^[a-z]+$? {true}");
        WriteLine("Press ESC to end or any key to try again.");
        cki = ReadKey();
        if (cki.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
    else 
    {
        WriteLine($"{input} matches ^[a-z]+$? {false}");
        WriteLine("Press ESC to end or any key to try again.");
        cki = ReadKey();
        if (cki.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }



}
bool IsAlpha(string? input)
{
    return Regex.IsMatch(input, "^[a-zA-Z]+$");
}

