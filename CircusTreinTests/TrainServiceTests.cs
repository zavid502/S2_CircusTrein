using CircusTrein;

namespace CircusTreinTests;

public class TrainServiceTests
{
    [Test]
    public void AddAnimalToPool_Succeeds()
    {
        TrainService trainService = new();
        Animal animal = new Animal(true, Format.Large);
        
        trainService.AddAnimalToPool(animal);
        
        Assert.That(trainService.Animals, Does.Contain(animal));
    }

    [Test]
    public void TryRemoveAnimalFromPool_FailsWhenSuppliedAnimalNotPresent()
    {
        TrainService trainService = new();
        Animal animal = new Animal(true, Format.Medium);

        bool success = trainService.TryRemoveAnimalFromPool(animal);
        
        Assert.That(success, Is.False);
    }

    [Test]
    public void TryRemoveAnimalFromPool_SucceedsWhenSuppliedAnimalPresent()
    {
        TrainService trainService = new();
        Animal animal = new Animal(true, Format.Medium);
        
        trainService.AddAnimalToPool(animal);

        bool success = trainService.TryRemoveAnimalFromPool(animal);
        
        Assert.That(success, Is.True);
    }

    [Test]
    public void GetTrains_ReturnsOneTrainWhenOneAnimalSupplied()
    {
        TrainService trainService = new();
        trainService.AddAnimalToPool(new Animal(true, Format.Small));
        var trains = trainService.GetTrains();
        Assert.That(trains, Has.Count.EqualTo(1));
    }
}