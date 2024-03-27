using CircusTrein;

namespace CircusTreinTests;

public class TrainTests
{
    [Test]
    public void Constructor_WithWagonCapacity20Persists()
    {
        Train train = new Train(20);
        Assert.That(train.WagonCapacity, Is.EqualTo(20));
    }
    
    [Test]
    public void TryAddWagon_FailsWhenExceedingWagonLimit()
    {
        int limit = 10;
        Train train = new Train(limit);
        for (int i = 0; i < limit; i++)
        {
            train.TryAddWagon(new Wagon());
        }

        bool success = train.TryAddWagon(new Wagon());
        
        Assert.That(success, Is.False);
    }

    [Test]
    public void TryAddWagon_SucceedsWhenNotExceedingWagonLimit()
    {
        int limit = 10;
        Train train = new Train(limit);
        for (int i = 0; i < limit - 1; i++)
        {
            train.TryAddWagon(new Wagon());
        }

        bool success = train.TryAddWagon(new Wagon());
        
        Assert.That(success, Is.True);
    }

    [Test]
    public void TryRemoveWagon_FailsWhenSuppliedWagonNotPresent()
    {
        Train train = new Train();
        
        bool success = train.TryRemoveWagon(new Wagon());

        Assert.That(success, Is.False);
    }

    [Test]
    public void TryRemoveWagon_SucceedsWhenSuppliedWagonPresent()
    {
        Train train = new Train();
        Wagon wagon = new Wagon();
        train.TryAddWagon(wagon);

        bool success = train.TryRemoveWagon(wagon);

        Assert.That(success, Is.True);
    }
}