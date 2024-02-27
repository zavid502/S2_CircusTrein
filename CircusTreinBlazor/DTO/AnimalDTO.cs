using System.ComponentModel.DataAnnotations;
using CircusTrein;

namespace CircusTreinBlazor.DTO;

public class AnimalDto
{
    public AnimalDto()
    {
        
    }

    public AnimalDto(Format format, bool carnivore)
    {
        Format = format;
        Carnivore = carnivore;
    }
    
    [Required]
    public Format Format { get; set; }
    [Required]
    public bool Carnivore { get; set; }
}