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

        public void Deconstruct(out object name, out object species)
        {
            name = Name;
            species = Species;
        }

    }
}
