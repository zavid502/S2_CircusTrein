using CircusTrein;
using Microsoft.VisualBasic;
using System.Linq;

namespace CircusTreinTests;

public class SortTests
{
    private static void AssertAnimalSorter(int smallCarnivore, int mediumCarnivore, int largeCarnivore,
        int smallHerbivore, int mediumHerbivore, int largeHerbivore, int wagonCount)
    {
        var animals = AnimalFactory.CreateAnimals(
            smallCarnivore,
            mediumCarnivore,
            largeCarnivore,
            smallHerbivore,
            mediumHerbivore,
            largeHerbivore
        ).ToList();

        var sortedWagons = Sorter.SortAnimals(animals).ToList();
        var animalsInWagons = sortedWagons.SelectMany(wagon => wagon.Animals);

        CollectionAssert.AreEquivalent(animals, animalsInWagons);
        Assert.That(sortedWagons.All(wagon => wagon.Score <= wagon.Capacity), Is.True);
        Assert.That(sortedWagons, Has.Count.EqualTo(wagonCount));
    }

    [Test]
    public void SortAnimals_ShouldCreateTwoWagonsWhenAnimalsSetTo100032()
    {
        AssertAnimalSorter(1, 0, 0, 0, 3, 2, 2);
    }

    [Test]
    public void SortAnimals_ShouldCreateTwoWagonsWhenAnimalsSetTo100521()
    {
        AssertAnimalSorter(1, 0, 0, 5, 2, 1, 2);
    }

    [Test]
    public void SortAnimals_ShouldCreateFourWagonsWhenAnimalsSetTo111111()
    {
        AssertAnimalSorter(1, 1, 1, 1, 1, 1, 4);
    }

    [Test]
    public void SortAnimals_ShouldCreateFiveWagonsWhenAnimalsSetTo211151()
    {
        AssertAnimalSorter(2, 1, 1, 1, 5, 1, 5);
    }

    [Test]
    public void SortAnimals_ShouldCreateTwoWagonsWhenAnimalsSetTo100112()
    {
        AssertAnimalSorter(1, 0, 0, 1, 1, 2, 2);
    }

    [Test]
    public void SortAnimals_ShouldCreateThreeWagonsWhenAnimalsSetTo300023()
    {
        AssertAnimalSorter(3, 0, 0, 0, 2, 3, 3);
    }

    [Test]
    public void SortAnimals_ShouldCreateThirteenWagonsWhenAnimalsSetTo733056()
    {
        AssertAnimalSorter(7, 3, 3, 0, 5, 6, 13);
    }

    [Test]
    public void SortAnimals_ShouldCreateTwoWagonsWhenAnimalsSetTo001211()
    {
        AssertAnimalSorter(0, 0, 1, 2, 1, 1, 2);
    }
}