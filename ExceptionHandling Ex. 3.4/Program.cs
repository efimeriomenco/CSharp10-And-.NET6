
try
{
    WriteLine("Enter a number between 0 and 255:");
    int nr1 = Convert.ToInt32(ReadLine());
    WriteLine("Enter another number between 0 and 255:");
    int nr2 = Convert.ToInt32(ReadLine());
    if (nr1 < 255 && nr2 < 255)
    {
        double result = nr1 / (double)nr2;
        WriteLine($"{nr1} devided by {nr2} is {result}");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Incorrect format please put number type.");
}
catch (OverflowException e)
{
    Console.WriteLine("The number is too big.");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero");
}
catch (Exception e)
{
    Console.WriteLine($"Error. Something went wrong. Details: {e.Message}");
}


