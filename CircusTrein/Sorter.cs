namespace CircusTrein;

public static class Sorter
{
    public static IEnumerable<Wagon> SortAnimals(IEnumerable<Animal> animals)
    {
        animals = animals.ToList();
        
        var listA = animals.OrderByDescending(a => (int)a.Format + (a.Carnivore ? 1 : 0) * 1000);
        var listB = animals.OrderByDescending(a => (int)a.Format + (a.Carnivore ? 0 : 1) * 1000);

        var testA = Sort(listA).ToList();
        var testB = Sort(listB).ToList();

        return testA.Count < testB.Count ? testA : testB;
    }

    private static IEnumerable<Wagon> Sort(IEnumerable<Animal> animals)
    {
        var wagons = new List<Wagon>();
        
        foreach (var animal in animals)
        {
            bool added = false;

            foreach (var wagon in wagons)
            {
                if (!wagon.AnimalIsCompatible(animal)) continue;
                
                added = true;
                var success = wagon.TryAddAnimal(animal);
                if (!success)
                {
                    throw new Exception("Could not add animal.");
                }
                break;
            }

            if (added) continue;
            
            var wag = new Wagon();
            wag.TryAddAnimal(animal);
            wagons.Add(wag);
        }

        return wagons;
    }
}