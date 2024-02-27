namespace CircusTrein;

public class Wagon
{
    public int Capacity { get; private set; } = 10;
    public IEnumerable<Animal> Animals => _animals;

    public int Score => _animals.Select(a => (int)a.Format).Sum();

    public bool Full => Score >= Capacity;
    
    private readonly List<Animal> _animals = [];

    public bool TryAddAnimal(Animal animal)
    {
        if (!Fits(animal) || !_animals.All(a => a.IsCompatible(animal)))
        {
            return false;
        }

        _animals.Add(animal);

        return true;
    }

    public bool TryRemoveAnimal(Animal animal)
    {
        if (!_animals.Contains(animal))
        {
            return false;
        }

        _animals.Remove(animal);

        return true;
    }

    public bool Fits(Animal animal)
    {
        var capacityAfter = Score + (int)animal.Format;
        return capacityAfter <= Capacity;
    }
}