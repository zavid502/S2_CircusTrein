namespace CircusTrein;

public class Animal(bool carnivore, Format format)
{
    public bool Carnivore { get; } = carnivore;
    public Format Format { get; } = format;

    public bool IsCompatible(Animal animal)
    {
        switch (Carnivore)
        {
            case false when !animal.Carnivore:
            case true when !animal.Carnivore && (int)animal.Format > (int)Format:
            case false when animal.Carnivore && (int)animal.Format < (int)Format:
                return true;
            
            default:
                return false;
        }
    }
}