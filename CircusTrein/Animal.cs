namespace CircusTrein;

public class Animal(bool carnivore, Format format)
{
    public bool Carnivore { get; private set; } = carnivore;
    public Format Format { get; private set; } = format;

    public bool IsCompatible(Animal animal)
    {
        if (!CarnivoreCompatible(animal))
        {
            return false;
        }

        return true;

    }

    private bool CarnivoreCompatible(Animal animal)
    {
        if (!Carnivore && !animal.Carnivore)
        {
            return true;
        }
        if (Carnivore && !animal.Carnivore && (int)animal.Format > (int)Format)
        {
            return true;
        }
        
        if (!Carnivore && animal.Carnivore && (int)animal.Format < (int)Format)
        {
            return true;
        }

        return false;

    }
}