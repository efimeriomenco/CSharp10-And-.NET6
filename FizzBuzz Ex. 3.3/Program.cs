// Traditional
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) WriteLine("FizzBuzz");
    else if (i % 3 == 0) WriteLine("Fizz");
    else if (i % 5 == 0) WriteLine("Buzz");
    else WriteLine(i);
}

// Patternmatching
foreach (var i in Enumerable.Range(1, 100))
{
    Console.WriteLine(i switch
    {
        _ when i % 15 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString(),
    });
}

// Linq
Enumerable
    .Range(1, 100)
    .ToList()
    .ForEach(i =>  
        Console.WriteLine(i switch
        {
            _ when i % 15 == 0 => "FizzBuzz",
            _ when i % 3 == 0 => "Fizz",
            _ when i % 5 == 0 => "Buzz",
            _ => i.ToString(),
        })
    );
