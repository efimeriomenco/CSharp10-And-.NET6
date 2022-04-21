
try
{
    WriteLine("Enter a number between 0 and 255:");
    int nr1 = Convert.ToInt32(ReadLine());
    WriteLine("Enter another number between 0 and 255:");
    int nr2 = Convert.ToInt32(ReadLine());
    if (nr1 < 255 && nr2 < 255)
    {
        double result = nr1 / nr2;
        WriteLine($"{nr1} devided by {nr2} is {result}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Incorrect format please put number type.");
}

