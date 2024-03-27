namespace CircusTrein;

public static class AnimalFactory
{
    public static IEnumerable<Animal> CreateAnimals(int smallCarnivore, int mediumCarnivore, int largeCarnivore, int smallHerbivore, int mediumHerbivore, int largeHerbivore)
    {
        List<Animal> animals = [];
        
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Small), smallCarnivore));
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Medium), mediumCarnivore));
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Large), largeCarnivore));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Small), smallHerbivore));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Medium), mediumHerbivore));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Large), largeHerbivore));
        
        return animals;
    }
}