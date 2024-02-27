namespace CircusTrein;

public static class SorterShort
{
    public static IEnumerable<Animal> CreateAnimals(int csm, int cmd, int clg, int hsm, int hmd, int hlg)
    {
        List<Animal> animals = [];
        
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Small), csm));
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Medium), cmd));
        animals.AddRange(Enumerable.Repeat(new Animal(true, Format.Large), clg));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Small), hsm));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Medium), hmd));
        animals.AddRange(Enumerable.Repeat(new Animal(false, Format.Large), hlg));
        
        return animals;
    }
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
                if (wagon.Fits(animal) && wagon.Animals.All(a => a.IsCompatible(animal)))
                {
                    added = true;
                    wagon.TryAddAnimal(animal);
                    break;
                }
            }

            if (added) continue;
            
            var wag = new Wagon();
            wag.TryAddAnimal(animal);
            wagons.Add(wag);
        }

        return wagons;
    }
}