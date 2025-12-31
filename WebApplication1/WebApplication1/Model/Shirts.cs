using System.ComponentModel.DataAnnotations;
using WebApplication1.Controllers.Validation;

namespace WebApplication1.Model;

public class Shirts
{
    [Required]
    public int ShirtId { get; set; }
    
    public string Brand { get; set; }
    public string Color { get; set; }
    [Shirt_Correct_Size]
    public int Size { get; set; }
    public string Gender { get; set; }
    public double Price { get; set; }
}