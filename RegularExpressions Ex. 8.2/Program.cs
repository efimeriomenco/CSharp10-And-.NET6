
var validInput = false;
ConsoleKeyInfo cki = default;
// loop until you have valid input
while (!validInput)
{
    // get the input
    var pattern = "^[a-zA-Z]+$";
    WriteLine("The default regular expression checks for at least one digit.");
    WriteLine($"Enter a regular expression (or press ENTER to use the default): {pattern}");
    
    var isEnter = ReadKey().Key == ConsoleKey.Enter;
    if (!isEnter)
        pattern = ReadLine();

    Write("Enter some input: ");

    var input = ReadLine();
    if (Regex.IsMatch(input, pattern))
    {
        WriteLine($"{input} matches {pattern} {true}");
        WriteLine("Press ESC to end or any key to try again.");
        cki = ReadKey();
        if (cki.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
    else 
    {
        WriteLine($"{input} matches {pattern} {false}");
        WriteLine("Press ESC to end or any key to try again.");
        cki = ReadKey();
        if (cki.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }

}
