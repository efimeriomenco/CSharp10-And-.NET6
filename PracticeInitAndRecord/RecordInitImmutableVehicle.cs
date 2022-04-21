namespace PracticeInitAndRecord
{
    public record RecordInitImmutableVehicle()
    {
        public int Wheels { get; init; }
        public string? Color { get; init; }
        public string? Brand { get; init; }
    }
}
