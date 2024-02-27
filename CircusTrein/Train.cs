namespace CircusTrein;

public class Train(int wagonCapacity = 10)
{
    public int WagonCapacity { get; private set; } = wagonCapacity;
    public IEnumerable<Wagon> Wagons => _wagons.AsEnumerable();
    
    private List<Wagon> _wagons = [];

    public bool TryAddWagon(Wagon wagon)
    {
        if (_wagons.Count >= WagonCapacity)
        {
            return false;
        }
        
        _wagons.Add(wagon);
        return true;
    }
    
    public bool TryRemoveWagon(Wagon wagon)
    {
        if (!_wagons.Contains(wagon))
        {
            return false;
        }
        
        _wagons.Remove(wagon);
        return true;
    }
    
}