
//New init keyword enables us to set properties during instantiation but not after.

//Correct!

using PracticeInitAndRecord;

InitImmutablePerson pers1 = new InitImmutablePerson()
{
    FirstName = "Efim",
    LastName = "Eriomenco"
};

//Incorrect!
//efim.FirstName = "Ion";

//----------------------------------------------------------------------------------------

//Records should not have any state (properties and fields) that changes after instantiation.
//Instead, the idea is that you create new records from existing ones with any changed state. This
//is called non-destructive mutation.To do this, C# 9 introduced the "with" keyword:
RecordInitImmutableVehicle vehicle1 = new RecordInitImmutableVehicle()
{
    Brand = "Bmw X5",
    Color = "Blue Metallic",
    Wheels = 5
};
WriteLine($"old color is: {vehicle1.Color}");
RecordInitImmutableVehicle repaintedCar = vehicle1 
    with { Color = "Red Crystal"};
WriteLine($"new color is: {repaintedCar.Color}");

//----------------------------------------------------------------------------------------

//You can also combine this with a deconstructor for splitting the object into individual parts
ConstrDesconstrInitImmutableAnimal dog = new("Oscar", "Labrador");
var (who, what) = dog; // calls Deconstruct method
WriteLine($"{who} is a {what}.");