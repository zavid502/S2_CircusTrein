using CircusTrein;

namespace CircusTreinTests;

public class AnimalTests
{
    [Test]
    public void Constructor_WithCarnivoreTrueAndFormatSmallPersists()
    {
        Animal animal = new Animal(true, Format.Small);
        Assert.That(animal.Carnivore && animal.Format == Format.Small, Is.True);
    }
    
    [Test]
    public void IsCompatible_FailsWhenSmallHerbivoreAndLargeCarnivore()
    {
        Animal herbivore = new Animal(false, Format.Small);
        Animal carnivore = new Animal(true, Format.Large);
        
        Assert.That(herbivore.IsCompatible(carnivore), Is.False);
        Assert.That(carnivore.IsCompatible(herbivore), Is.False);
    }
    
    [Test]
    public void IsCompatible_SucceedsWhenLargeHerbivoreAndSmallCarnivore()
    {
        Animal herbivore = new Animal(false, Format.Large);
        Animal carnivore = new Animal(true, Format.Small);
        
        Assert.That(herbivore.IsCompatible(carnivore), Is.True);
        Assert.That(carnivore.IsCompatible(herbivore), Is.True);
    }
}