namespace PracticeInitAndRecord
{
    public record ConstrDesconstrInitImmutableAnimal
    {
        public string Name { get; init; }
        public string Species { get; init; }

        public ConstrDesconstrInitImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
    }
}
