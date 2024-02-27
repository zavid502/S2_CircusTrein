namespace CircusTrein;

public class TrainService
{
    private readonly List<Animal> _animals = [];
    private readonly List<Wagon> _wagons = [];

    public IEnumerable<Animal> Animals => _animals.AsEnumerable();
    public IEnumerable<Wagon> Wagons => _wagons.AsEnumerable();
    
    public void AddAnimalToPool(Animal animal)
    {
        _animals.Add(animal);
    }

    public bool TryRemoveAnimalFromPool(Animal animal)
    {
        if (!_animals.Contains(animal))
        {
            return false;
        }

        _animals.Remove(animal);

        return true;
    }

    public List<Train> GetTrains()
    {
        List<Train> trains = [];
        var wagons = SorterShort.SortAnimals(_animals);

        foreach (var wagon in wagons)
        {
            if (trains.Count == 0)
            {
                trains.Add(new Train());
            }
            if (trains.Last().TryAddWagon(wagon)) continue;
            
            var train = new Train();
            train.TryAddWagon(wagon);
            trains.Add(train);
        }

        return trains;
    }
}