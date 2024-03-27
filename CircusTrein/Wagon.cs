namespace CircusTrein;

public class Wagon
{
    public int Capacity { get; } = 10;
    public IReadOnlyCollection<Animal> Animals => _animals;

    public int Score => _animals.Select(a => (int)a.Format).Sum();
    
    private readonly List<Animal> _animals = [];

    public bool TryAddAnimal(Animal animal)
    {
        if (!AnimalIsCompatible(animal))
        {
            return false;
        }

        _animals.Add(animal);

        return true;
    }

    public bool Fits(Animal animal)
    {
        var capacityAfter = Score + (int)animal.Format;
        return capacityAfter <= Capacity;
    }

    public bool AnimalIsCompatible(Animal animal)
    {
        return Fits(animal) && _animals.All(a => a.IsCompatible(animal));
    }
}
