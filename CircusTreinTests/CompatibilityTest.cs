using CircusTrein;
using Microsoft.VisualBasic;
using System.Linq;

namespace CircusTreinTests;

public class Tests
{

    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CarnivoreCompatibilityTest()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(1, 0, 0, 0, 3, 2)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest2()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(1, 0, 0, 5, 2, 1)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest3()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(1, 1, 1, 1, 1, 1)).ToList(), Has.Count.EqualTo(4));
    }
    [Test]
    public void CarnivoreCompatibilityTest4()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(2, 1, 1, 1, 5, 1)).ToList(), Has.Count.EqualTo(5));
    }
    [Test]
    public void CarnivoreCompatibilityTest5()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(1, 0, 0, 1, 1, 2)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest6()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(3, 0, 0, 0, 2, 3)).ToList(), Has.Count.EqualTo(3));
    }
    [Test]
    public void CarnivoreCompatibilityTest7()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(7, 3, 3, 0, 5, 6)).ToList(), Has.Count.EqualTo(13));
    }
    [Test]
    public void CarnivoreCompatibilityTest8()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(0, 0, 1, 2, 3, 0)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest9()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(0, 0, 1, 1, 2, 5)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest10()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(1, 1, 1, 1, 1, 1)).ToList(), Has.Count.EqualTo(4));
    }
    [Test]
    public void CarnivoreCompatibilityTest11()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(2, 1, 1, 1, 5, 1)).ToList(), Has.Count.EqualTo(5));
    }
    [Test]
    public void CarnivoreCompatibilityTest12()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(0, 0, 1, 2, 1, 1)).ToList(), Has.Count.EqualTo(2));
    }
    [Test]
    public void CarnivoreCompatibilityTest13()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(0, 0, 3, 3, 2, 0)).ToList(), Has.Count.EqualTo(3));
    }
    [Test]
    public void CarnivoreCompatibilityTest14()
    {
        Assert.That(SorterShort.SortAnimals(SorterShort.CreateAnimals(3, 3, 7, 6, 5, 0)).ToList(), Has.Count.EqualTo(13));
    }
    
}